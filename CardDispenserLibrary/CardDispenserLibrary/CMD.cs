using System;
using System.Collections.Generic;
using System.Text;

namespace CardDispenserLibrary
{
    public static class CMD
    {
        public static string GetEventCMD => "GetEvent?/";
        public static string DeleteEventCMD => "DeleteEvent?/";
        #region: TCP_IP

        public static string AutoDetectCMD => "AutoDetect?/";


        /// <summary>
        /// Change Network Setting: ALL KZTEK DEVICE
        /// </summary>
        /// <param name="IP"></param>
        /// <param name="subnetMask"></param>
        /// <param name="defaultGateWay"></param>
        /// <param name="HostMac"></param>
        /// <returns></returns>
        public static string ChangeIPCMD(string IP, string subnetMask, string defaultGateWay, string HostMac)
        {
            return $"ChangeIP?/IP={IP}/SubnetMask={subnetMask}/DefaultGateWay={defaultGateWay}/HostMac={HostMac}/";
        }

        #endregion: END TCP_IP

        #region: RELAY
        /// <summary>
        /// Open Relay: E05 Net v3.4, KZ-E02.NET V3.0
        /// </summary>
        /// <param name="relayIndex"></param>
        /// <returns></returns>
        public static string OpenRelayCMD(int relayIndex)
        {
            return $"SetRelay?/Relay={relayIndex}/State=ON";
        }

        /// <summary>
        /// Open Multy Relay: 1 to 64: E05 Net v3.6
        /// </summary>
        /// <param name="relays"></param>
        /// <returns></returns>

        /// <summary>
        /// Set Relay Keep Open Tine: E05 Net v3.4, KZ-E02.NET V3.0
        /// </summary>
        /// <param name="DelayTimeInMiliSecond"></param>
        /// <returns></returns>
        public static string SetRelayDelayTimeCMD(int relayIndex, int DelayTimeInMiliSecond)
        {
            if (DelayTimeInMiliSecond >= 1 && DelayTimeInMiliSecond <= 900000)
            {
                return $"SetDelayRelay?/Relay={relayIndex}/Delay={DelayTimeInMiliSecond}/";
            }
            return $"SetDelayRelay?/Relay={relayIndex}/Delay=2000/";
        }

        #endregion: END RELAY

        public static string GetModeKeyCMD => "GetModeKey?/";
        public static string GetModeAutoCollectCardCMD => "GetModeAutoCollectCard?/";
        public static string SetTimeOutAutoCollectCardCMD(int timeOutInSecond) => $"SetTimeOutAutoCollectCard?/TimeOutAutoCollectCard={timeOutInSecond}/";
        public static string GetTimeOutAutoCollectCardCMD => "GetTimeOutAutoCollectCard?/";
        public static string SetKeyACMD(string keyA) => $"SetKeyA?/KeyA={keyA}/";
        public static string GetModeButtonCMD => "GetModeButton?/";
        public static string GetModeLoopCMD => "GetModeLoop?/";
        public static string SetPauseDispenseCardCMD => "SetPauseDispenseCard?/";
        public static string ResetDefaultCMD => "ResetDefault?/";

        public static string SetModeKeyCMD(bool isUseKey)
        {
            int _isUseKey = isUseKey ? 1 : 0;
            return $"SetModeKey?/ModeKey={_isUseKey}/";
        }

        public static string SetModeLoop(int modeLoop)
        {
            return $"SetModeLoop?/ModeLoop={modeLoop}/";
        }
    }
}
