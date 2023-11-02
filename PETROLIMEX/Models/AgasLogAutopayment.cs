namespace iPGSTools.Models
{
    public class AgasLogAutopayment
    {
        public string agastransid { get; set; } = string.Empty;
        public string transidautopayment { get; set; } = string.Empty;
        public string timestamp { get; set; } = string.Empty;
        public string pumpid { get; set; } = string.Empty;
        public string stationid { get; set; } = string.Empty;
        public string price { get; set; } = string.Empty;
        public string volume { get; set; } = string.Empty;
        public string amount { get; set; } = string.Empty;
        public string etag { get; set; } = string.Empty;
        public string platenumber { get; set; } = string.Empty;
        public string plxid { get; set; } = string.Empty;
        public string subid { get; set; } = string.Empty;
        public string paymenttype { get; set; } = string.Empty;
        public string partnercode { get; set; } = string.Empty;
        public string bankcode { get; set; } = string.Empty;
        public string paymenthash { get; set; } = string.Empty;
    }
}
