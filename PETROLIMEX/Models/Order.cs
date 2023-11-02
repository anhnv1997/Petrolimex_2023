using static iPGSTools.Models.GasModel;

namespace iPGSTools.Models
{
    public class Order
    {
        public EM_PumpStatus pumpstatus { get; set; }
        public string timestamp { get; set; }
        public string agastransid { get; set; }
        public string pumpid { get; set; }
        public string stationid { get; set; }
        public long price { get; set; }
        public float volume { get; set; }
        public long amount { get; set; }
        public string etag { get; set; }
        public string platenumber { get; set; }
        public string subid { get; set; }
        public string plxid { get; set; }
        public string feaprequestid { get; set; }
    }
    public class OrderResponse
    {
        public string feapresponseid { get; set; }
        public string beaptransid { get; set; }
    }
    
}
