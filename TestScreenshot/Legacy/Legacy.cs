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
        private void btnCapture_Click(object sender, EventArgs e)
        {
            start = DateTime.Now;
            progressBar1.Maximum = 1;
            progressBar1.Step = 1;
            progressBar1.Value = 0;

            DoRequest();
        }

        private void btnLoadTest_Click(object sender, EventArgs e)
        {
            // Note: we bring the target application into the foreground because
            //       windowed Direct3D applications have a lower framerate 
            //       if not the currently focused window
            capturing.CaptureProcess.BringProcessWindowToFront();
            start = DateTime.Now;
            progressBar1.Maximum = Convert.ToInt32(txtNumber.Text);
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
            progressBar1.Value = 0;
            DoRequest();
        }

        // Legacy
        /// <summary>
        /// Create the screen shot request
        /// </summary>
        void DoRequest()
        {
            progressBar1.Invoke(new MethodInvoker(delegate ()
            {
                if (progressBar1.Value < progressBar1.Maximum)
                {
                    progressBar1.PerformStep();

                    capturing.CaptureProcess.BringProcessWindowToFront();
                    // Initiate the screenshot of the CaptureInterface, the appropriate event handler within the target process will take care of the rest
                    Size? resize = null;
                    if (!String.IsNullOrEmpty(txtResizeHeight.Text) && !String.IsNullOrEmpty(txtResizeWidth.Text))
                        resize = new System.Drawing.Size(int.Parse(txtResizeWidth.Text), int.Parse(txtResizeHeight.Text));
                    capturing.CaptureProcess.CaptureInterface.BeginGetScreenshot(new Rectangle(int.Parse(txtCaptureX.Text), int.Parse(txtCaptureY.Text), int.Parse(txtCaptureWidth.Text), int.Parse(txtCaptureHeight.Text)), new TimeSpan(0, 0, 2), Callback, resize, (ImageFormat)Enum.Parse(typeof(ImageFormat), cmbFormat.Text));
                }
                else
                {
                    end = DateTime.Now;
                    txtDebugLog.Text = String.Format("Debug: {0}\r\n{1}", "Total Time: " + (end - start).ToString(), txtDebugLog.Text);
                }
            })
            );
        }
        /// <summary>
        /// The callback for when the screenshot has been taken
        /// </summary>
        /// <param name="clientPID"></param>
        /// <param name="status"></param>
        /// <param name="screenshotResponse"></param>
        void Callback(IAsyncResult result)
        {
            using (Screenshot screenshot = capturing.CaptureProcess.CaptureInterface.EndGetScreenshot(result))
                try
                {
                    capturing.CaptureProcess.CaptureInterface.DisplayInGameText("Screenshot captured...");
                    if (screenshot != null && screenshot.Data != null)
                    {
                        pictureBoxOverview.Invoke(new MethodInvoker(delegate ()
                        {
                            if (pictureBoxOverview.Image != null)
                            {
                                pictureBoxOverview.Image.Dispose();
                            }
                            pictureBoxOverview.Image = screenshot.ToBitmap();
                        })
                        );
                    }

                    Thread t = new Thread(new ThreadStart(DoRequest));
                    t.Start();
                }
                catch
                {
                }
        }
        // Legacy
        private void button1_Click(object sender, EventArgs e)
        {
            screenshottingTimer.Enabled = true;
            screenshottingTimer.Stop();
            screenshottingTimer.Start();
        }

    }
}
