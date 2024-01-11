
using Kztek.Cameras;

namespace PetrolimexTools.Model
{
    public class LocationConfig
    {
        public string locationID { get; set; } = "";
        public string LocationName { get; set; } = "";
        public string PCID { get; set; } = "";
        public Camera Camera { get; set; } = new Camera();
        public List<int> listPumpID { get; set; } = new List<int>();
        public string ControllerEtagID { get; set; } = "";
        public string Description { get; set; } = "";
        public string IsActive { get; set; } = "";
    }
}
