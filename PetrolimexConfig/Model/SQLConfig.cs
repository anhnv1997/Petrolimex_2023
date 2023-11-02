using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolimexConfig.Model
{
    public class SQLConfig
    {
        public string SQLServername { get; set; } = "";
        public string SQLDatabaseName { get; set; } = "";
        public string SQLAuthMode { get; set; } = "";
        public string SQLUsername { get; set; } = "";
        public string SQLPassword { get; set; } = "";

        public SQLConfig()
        {

        }
        public SQLConfig(string sqlServername, string sqlDatabaseName, string sqlAuthMode, string sqlUsername, string sqlPassword)
        {
            SQLServername = sqlServername;
            SQLDatabaseName = sqlDatabaseName;
            SQLAuthMode = sqlAuthMode;
            SQLUsername = sqlUsername;
            SQLPassword = sqlPassword;
        }
    }
}
