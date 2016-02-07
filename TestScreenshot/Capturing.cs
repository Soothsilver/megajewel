using Capture;
using Capture.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Megajewel
{
    public class Capturing
    {
        public int ProcessId = 0;
        public Process Process;
        public CaptureProcess CaptureProcess;
        public Bitmap LastBitmap;

        MegajewelForm Form;
        internal bool ScreenshotInProgress;

        public bool BejeweledInForeground()
        {
            return NativeMethods.IsWindowInForeground(Process.MainWindowHandle);
        }

        public Capturing(MegajewelForm form)
        {
            Form = form;
        }

        internal void RequestCapture()
        {
            if (ScreenshotInProgress)
            {
                return;
            }
            if (CaptureProcess == null)
            {
                return;
            }
            if (!BejeweledInForeground()) return;
            ScreenshotInProgress = true;

            CaptureProcess.CaptureInterface.BeginGetScreenshot(
                new Rectangle(0, 0, 0, 0), new TimeSpan(0, 0, 2), Callback, null, ImageFormat.Bitmap);
        }
        void Callback(IAsyncResult result)
        {
            using (Screenshot screenshot = CaptureProcess.CaptureInterface.EndGetScreenshot(result))
                try
                {
                    CaptureProcess.CaptureInterface.DisplayInGameText("Screenshot captured...");
                    if (screenshot != null && screenshot.Data != null)
                    {
                        Bitmap last = LastBitmap;
                        LastBitmap = screenshot.ToBitmap();
                        if (last != null)
                        {
                            last.Dispose();
                        }
                        Form.Processing.Process(LastBitmap); 
                        Form.pictureBoxOverview.Image = LastBitmap;
                    }
                    ScreenshotInProgress = false;
                }
                catch (Exception ex)
                {
                    Action a = () => {
                        Form.txtDebugLog.Text = "Callback Exception: " + ex + Environment.NewLine + Form.txtDebugLog.Text;
                    };
                    Form.txtDebugLog.Invoke(a);
                }
        }
    }
}
