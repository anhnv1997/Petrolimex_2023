namespace iPGSTools.Models
{
    public class Payment
    {
        public string agastransid { get; set; } = string.Empty;
        public string timestamp { get; set; } = string.Empty;
        public string pumpid { get; set; } = string.Empty;
        public string stationid { get; set; } = string.Empty;
        public long price { get; set; } = 0;
        public float volume { get; set; } = 0;
        public long amount { get; set; } = 0;
        public string etag { get; set; } = string.Empty;
        public string platenumber { get; set; } = string.Empty;
        public string plxid { get; set; } = string.Empty;
        public string subid { get; set; } = string.Empty;
        public string beaptransid { get; set; } = string.Empty;
        public string feaprequestid { get; set; } = string.Empty;
        public string hashId { get; set; } = string.Empty;

    }
    public class PaymentResponse
    {
        public string paystatus { get; set; } = string.Empty;
        public string feapresponseid { get; set; } = string.Empty;
        public string partnercode { get; set; } = string.Empty;
        public string beaptransid { get; set; } = string.Empty;
        public string paytype { get; set; } = string.Empty;
        public string bankcode { get; set; } = string.Empty;
        public string payhash { get; set; } = string.Empty;
        public string payMesage { get; set; } = string.Empty;
    }
}
