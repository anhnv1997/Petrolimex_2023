using PetrolimexTools.Model;
using PetrolimexConfig.Helper;
using PetrolimexTools;
using System.Windows.Forms;
using System.Data;
using PetrolimexConfig.UC;
using PetrolimexTools.tblData;

namespace PetrolimexConfig
{
    public partial class frmSetting : Form
    {
        #region Propertiws
        #endregion
        //private string SQLConfigPath = $"{Application.StartupPath}\\SQLConfig.xml";
        //private string SystemConfigPath = $"{Application.StartupPath}\\ApplicationConfig.xml";
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
        private async void frmSetting_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;

            SQLConfig sql = LoadSQLConfig();
            ApplicationConfig systemInfo = LoadSystemConfig();

            txtSqlServerName.Text = sql.SQLServername;
            txtDatabaseName.Text = sql.SQLDatabaseName;
            cbAuthMode.SelectedIndex = cbAuthMode.FindStringExact(sql.SQLAuthMode);
            txtSqlUsername.Text = sql.SQLUsername;
            txtSqlPassword.Text = sql.SQLPassword;

            //--Camera
            //txtCameraIp.Text = systemInfo?.CameraIP;
            //numCameraPort.Value = systemInfo.CameraPort;
            //txtCameraUsername.Text = systemInfo.CameraUsername;
            //txtCameraPassword.Text = systemInfo.CameraPassword;
            //cbCameraDetectType.SelectedIndex = cbCameraDetectType.FindStringExact(systemInfo.DetectType);
            //LPR Camera
            txtLprServer.Text = systemInfo.LPR_API;

            //--API
            numApiPort.Value = systemInfo.ApiPort;
            txtPaymentServer.Text = systemInfo.FIS_URL;
            txtAgasUrl.Text = systemInfo.AGAS_URl;
            txbCreateInvoiceHost.Text = systemInfo.Host_CreateInvoice;
            txbCreateInvoicePort.Text = systemInfo.Port_CreateInvoice.ToString();

            // Other
            txbCountDetect.Text = systemInfo.CountDetect.ToString();
            txbTimeDelayDetect.Text = systemInfo.TimeDelayDetect.ToString();

            txbTimeClearList.Text = systemInfo.TimeClearList.ToString();

            await LoadViewConfigSQL();
        }

        private async Task LoadViewConfigSQL()
        {
            if (StaticPool.LoadSQL())
            {
                if (!await StaticPool.DatabaseConnectCheck(StaticPool.SQLServerName, StaticPool.SQLUserName, StaticPool.SQLPassword, StaticPool.SQLAuthentication))
                {
                    MessageBox.Show("Chưa mở kết nối! Xem lại cấu hình");
                }
                else
                {
                    LoadPC();
                    LoadStation();
                    LoadLocation();
                    LoadController();
                    LoadCamera();
                    LoadPump();
                }

            }
        }

        private SQLConfig LoadSQLConfig()
        {
            SQLConfig[] sql = null;
            var usingdb = new SQLConfig();

            if (File.Exists(StaticPool.SQLConfigPath))
            {
                FileXML.ReadXMLSQLConn(StaticPool.SQLConfigPath, ref sql);
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

            if (File.Exists(StaticPool.SystemConfigPath))
            {
                FileXML.ReadXMLSQLConn(StaticPool.SystemConfigPath, ref system);
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

            FileXML.WriteXML<SQLConfig>(StaticPool.SQLConfigPath, sqlconnlist);
        }
        private void SaveSymtemInfoConfig()
        {
            List<ApplicationConfig> systemlist = new List<ApplicationConfig>();

            ApplicationConfig sys = new ApplicationConfig()
            {
                //CameraIP = txtCameraIp.Text,
                //CameraPort = (int)numCameraPort.Value,
                //CameraUsername = txtCameraUsername.Text,
                //CameraPassword = txtCameraPassword.Text,
                //DetectType = cbCameraDetectType.Text,

                ApiPort = (int)numApiPort.Value,
                LPR_API = txtLprServer.Text,
                FIS_URL = txtPaymentServer.Text,
                AGAS_URl = txtAgasUrl.Text,
                Host_CreateInvoice = txbCreateInvoiceHost.Text,
                Port_CreateInvoice = int.Parse(txbCreateInvoicePort.Text),

                CountDetect = int.Parse(txbCountDetect.Text),
                TimeDelayDetect = int.Parse(txbTimeDelayDetect.Text),

                TimeClearList = int.Parse(txbTimeClearList.Text),
            };
            systemlist.Add(sys);

            FileXML.WriteXML<ApplicationConfig>(StaticPool.SystemConfigPath, systemlist);
        }
        private void LoadPC()
        {
            string cmd = "Select * from tblPC";
            DataTable dt = StaticPool.mdb?.FillData(cmd);

            dgvPC.DataSource = dt;
        }
        private void LoadStation()
        {
            string cmd = "Select * from tblStation";
            DataTable dt = StaticPool.mdb?.FillData(cmd);

            dgvStation.DataSource = dt;
        }
        private void LoadLocation()
        {
            string cmd = "Select * from tblLocation";
            DataTable dt = StaticPool.mdb?.FillData(cmd);

            dgvLocation.DataSource = dt;
        }
        private void LoadController()
        {
            string cmd = "Select * from tblController";
            DataTable dt = StaticPool.mdb?.FillData(cmd);

            dgvController.DataSource = dt;
        }
        private void LoadCamera()
        {
            string cmd = "Select * from tblCamera";
            DataTable dt = StaticPool.mdb?.FillData(cmd);

            dgvCamera.DataSource = dt;
        }
        private void LoadPump()
        {
            string cmd = "Select * from tblPump";
            DataTable dt = StaticPool.mdb?.FillData(cmd);

            dgvPump.DataSource = dt;
        }
        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void siticoneTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void siticoneTabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TabPage selectedTab = siticoneTabControl2.SelectedTab;
            //if (selectedTab.Tag != null)
            //{
            //    // Lấy thông tin dữ liệu gắn với tab (có thể là tên form, đối tượng UserControl, hoặc bất kỳ dữ liệu nào khác)
            //    var tabData = selectedTab.Tag;

            //    // Kiểm tra kiểu dữ liệu để thực hiện xử lý tương ứng
            //    if (tabData is Type formType)
            //    {
            //        // Nếu là kiểu Type (đối tượng Form), thì tạo mới và hiển thị form
            //        Form formInstance = Activator.CreateInstance(formType) as Form;
            //        if (formInstance != null)
            //        {
            //            formInstance.TopLevel = false;
            //            formInstance.FormBorderStyle = FormBorderStyle.None;
            //            formInstance.Dock = DockStyle.Fill;
            //            // Thêm form vào Controls của tab hoặc của một Panel trong tab (tùy thuộc vào cách bạn thiết kế)
            //            selectedTab.Controls.Add(formInstance);
            //            formInstance.Show();
            //        }
            //    }
            //    // Có thể thêm các điều kiện xử lý khác tùy thuộc vào kiểu dữ liệu bạn sử dụng
            //}
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmModifyConfig frm = new frmModifyConfig(new ucAddPC());
            frm.ShowDialog();

            Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmModifyConfig frm = new frmModifyConfig(new ucStation());
            frm.ShowDialog();

            Refresh();

        }

        private void siticoneButton8_Click(object sender, EventArgs e)
        {
            frmModifyConfig frm = new frmModifyConfig(new ucLocation());
            frm.ShowDialog();
            Refresh();

        }

        private void siticoneButton11_Click(object sender, EventArgs e)
        {
            frmModifyConfig frm = new frmModifyConfig(new ucController());
            frm.ShowDialog();
            Refresh();

        }

        private void siticoneButton14_Click(object sender, EventArgs e)
        {
            frmModifyConfig frm = new frmModifyConfig(new ucCamera());
            frm.ShowDialog();
            Refresh();

        }
        private void siticoneButton17_Click(object sender, EventArgs e)
        {
            frmModifyConfig frm = new frmModifyConfig(new ucPump());
            frm.ShowDialog();
            Refresh();

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private async void btnPing_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            if (await StaticPool.DatabaseConnectCheck(txtSqlServerName.Text, txtSqlUsername.Text, txtSqlPassword.Text, cbAuthMode.Text))
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources._true;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.False;
            }
        }
       
        private void dgvPC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy giá trị của cột "ID" tại hàng được kích đúp
                string idValue = dgvPC.Rows[e.RowIndex].Cells["PCID"].Value.ToString();

                if (idValue != null)
                {
                    ucAddPC uc = new ucAddPC(idValue, true);
                    frmModifyConfig frm = new frmModifyConfig(uc);
                    frm.ShowDialog();

                    Refresh();

                }
            }
        }

        private void dgvPC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Refresh()
        {
            frmSetting_Load(null,null);
        }
        private void btnDeletePC_Click(object sender, EventArgs e)
        {
            if (dgvPC.CurrentRow != null)
            {
                string idPC = dgvPC.CurrentRow.Cells["PCID"].Value.ToString();
                string pcname = dgvPC.CurrentRow.Cells["ComputerName"].Value.ToString();

                DialogResult dt = MessageBox.Show($"Xác nhận xóa PC: {pcname}", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dt == DialogResult.Yes)
                {
                    string cmd = $"Delete from tblPC where PCID = '{idPC}'";
                    if (StaticPool.mdb.ExecuteCommand(cmd))
                    {
                    }
                    else
                    {
                        MessageBox.Show("Lỗi");
                    }
                    Refresh();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn dữ liệu cần xóa");
            }
            
            
        }

        private void btnDeleteStation_Click(object sender, EventArgs e)
        {
            if (dgvStation.CurrentRow != null)
            {
                string id = dgvStation.CurrentRow.Cells["IDStation"].Value.ToString();
                string stationName = dgvStation.CurrentRow.Cells["StationName"].Value.ToString();

                DialogResult dt = MessageBox.Show($"Xác nhận xóa trạm xăng: {stationName} này", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dt == DialogResult.Yes)
                {
                    string cmd = $"Delete from tblStation where ID = '{id}'";
                    if (StaticPool.mdb.ExecuteCommand(cmd))
                    {
                    }
                    else
                    {
                        MessageBox.Show("Lỗi");
                    }
                    Refresh();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn dữ liệu cần xóa");
            }
        }

        private void dgvStation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy giá trị của cột "ID" tại hàng được kích đúp
                string idValue = dgvStation.Rows[e.RowIndex].Cells["IDStation"].Value.ToString();

                if (idValue != null)
                {
                    ucStation uc = new ucStation(idValue, true);
                    frmModifyConfig frm = new frmModifyConfig(uc);
                    frm.ShowDialog();

                    Refresh();

                }
            }
        }
    }
}
