using PETROLIMEX.Models;
using static iPGSTools.Models.QueryEtagResponse;

namespace iPGSTools.Models
{
    public class Vehicle
    {
        public enum EmVehicleStatus
        {
            ChoVaoViTriDoXang = 0,
            NhacCo = 1,
            DangDoXang = 3,
            GacCo = 4,
            HuyGiaoDich = 5,
        }
        public enum EmPaymentStatus
        {
            DangThanhToan = 0,
            ThanhToanThatBai = 1,
            ThanhToanThanhCong = 2,
            HuyGiaoDich = 3,
        }
        public enum EmPaymentStatusSQL
        {
            XeKoDangKy = -1,
            ChuaThanhToan = 0,
            ThanhToanThatBai = 1,
            ThanhToanThanhCong = 2
        }
        public enum EmTypeLog
        {
            LogInfor,
            LogError,
            LogWarning
        }
        public bool isNhacCo { get; set; } = false;
        public bool isBopCo { get; set; } = false;
        public bool isGacCo { get; set; } = false;

        public DateTime TimeAgas { get; set; }
        public DateTime TimeQueryEtag { get; set; }
        public DateTime TimeCreateOrder { get; set; }
        public DateTime TimePumping { get; set; }
        public DateTime TimePayment { get; set; }
        public DateTime TimeLogPayment { get; set; }

        public string IDVehicle { get; set; } = string.Empty;
        public string IDAgas { get; set; } = string.Empty;
        public string IDMainEvent { get; set; } = string.Empty;
        public string IDQueryEtag { get; set; } = string.Empty;
        public string IDCreateOrder { get; set; } = string.Empty;
        public string IDPumping { get; set; } = string.Empty;
        public string IDPayment { get; set; } = string.Empty;
        public string IDLogPayment { get; set; } = string.Empty;
        public string IDCreateInvoice{ get; set; } = string.Empty;

        public string ImgPathPickup { get; set; } = string.Empty;
        public string ImgPathPumping { get; set; } = string.Empty;
        public string ImgPathPutdown { get; set; } = string.Empty;
        public string ImgPathCancel { get; set; } = string.Empty;


        public string etag { get; set; } = string.Empty;
        public string etagControllerID { get; set; } = string.Empty;
        public string platenumber { get; set; } = string.Empty;
        public string pumpid { get; set; } = string.Empty;
        public string subid { get; set; } = string.Empty;
        public string plxid { get; set; } = string.Empty;
        public EmAutoPayment autopayment { get; set; } = EmAutoPayment.KhongThanhToanTuDong;
        public string feapresponseid { get; set; } = "";
        public string beaptransid { get; set; } = "";

        public DateTime TimeIn { get; set; } = DateTime.Now;            // Biến tham chiếu Clear list danh sách chờ
        public EmVehicleStatus VehicleStatus { get; set; } = EmVehicleStatus.ChoVaoViTriDoXang;
        public long Price { get; set; }
        public float Volume { get; set; }
        public long Amount { get; set; }
        public string Describtion{ get; set; } = string.Empty;
        public AgasCreateInvoiceResponse createInvoiceResponse { get; set; } = new AgasCreateInvoiceResponse();
        public string GetDisplayStatus()
        {
            switch (this.VehicleStatus)
            {
                case EmVehicleStatus.ChoVaoViTriDoXang:
                    return "Đang Vào Vị Trí Đổ Xăng";
                case EmVehicleStatus.NhacCo:
                    return "Nhấc Cò Chờ Đổ Xăng";
                case EmVehicleStatus.DangDoXang:
                    return "Đang Đổ Xăng";
                case EmVehicleStatus.GacCo:
                    return "Hoàn tất đổ xăng";
                case EmVehicleStatus.HuyGiaoDich:
                    return "Hủy giao dịch";
                default:
                    return "";
            }
        }
        public string GetPaymentStatus(EmPaymentStatus yourVariable = EmPaymentStatus.DangThanhToan)
        {
            switch (this.VehicleStatus)
            {
                case EmVehicleStatus.ChoVaoViTriDoXang:
                    return "Chưa thanh toán";
                case EmVehicleStatus.NhacCo:
                    return "Chưa thanh toán";
                case EmVehicleStatus.DangDoXang:
                    return "Chưa thanh toán";
                case EmVehicleStatus.GacCo:
                    //return "Thanh toán thành công";
                    switch (yourVariable)
                    {
                        case EmPaymentStatus.DangThanhToan:
                            return "Đang thanh toán";
                        case EmPaymentStatus.ThanhToanThatBai:
                            return "Thanh toán thất bại";
                        case EmPaymentStatus.ThanhToanThanhCong:
                            return "Thanh toán thành công";
                        default:
                            return "";
                    }
                case EmVehicleStatus.HuyGiaoDich:
                    return "Hủy giao dịch";
                default:
                    return "";
            }
        }
    }
}
