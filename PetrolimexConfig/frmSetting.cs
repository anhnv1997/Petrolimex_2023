using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetrolimexConfig.Helper;
using PetrolimexConfig.Model;

namespace PetrolimexConfig
{
    public partial class frmSetting : Form
    {
        #region Propertiws
        #endregion
        private string SQLConfigPath = $"{Application.StartupPath}\\SQLConfig.xml";
        private string SystemConfigPath = $"{Application.StartupPath}\\ApplicationConfig.xml";
        #region Forms
        public frmSetting()
        {
            InitializeComponent();
        }

        #endregion

        #region Controls In Form
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSQLConfig();
            SaveSymtemInfoConfig();

            MessageBox.Show("Lưu cấu hình hoàn tất", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        private void frmSetting_Load(object sender, EventArgs e)
        {
            SQLConfig sql = LoadSQLConfig();
            ApplicationConfig systemInfo = LoadSystemConfig();

            txtSqlServerName.Text = sql.SQLServername;
            txtDatabaseName.Text = sql.SQLDatabaseName;
            cbAuthMode.SelectedIndex = cbAuthMode.FindStringExact(sql.SQLAuthMode);
            txtSqlUsername.Text = sql.SQLUsername;
            txtSqlPassword.Text = sql.SQLPassword;

            //--Controller
            txtControllerIp.Text = systemInfo.ControllerIP;
            numControllerPort.Value = systemInfo.ControllerPort;

            //--Camera
            txtCameraIp.Text = systemInfo?.CameraIP;
            numCameraPort.Value = systemInfo.CameraPort;
            txtCameraUsername.Text = systemInfo.CameraUsername;
            txtCameraPassword.Text = systemInfo.CameraPassword;
            cbCameraDetectType.SelectedIndex = cbCameraDetectType.FindStringExact(systemInfo.DetectType);
            //LPR Camera
            txtLprServer.Text = systemInfo.LPR_API;

            //--API
            numApiPort.Value = systemInfo.ApiPort;
            txtPaymentServer.Text = systemInfo.FIS_URL;
            txtAgasUrl.Text = systemInfo.AGAS_URl;
            txbCreateInvoiceHost.Text = systemInfo.Host_CreateInvoice;
            txbCreateInvoicePort.Text = systemInfo.Port_CreateInvoice.ToString();
            
            // Other
            txtStationID.Text = systemInfo.StationID;
            txtStationName.Text = systemInfo.StationName;
            txbCountDetect.Text = systemInfo.CountDetect.ToString();
            txbTimeDelayDetect.Text = systemInfo.TimeDelayDetect.ToString();

            txbTimeClearList.Text = systemInfo.TimeClearList.ToString();
        }

        private SQLConfig LoadSQLConfig()
        {
            SQLConfig[] sql = null;
            var usingdb = new SQLConfig();
            
            if (File.Exists(SQLConfigPath))
            {
                FileXML.ReadXMLSQLConn(SQLConfigPath, ref sql);
                if (sql != null && sql.Length > 0)
                {
                    usingdb = sql[0];
                }
                else
                {
                    MessageBox.Show("Chưa có dữ liệu để load");
                }
            }
            return usingdb;
        }
        private ApplicationConfig LoadSystemConfig()
        {
            ApplicationConfig[] system = null;
            var usingdb = new ApplicationConfig();

            if (File.Exists(SystemConfigPath))
            {
                FileXML.ReadXMLSQLConn(SystemConfigPath, ref system);
                if (system != null && system.Length > 0)
                {
                    usingdb = system[0];
                }
                else
                {
                    MessageBox.Show("Chưa có dữ liệu để load");
                }
            }
            return usingdb;
        }
        #endregion

        private void label19_Click(object sender, EventArgs e)
        {

        }
       
        private void SaveSQLConfig()
        {
            List<SQLConfig> sqlconnlist = new List<SQLConfig>();

            SQLConfig cn1 = new SQLConfig()
            {
                SQLServername = txtSqlServerName.Text,
                SQLDatabaseName = txtDatabaseName.Text,
                SQLAuthMode = cbAuthMode.Text,
                SQLUsername = txtSqlUsername.Text,
                SQLPassword = txtSqlPassword.Text,
            };
            sqlconnlist.Add(cn1);

            FileXML.WriteXML<SQLConfig>(SQLConfigPath, sqlconnlist);
        }
        private void SaveSymtemInfoConfig()
        {
            List<ApplicationConfig> systemlist = new List<ApplicationConfig>();

            ApplicationConfig sys = new ApplicationConfig()
            {
                ControllerIP = txtControllerIp.Text,
                ControllerPort = (int)numControllerPort.Value,

                CameraIP = txtCameraIp.Text,
                CameraPort = (int)numCameraPort.Value,
                CameraUsername = txtCameraUsername.Text,
                CameraPassword = txtCameraPassword.Text,
                DetectType = cbCameraDetectType.Text,

                ApiPort = (int)numApiPort.Value,
                LPR_API = txtLprServer.Text,
                FIS_URL = txtPaymentServer.Text,
                AGAS_URl = txtAgasUrl.Text,
                Host_CreateInvoice = txbCreateInvoiceHost.Text,
                Port_CreateInvoice = int.Parse(txbCreateInvoicePort.Text),

                StationID = txtStationID.Text,
                StationName = txtStationName.Text,
                CountDetect = int.Parse(txbCountDetect.Text),
                TimeDelayDetect = int.Parse(txbTimeDelayDetect.Text),

                TimeClearList = int.Parse(txbTimeClearList.Text),
            };
            systemlist.Add(sys);

            FileXML.WriteXML<ApplicationConfig>(SystemConfigPath, systemlist);
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
