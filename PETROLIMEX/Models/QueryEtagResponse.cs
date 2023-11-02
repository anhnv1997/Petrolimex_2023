namespace iPGSTools.Models
{
    public class QueryEtagResponse
    {
        public enum EmAutoPayment
        {
            CoThanhToanTuDong = 1,
            KhongThanhToanTuDong = 0,
        }

        public string etag { get; set; }
        public string platenumber { get; set; }
        public string subid { get; set; }
        public string plxid { get; set; }
        public EmAutoPayment autopayment { get; set; } = EmAutoPayment.KhongThanhToanTuDong;
        public string feapresponseid { get; set; }
    }
}
