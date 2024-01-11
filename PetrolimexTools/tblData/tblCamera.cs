using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolimexTools.tblData
{
    public class tblCamera
    {
        public string CameraID { get; set; } = "";
        public string CameraName { get; set; } = "";
        public string HttpURL { get; set; } = "";
        public string HttpPort { get; set; } = "";
        public string RtspPort { get; set; } = "";
        public string UserName { get; set; } = "";
        public string Password { get; set; } = "";
        public string PCID { get; set; } = "";
        public int FrameRate { get; set; } = 0;
        public string Resolution { get; set; } = "";
        public int Channel { get; set; } = 0;
        public string CameraType { get; set; } = "";
        public string StreamType { get; set; } = "";
        public string SDK { get; set; } = "";
        public string Cgi { get; set; } = "";
        public bool EnableRecording { get; set; } = false;
        public int PositionIndex { get; set; } = 0;
        public string ResizeImage { get; set; } = "";
        public string Description { get; set; } = "";

    }
}
