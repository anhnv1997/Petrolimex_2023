using System.Collections.Generic;
using static KztekObject.Enums.CommunicationTypes;
using static KztekObject.Enums.ControllerFunctions;
using static KztekObject.Enums.ControllerTypes;
using static KztekObject.Enums.DisplayModes;

namespace KztekObject.Objects
{
    /// <summary>
    /// Chứa Thông Tin BĐK <br/>
    /// <term><see langword="Thông Tin Chung:"/> </term>
    /// <description> ID, Name Code, Description, IpAddress, Port, Comport, Baudrate, ControllerType, COntrollerFunction</description>  <br/>
    /// <term><see langword="Cấu Tạo BĐK:"/>  </term> 
    /// <description> Đầu Đọc <see cref="ReaderDefines"/>; Relay <see cref="RelayCounts"/></description>  <br/>
    /// <term><see langword="Giao Tiếp:"/></term> 
    /// <description> Chuẩn Truyền Thông Để Giao Tiếp Với Thiết Bị <seealso cref="EM_CommunicationType"/>, nếu RS485 thì vị trí của thiết bị là bao nhiêu</description>  <br/>
    /// <term><see langword=" Tài Khoản Đăng Nhập Vào Thiết Bị:"/></term> 
    /// <description> Tên Đăng Nhập <see cref="Username"/>, Mật Khẩu<see cref="Password"/> </description>  <br/>
    /// </summary>
    public class Controller
    {
        public string ID { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public string IpAddress { get; set; } = "127.0.0.1";
        public int Port { get; set; } = 100;

        public string Comport { get; set; } = string.Empty;
        public int Baudrate { get; set; } = 9600;
        public bool IsConnect { get; set; }

        public EM_ControllerType ControllerType { get; set; }
        public EM_ControllerFunctions ControllerFunction { get; set; }

        public int RelayCounts { get; set; } = 0;

        public EM_CommunicationType CommunicationType;

        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int MachineID { get; set; } = 0;

        public EM_DisplayMode DisplayMode { get; set; }
    }
}
