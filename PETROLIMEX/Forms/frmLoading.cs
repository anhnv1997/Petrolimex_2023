using System.Net;
using System.Data;
using Kztek.Cameras;
using Newtonsoft.Json;
using iPGSTools.Models;
using iPGSTools;
using PetrolimexTools.Helper;
using PetrolimexTools;
using PetrolimexTools.Model;

namespace PETROLIMEX.Forms
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();

            //StaticPool.SQLConfigPath = $"{Application.StartupPath}\\SQLConfig.xml";
            //StaticPool.SystemConfigPath = $"{Application.StartupPath}\\ApplicationConfig.xml";

        }

        private async void frmLoading_Load(object sender, EventArgs e)
        {
            try
            {
                lblMessage.Text = "Đang tải cấu hình...";

                StaticPool.LoadSQL();
                //LoadSQL();
                lblMessage.Text = "Load SQL hoàn tất";

                LoadSystemConfig();
                lblMessage.Text = "Load SystemConfig hoàn tất";

                LoadLocationConfig();
                lblMessage.Text = "Load LoadLocationConfig hoàn tất";

                await Task.Run(() =>
                {
                    FISHelper.StartPollingAuthorize();
                });
                lblMessage.Text = "Login Author hoàn tất";

                try
                {
                    CreateHostBuilder().Build().RunAsync();
                }
                catch (Exception ex)
                {
                    LogHelperv2.Logger_CONTROLLER_Error($"Exception CreateHostBuilder ex = {ex}", LogHelperv2.SaveLogFolder);
                    MessageBox.Show(ex.Message);
                }
                lblMessage.Text = "Tạo host hoàn tất";

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception frmLoading_Load ex = {ex}", LogHelperv2.SaveLogFolder);
            }


        }
        private static IHostBuilder CreateHostBuilder() =>
        Host.CreateDefaultBuilder()
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseUrls("http://*:" + StaticPool.applicationConfig.ApiPort);// 
                string a = StaticPool.applicationConfig.ApiPort.ToString();
                webBuilder.UseStartup<Startup>();
            });
        private void LoadLocationConfig()
        {
            string IPLocal = LocalIPAddress();
            string namePC = Environment.MachineName;


            // Check tên máy tính*********************************************************************************************************************
            string cmd = $"Select * from tblPC where ComputerName = '{namePC}' or IPAdress = '{IPLocal}'";
            DataTable dtPC = StaticPool.mdb.FillData(cmd);

            if (dtPC == null || dtPC.Rows.Count <= 0)
            {
                MessageBox.Show("Máy tính không tồn tại");
                return;
            }

            string PCID = dtPC.Rows[0]["PCID"].ToString();
            string namepc = dtPC.Rows[0]["ComputerName"].ToString();
            string pathImage = dtPC.Rows[0]["PicPath"].ToString();
            StaticPool.pathImage = pathImage;

            // Check Station
            string cmdStation = $"Select * from tblStation where PCID = '{PCID}'";
            DataTable dtStation = StaticPool.mdb.FillData(cmdStation);

            if (dtStation != null && dtStation.Rows.Count > 0)
            {
                StaticPool.StationName = dtStation.Rows[0]["StationName"].ToString();
                StaticPool.StationID = dtStation.Rows[0]["AgasStationID"].ToString();
            }

            // Check BDK ***************************************************************************************************************************
            string cmdBDK = $"Select PCID, Comport, Baudrate from tblController where PCID = '{PCID}'";
            DataTable dtPC2 = StaticPool.mdb.FillData(cmdBDK);
            if (dtPC2 != null && dtPC2.Rows.Count > 0)
            {
                StaticPool.controllerInfo.controllerIP = dtPC2.Rows[0]["Comport"].ToString();
                StaticPool.controllerInfo.controllerPort = int.Parse(dtPC2.Rows[0]["Baudrate"].ToString());
            }
            else
            {
                MessageBox.Show("Không tìm thấy controller!");
            }

            // Check location *************************************************************************************************************************
            string cmdLocation = $"Select * from tblLocation where PCID = '{PCID}' and IsActive = '1'";
            DataTable dtLocation = StaticPool.mdb.FillData(cmdLocation);

            if (dtLocation == null || dtLocation.Rows.Count <= 0)
            {
                MessageBox.Show($"Không tìm thấy vị trí đổ xăng cho máy tính này {namepc}");
                return;
            }

            foreach (DataRow row in dtLocation.Rows)
            {
                LocationConfig location = new LocationConfig();

                location.locationID = row["LocationID"].ToString();
                location.LocationName = row["LocationName"].ToString();
                location.PCID = row["PCID"].ToString();
                location.Camera = GetCamera(row["Camera1"].ToString());
                location.listPumpID = GetPump(row["PumpID"].ToString());
                location.ControllerEtagID = row["ControllerEtagID"].ToString();
                location.Description = row["Description"].ToString();

                StaticPool.listLocationConfig.Add(location);
            }
            StaticPool.NumberLocation = StaticPool.listLocationConfig.Count;

          
        }

        private static Camera GetCamera(string cameraID)
        {
            string cmdCam = $"Select * from tblCamera where CameraID  = '{cameraID}'";
            DataTable dtCam = StaticPool.mdb.FillData(cmdCam);

            Camera camera = new Camera();
            if (dtCam != null && dtCam.Rows.Count > 0)
            {
                camera.ID = dtCam.Rows[0]["CameraID"].ToString();
                camera.Name = dtCam.Rows[0]["CameraName"].ToString();
                camera.VideoSource = dtCam.Rows[0]["HttpURL"].ToString();
                camera.HttpPort = int.Parse(dtCam.Rows[0]["HttpPort"].ToString());
                camera.ServerPort = int.Parse(dtCam.Rows[0]["RtspPort"].ToString());
                camera.Chanel = int.Parse(dtCam.Rows[0]["Channel"].ToString());
                camera.Login = dtCam.Rows[0]["UserName"].ToString();
                camera.Password = dtCam.Rows[0]["Password"].ToString();
                camera.CameraType = CameraTypes.GetType(dtCam.Rows[0]["CameraType"].ToString());
                camera.StreamType = StreamTypes.GetType(dtCam.Rows[0]["StreamType"].ToString());
                camera.Resolution = dtCam.Rows[0]["Resolution"].ToString();
                camera.UsingPlugins = 0;
            }

            return camera;
        }
        private List<int> GetPump(string pumpjson)
        {
            string json = pumpjson;
           
            List<int> listPump = JsonConvert.DeserializeObject<List<int>>(json);
            return listPump;
        }
        public static string LocalIPAddress()
        {
            try
            {
                IPHostEntry host;
                string localIP = "";
                host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily.ToString() == "InterNetwork")
                    {
                        localIP = ip.ToString();
                    }
                }
                return localIP;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "";
        }
       
        private void LoadSystemConfig()
        {
            try
            {
                if (File.Exists(StaticPool.SystemConfigPath))
                {
                    ApplicationConfig[] systemconfig = FileXML.ReadXML<ApplicationConfig>(StaticPool.SystemConfigPath);

                    if (systemconfig != null && systemconfig.Length > 0)
                    {
                        StaticPool.applicationConfig = systemconfig[0];

                        LogHelperv2.Logger_SystemInfor($"LoadSystemConfig thành công", LogHelperv2.SaveLogFolder);
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception LoadSystemConfig ex = {ex}", LogHelperv2.SaveLogFolder);
            }
        }
    }
}
