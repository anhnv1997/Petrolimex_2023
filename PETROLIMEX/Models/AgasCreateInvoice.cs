namespace PETROLIMEX.Models
{
    public class AgasCreateInvoice
    {
        public string apiname { get; set; } = string.Empty;
        public ulong agasTransId { get; set; } = 0;
        public float quantity { get; set; } = 0;
        public long price { get; set; } = 0;
        public long amount { get; set; } = 0;
        public string plateNumber { get; set; } = string.Empty;
        public string partnerCode { get; set; } = string.Empty;
        public string BankCode { get; set; } = string.Empty;
    }

    public class AgasCreateInvoiceResponse
    {
        public string apiname { get; set; } = string.Empty;
        public ulong agasTransId { get; set; } = 0;
        public string responsedate { get; set; } = string.Empty;
        public string statuscode { get; set; } = string.Empty;
        public string linkref { get; set; } = string.Empty;
        public string refcode { get; set; } = string.Empty;
        public string reason { get; set; } = string.Empty;
        public string checksum { get; set; } = string.Empty;
    }
}
