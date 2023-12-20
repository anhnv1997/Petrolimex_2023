using DocumentFormat.OpenXml.Spreadsheet;
using iPGSTools;
using iPGSTools.Usercontrols;
using Kztek.Cameras;
using PETROLIMEX.Helper;
using PETROLIMEX.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HIKSDK.CHCNetSDK;

namespace PETROLIMEX.Usercontrols
{
    public partial class ucLocationView : UserControl
    {
        public string title { get; set; } = "";
        public Camera camera { get; set; }

        public static double GetPreferRatio()
        {
            //return 643f / 582;
            return 500f / 582;

        }
        public static int GetPreferWidth() => 800;

        public ucLocationView(LocationConfig location)
        {
            InitializeComponent();

            this.title = location.LocationName;

            label1.Text = location.LocationName;
            this.camera = location.Camera;

            this.Load += Ucm_Load;
        }

        private void Ucm_Load(object? sender, EventArgs e)
        {
            StartCameraView(camera);
        }
        public void SetImage(Image image)
        {
            pictureBox1.Image = image;
        }
        public void SetText(DateTime dtime, string plate)
        {
            lblTime.Text = dtime.ToString();
            lblPlate.Text = plate;
        }
        private void StartCameraView(Camera cam)
        {
            try
            {
                panel1?.Invoke(new Action(() =>
                {
                    //panelCamera.Controls.Add(ucCamera);
                    ucCameraView1?.Invoke(() =>
                    {
                        ucCameraView1.StartViewer(cam, CameraErrorFunc, CameraDoubleClickFunc);
                    });
                }));
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception StartCameraView ex: {ex}", LogHelperv2.SaveLogFolder);
                MessageBox.Show($"Exception StartCameraView: {ex}");
            }

        }
        private void CameraErrorFunc(object sender, string errorString)
        {

        }
        private void CameraDoubleClickFunc(object sender, EventArgs e)
        {
        }
    }
}
