using KztekObject.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace KztekObject.Enums
{
    public class CommunicationTypes
    {
        public enum EM_CommunicationType
        {
            TCP_IP,
            SERIAL,
            USB
        }

        public static bool IS_TCP(EM_CommunicationType communicationType)
        {
            return communicationType == EM_CommunicationType.TCP_IP;
        }
    }

    public class Errors
    {
        public enum EM_ErrorCode
        {

        }
    }

    public class ControllerFunctions
    {
        [Flags]
        public enum EM_ControllerFunctions
        {
            ALL = 0,
            ACCESS_NOT_FIRE_ALARM_ONLY = 1,
            ACCESS_WITH_FIRE_ALARM_ONLY = 2,
            ACCESS_AND_TIME_ATTENDANCE,
            TIME_ATTENDANCE_ONLY = 4
        }
    }

    public class ControllerTypes
    {
        public enum EM_ControllerType
        {
            KZ_E02,
            KZ_E05,
            KZ_E32,
            KZ_ELV_v1,
            FingerTech_R2_SDK3,
            FingerTech_Q2i,
            TCP_IP,
            ZKTEKO_PULL,
            KZ_Lock32,
        }

        public static Controller GetControllerByName(string controllerName)
        {
            return null;
        }

        public static Controller GetControllerByType(EM_ControllerType controllerType)
        {
            return null;
        }

        public static string GetControllerName(int controllerType)
        {
            return ((EM_ControllerType)controllerType).ToString();
        }
    }

    public class AntiPassBackModes
    {

    }

    public class DisplayModes
    {
        public enum EM_DisplayMode
        {
            DEC,
            HEX
        }
    }

    public class EventStatuses
    {
        public enum EM_EventStatus
        {
            ACCESS_GRANT,
            ACCESS_DENIED
        }
    }

    public class EventTypes
    {
        public enum EM_EventType
        {
            CARD,
            FINGER,
            FACE,
            Input
        }
    }
}
