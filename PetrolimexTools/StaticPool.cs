using Kztek.Cameras;
using Kztek.LPR;
using PetrolimexTools.Helper;
using PetrolimexTools.Model;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace PetrolimexTools
{
    public static class StaticPool
    {
        public static string SQLConfigPath = $"{Application.StartupPath}\\SQLConfig.xml";
        public static string SystemConfigPath = $"{Application.StartupPath}\\ApplicationConfig.xml";

        public static Mdb? mdb;
        public static string SQLServerName = "";
        public static string SQLDatabaseName = "";
        public static string SQLUserName = "";
        public static string SQLPassword = "";
        public static string SQLAuthentication = "";

        // Thông tin vị trí đổ xăng Location (camera, pump, )
        public static List<LocationConfig> listLocationConfig = new List<LocationConfig>();
        public static int NumberLocation = 0;

        // Thông tin config 2 
        public static ApplicationConfig applicationConfig { get; set; } = new ApplicationConfig();  // Model application config

        // Thông tin Camera
        public static Camera camera { get; set; } = new Camera();                                   // Model Camera
        public static List<Camera> listCamera { get; set; } = new List<Camera>();                   // List model camera

        // Thông tin bộ điều khiển
        public static ControllerInfo controllerInfo { get; set; } = new ControllerInfo();           // Model bộ điều khiển

        public static CarANPR carANPR1 { get; set; } = null;                                        // Chưa rõ
        public static Futech.LPR.LPREngine lprapi { get; set; } = new Futech.LPR.LPREngine();       // Chưa rõ

        // Thông tin Station (Trạm xăng)
        public static string StationName { get; set; } = "";                                        // Tên trạm xăng 
        public static string StationID { get; set; } = "";                                          // ID trạm xăng

        // Đường dẫn ảnh
        public static string pathImage { get; set; } = "";
        //--Data
        public static VehicleCollection vehicleWithAutoPayments = new VehicleCollection();          // Dữ liệu lưu list danh sách chờ đang lưu chung của các luồng (nếu có nhiều BDK cần lưu riêng)

        #region Function
        public static string StandardlizePlateNumber(this string plateNumber)
        {
            string output = string.Empty;
            Regex regex = new Regex("[a-zA-Z0-9;]");
            for (int i = 0; i < plateNumber.Length; i++)
            {
                string plateNumberItem = plateNumber[i].ToString();
                if (regex.IsMatch(plateNumberItem))
                {
                    output += plateNumberItem;
                }
            }
            
            return output;
        }
        public static bool LoadSQL()
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
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("SQL load fail File");
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                LogHelperv2.Logger_CONTROLLER_Error($"Exception LoadSQL ex = {ex}", LogHelperv2.SaveLogFolder);
                return false;
            }

        }
        public async static Task<bool> DatabaseConnectCheck(string servername, string user, string pass, string auMode)
        {
            return await CheckSQLConnectionAsync(servername, user, pass, auMode);
        }
        private async static Task<bool> CheckSQLConnectionAsync(string serverName, string authUser, string authPassl, string authMode)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectStr(serverName, "master", authMode, authUser, authPassl)))
            {
                try
                {
                    Task openTask = connection.OpenAsync();

                    // Chờ cả hai sự kiện: mở kết nối thành công hoặc timeout
                    Task completedTask = await Task.WhenAny(openTask, Task.Delay(TimeSpan.FromSeconds(5)));

                    // Kiểm tra xem kết nối đã mở thành công chưa
                    if (completedTask == openTask)
                    {
                        // Kết nối đã thành công
                        connection.Close();
                        return true;
                    }
                    else
                    {
                        // Timeout, đóng kết nối và trả về false
                        connection.Close();
                        return false;
                    }
                }
                catch (SqlException ex)
                {
                    return false; // Kết nối không thành công
                }
            }
        }
        private static string GetConnectStr(string serverName, string databaseName, string authentication, string username, string password)
        {
            if (authentication == "Windows Authentication")
            {
                return $"data source={serverName};initial Catalog ={databaseName}; Integrated Security=True";

            }
            return $"data source={serverName};initial Catalog ={databaseName}; user id ={username};password={password}";
        }
        #endregion
    }
}
