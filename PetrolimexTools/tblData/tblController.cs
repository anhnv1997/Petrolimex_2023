using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolimexTools.tblData
{
    public class tblController
    {
        public string ID { get; set; } = "";
        public string Name { get; set; } = "";
        public string Code { get; set; } = "";
        public string Description { get; set; } = "";
        public string Comport { get; set; } = "";
        public int Baudrate { get; set; } = 0;
        public int CommunicationType { get; set; } = 0;
        public string PCID { get; set; } = "";
        public int Type { get; set; } = 0;
    }
}
