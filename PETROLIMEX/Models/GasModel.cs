namespace iPGSTools.Models
{
    public class GasModel
    {
        public enum EM_PumpStatus     // Trạng thái bơm
        {
            NhacCo = 1,
            BopCo = 3,
            GacCo = 4,
            HuyGiaoDich = 5,
        }

        private int PumpStatus;     // Trạng thái đổ xăng (nhấc vòi, bơm xăng, gác vòi, hủy giao dịch)

        private string TimeStamp;   // Thời gian bắt đầu gửi tin

        private string Agastransid; // ID giao dịch AGAS

        private string Pumpid;      // ID cò bơm

        private string Stationid;   // ID trạm xăng

        private long Price;         // Đơn giá

        private float Volume;       // khối lượng

        private long Amount;        // Thành tiền

        private string Reasonid;    // Lý do huỷ giao dịch 

        public string timestamp { get => TimeStamp; set => TimeStamp = value; }
        public string agastransid { get => Agastransid; set => Agastransid = value; }
        public string pumpid { get => Pumpid; set => Pumpid = value; }
        public string stationid { get => Stationid; set => Stationid = value; }
        public long price { get => Price; set => Price = value; }
        public float volume { get => Volume; set => Volume = value; }
        public long amount { get => Amount; set => Amount = value; }
        public string reasonid { get => Reasonid; set => Reasonid = value; }
        public int pumpstatus { get => PumpStatus; set => PumpStatus = value; }
    }
}
