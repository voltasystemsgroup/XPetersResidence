namespace Crestron.Seawolf.CRPC.Common.v2.Utilities;
        // class declarations
         class VersionInfo;
         class IdGenerator;
         class BackgroundTaskQueue;
         class Log;
         class MessageType;
     class IdGenerator 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION Generate ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class BackgroundTaskQueue 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION RemoveData ( STRING key );
        FUNCTION Dispose ();
        STRING_FUNCTION ToString ();
        FUNCTION Cancel ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
    };

    static class Log 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

    static class MessageType // enum
    {
        static SIGNED_LONG_INTEGER Information;
        static SIGNED_LONG_INTEGER Header;
        static SIGNED_LONG_INTEGER Highlight;
        static SIGNED_LONG_INTEGER Warning;
        static SIGNED_LONG_INTEGER Error;
    };

namespace Crestron.Seawolf.CRPC.Common.Extensions;
        // class declarations
         class Extensions;
    static class Extensions 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

namespace Crestron.Seawolf.CRPC;
        // class declarations
         class CrpcMemberInfoAttribute;
         class CrpcMemberAttribute;
         class CrpcMemberInfoParamsAttribute;
         class CrpcInterfaceAttribute;
     class CrpcMemberAttribute 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
    };

     class CrpcInterfaceAttribute 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
        STRING Version[];
    };

namespace Crestron.Seawolf.CRPC.Common.v2.Messages.Objects;
        // class declarations
         class CrpcSetProperty;
         class CrpcResponseError;
         class CrpcRegisterEventParameters;
         class CrpcRemoteDirectory;
         class CrpcRemoteEventRaised;
         class CrpcRemoteDirectoryChanged;
         class CrpcRegisterRequest;
         class CrpcGetProperty;
         class CrpcRemoteObject;
         class CrpcRemoteObjectComparer;
         class CrpcGetObjectResponseResult;
         class CrpcRegisterResponse;
     class CrpcSetProperty 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
    };

     class CrpcResponseError 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER Code;
        STRING Message[];
    };

     class CrpcRegisterEventParameters 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Event[];
    };

     class CrpcRemoteDirectory 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        CrpcRemoteObject Objects[];
    };

     class CrpcRemoteEventRaised 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Event[];
        STRING Handle[];
    };

     class CrpcRemoteDirectoryChanged 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        CrpcRemoteObject ObjectsAdded[];
        CrpcRemoteObject ObjectsRemoved[];
    };

     class CrpcRegisterRequest 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Version[];
        STRING Name[];
        SIGNED_LONG_INTEGER MaxPacketSize;
        STRING Encoding[];
        STRING Format[];
        STRING SupportedFormats[][];
        STRING SupportedEncodings[][];
        STRING Hostname[];
        STRING IpAddress[];
        STRING Subnet[];
    };

     class CrpcGetProperty 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
    };

     class CrpcRemoteObject 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
        STRING Instance[];
        STRING Categories[][];
        STRING Interfaces[][];
        STRING TypeName[];
        STRING TypeVersion[];
    };

     class CrpcRemoteObjectComparer 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ( CrpcRemoteObject object );
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class CrpcGetObjectResponseResult 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        CrpcRemoteDirectory Directory;
    };

     class CrpcRegisterResponse 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Version[];
        STRING Name[];
        SIGNED_LONG_INTEGER MaxPacketSize;
        STRING Encoding[];
        STRING Format[];
    };

namespace Crestron.Seawolf.CRPC.Common;
        // class declarations
         class MenuBusy;
         class MenuStatusMsg;
         class MenuItem;
         class MediaPlayerStatusMsg;
         class MediaPlayerBusy;
         class MediaPlayerRating;
         class JSONRPCResponse;
         class CrpcCategoryAttribute;
         class MediaPlayerEventConstants;
         class CrpcEventAttribute;
         class CrpcIid;
         class ShuffleState;
         class RepeatState;
         class CrpcEventArgs;
         class ObjectDirectoryChangedEventArgs;
         class CrpcMethodAttribute;
         class CrpcPropertyAttribute;
         class MenuUpdateEventArgs;
         class MenuClearEventArgs;
         class MenuBusyEventArgs;
         class MenuStateChangedEventArgs;
         class MenuStatusMsgEventArgs;
         class Access;
         class PlayerIcon;
         class MediaPlayerBusyEventArgs;
         class MediaPlayerStateChangedEventArgs;
         class MediaPlayerStatusMsgEventArgs;
         class MediaPlayerStateChangedByBrowseContextEventArgs;
         class LogLevel;
         class CrpcObjectAttribute;
     class MenuBusy 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER timeoutSec;
    };

     class MenuStatusMsg 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING text[];
        SIGNED_LONG_INTEGER timeoutSec;
        STRING userInputRequired[];
        STRING initialUserInput[];
        STRING textForItems[][];
    };

     class MenuItem 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING L1[];
        STRING L2[];
        STRING URL[];
    };

     class MediaPlayerStatusMsg 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING text[];
        SIGNED_LONG_INTEGER timeoutSec;
        STRING userInputRequired[];
        STRING initialUserInput[];
        STRING textForItems[][];
    };

     class MediaPlayerBusy 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER timeoutSec;
    };

     class MediaPlayerRating 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER current;
        SIGNED_LONG_INTEGER max;
        SIGNED_LONG_INTEGER system;
    };

    static class MediaPlayerEventConstants 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        static STRING text[];
        static STRING timeoutSec[];
        static STRING userInputRequired[];
        static STRING initialUserInput[];
        static STRING show[];
        static STRING textForItems[];
        static STRING localExit[];
        static STRING on[];
        static STRING instance[];
        static STRING item[];
        static STRING count[];

        // class properties
    };

     class CrpcIid 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
        STRING Version[];
    };

    static class ShuffleState // enum
    {
        static SIGNED_LONG_INTEGER Off;
        static SIGNED_LONG_INTEGER Track;
        static SIGNED_LONG_INTEGER Album;
    };

    static class RepeatState // enum
    {
        static SIGNED_LONG_INTEGER Off;
        static SIGNED_LONG_INTEGER Track;
        static SIGNED_LONG_INTEGER All;
    };

     class CrpcEventArgs 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class MenuClearEventArgs 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class MenuStateChangedEventArgs 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

    static class Access // enum
    {
        static SIGNED_LONG_INTEGER Public;
        static SIGNED_LONG_INTEGER Private;
    };

    static class PlayerIcon // enum
    {
        static SIGNED_LONG_INTEGER Default;
        static SIGNED_LONG_INTEGER XM;
        static SIGNED_LONG_INTEGER Sirius;
        static SIGNED_LONG_INTEGER AMFM;
        static SIGNED_LONG_INTEGER ADMS;
        static SIGNED_LONG_INTEGER iPod;
        static SIGNED_LONG_INTEGER InternetRadio;
        static SIGNED_LONG_INTEGER SatelliteRadio;
        static SIGNED_LONG_INTEGER Pandora;
        static SIGNED_LONG_INTEGER Librivox;
    };

     class MediaPlayerStateChangedEventArgs 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

    static class LogLevel // enum
    {
        static SIGNED_LONG_INTEGER Off;
        static SIGNED_LONG_INTEGER Error;
        static SIGNED_LONG_INTEGER Warning;
        static SIGNED_LONG_INTEGER Info;
        static SIGNED_LONG_INTEGER Verbose;
        static SIGNED_LONG_INTEGER Diagnostic;
    };

namespace Crestron.Seawolf.CRPC.Common.v2.Interfaces;
        // class declarations

