using iPGS.Tools;
using Kztek.Cameras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iPGSTools.Usercontrols
{
    public partial class ucCameraView : UserControl
    {
        public Camera _Camera { get; set; }
        //public MotionDetector _MotionDetector { get; set; }
        private CancellationTokenSource ctsDetectMotion;

        //public delegate void MotionDetectEventHandler(object sender, MotionDetectEventArgs e);

        public class MotionDetectEventArgs : EventArgs
        {
            public DateTime EventTime { get; set; }
            public Camera DetectCamera { get; set; }
        }

        public static bool SafeInvoke(Control control, MethodInvoker method)
        {
            if (control != null && !control.IsDisposed && control.IsHandleCreated && control.FindForm().IsHandleCreated)
            {
                if (control.InvokeRequired)
                {
                    control.Invoke(method);
                }
                else
                {
                    method();
                }
                return true;
            }
            return false;
        }
        public ucCameraView()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        //public void StartViewer(Camera camera, MotionDetector motionDetector, CameraErrorEventHandler cameraErrorFunc, EventHandler cameraDoubleClickFunc)
        //{
        //    this._Camera = camera;
        //    this._MotionDetector = motionDetector;

        //    SafeInvoke(lblCameraName, new MethodInvoker(() =>
        //    {
        //        lblCameraName.Text = camera.Name;
        //    }));
        //    motionDetector = new MotionDetector(new TwoFramesDifferenceDetector(true), null);
        //    if (!string.IsNullOrEmpty(camera.MotionRegions))
        //    {
        //        string[] motionRegions = camera.MotionRegions.Split(',');
        //        Rectangle motionRegion = new Rectangle(int.Parse(motionRegions[0]), int.Parse(motionRegions[1]), int.Parse(motionRegions[2]), int.Parse(motionRegions[3]));
        //        Rectangle[] motionZone1 = new Rectangle[] { motionRegion };
        //        motionDetector.MotionZones = motionZone1;
        //    }

        //    camera.CameraError += cameraErrorFunc;
        //    camera.Start();

        //    if (camera != null && camera.videoSourcePlayer != null)
        //    {
        //        var control = (Control)camera.videoSourcePlayer;
        //        panelCameraView?.Invoke(method: () => panelCameraView.Controls.Add(control));

        //        control?.Invoke(method: () =>
        //        {
        //            (control).Name = camera.ID;
        //            (control).DoubleClick += cameraDoubleClickFunc;
        //            (control).Dock = DockStyle.Fill;
        //        });

        //        control?.Invoke(method: () => control.BringToFront());
        //    }

        //}
        public void StartViewer(Camera camera, CameraErrorEventHandler cameraErrorFunc, EventHandler cameraDoubleClickFunc)
        {
            try
            {
                this._Camera = camera;

                SafeInvoke(lblCameraName, new MethodInvoker(() =>
                {
                    lblCameraName.Text = camera.Name;
                }));
                camera.CameraError += cameraErrorFunc;
                camera.Start();

                if (camera != null && camera.videoSourcePlayer != null)
                {
                    var control = (Control)camera.videoSourcePlayer;
                    panelCameraView?.Invoke(method: () => panelCameraView.Controls.Add(control));

                    control?.Invoke(method: () =>
                    {
                        (control).Name = camera.ID;
                        (control).DoubleClick += cameraDoubleClickFunc;
                        (control).Dock = DockStyle.Fill;
                        control.DoubleClick += Control_DoubleClick;
                    });

                    control?.Invoke(method: () => control.BringToFront());
                }
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception StartViewer ex = {ex}", LogHelperv2.SaveLogFolder);
            }
        }

        private void Control_DoubleClick(object? sender, EventArgs e)
        {
            frmViewCamera frm = new frmViewCamera();
            frm.CurrentCamera = _Camera;
            frm.ShowDialog();
        }

        public void StartMotionDetection()
        {
            PollingStart();
        }

        private void PollingStart()
        {
            ctsDetectMotion = new CancellationTokenSource();

            //Task.Run(() =>
            //    DetectMotionCam(ctsDetectMotion.Token), ctsDetectMotion.Token
            //);
        }

        //private async Task DetectMotionCam(CancellationToken token)
        //{
        //    while (!token.IsCancellationRequested)
        //    {
        //        try
        //        {
        //            await Task.Delay(1000);

        //            // get current frame
        //            Bitmap currentFrame = null;
        //            currentFrame = this._Camera.GetCurrentVideoFrame();

        //            if (currentFrame != null)
        //            {
        //                using (Bitmap bmp = new Bitmap(currentFrame))
        //                {
        //                    UnmanagedImage currentVideoFrame = UnmanagedImage.FromManagedImage(bmp);
        //                    if (this._MotionDetector != null && currentVideoFrame != null)
        //                    {
        //                        // process frame
        //                        float motionLevel = _MotionDetector.ProcessFrame(currentVideoFrame);
        //                        float alarmLevel = (float)this._Camera.MotionAlarmLevel / 1000f;

        //                        if (motionLevel > alarmLevel)
        //                        {
        //                            MotionDetectEvent?.Invoke(this, new MotionDetectEventArgs { DetectCamera = this._Camera, EventTime = DateTime.Now });
        //                        }
        //                    }

        //                    // release image
        //                    if (currentVideoFrame != null)
        //                    {
        //                        currentVideoFrame.Dispose();
        //                    }
        //                }
        //            }


        //        }
        //        catch (Exception ex)
        //        {
        //            LogHelper.Logger_Error(ex.Message, LogHelper.GetFunctionName());
        //        }
        //    }
        //}

    }

}
