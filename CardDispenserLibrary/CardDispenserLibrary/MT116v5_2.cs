using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Net.Sockets;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using KztekObject.Objects;
using KztekObject.Enums;
using static KztekObject.Objects.ControllerEvent;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Linq;
using static CardDispenserLibrary.MT116Controller;
using iPGS.Tools;
using GeneralTool.SocketHelpers;
using GeneralTool.NetworkTools;

namespace CardDispenserLibrary
{
    public class MT116v5_2 : ICardDispenser
    {
        public event OnEvent onEvent;

        private int test = -1;
        public int Test { get => test; set => test = value; }


        public CancellationTokenSource cts { get; set; }
        public ManualResetEvent ForceLoopIteration { get; set; }
        public bool IsSupportCard { get; } = true;
        public bool IsSupportFace { get; } = false;
        public bool IsSupportFinger { get; } = false;

        public bool IsSupportPassword { get { return false; } }
        public bool IsSupportTimezone { get { return false; } }
        #region: PROPERTIES
        public virtual Controller ControllerInfor { get; set; } = new Controller();
        public bool IsAutoRestart { get; set; } = false;
        public DateTime AutoRestartTime { get; set; } = DateTime.MinValue;
        public bool isAutoEnableGetEventTime { get; set; } = false;
        public DateTime AutoStopGetEventTime { get; set; } = DateTime.MinValue;
        public DateTime AutoStartGetEventTime { get; set; } = DateTime.MinValue;
        public bool IsStopGetEvent { get; set; } = false;
        public bool IsBusy { get; set; }
        #endregion: END PROPERTIES

        #region:EVENT
        public event CardEventHandler CardEvent;
        public event ErrorEventHandler ErrorEvent;
        public event InputEventHandler InputEvent;
        public event ConnectStatusChangeEventHandler ConnectStatusChangeEvent;
        #endregion: END EVENT

        #region: CONNECT
        public bool TestConnection()
        {
            if (CommunicationTypes.IS_TCP(this.ControllerInfor.CommunicationType))
            {
                if (NetWorkTools.IsPingSuccess(this.ControllerInfor.Comport, 500))
                {
                    this.ControllerInfor.IsConnect = true;
                    return this.ControllerInfor.IsConnect;
                }

            }
            return false;
        }
        public bool Connect()
        {
            return TestConnection();
        }
        public bool Disconnect()
        {
            cts?.Cancel();
            return true;
        }
        #endregion: END CONNECT

        #region: THREAD
        #region:Delete
        public bool DeleteEvent()
        {
            string comport = this.ControllerInfor.Comport;
            int baudrate = this.ControllerInfor.Baudrate;
            string setNetworkInfor = CMD.DeleteEventCMD;
            this.IsBusy = true;
            string response = UdpTools.ExecuteCommand(comport, baudrate, setNetworkInfor, 500, Encoding.ASCII);
            this.IsBusy = false;
            //Char(2) + ChangeIP?/OK + char(3)	
            //Char(2) + ChangeIP?/ERR + char(3)
            if (UdpTools.IsSuccess(response, "OK"))
            {
                return true;
            }
            else if (UdpTools.IsSuccess(response, "ERR"))
            {
                return false;
            }
            if (ErrorEvent != null)
            {
                ErrorEvent(this, new ErrorEventArgs()
                {
                    ErrorString = response,
                    ErrorFunc = GetFunctionName(),
                    CMD = setNetworkInfor
                });
            }
            return false;
        }
        #endregion
        #endregion: END THREAD

        #region: RELAY
        public bool RelayOn(int relayIndex)
        {
            string comport = this.ControllerInfor.Comport;
            int baudrate = this.ControllerInfor.Baudrate;
            string setNetworkInfor = CMD.OpenRelayCMD(relayIndex);
            this.IsBusy = true;
            string response = UdpTools.ExecuteCommand(comport, baudrate, setNetworkInfor, 500, Encoding.ASCII);
            this.IsBusy = false;
            //Char(2) + ChangeIP?/OK + char(3)	
            //Char(2) + ChangeIP?/ERR + char(3)
            if (UdpTools.IsSuccess(response, "OK"))
            {
                return true;
            }
            else if (UdpTools.IsSuccess(response, "ERR"))
            {
                return false;
            }
            if (ErrorEvent != null)
            {
                ErrorEvent(this, new ErrorEventArgs()
                {
                    ErrorString = response,
                    ErrorFunc = GetFunctionName(),
                    CMD = setNetworkInfor
                });
            }
            return false;
        }
        public bool SetRelayDelayTime(int relayIndex, int timeInMiliscond)
        {

            throw new Exception("Không được hỗ trợ");
        }
        #endregion: END RELAY

        #region:Mode key
        public int GetModeKey()
        {
            string comport = this.ControllerInfor.Comport;
            int baudrate = this.ControllerInfor.Baudrate;
            string autoDetectCMD = CMD.GetModeKeyCMD;
            this.IsBusy = true;
            string response = UdpTools.ExecuteCommand(comport, baudrate, autoDetectCMD, 500, Encoding.ASCII);
            this.IsBusy = false;
            //Char(2)  + version  + “/”  + IPAdress + “/”  Port + “/” + subNetMask + “/”  + DefaultGateway + “/”+ MacAddress + char(3)
            if (response != null && response.Length > 0)
            {
                string[] data = response.Split('/');
                Dictionary<string, string> map = iPGS.Tools.EventHelpers.GetEventContent(data);
                string modeKey = map.ContainsKey("modekey") ? map["modekey"] : "";

                int ReaderIndex = Regex.IsMatch(modeKey, @"^\d+$") ? Convert.ToInt32(modeKey) : -1;
                return ReaderIndex;
            }
            if (ErrorEvent != null)
            {
                ErrorEvent(this, new ErrorEventArgs()
                {
                    ErrorString = response,
                    ErrorFunc = GetFunctionName(),
                    CMD = autoDetectCMD
                });
            }
            return -1;
        }
        public bool SetModeKey(bool isUseKey)
        {
            string comport = this.ControllerInfor.Comport;
            int baudrate = this.ControllerInfor.Baudrate;
            string setNetworkInfor = CMD.SetModeKeyCMD(isUseKey);
            this.IsBusy = true;
            string response = UdpTools.ExecuteCommand(comport, baudrate, setNetworkInfor, 500, Encoding.ASCII);
            this.IsBusy = false;
            //Char(2) + ChangeIP?/OK + char(3)	
            //Char(2) + ChangeIP?/ERR + char(3)
            if (UdpTools.IsSuccess(response, "OK"))
            {
                return true;
            }
            else if (UdpTools.IsSuccess(response, "ERR"))
            {
                return false;
            }
            if (ErrorEvent != null)
            {
                ErrorEvent(this, new ErrorEventArgs()
                {
                    ErrorString = response,
                    ErrorFunc = GetFunctionName(),
                    CMD = setNetworkInfor
                });
            }
            return false;
        }
        #endregion: End Mode key

        #region: ModeAutoCollectCard
        public int GetModeAutoCollectCard()
        {
            throw new Exception("Không được hỗ trợ");
        }
        public int GetTimeOutAutoCollectCard()
        {
            throw new Exception("Không được hỗ trợ");
        }

        public bool SetTimeOutAutoCollectCard(int timeInSecond)
        {
            throw new Exception("Không được hỗ trợ");
        }

        #endregion: End ModeAutoCollectCard

        public bool SetKeyA(string keyA)
        {
            string comport = this.ControllerInfor.Comport;
            int baudrate = this.ControllerInfor.Baudrate;
            string setNetworkInfor = CMD.SetKeyACMD(keyA);
            this.IsBusy = true;
            string response = UdpTools.ExecuteCommand(comport, baudrate, setNetworkInfor, 500, Encoding.ASCII);
            this.IsBusy = false;
            //Char(2) + ChangeIP?/OK + char(3)	
            //Char(2) + ChangeIP?/ERR + char(3)
            if (UdpTools.IsSuccess(response, "OK"))
            {
                return true;
            }
            else if (UdpTools.IsSuccess(response, "ERR"))
            {
                return false;
            }
            if (ErrorEvent != null)
            {
                ErrorEvent(this, new ErrorEventArgs()
                {
                    ErrorString = response,
                    ErrorFunc = GetFunctionName(),
                    CMD = setNetworkInfor
                });
            }
            return false;
        }

        public int GetModeButton()
        {
            throw new Exception("Không được hỗ trợ");
        }

        public int GetModeLoop()
        {
            string comport = this.ControllerInfor.Comport;
            int baudrate = this.ControllerInfor.Baudrate;
            string autoDetectCMD = CMD.GetModeLoopCMD;
            this.IsBusy = true;
            string response = UdpTools.ExecuteCommand(comport, baudrate, autoDetectCMD, 500, Encoding.ASCII);
            this.IsBusy = false;
            //Char(2)  + version  + “/”  + IPAdress + “/”  Port + “/” + subNetMask + “/”  + DefaultGateway + “/”+ MacAddress + char(3)
            if (response != null && response.Length > 0)
            {
                string[] data = response.Split('/');
                Dictionary<string, string> map = iPGS.Tools.EventHelpers.GetEventContent(data);
                string modeLoop_str = map.ContainsKey("ModeLoop".ToLower()) ? map["ModeLoop".ToLower()] : "";

                int modeLoop = Regex.IsMatch(modeLoop_str, @"^\d+$") ? Convert.ToInt32(modeLoop_str) : -1;
                return modeLoop;
            }
            if (ErrorEvent != null)
            {
                ErrorEvent(this, new ErrorEventArgs()
                {
                    ErrorString = response,
                    ErrorFunc = GetFunctionName(),
                    CMD = autoDetectCMD
                });
            }
            return -1;
        }
        public bool SetModeLoop(int mode)
        {
            string comport = this.ControllerInfor.Comport;
            int baudrate = this.ControllerInfor.Baudrate;
            string setNetworkInfor = CMD.SetModeLoop(mode);
            this.IsBusy = true;
            string response = UdpTools.ExecuteCommand(comport, baudrate, setNetworkInfor, 500, Encoding.ASCII);
            this.IsBusy = false;
            //Char(2) + ChangeIP?/OK + char(3)	
            //Char(2) + ChangeIP?/ERR + char(3)
            if (UdpTools.IsSuccess(response, "OK"))
            {
                return true;
            }
            else if (UdpTools.IsSuccess(response, "ERR"))
            {
                return false;
            }
            if (ErrorEvent != null)
            {
                ErrorEvent(this, new ErrorEventArgs()
                {
                    ErrorString = response,
                    ErrorFunc = GetFunctionName(),
                    CMD = setNetworkInfor
                });
            }
            return false;
        }
        public bool SetPauseDispenseCard()
        {
            string comport = this.ControllerInfor.Comport;
            int baudrate = this.ControllerInfor.Baudrate;
            string setNetworkInfor = CMD.SetPauseDispenseCardCMD;
            this.IsBusy = true;
            string response = UdpTools.ExecuteCommand(comport, baudrate, setNetworkInfor, 500, Encoding.ASCII);
            this.IsBusy = false;
            //Char(2) + ChangeIP?/OK + char(3)	
            //Char(2) + ChangeIP?/ERR + char(3)
            if (UdpTools.IsSuccess(response, "OK"))
            {
                return true;
            }
            else if (UdpTools.IsSuccess(response, "ERR"))
            {
                return false;
            }
            if (ErrorEvent != null)
            {
                ErrorEvent(this, new ErrorEventArgs()
                {
                    ErrorString = response,
                    ErrorFunc = GetFunctionName(),
                    CMD = setNetworkInfor
                });
            }
            return false;
        }

        public async Task<bool> ResetDefault()
        {
            var serverIP = IPAddress.Parse(this.ControllerInfor.Comport);
            var serverPort = this.ControllerInfor.Baudrate;
            var serverEndpoint = new IPEndPoint(serverIP, serverPort);
            var size = 500;
            var receiveBuffer = new byte[size];
            string text = CMD.ResetDefaultCMD;
            var socket = new Socket(SocketType.Dgram, ProtocolType.Udp);

            var sendBuffer = Encoding.UTF8.GetBytes(text);

            socket.SendTo(sendBuffer, serverEndpoint);

            EndPoint dummyEndpoint = new IPEndPoint(IPAddress.Any, 0);
            string response = "";
            while (!response.Contains("ResetDefault?/OK/"))
            {
                var length = socket.ReceiveFrom(receiveBuffer, ref dummyEndpoint);
                response = Encoding.UTF8.GetString(receiveBuffer);
                Array.Clear(receiveBuffer, 0, size);
                await Task.Delay(1000);
            }
            socket.Close();
            return true;
        }


        #region:TCP_IP
        //GET
        public bool GetIP(ref string IP)
        {
            string comport = this.ControllerInfor.Comport;
            int baudrate = this.ControllerInfor.Baudrate;
            string autoDetectCMD = CMD.AutoDetectCMD;
            this.IsBusy = true;
            string response = UdpTools.ExecuteCommand(comport, baudrate, autoDetectCMD, 500, Encoding.ASCII);
            this.IsBusy = false;
            //Char(2)  + version  + “/”  + IPAdress + “/”  Port + “/” + subNetMask + “/”  + DefaultGateway + “/”+ MacAddress + char(3)
            if (response != null && response.Length > 0)
            {
                string[] _responses = response.Split('/');
                if (_responses.Length > 1)
                {
                    IP = _responses[1];
                    return true;
                }
            }
            if (ErrorEvent != null)
            {
                ErrorEvent(this, new ErrorEventArgs()
                {
                    ErrorString = response,
                    ErrorFunc = GetFunctionName(),
                    CMD = autoDetectCMD
                });
            }
            return false;
        }
        public bool GetMac(ref string macAddr)
        {
            string comport = this.ControllerInfor.Comport;
            int baudrate = this.ControllerInfor.Baudrate;
            string autoDetectCMD = CMD.AutoDetectCMD;
            this.IsBusy = true;
            string response = UdpTools.ExecuteCommand(comport, baudrate, autoDetectCMD, 500, Encoding.ASCII);
            this.IsBusy = false;
            //Char(2)  + version  + “/”  + IPAdress + “/”  Port + “/” + subNetMask + “/”  + DefaultGateway + “/”+ MacAddress + char(3)
            if (response != null && response.Length > 0)
            {
                string[] _responses = response.Split('/');
                if (_responses.Length > 5)
                {
                    macAddr = _responses[5];
                    macAddr = macAddr.Substring(0, macAddr.Length - 1);
                    return true;
                }
            }
            if (ErrorEvent != null)
            {
                ErrorEvent(this, new ErrorEventArgs()
                {
                    ErrorString = response,
                    ErrorFunc = GetFunctionName(),
                    CMD = autoDetectCMD
                });
            }
            return false;
        }
        public bool GetDefaultGateway(ref string defaultGateway)
        {
            string comport = this.ControllerInfor.Comport;
            int baudrate = this.ControllerInfor.Baudrate;
            string autoDetectCMD = CMD.AutoDetectCMD;
            this.IsBusy = true;
            string response = UdpTools.ExecuteCommand(comport, baudrate, autoDetectCMD, 500, Encoding.ASCII);
            this.IsBusy = false;
            //Char(2)  + version  + “/”  + IPAdress + “/”  Port + “/” + subNetMask + “/”  + DefaultGateway + “/”+ MacAddress + char(3)
            if (response != null && response.Length > 0)
            {
                string[] _responses = response.Split('/');
                if (_responses.Length > 4)
                {
                    defaultGateway = _responses[4];
                    return true;
                }
            }
            if (ErrorEvent != null)
            {
                ErrorEvent(this, new ErrorEventArgs()
                {
                    ErrorString = response,
                    ErrorFunc = GetFunctionName(),
                    CMD = autoDetectCMD
                });
            }
            return false;
        }
        public bool GetPort(ref int port)
        {
            string comport = this.ControllerInfor.Comport;
            int baudrate = this.ControllerInfor.Baudrate;
            string autoDetectCMD = CMD.AutoDetectCMD;
            this.IsBusy = true;
            string response = UdpTools.ExecuteCommand(comport, baudrate, autoDetectCMD, 500, Encoding.ASCII);
            this.IsBusy = false;
            //Char(2)  + version  + “/”  + IPAdress + “/”  Port + “/” + subNetMask + “/”  + DefaultGateway + “/”+ MacAddress + char(3)
            if (response != null && response.Length > 0)
            {
                string[] _responses = response.Split('/');
                if (_responses.Length > 5)
                {
                    port = Convert.ToInt32(_responses[2]);
                    return true;
                }
            }
            if (ErrorEvent != null)
            {
                ErrorEvent(this, new ErrorEventArgs()
                {
                    ErrorString = response,
                    ErrorFunc = GetFunctionName(),
                    CMD = autoDetectCMD
                });
            }
            return false;
        }
        public bool SetNetWorkInfor(string ip, string subnetMask, string defaultGateway, string macAddr)
        {
            string comport = this.ControllerInfor.Comport;
            int baudrate = this.ControllerInfor.Baudrate;
            string setNetworkInfor = CMD.ChangeIPCMD(ip, subnetMask, defaultGateway, macAddr);
            this.IsBusy = true;
            string response = UdpTools.ExecuteCommand(comport, baudrate, setNetworkInfor, 500, Encoding.ASCII);
            this.IsBusy = false;
            //Char(2) + ChangeIP?/OK + char(3)	
            //Char(2) + ChangeIP?/ERR + char(3)
            if (UdpTools.IsSuccess(response, "OK"))
            {
                return true;
            }
            else if (UdpTools.IsSuccess(response, "ERR"))
            {
                return false;
            }
            if (ErrorEvent != null)
            {
                ErrorEvent(this, new ErrorEventArgs()
                {
                    ErrorString = response,
                    ErrorFunc = GetFunctionName(),
                    CMD = setNetworkInfor
                });
            }
            return false;
        }
        #endregion: END TCP_IP

        private string GetFunctionName()
        {
            StackTrace stackTrace = new StackTrace();
            StackFrame stackFrame = stackTrace.GetFrame(1);
            MethodBase methodBase = stackFrame.GetMethod();
            return methodBase.Name;
        }



        public void PollingStart()
        {
            if (this.IsStopGetEvent == true)
            {
                this.IsStopGetEvent = false;
            }
            else
            {
                Task.Run(new Action(() =>
                {
                    LogHelper.Logger_CONTROLLER_Infor("START POLLING", LogHelper.SaveLogFolder);
                    PollingGetEventFunc();
                }));
            }
        }

        public void PollingStop()
        {
            this.IsStopGetEvent = true;
        }

        Dictionary<string, string> converts = new Dictionary<string, string>()
        {
            {"0","0000"},
            {"1","0001"},
            {"2","0010"},
            {"3","0011"},
            {"4","0100"},
            {"5","0101"},
            {"6","0110"},
            {"7","0111"},
            {"8","1000"},
            {"9","1001"},
            {"A","1010"},
            {"B","1011"},
            {"C","1100"},
            {"D","1101"},
            {"E","1110"},
            {"F","1111"},

        };

        static Dictionary<string, string> convertReverts = new Dictionary<string, string>()
        {
            {"0000","0"},
            {"0001","1"},
            {"0010","2"},
            {"0011","3"},
            {"0100","4"},
            {"0101","5"},
            {"0110","6"},
            {"0111","7"},
            {"1000","8"},
            {"1001","9"},
            {"1010","A"},
            {"1011","B"},
            {"1100","C"},
            {"1101","D"},
            {"1110" , "E"},
            {"1111" , "F"},

        };

        private void PollingGetEventFunc()
        {
            while (true)
            {
                if (!IsStopGetEvent)
                {
                    try
                    {
                        //MT116EventArgs e1 = new MT116EventArgs();
                        //e1.LenCard = 12;
                        //e1.CardNumber = "test";
                        //onEvent?.Invoke(this, e1);
                        //Thread.Sleep(2000);

                        string viewraw = "";
                        string[] message = null;
                        if (CommunicationTypes.IS_TCP(this.ControllerInfor.CommunicationType))
                        {
                            // Thuc hien lenh den thiet bi (pc <-> host)
                            string cmd = CMD.GetEventCMD;
                            if (!NetWorkTools.IsPingSuccess(this.ControllerInfor.Comport, 500))
                            {
                                if (this.ControllerInfor.IsConnect != false)
                                {
                                    ConnectStatusCHangeEventArgs e = new ConnectStatusCHangeEventArgs();
                                    e.CurrentStatus = false;
                                    e.ControllerID = this.ControllerInfor.ID;
                                    this.ControllerInfor.IsConnect = false;
                                    e.Comport = this.ControllerInfor.Comport;
                                    e.reason = "PING ERROR";
                                    this.OnConnectStatusChangeEvent(e);
                                }

                            }
                            else
                            {
                                string response = UdpTools.ExecuteCommand(this.ControllerInfor.Comport, this.ControllerInfor.Baudrate, cmd, 500, Encoding.ASCII);
                                //LogHelper.Logger_CONTROLLER_Infor(response, LogHelper.SaveLogFolder);
                                // Trang thai thiet bi
                                if (this.ControllerInfor.IsConnect != (response != "" && !response.ToLower().Contains("exception")))
                                {
                                    this.ControllerInfor.IsConnect = response != "";
                                    ConnectStatusCHangeEventArgs e = new ConnectStatusCHangeEventArgs();
                                    e.CurrentStatus = response != "" && !response.ToLower().Contains("exception");
                                    e.ControllerID = this.ControllerInfor.ID;
                                    e.Comport = this.ControllerInfor.Comport;
                                    if (response.ToLower().Contains("exception"))
                                    {
                                        e.reason = "EXCEPTION";
                                    }
                                    else
                                        e.reason = response == "" ? "RESPONSE EMPTY: " + response : "Get EVent Success: " + response;
                                    this.OnConnectStatusChangeEvent(e);
                                }
                                // Có sự kiện nút nhấn nhả thẻ ( BTN1, BTN2)
                                // -- GetEvent?/LenCard=4/Card=7C19F640/Input=1/ArrayInput=X/Com=Com1/StateCardDispenserCom1 = Y/StateCardDispenserCom2 = Z /

                                //Có sự kiện quẹt thẻ trên đầu đọc Reader1 và Reader2 ( Reader1, Reader2):
                                //--GetEvent?/LenCard=4/Card=7C19F640/Input=3/ArrayInput=X/Com=NotCom/StateCardDispenserCom1=Y/StateCardDispenserCom2=Z/

                                //Có sự kiện đầu vào Exit, Input, Loop, hoặc sự kiện thẻ được rút ra khỏi miệng nhả thẻ
                                //--GetEvent?/LenCard=0/Card=0/Input=5/ArrayInput=X/Com=NotCom/StateCardDispenserCom1=Y/StateCardDispenserCom2=Z/

                                //GetEvent?/NotEvent /StateCardDispenserCom1=X/StateCardDispenserCom2=Y/
                                response = "GetEvent?/";
                                if (response != "" && (response.Contains("GetEvent?/")) && !response.Contains("NotEvent"))
                                {
                                    string[] data = response.Split('/');
                                    Dictionary<string, string> map = iPGS.Tools.EventHelpers.GetEventContent(data);

                                    string lenCard_str = map.ContainsKey("LenCard".ToLower()) ? map["LenCard".ToLower()] : "";
                                    string cardNumber_str = map.ContainsKey("Card".ToLower()) ? map["Card".ToLower()] : "";


                                    string inputIndex_str = map.ContainsKey("Input".ToLower()) ? map["Input".ToLower()] : "";
                                    string arrayInput_str = map.ContainsKey("ArrayInput".ToLower()) ? map["ArrayInput".ToLower()] : "";
                                    string com_str = map.ContainsKey("Com".ToLower()) ? map["Com".ToLower()] : "";
                                    string stateCardDispenserCom1_str = map.ContainsKey("StateCardDispenserCom1".ToLower()) ? map["StateCardDispenserCom1".ToLower()] : "";
                                    string stateCardDispenserCom2_str = map.ContainsKey("StateCardDispenserCom2".ToLower()) ? map["StateCardDispenserCom2".ToLower()] : "";

                                    int lenCard = Regex.IsMatch(lenCard_str, @"^\d+$") ? Convert.ToInt32(lenCard_str) : -1;
                                    string cardNumber = cardNumber_str;
                                    LogHelper.Logger_API_Infor($"Log BDK v2 ======= >  Bắt đầu cardnumber  : {cardNumber}", LogHelper.SaveLogFolder);

                                    //cardNumber = "3416214B880E700001941070";
                                    //341621 4B 88   07 38 00 00 CA 08 38


                                    cardNumber = "341610A5CA0007FC00200037";
                                    string cardLast = cardNumber.Substring(10);
                                    string cardHead = cardNumber.Remove(10, cardNumber.Length - 10);

                                    LogHelper.Logger_API_Infor($"Log BDK v2 ======= >  Bắt đầudoc cardnumber sau cat chuoi cardNumber: {cardNumber}, caardNumberHead  '{cardHead}', cardLas {cardLast}" , LogHelper.SaveLogFolder);
                                    cardNumber = cardLast;
                                    // Cthuc etag BDK 
                                    string _data = string.Empty;
                                    for (int i = 1; i < cardNumber.Length; i++)
                                    {
                                        _data += converts[cardNumber[i].ToString()];
                                    }
                                    char first = _data[0];
                                    _data = _data.Remove(0, 1);
                                    _data = _data + first;
                                    string[] datas = TachChuoi(_data, 4);

                                    string final = "";
                                    for (int i = 0; i < datas.Length; i++)
                                    {
                                        final += convertReverts[datas[i]];
                                    }
                                    final = "0" + final;
                                    string cardNumberSau = final;

                                    cardNumber = cardHead + cardNumberSau; 
                                    LogHelper.Logger_API_Infor($"Log BDK v2 ======= >   Dọc mã eTag : {cardNumber}, cardNumberHead = '{cardHead}, cardNumberSau = '{cardNumberSau}''", LogHelper.SaveLogFolder);
                                    int input = Regex.IsMatch(inputIndex_str, @"^\d+$") ? Convert.ToInt32(inputIndex_str) : -1;
                                    string inputDetail = string.Empty;
                                    inputDetail = GetInputDetail(input, inputDetail);

                                    string[] arrayInputs = Split(arrayInput_str, 1).ToArray();
                                    bool isIn5Actived = false;
                                    bool isIn6Actived = false;
                                    bool isLoop1Actived = false;
                                    bool isLoop2Actived = false;
                                    bool isLoop3Actived = false;
                                    bool isLoop4Actived = false;
                                    GetArrayInputDetail(arrayInputs, ref isIn5Actived, ref isIn6Actived, ref isLoop1Actived, ref isLoop2Actived, ref isLoop3Actived, ref isLoop4Actived);
                                    string com = com_str;

                                    MT116EventArgs e = new MT116EventArgs();
                                    e.LenCard = lenCard;
                                    e.CardNumber = cardNumber;
                                    e.InputDetail = inputDetail;
                                    e.isIn5Actived = isIn5Actived;
                                    e.isIn6Actived = isIn6Actived;
                                    e.isLoop1Actived = isLoop1Actived;
                                    e.isLoop2Actived = isLoop2Actived;
                                    e.isLoop3Actived = isLoop3Actived;
                                    e.isLoop4Actived = isLoop4Actived;
                                    e.COM = com;
                                    e.StateCardDispenserCom1 = stateCardDispenserCom1_str;
                                    e.StateCardDispenserCom2 = stateCardDispenserCom2_str;
                                    onEvent?.Invoke(this, e);
                                    DeleteEvent();
                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        LogHelper.Logger_CONTROLLER_Infor(ex.Message, LogHelper.SaveLogFolder);
                    }
                }
                else
                {
                    bool isPingSuccess = NetWorkTools.IsPingSuccess(ControllerInfor.Comport, ControllerInfor.Baudrate);
                    if (this.ControllerInfor.IsConnect != isPingSuccess)
                    {
                        this.ControllerInfor.IsConnect = isPingSuccess;
                        ConnectStatusCHangeEventArgs e = new ConnectStatusCHangeEventArgs();
                        e.CurrentStatus = isPingSuccess;
                        e.ControllerID = this.ControllerInfor.ID;
                        e.Comport = this.ControllerInfor.Comport;
                        e.reason = isPingSuccess ? "PING SUCCESS" : "PING ERROR";
                        this.OnConnectStatusChangeEvent(e);
                    }
                }
                Thread.Sleep(2000);
            }
        }

        static string[] TachChuoi(string chuoi, int doDaiPhanTu)
        {
            int soPhanTu = (int)Math.Ceiling((double)chuoi.Length / doDaiPhanTu);
            string[] mangChuoi = new string[soPhanTu];

            for (int i = 0; i < soPhanTu; i++)
            {
                int batDau = i * doDaiPhanTu;
                int doDai = Math.Min(doDaiPhanTu, chuoi.Length - batDau);
                mangChuoi[i] = chuoi.Substring(batDau, doDai);
            }

            return mangChuoi;
        }

        private static void GetArrayInputDetail(string[] arrayInputs, ref bool isIn5Actived, ref bool isIn6Actived, ref bool isLoop1Actived, ref bool isLoop2Actived, ref bool isLoop3Actived, ref bool isLoop4Actived)
        {
            if (arrayInputs.Length == 6)
            {
                isIn5Actived = arrayInputs[0] == "1";
                isIn6Actived = arrayInputs[1] == "1";
                isLoop1Actived = arrayInputs[2] == "1";
                isLoop2Actived = arrayInputs[3] == "1";
                isLoop3Actived = arrayInputs[4] == "1";
                isLoop4Actived = arrayInputs[5] == "1";
            }
        }

        private static string GetInputDetail(int input, string inputDetail)
        {
            switch (input)
            {
                case 1:
                    inputDetail = "Nút nhấn BTN1 - Thẻ được nhả ra sau khi nhấn nút trên BTN1";
                    break;
                case 2:
                    inputDetail = "Nút nhấn BTN2";
                    break;
                case 3:
                    inputDetail = "Reader 1";
                    break;
                case 4:
                    inputDetail = "Reader 2";
                    break;
                case 5:
                    inputDetail = "Exit 1";
                    break;
                case 6:
                    inputDetail = "Exit 2";
                    break;
                case 7:
                    inputDetail = "In 5";
                    break;
                case 8:
                    inputDetail = "In 6";
                    break;
                case 9:
                    inputDetail = "LOOP 1";
                    break;
                case 10:
                    inputDetail = "LOOP 2";
                    break;
                case 11:
                    inputDetail = "LOOP 3";
                    break;
                case 12:
                    inputDetail = "LOOP 4";
                    break;
                case 13:
                    inputDetail = "Spare";
                    break;
                case 14:
                    inputDetail = "Sự kiện có thẻ được rút ra khỏi miệng nhả thẻ (Bezel)";
                    break;
                case 21:
                    inputDetail = "Thẻ được nuốt vào khay nhả thẻ sau khi được nhấn trên BTN1, nhưng người dùng đã không rút thẻ sau một thời gian quy định.";
                    break;
                case 22:
                    inputDetail = "Thẻ được nuốt vào khay nhả thẻ sau khi được nhấn trên BTN2, nhưng người dùng đã không rút thẻ sau một thời gian quy định.";
                    break;
            }

            return inputDetail;
        }

        protected void OnConnectStatusChangeEvent(ConnectStatusCHangeEventArgs e)
        {
            if (this.ConnectStatusChangeEvent != null)
            {
                this.ConnectStatusChangeEvent(this, e);
            }
        }
        static IEnumerable<string> Split(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }

    }
}
