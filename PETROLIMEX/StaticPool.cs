using IPGS.Object.Databases;
using Kztek.Cameras;
using Kztek.LPR;
using iPGSTools.Models;
using System.Text.RegularExpressions;
using PetrolimexConfig.Model;

namespace PETROLIMEX
{
    public static class StaticPool
    {
        public static string SQLConfigPath = "";
        public static string SystemConfigPath = "";
        
        public static Mdb? mdb;
        public static string SQLServerName = "";
        public static string SQLDatabaseName = "";
        public static string SQLUserName = "";
        public static string SQLPassword = "";
        public static string SQLAuthentication = "";

        public static ApplicationConfig applicationConfig;
        public static Camera camera;
        public static List<Camera> listCamera;

        public static CarANPR carANPR1 = null;
        public static Futech.LPR.LPREngine lprapi;

        //--Data
        public static VehicleCollection vehicleWithAutoPayments = new VehicleCollection();
        public static VehicleCollection vehicleWithNonAutoPayments = new VehicleCollection();


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
        #endregion
    }
}
