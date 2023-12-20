using IPGS.Object.Databases;
using PETROLIMEX.Helper;
using PetrolimexConfig.Model;
using System.Net.Sockets;
using System.Net;
using System.Data;
using PETROLIMEX.Models;
using Kztek.Cameras;
using Newtonsoft.Json;
using iPGSTools.Models;
using iPGSTools;

namespace PETROLIMEX.Forms
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();

            StaticPool.SQLConfigPath = $"{Application.StartupPath}\\SQLConfig.xml";
            StaticPool.SystemConfigPath = $"{Application.StartupPath}\\ApplicationConfig.xml";

        }

        private async void frmLoading_Load(object sender, EventArgs e)
        {
            try
            {
                lblMessage.Text = "Đang tải cấu hình...";
                LoadSQL();
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


            // Check tên máy tính
            string cmd = $"Select * from tblPC where ComputerName = '{namePC}' or IPAdress = '{IPLocal}'";
            DataTable dtPC = StaticPool.mdb.FillData(cmd);

            if (dtPC == null || dtPC.Rows.Count <= 0)
            {
                MessageBox.Show("Máy tính không tồn tại");
                return;
            }

            string PCID = dtPC.Rows[0]["PCID"].ToString();
            string namepc = dtPC.Rows[0]["ComputerName"].ToString();

            // Check location
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
            if (dtCam != null || dtCam.Rows.Count > 0)
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
        private void LoadSQL()
        {
            try
            {
                if (File.Exists(StaticPool.SQLConfigPath))
                {
                    SQLConfig[] sqlcon = FileXML.ReadXML<SQLConfig>(StaticPool.SQLConfigPath);

                    if (sqlcon != null && sqlcon.Length > 0)
                    {
                        StaticPool.SQLServerName = sqlcon[0].SQLServername;
                        StaticPool.SQLDatabaseName = sqlcon[0].SQLDatabaseName;
                        StaticPool.SQLAuthentication = sqlcon[0].SQLAuthMode;
                        StaticPool.SQLUserName = sqlcon[0].SQLUsername;
                        StaticPool.SQLPassword = sqlcon[0].SQLPassword;

                        StaticPool.mdb = new Mdb(StaticPool.SQLServerName,
                                                StaticPool.SQLDatabaseName,
                                                StaticPool.SQLAuthentication,
                                                StaticPool.SQLUserName,
                                                StaticPool.SQLPassword);
                        LogHelperv2.Logger_SystemInfor($"Load SQL thành công", LogHelperv2.SaveLogFolder);
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception LoadSQL ex = {ex}", LogHelperv2.SaveLogFolder);
            }

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
