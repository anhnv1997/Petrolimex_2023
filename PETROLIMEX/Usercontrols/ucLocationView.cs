using Kztek.Cameras;
using PetrolimexTools.Helper;
using PetrolimexTools.Model;

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
            lblTime.Text = "Time: " + dtime.ToString();
            plate = plate == "" ? "Empty" : plate;
            lblPlate.Text = "Biển số: " + plate;
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
