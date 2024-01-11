using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolimexTools.tblData
{
    public class tblLocation
    {
        public string LocationID { get; set; } = "";
        public string LocationName { get; set; } = "";
        public string PCID { get; set; } = "";
        public string Camera1 { get; set; } = "";
        public string Camera2 { get; set; } = "";
        public string PumpID { get; set; } = "";
        public string ControllerEtagID { get; set; } = "";
        public string Description { get; set; } = "";
        public string IsActive { get; set; } = "";
    }
}
