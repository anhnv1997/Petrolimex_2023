using IPGS.Object.Databases;
using PETROLIMEX.Helper;
using PetrolimexConfig.Model;

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

        private void frmLoading_Load(object sender, EventArgs e)
        {
            try
            {
                lblMessage.Text = "Đang tải cấu hình...";
                LoadSQL();
                lblMessage.Text = "Load SQL hoàn tất";

                LoadSystemConfig();
                lblMessage.Text = "Load SystemConfig hoàn tất";


                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception frmLoading_Load ex = {ex}", LogHelperv2.SaveLogFolder);
            }
            

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
