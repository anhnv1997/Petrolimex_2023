using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolimexTools.Model
{
    public class ApplicationConfig
    {
        // Camera
        //public string CameraIP { get; set; } = "";
        //public int CameraPort { get; set; } = 0;
        //public string CameraUsername { get; set; } = "";
        //public string CameraPassword { get; set; } = "";
        //public string DetectType { get; set; } = "";

        // API
        public int ApiPort { get; set; } = 0;
        public string LPR_API { get; set; } = "";           // Loại api nhận dạng
        public string FIS_URL { get; set; } = "";
        public string AGAS_URl { get; set; } = "";
        public string Host_CreateInvoice { get; set; } = "";
        public int Port_CreateInvoice { get; set; } = 0;

        // Location
        public int CountDetect { get; set; } = 3;
        public int TimeDelayDetect { get; set; } = 100;

        public int TimeClearList { get; set; } = 0;

        public int TimeRepeatRefuel { get; set; } = 0;

        public ApplicationConfig()
        {

        }
        //public SystemInfoConfig(string _controllerIP, string _controllerPort, string sqlAuthMode, string sqlUsername, string sqlPassword)
        //{
        //    SQLServername = sqlServername;
        //    SQLDatabaseName = sqlDatabaseName;
        //    SQLAuthMode = sqlAuthMode;
        //    SQLUsername = sqlUsername;
        //    SQLPassword = sqlPassword;
        //}
    }
}
