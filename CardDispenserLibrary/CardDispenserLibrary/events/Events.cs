using System;
using System.Collections.Generic;
using System.Text;
using static KztekObject.Enums.EventStatuses;
using static KztekObject.Enums.EventTypes;

namespace KztekObject.Objects
{
    public class ControllerEvent
    {
        public delegate void ErrorEventHandler(object sender, ErrorEventArgs e);
        public class ErrorEventArgs : EventArgs
        {
            public string ErrorString { get; set; } = string.Empty;
            public string ErrorFunc { get; set; } = string.Empty;
            public string ErrorLine { get; set; } = string.Empty;
            public string CMD { get; set; } = string.Empty;
        }

        public delegate void InputEventHandler(object sender, InputEventArgs e);
        public class InputEventArgs : EventArgs
        {
            public string InputIndex { get; set; }
            public DateTime Time { get; set; }
            public string InputName { get; set; }
            public string Status { get; set; }
        }

        public delegate void CardEventHandler(object sender, CardEventArgs e);
        public class CardEventArgs : EventArgs
        {
            public string CardNumberHEX { get; set; } = string.Empty;
            public string CardNumberDEC { get; set; } = string.Empty;
            public string ControllerID { get; set; } = string.Empty;
            public int ReaderIndex { get; set; }
            public string Date { get; set; } = string.Empty;
            public string Time { get; set; } = string.Empty;
            public EM_EventStatus EventStatus { get; set; }
            public string UserID { get; set; } = string.Empty;
            public EM_EventType EventType { get; set; }
            public string Doors { get; set; }
        }

        public delegate void ConnectStatusChangeEventHandler(object sender, ConnectStatusCHangeEventArgs e);
        public class ConnectStatusCHangeEventArgs : EventArgs
        {
            public bool CurrentStatus { get; set; }
            public string ControllerID { get; set; }
            public string Comport { get; set; }
            public string reason { get; set; }
        }


    }
}
