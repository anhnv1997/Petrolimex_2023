using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolimexConfig.Model
{
    public class ApplicationConfig
    {
        // BDK
        public string ControllerIP { get; set; } = "";
        public int ControllerPort { get; set; } = 0;
        
        // Camera
        public string CameraIP { get; set; } = "";
        public int CameraPort { get; set; } = 0;
        public string CameraUsername { get; set; } = "";
        public string CameraPassword { get; set; } = "";
        public string DetectType { get; set; } = "";
        
        // API
        public int ApiPort { get; set; } = 0;
        public string LPR_API { get; set; } = "";
        public string FIS_URL { get; set; } = "";
        public string AGAS_URl { get; set; } = "";
        public string Host_CreateInvoice { get; set; } = "";
        public int Port_CreateInvoice { get; set; } = 0;

        // Location
        public string StationID { get; set; } = "";
        public string StationName { get; set; } = "";
        public int CountDetect { get; set; } = 3;
        public int TimeDelayDetect { get; set; } = 100;



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
