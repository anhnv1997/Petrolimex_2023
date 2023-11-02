using KztekObject.Objects;
using static CardDispenserLibrary.MT116Controller;
using System.Threading.Tasks;
using static KztekObject.Objects.ControllerEvent;

namespace CardDispenserLibrary
{
    public interface ICardDispenser
    {
        public event OnEvent onEvent;

        #region: CONNECT
        bool TestConnection();
        bool Connect();
        bool Disconnect();
        #endregion: END CONNECT

        #region: THREAD
        #region:Delete
        bool DeleteEvent();
        #endregion
        #endregion: END THREAD



         event ConnectStatusChangeEventHandler ConnectStatusChangeEvent;

        Controller ControllerInfor { get; set; }
        #region: RELAY
        bool RelayOn(int relayIndex);
        bool SetRelayDelayTime(int relayIndex, int timeInMiliscond);
        #endregion: END RELAY

        #region:Mode key
        int GetModeKey();
        bool SetModeKey(bool isUseKey);
        #endregion: End Mode key

        #region: ModeAutoCollectCard
        int GetModeAutoCollectCard();
        int GetTimeOutAutoCollectCard();
        bool SetTimeOutAutoCollectCard(int timeInSecond);

        #endregion: End ModeAutoCollectCard

        bool SetKeyA(string keyA);

        int GetModeButton();

        int GetModeLoop();
        bool SetModeLoop(int mode);


        bool SetPauseDispenseCard();

        Task<bool> ResetDefault();


        #region:TCP_IP
        //GET
        bool GetIP(ref string IP);

        bool GetMac(ref string macAddr);

        bool GetDefaultGateway(ref string defaultGateway);

        bool GetPort(ref int port);

        bool SetNetWorkInfor(string ip, string subnetMask, string defaultGateway, string macAddr);

        #endregion: END TCP_IP





        void PollingStart();


        void PollingStop();


    }
}

