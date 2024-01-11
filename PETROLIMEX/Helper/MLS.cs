namespace iPGSTools.Helper
{
    public static class MLS
    {
        public static class Plate
        {
            public static string ReadPlateFail = "Đọc biển số thất bại, xem lại ảnh chụp";
            public static string ComparePlateFail = "Biển số không khớp với biển số đăng ký etag trong danh sách";
        }
        public static class Agas
        {
            public static string InserttblAgasFail = "Thêm dữ liệu vào bảng tblAgas thất bại";
        }
        public static class Etag
        {
            public static string APIQueryEtagFail = "Call API QueryEtag thất bại";
            public static string InserttblQueryEtagFail = "Thêm dữ liệu vào bảng QueryEtag thất bại";
        }
        public static class NhacCo
        {
            public static string APICreateOrderFail = "Call API CreateOrder thất bại";
            public static string APICreateOrderNull = "Api CreateOrder null";
            public static string InserttblCreateOrderFail = "Thêm dữ liệu vào bảng tblCreateOrder thất bại";
            public static string InserttblMainEventFail = "Thêm dữ liệu vào bảng tblEventMain thất bại";
            public static string WrongPump = "Cảnh báo đang có sự kiện bơm của biển số này";
        }

        public static class BopCo
        {
            public static string BomXangSaiQuyTrinh = "Bơm xăng, Sai quy trình";
            public static string BomXangSaiVoi = "Bơm xăng sai vòi, sai quy trình";
            public static string UpdatettblMainEventFail_BopCo = "Update dữ liệu vào bảng tblEventMain thất bại, đang bơm";
        }

        public static class GacCo
        {
            public static string GacCoError = "Đóng vòi, sai quy trình";
            public static string GacCoSaiQuyTrinh = "Gác cò, Sai quy trình";

            public static string APIPaymentFail = "Call API Payment thất bại";
            public static string APILogPaymentFail = "Call API AutoPaymentLog thất bại";
            public static string FeapCreateInvoice = "Call API FeapCreateInvoice thất bại";
            public static string InserttblPaymentFail = "Thêm dữ liệu vào bảng tblPayment thất bại";
            public static string UpdatettblMainEventFail_GacCo = "Update dữ liệu vào bảng tblEventMain thất bại, Gác cò";
            public static string UpdatettblMainEventFail_LogPayment = "Update dữ liệu vào bảng tblEventMain thất bại, LogPayment";
        }
    }
}
