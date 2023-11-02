namespace iPGSTools.Models
{
    public class Event_Info
    {
        public Event_Info()
        {
        }
        public string CameraIP { get; set; }

        // Số thứ tự xếp hàng
        public int _number = 0;
        // Khối lượng
        public int _weight = 0;

        public DateTime _dateTime = DateTime.Now;

        public string _event_ID = "";
        public string _plate_Number1 = "";
        public string _plate_Number2 = "";
        public string _imgPath_Lpr1_Evening = "";
        public string _imgPath_Lpr2_Evening = "";
        public string _imgPath_LPR_Morning = "";
        public string _imgPath_Panorama2 = "";
        public string _customer_Name = "";
        public string _driver_Name = "";
        public string _commodity_Name = "";
        public string _description = "";
        public Bitmap image_plateCut;

        public float _confidence1 = 0f;
        public float _confidence2 = 0f;

        public Bitmap _image_Lpr1 = null;
        public Bitmap _image_Lpr2 = null;
        public Bitmap _image_Plate1 = null;
        public Bitmap _image_Plate2 = null;
        public Bitmap _image_Panorama1 = null;
        public Bitmap _image_Panorama2 = null;
        public Bitmap _image_plateCut = null;
    }

}
