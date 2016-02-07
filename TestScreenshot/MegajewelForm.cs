using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using EasyHook;
using System.Runtime.Remoting.Channels.Ipc;
using System.Runtime.Remoting;
using System.Runtime.InteropServices;
using System.IO;
using Capture.Interface;
using Capture.Hook;
using Capture;

namespace Megajewel
{
    public partial class MegajewelForm : Form
    {
        public Overlaying Overlaying;
        public Capturing capturing;
        public Processing Processing;
        public HotkeyManager HotkeyManager;
        public Mode CurrentMode;
        public KnowledgeBase KnowledgeBase;
        public RecognitionStrategy RecognitionStrategy;
        public AutonomyStrategy AutonomyStrategy;
        public bool IsAutonomous = false;
        public bool IsPaused = false;
        public Gem TaughtGem;


        public MegajewelForm()
        {
            InitializeComponent();
            capturing = new Capturing(this);
            Overlaying = new Overlaying(this);
            Processing = new Processing(this);
            HotkeyManager = new HotkeyManager(this);
            KnowledgeBase = new KnowledgeBase(this);
            KnowledgeBase.Load();
            RecognitionStrategy.AllStrategies.Add(new NearestHistogramStrategy(this.KnowledgeBase.TrainingData));
            PopulateModes();
            RecognitionStrategy = new NearestHistogramStrategy(this.KnowledgeBase.TrainingData);
            AutonomyStrategy = new DoNothingStrategy();
            fontPower = new Font(FontFamily.GenericSansSerif, 28);
        }

        private void PopulateModes()
        {
            foreach (Mode mode in Mode.AllModes)
            {
                this.cbMode.Items.Add(mode);
            }
            CurrentMode = Mode.AllModes[0];
            this.cbMode.SelectedIndex = 0;
            foreach (GemColor color in (GemColor[])Enum.GetValues(typeof(GemColor)))
            {
                this.cbChooseColor.Items.Add(color);
            }
            foreach(GemAuxiliaryInfo aux in (GemAuxiliaryInfo[])Enum.GetValues(typeof(GemAuxiliaryInfo)))
            {
                this.cbTeachAuxiliary.Items.Add(aux);
            }
            this.cbChooseColor.SelectedIndex = 0;
            foreach(AutonomyStrategy strategy in AutonomyStrategy.AllStrategies)
            {
                this.cbAutonomousStrategy.Items.Add(strategy);
            }
            this.cbAutonomousStrategy.SelectedIndex = 0;
            foreach (RecognitionStrategy strategy in RecognitionStrategy.AllStrategies)
            {
                this.cbRecognitionStrategy.Items.Add(strategy);
            }
            this.cbRecognitionStrategy.SelectedIndex = 0;
        }

        private void btnInject_Click(object sender, EventArgs e)
        {
            if (capturing.CaptureProcess == null)
            {
                btnInject.Enabled = false;

                if (cbAutoGAC.Checked)
                {
                    // NOTE: On some 64-bit setups this doesn't work so well.
                    //       Sometimes if using a 32-bit target, it will not find the GAC assembly
                    //       without a machine restart, so requires manual insertion into the GAC
                    // Alternatively if the required assemblies are in the target applications
                    // search path they will load correctly.

                    // Must be running as Administrator to allow dynamic registration in GAC
                    Config.Register("Capture",
                        "Capture.dll");
                }

                AttachProcess();
            }
            else
            {
                HookManager.RemoveHookedProcess(capturing.CaptureProcess.Process.Id);
                capturing.CaptureProcess.CaptureInterface.Disconnect();
                capturing.CaptureProcess = null;
            }

            if (capturing.CaptureProcess != null)
            {
                btnInject.Text = "Detach";
                btnInject.Enabled = true;
            }
            else
            {
                btnInject.Text = "Inject";
                btnInject.Enabled = true;
            }
        }
        private void AttachProcess()
        {
            string exeName = "Bejeweled3";

            Process[] processes = Process.GetProcessesByName(exeName);
            foreach (Process process in processes)
            {
                // Simply attach to the first one found.

                // If the process doesn't have a mainwindowhandle yet, skip it (we need to be able to get the hwnd to set foreground etc)
                if (process.MainWindowHandle == IntPtr.Zero)
                {
                    continue;
                }

                // Skip if the process is already hooked (and we want to hook multiple applications)
                if (HookManager.IsHooked(process.Id))
                {
                    continue;
                }

                Direct3DVersion direct3DVersion = Direct3DVersion.AutoDetect;

                CaptureConfig cc = new CaptureConfig()
                {
                    Direct3DVersion = direct3DVersion,
                    ShowOverlay = cbDrawOverlay.Checked
                };

                capturing.ProcessId = process.Id;
                capturing.Process = process;

                var captureInterface = new CaptureInterface();
                captureInterface.RemoteMessage += new MessageReceivedEvent(CaptureInterface_RemoteMessage);
                capturing.CaptureProcess = new CaptureProcess(process, cc, captureInterface);

                break;
            }
            Thread.Sleep(10);

            if (capturing.CaptureProcess == null)
            {
                MessageBox.Show("No executable found matching: '" + exeName + "'");
            }
            else
            {
                btnLoadTest.Enabled = true;
                btnCapture.Enabled = true;
            }
        }

        void CaptureInterface_RemoteMessage(MessageReceivedEventArgs message)
        {
            txtDebugLog.Invoke(new MethodInvoker(delegate ()
                {
                    txtDebugLog.Text = String.Format("{0}\r\n{1}", message, txtDebugLog.Text);
                    if (txtDebugLog.Text.Length > 1000)
                    {
                        txtDebugLog.Text = txtDebugLog.Text.Substring(0, 1000);
                    }
                })
            );
        }
        void ScreenshotManager_OnScreenshotDebugMessage(int clientPID, string message)
        {
            txtDebugLog.Invoke(new MethodInvoker(delegate ()
                {
                   // txtDebugLog.Text = String.Format("{0}:{1}\r\n{2}", clientPID, message, txtDebugLog.Text);
                })
            );
        }

        DateTime start;
        DateTime end;


        private void delayedTimer_Tick(object sender, EventArgs e)
        {
            capturing.RequestCapture();
        }

        // Full Timer
        private void fullTimer_Tick(object sender, EventArgs e)
        {
            if (capturing.Process != null)
            {
                this.lblBejeweledActive.Visible = NativeMethods.IsWindowInForeground(capturing.Process.MainWindowHandle);
            } else
            {
                this.lblBejeweledActive.Visible = false;
            }
            this.lblAutonomous.Visible = IsAutonomous;
            this.lblPaused.Visible = IsPaused;
            this.lblMineCleared.Visible = Processing.DiamondMineCleared;
            if (IsAutonomous)
            {
                AutonomyStrategy.Tick(this);
            }
        }

        private void bSaveScreenshot_Click(object sender, EventArgs e)
        {
            string filename = System.IO.Path.GetTempFileName();
            if (capturing.LastBitmap != null)
            {
                capturing.LastBitmap.Save(filename);
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(filename, saveFileDialog1.FileName);
                }
            }
        }

     

        private void pictureBoxGrid_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Gray, e.ClipRectangle);
            if (Processing.Grid != null)
            {
                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        Gem gem = Processing.Grid[x, y];
                        Rectangle rect = new Rectangle(x * 40 + 2, y * 40 + 2, 35, 35);
                        if (gem != null)
                        {
                            e.Graphics.FillRectangle(new SolidBrush(gem.Color), rect);
                        }
                    }
                }
            }
        }

        private void bLearnAll_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    if (Processing.Grid[x, y] == null) return;
                    KnowledgeBase.TeachingQueue.Add(Processing.Grid[x, y]);
                }
            }
            UpdateUI();
        }

        public void UpdateUI()
        {
            this.lblTeachingQueue.Text = "Lessons: " + KnowledgeBase.TeachingQueue.Count;
            if (TaughtGem != null)
            {
                this.pictureboxTeaching.Image = TaughtGem.Bitmap;
                this.pictureBoxTeachingHistogram.Refresh();
            }
        }

        private void bTeachUnrecognized_Click(object sender, EventArgs e)
        {
            int worstAccuracy = 0;
            Gem worstGem = null;
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    if (Processing.Grid[x, y] == null) return;
                    if (KnowledgeBase.TeachingQueue.Contains(Processing.Grid[x, y])) continue;
                    if (Processing.Grid[x, y].Inaccuracy > worstAccuracy)
                    {
                        worstAccuracy = Processing.Grid[x, y].Inaccuracy;
                        worstGem = Processing.Grid[x, y];
                    }
                }
            }
            if (worstGem != null)
            {
                KnowledgeBase.TeachingQueue.Add(worstGem);
            }
            UpdateUI();
        }

        private void bForget_Click(object sender, EventArgs e)
        {
            if (KnowledgeBase.TeachingQueue.Count > 0)
            {
                KnowledgeBase.TeachingQueue.RemoveAt(0);
                TeachFirst();
            }
        }

        private void TeachFirst()
        {
            if (KnowledgeBase.TeachingQueue.Count > 0)
            {
                TaughtGem = KnowledgeBase.TeachingQueue[0];
                UpdateUI();
            }
            else
            {
                TaughtGem = null;
                this.pictureboxTeaching.Image = new Bitmap(112, 112);
                UpdateUI();
            }
        }

        private void bStartTeaching_Click(object sender, EventArgs e)
        {
            TeachFirst();
        }

        private void bTeach_Click(object sender, EventArgs e)
        {
            if (TaughtGem != null)
            {
                TaughtGem.GemColor = (GemColor)this.cbChooseColor.SelectedItem;
                TaughtGem.GemAuxiliaryInfo = (GemAuxiliaryInfo)this.cbTeachAuxiliary.SelectedItem;
                KnowledgeBase.TrainingData.Add(TaughtGem);
                KnowledgeBase.TeachingQueue.RemoveAt(0);
                TeachFirst();
            }
        }

        private void bSaveDatabase_Click(object sender, EventArgs e)
        {
            KnowledgeBase.Save();
        }

        private void cbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMode.SelectedIndex != -1)
            {
                CurrentMode = (Mode)cbMode.SelectedItem;
            }
        }
        private void cbRecognitionStrategy_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecognitionStrategy = (RecognitionStrategy)cbRecognitionStrategy.SelectedItem;
        }

        private void cbAutonomousStrategy_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutonomyStrategy = (AutonomyStrategy)cbAutonomousStrategy.SelectedItem;
        }

        private void pictureBoxKnowledgeBase_Paint(object sender, PaintEventArgs e)
        {
            int x = 0;
            int y = 0;
            int w = this.pictureBoxKnowledgeBase.Width;
            int size = 56;
            int count = w / size;
            int i = KnowledgeBase.TrainingData.Count - 1;
            while (i >= 0 && y < 6)
            {
                Gem gem = KnowledgeBase.TrainingData[i];
                Rectangle rectGem = new Rectangle(x * size, y * size, size, size);
                e.Graphics.DrawImage(gem.Bitmap, rectGem);
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, gem.Color)), rectGem);
                e.Graphics.DrawRectangle(new Pen(gem.Color, 3), new Rectangle(rectGem.X, rectGem.Y, rectGem.Width - 3,rectGem.Height-3));
                x++;
                if (x == count)
                {
                    x = 0;
                    y++;
                }
                i--;
            }
        }

        private void pictureBoxKnowledgeBase_MouseClick(object sender, MouseEventArgs e)
        {

            int x = 0;
            int y = 0;
            int w = this.pictureBoxKnowledgeBase.Width;
            int size = 56;
            int count = w / size;
            int i = KnowledgeBase.TrainingData.Count - 1;

            int mx = e.X / size;
            int my = e.Y / size;

            while (i >= 0 && y < 6)
            {
                Gem gem = KnowledgeBase.TrainingData[i];
               
                if (mx == x && my == y)
                {
                    KnowledgeBase.TrainingData.RemoveAt(i);
                    break;
                }


                x++;
                if (x == count)
                {
                    x = 0;
                    y++;
                }
                i--;
            }
            this.pictureBoxKnowledgeBase.Refresh();
        }
        internal void Log(string v)
        {
            this.txtDebugLog.Text = v + Environment.NewLine + this.txtDebugLog.Text;
        }

        private void bReloadDB_Click(object sender, EventArgs e)
        {
            KnowledgeBase.Load();
            this.pictureBoxKnowledgeBase.Refresh();
        }

        private void pictureBoxTeachingHistogram_Paint(object sender, PaintEventArgs e)
        {
            if (TaughtGem != null)
            {
                int x = 2;
                int y = 2;
                int height = 10;
                for (int i = 0; i < Histogram.BucketCount; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Red, new RectangleF(x, y, TaughtGem.Histograms.Red.Buckets[i] / 30 + 1, height));
                    y += height;
                }
                y += height;
                for (int i = 0; i < Histogram.BucketCount; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Green, new RectangleF(x, y, TaughtGem.Histograms.Green.Buckets[i] / 30  + 1, height));
                    y += height;
                }
                y += height;
                for (int i = 0; i < Histogram.BucketCount; i++)
                {
                    e.Graphics.FillRectangle(Brushes.Blue, new RectangleF(x, y, TaughtGem.Histograms.Blue.Buckets[i] / 30 + 1, height));
                    y += height;
                }
                y += height;
            }
        }

        private void bRecalcHisto_Click(object sender, EventArgs e)
        {
            foreach(Gem gem in KnowledgeBase.TrainingData)
            {
                gem.Histograms = Histograms.Calculate(gem.Bitmap);
            }
            Log("Recalc complete. Don't forget to save!");
        }
        Font fontPower;
        private void pictureBoxField_Paint(object sender, PaintEventArgs e)
        {
            if (Processing.Grid[0, 0] == null) return;
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Gem gem = Processing.Grid[x, y];
                    Rectangle rect = new Rectangle(x * 56, y * 56, 56, 56);
                    if (gem.SuggestedDirection != Direction.None)
                    {
                        e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(50, Color.White)), rect);
                        e.Graphics.DrawRectangle(Pens.White, rect);
                        switch(gem.SuggestedDirection)
                        {
                            case Direction.Up:
                                e.Graphics.FillRectangle(Brushes.White, new RectangleF(rect.X, rect.Y, rect.Width, 5));
                                break;
                            case Direction.Down:
                                e.Graphics.FillRectangle(Brushes.White, new RectangleF(rect.X, rect.Bottom - 5, rect.Width, 5));
                                break;
                            case Direction.Left:
                                e.Graphics.FillRectangle(Brushes.White, new RectangleF(rect.X, rect.Y, 5, rect.Height));
                                break;
                            case Direction.Right:
                                e.Graphics.FillRectangle(Brushes.White, new RectangleF(rect.Right - 5, rect.Y, 5, rect.Height));
                                break;
                        }
                        e.Graphics.DrawString(gem.SuggestedPower.ToString(), fontPower, Brushes.Black, new PointF(rect.X + 10, rect.Y + 10));
                    }

                }
            }
        }
    }
}
