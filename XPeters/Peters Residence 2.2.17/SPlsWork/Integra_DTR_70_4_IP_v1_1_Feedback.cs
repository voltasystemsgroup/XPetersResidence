using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_INTEGRA_DTR_70_4_IP_V1_1_FEEDBACK
{
    public class UserModuleClass_INTEGRA_DTR_70_4_IP_V1_1_FEEDBACK : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput NET_FF_REW_PUSHED;
        Crestron.Logos.SplusObjects.DigitalInput SEND_KEYBOARD;
        Crestron.Logos.SplusObjects.DigitalInput PROCESS_FROM_DEVICE;
        Crestron.Logos.SplusObjects.AnalogInput TUNER_BAND_IN;
        Crestron.Logos.SplusObjects.AnalogInput DELIMITER_TYPE;
        Crestron.Logos.SplusObjects.StringInput KEYBOARD_INPUT_TEXT;
        Crestron.Logos.SplusObjects.BufferInput FROM_DEVICE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput BUTTON_1_HIGHLIGHTED;
        Crestron.Logos.SplusObjects.DigitalOutput BUTTON_2_HIGHLIGHTED;
        Crestron.Logos.SplusObjects.AnalogOutput SLEEP_TIME;
        Crestron.Logos.SplusObjects.AnalogOutput MAIN_VOLUME_IN;
        Crestron.Logos.SplusObjects.AnalogOutput ZONE_2_VOLUME_IN;
        Crestron.Logos.SplusObjects.AnalogOutput ZONE_3_VOLUME_IN;
        Crestron.Logos.SplusObjects.AnalogOutput ZONE_4_VOLUME_IN;
        Crestron.Logos.SplusObjects.StringOutput TUNER_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TUNER_ZONE_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TUNER_ZONE_3_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TUNER_ZONE_4_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NAT_ARTIST__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NAT_ALBUM__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NAT_TITLE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NAT_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NAT_PLAY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NAT_REPEAT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NAT_SHUFFLE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NAT_TRACK__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput POPUP_TYPE_VALUE;
        Crestron.Logos.SplusObjects.StringOutput TOP_TITLE_TEXT;
        Crestron.Logos.SplusObjects.StringOutput POPUP_TITLE_TEXT;
        Crestron.Logos.SplusObjects.StringOutput POPUP_MESSAGE_TEXT;
        Crestron.Logos.SplusObjects.StringOutput ITEM_TITLE_1_TEXT;
        Crestron.Logos.SplusObjects.StringOutput ITEM_PARAMETER_1_TEXT;
        Crestron.Logos.SplusObjects.StringOutput ITEM_TITLE_2_TEXT;
        Crestron.Logos.SplusObjects.StringOutput ITEM_PARAMETER_2_TEXT;
        Crestron.Logos.SplusObjects.StringOutput ITEM_TITLE_3_TEXT;
        Crestron.Logos.SplusObjects.StringOutput ITEM_PARAMETER_3_TEXT;
        Crestron.Logos.SplusObjects.StringOutput ITEM_TITLE_4_TEXT;
        Crestron.Logos.SplusObjects.StringOutput ITEM_PARAMETER_4_TEXT;
        Crestron.Logos.SplusObjects.StringOutput ITEM_TITLE_5_TEXT;
        Crestron.Logos.SplusObjects.StringOutput ITEM_PARAMETER_5_TEXT;
        Crestron.Logos.SplusObjects.StringOutput ITEM_TITLE_6_TEXT;
        Crestron.Logos.SplusObjects.StringOutput ITEM_PARAMETER_6_TEXT;
        Crestron.Logos.SplusObjects.StringOutput BUTTON_1_TEXT;
        Crestron.Logos.SplusObjects.StringOutput BUTTON_2_TEXT;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> NET_CURSOR_POSITION_LINE;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> NET_LINE_TEXT;
        ushort ITEMP = 0;
        ushort ISLEEP = 0;
        ushort IFLAG1 = 0;
        ushort A = 0;
        ushort IVOL = 0;
        ushort IVOL2 = 0;
        ushort IVOL3 = 0;
        ushort ITEMP1 = 0;
        ushort IVOL4 = 0;
        ushort ICURSORPOSITION = 0;
        ushort ITEMP2 = 0;
        ushort ITEMP3 = 0;
        ushort INETDELAY = 0;
        ushort IWAITING = 0;
        ushort IMARKER1 = 0;
        ushort IMARKER2 = 0;
        ushort IMARKER3 = 0;
        ushort IMARKER4 = 0;
        ushort IMARKER5 = 0;
        ushort IMARKER6 = 0;
        ushort IMARKER7 = 0;
        ushort IMARKER8 = 0;
        ushort IMARKER9 = 0;
        ushort IMARKER10 = 0;
        ushort IMARKER11 = 0;
        ushort IMARKER12 = 0;
        ushort IMARKER13 = 0;
        ushort IMARKER14 = 0;
        ushort IMARKER15 = 0;
        ushort ICURSOR = 0;
        ushort ICURSORPOINTER = 0;
        CrestronString STEMP;
        CrestronString STEMP1;
        CrestronString STUNER;
        CrestronString STUNERZONE;
        CrestronString STUNER3;
        CrestronString STUNER4;
        CrestronString [] SLINETEXT;
        CrestronString SNATARTIST;
        CrestronString SNATALBUM;
        CrestronString SNATTITLE;
        CrestronString SNATTIME;
        CrestronString SNATPLAY;
        CrestronString SNATREPEAT;
        CrestronString SNATSHUFFLE;
        CrestronString SNATTRACK;
        CrestronString STEMPCMD;
        CrestronString SDISPLAYTYPE;
        CrestronString STEMP2;
        CrestronString SDELIMITER;
        object SEND_KEYBOARD_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 105;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( KEYBOARD_INPUT_TEXT ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt (IWAITING == 1) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 107;
                    MakeString ( STEMPCMD , "{0}{1}\r", "!1NKY" , Functions.Left ( KEYBOARD_INPUT_TEXT ,  (int) ( 128 ) ) ) ; 
                    __context__.SourceCodeLine = 108;
                    MakeString ( TO_DEVICE__DOLLAR__ , "{0}{1}{2}{3}", "ISCP\u0000\u0000\u0000\u0010\u0000\u0000\u0000" , Functions.Chr (  (int) ( Functions.Length( STEMPCMD ) ) ) , "\u0001\u0000\u0000\u0000" , STEMPCMD ) ; 
                    __context__.SourceCodeLine = 109;
                    IWAITING = (ushort) ( 0 ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object NET_FF_REW_PUSHED_OnRelease_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 115;
            CreateWait ( "WNETDELAY" , 500 , WNETDELAY_Callback ) ;
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
public void WNETDELAY_CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 117;
            INETDELAY = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 118;
            NAT_PLAY__DOLLAR__  .UpdateValue ( SNATPLAY  ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object NET_FF_REW_PUSHED_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 124;
        CancelWait ( "WNETDELAY" ) ; 
        __context__.SourceCodeLine = 125;
        INETDELAY = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROM_DEVICE__DOLLAR___OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 130;
        while ( Functions.TestForTrue  ( ( 1)  ) ) 
            { 
            __context__.SourceCodeLine = 132;
            /* Trace( "len(From_Device$):{0:d}\r\n", (ushort)Functions.Length( FROM_DEVICE__DOLLAR__ )) */ ; 
            __context__.SourceCodeLine = 133;
            STEMP  .UpdateValue ( Functions.Gather ( SDELIMITER , FROM_DEVICE__DOLLAR__ )  ) ; 
            __context__.SourceCodeLine = 134;
            STEMP  .UpdateValue ( Functions.Right ( STEMP ,  (int) ( (Functions.Length( STEMP ) - Functions.Length( "ISCP\u0000\u0000\u0000\u0010\u0000\u0000\u0000\u0000\u0001\u0000\u0000\u0000" )) ) )  ) ; 
            __context__.SourceCodeLine = 135;
            STEMP  .UpdateValue ( Functions.Left ( STEMP ,  (int) ( (Functions.Length( STEMP ) - (Functions.Length( SDELIMITER ) - 1)) ) )  ) ; 
            __context__.SourceCodeLine = 136;
            if ( Functions.TestForTrue  ( ( Functions.Length( STEMP ))  ) ) 
                { 
                __context__.SourceCodeLine = 138;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NJA" , STEMP ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 140;
                    STEMP1  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 141;
                    STEMP  .UpdateValue ( ""  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 143;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1SLP" , STEMP ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 145;
                        ITEMP1 = (ushort) ( Functions.Find( "!1SLP" , STEMP ) ) ; 
                        __context__.SourceCodeLine = 146;
                        STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1SLP" ) + ITEMP1) ) ,  (int) ( 2 ) )  ) ; 
                        __context__.SourceCodeLine = 147;
                        ITEMP = (ushort) ( Functions.HextoI( STEMP1 ) ) ; 
                        __context__.SourceCodeLine = 148;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != ISLEEP))  ) ) 
                            { 
                            __context__.SourceCodeLine = 150;
                            ISLEEP = (ushort) ( ITEMP ) ; 
                            __context__.SourceCodeLine = 151;
                            SLEEP_TIME  .Value = (ushort) ( ISLEEP ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 153;
                        STEMP1  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 154;
                        STEMP  .UpdateValue ( ""  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 156;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1MVL" , STEMP ) > 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 158;
                            ITEMP1 = (ushort) ( Functions.Find( "!1MVL" , STEMP ) ) ; 
                            __context__.SourceCodeLine = 159;
                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1MVL" ) + ITEMP1) ) ,  (int) ( 2 ) )  ) ; 
                            __context__.SourceCodeLine = 160;
                            ITEMP = (ushort) ( Functions.HextoI( STEMP1 ) ) ; 
                            __context__.SourceCodeLine = 161;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != IVOL))  ) ) 
                                { 
                                __context__.SourceCodeLine = 163;
                                IVOL = (ushort) ( ITEMP ) ; 
                                __context__.SourceCodeLine = 164;
                                MAIN_VOLUME_IN  .Value = (ushort) ( IVOL ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 166;
                            STEMP1  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 167;
                            STEMP  .UpdateValue ( ""  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 169;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1ZVL" , STEMP ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 171;
                                ITEMP1 = (ushort) ( Functions.Find( "!1ZVL" , STEMP ) ) ; 
                                __context__.SourceCodeLine = 172;
                                STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1ZVL" ) + ITEMP1) ) ,  (int) ( 2 ) )  ) ; 
                                __context__.SourceCodeLine = 173;
                                ITEMP = (ushort) ( Functions.HextoI( STEMP1 ) ) ; 
                                __context__.SourceCodeLine = 174;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != IVOL2))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 176;
                                    IVOL2 = (ushort) ( ITEMP ) ; 
                                    __context__.SourceCodeLine = 177;
                                    ZONE_2_VOLUME_IN  .Value = (ushort) ( IVOL2 ) ; 
                                    } 
                                
                                __context__.SourceCodeLine = 179;
                                STEMP1  .UpdateValue ( ""  ) ; 
                                __context__.SourceCodeLine = 180;
                                STEMP  .UpdateValue ( ""  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 182;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1VL3" , STEMP ) > 0 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 184;
                                    ITEMP1 = (ushort) ( Functions.Find( "!1VL3" , STEMP ) ) ; 
                                    __context__.SourceCodeLine = 185;
                                    STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1VL3" ) + ITEMP1) ) ,  (int) ( 2 ) )  ) ; 
                                    __context__.SourceCodeLine = 186;
                                    ITEMP = (ushort) ( Functions.HextoI( STEMP1 ) ) ; 
                                    __context__.SourceCodeLine = 187;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != IVOL3))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 189;
                                        IVOL3 = (ushort) ( ITEMP ) ; 
                                        __context__.SourceCodeLine = 190;
                                        ZONE_3_VOLUME_IN  .Value = (ushort) ( IVOL3 ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 192;
                                    STEMP1  .UpdateValue ( ""  ) ; 
                                    __context__.SourceCodeLine = 193;
                                    STEMP  .UpdateValue ( ""  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 195;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1VL4" , STEMP ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 197;
                                        ITEMP1 = (ushort) ( Functions.Find( "!1VL4" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 198;
                                        STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1VL4" ) + ITEMP1) ) ,  (int) ( 2 ) )  ) ; 
                                        __context__.SourceCodeLine = 199;
                                        ITEMP = (ushort) ( Functions.HextoI( STEMP1 ) ) ; 
                                        __context__.SourceCodeLine = 200;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != IVOL4))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 202;
                                            IVOL4 = (ushort) ( ITEMP ) ; 
                                            __context__.SourceCodeLine = 203;
                                            ZONE_4_VOLUME_IN  .Value = (ushort) ( IVOL4 ) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 205;
                                        STEMP1  .UpdateValue ( ""  ) ; 
                                        __context__.SourceCodeLine = 206;
                                        STEMP  .UpdateValue ( ""  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 208;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1TUN" , STEMP ) > 0 ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 210;
                                            ITEMP1 = (ushort) ( Functions.Find( "!1TUN" , STEMP ) ) ; 
                                            __context__.SourceCodeLine = 211;
                                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1TUN" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1TUN" )) - ITEMP1) ) )  ) ; 
                                            __context__.SourceCodeLine = 212;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STUNER != STEMP1))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 214;
                                                MakeString ( STUNER , "{0:d}", (short)Functions.Atoi( STEMP1 )) ; 
                                                __context__.SourceCodeLine = 215;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TUNER_BAND_IN  .UshortValue == 1))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 217;
                                                    MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0}.{1} MHz", Functions.Left ( STUNER ,  (int) ( (Functions.Length( STUNER ) - 2) ) ) , Functions.Right ( STUNER ,  (int) ( 2 ) ) ) ; 
                                                    } 
                                                
                                                else 
                                                    { 
                                                    __context__.SourceCodeLine = 221;
                                                    MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0} kHz", STUNER ) ; 
                                                    } 
                                                
                                                } 
                                            
                                            __context__.SourceCodeLine = 224;
                                            STEMP1  .UpdateValue ( ""  ) ; 
                                            __context__.SourceCodeLine = 225;
                                            STEMP  .UpdateValue ( ""  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 227;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1TUZ" , STEMP ) > 0 ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 229;
                                                ITEMP1 = (ushort) ( Functions.Find( "!1TUZ" , STEMP ) ) ; 
                                                __context__.SourceCodeLine = 230;
                                                STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1TUZ" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1TUZ" )) - ITEMP1) ) )  ) ; 
                                                __context__.SourceCodeLine = 231;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STUNERZONE != STEMP1))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 233;
                                                    MakeString ( STUNERZONE , "{0:d}", (short)Functions.Atoi( STEMP1 )) ; 
                                                    __context__.SourceCodeLine = 234;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TUNER_BAND_IN  .UshortValue == 1))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 236;
                                                        MakeString ( TUNER_ZONE_FREQUENCY__DOLLAR__ , "{0}.{1} MHz", Functions.Left ( STUNERZONE ,  (int) ( (Functions.Length( STUNERZONE ) - 2) ) ) , Functions.Right ( STUNERZONE ,  (int) ( 2 ) ) ) ; 
                                                        } 
                                                    
                                                    else 
                                                        { 
                                                        __context__.SourceCodeLine = 240;
                                                        MakeString ( TUNER_ZONE_FREQUENCY__DOLLAR__ , "{0} kHz", STUNERZONE ) ; 
                                                        } 
                                                    
                                                    } 
                                                
                                                __context__.SourceCodeLine = 243;
                                                STEMP1  .UpdateValue ( ""  ) ; 
                                                __context__.SourceCodeLine = 244;
                                                STEMP  .UpdateValue ( ""  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 246;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1TU3" , STEMP ) > 0 ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 248;
                                                    ITEMP1 = (ushort) ( Functions.Find( "!1TU3" , STEMP ) ) ; 
                                                    __context__.SourceCodeLine = 249;
                                                    STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1TU3" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1TU3" )) - ITEMP1) ) )  ) ; 
                                                    __context__.SourceCodeLine = 250;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STUNER3 != STEMP1))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 252;
                                                        MakeString ( STUNER3 , "{0:d}", (short)Functions.Atoi( STEMP1 )) ; 
                                                        __context__.SourceCodeLine = 253;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TUNER_BAND_IN  .UshortValue == 1))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 255;
                                                            MakeString ( TUNER_ZONE_3_FREQUENCY__DOLLAR__ , "{0}.{1} MHz", Functions.Left ( STUNER3 ,  (int) ( (Functions.Length( STUNER3 ) - 2) ) ) , Functions.Right ( STUNER3 ,  (int) ( 2 ) ) ) ; 
                                                            } 
                                                        
                                                        else 
                                                            { 
                                                            __context__.SourceCodeLine = 259;
                                                            MakeString ( TUNER_ZONE_3_FREQUENCY__DOLLAR__ , "{0} kHz", STUNER3 ) ; 
                                                            } 
                                                        
                                                        } 
                                                    
                                                    __context__.SourceCodeLine = 262;
                                                    STEMP1  .UpdateValue ( ""  ) ; 
                                                    __context__.SourceCodeLine = 263;
                                                    STEMP  .UpdateValue ( ""  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 265;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1TU4" , STEMP ) > 0 ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 267;
                                                        ITEMP1 = (ushort) ( Functions.Find( "!1TU4" , STEMP ) ) ; 
                                                        __context__.SourceCodeLine = 268;
                                                        STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1TU4" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1TU4" )) - ITEMP1) ) )  ) ; 
                                                        __context__.SourceCodeLine = 269;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STUNER4 != STEMP1))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 271;
                                                            MakeString ( STUNER4 , "{0:d}", (short)Functions.Atoi( STEMP1 )) ; 
                                                            __context__.SourceCodeLine = 272;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TUNER_BAND_IN  .UshortValue == 1))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 274;
                                                                MakeString ( TUNER_ZONE_4_FREQUENCY__DOLLAR__ , "{0}.{1} MHz", Functions.Left ( STUNER4 ,  (int) ( (Functions.Length( STUNER4 ) - 2) ) ) , Functions.Right ( STUNER4 ,  (int) ( 2 ) ) ) ; 
                                                                } 
                                                            
                                                            else 
                                                                { 
                                                                __context__.SourceCodeLine = 278;
                                                                MakeString ( TUNER_ZONE_4_FREQUENCY__DOLLAR__ , "{0} kHz", STUNER4 ) ; 
                                                                } 
                                                            
                                                            } 
                                                        
                                                        __context__.SourceCodeLine = 281;
                                                        STEMP1  .UpdateValue ( ""  ) ; 
                                                        __context__.SourceCodeLine = 282;
                                                        STEMP  .UpdateValue ( ""  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 284;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NLSA" , STEMP ) > 0 ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 286;
                                                            ITEMP1 = (ushort) ( Functions.Find( "!1NLSA" , STEMP ) ) ; 
                                                            __context__.SourceCodeLine = 287;
                                                            ITEMP2 = (ushort) ( (Functions.Atoi( Functions.Mid( STEMP , (int)( (ITEMP1 + 2) ) , (int)( 8 ) ) ) + 1) ) ; 
                                                            __context__.SourceCodeLine = 288;
                                                            ITEMP3 = (ushort) ( Functions.Find( "\u001A" , STEMP ) ) ; 
                                                            __context__.SourceCodeLine = 289;
                                                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 9 ) ,  (int) ( (ITEMP3 - 9) ) )  ) ; 
                                                            __context__.SourceCodeLine = 290;
                                                            IMARKER1 = (ushort) ( 0 ) ; 
                                                            __context__.SourceCodeLine = 291;
                                                            IMARKER1 = (ushort) ( Functions.Find( "\u0000" , STEMP1 ) ) ; 
                                                            __context__.SourceCodeLine = 292;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IMARKER1 > 0 ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 294;
                                                                STEMP1  .UpdateValue ( Functions.Left ( STEMP1 ,  (int) ( (IMARKER1 - 1) ) )  ) ; 
                                                                __context__.SourceCodeLine = 295;
                                                                IMARKER1 = (ushort) ( 0 ) ; 
                                                                } 
                                                            
                                                            __context__.SourceCodeLine = 297;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SLINETEXT[ ITEMP2 ] != STEMP1))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 299;
                                                                SLINETEXT [ ITEMP2 ]  .UpdateValue ( STEMP1  ) ; 
                                                                __context__.SourceCodeLine = 300;
                                                                NET_LINE_TEXT [ ITEMP2]  .UpdateValue ( SLINETEXT [ ITEMP2 ]  ) ; 
                                                                } 
                                                            
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 303;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NLSU" , STEMP ) > 0 ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 305;
                                                                ITEMP1 = (ushort) ( Functions.Find( "!1NLSU" , STEMP ) ) ; 
                                                                __context__.SourceCodeLine = 306;
                                                                ITEMP2 = (ushort) ( (Functions.Atoi( Functions.Mid( STEMP , (int)( (ITEMP1 + 2) ) , (int)( 5 ) ) ) + 1) ) ; 
                                                                __context__.SourceCodeLine = 307;
                                                                ITEMP3 = (ushort) ( Functions.Find( "\u001A" , STEMP ) ) ; 
                                                                __context__.SourceCodeLine = 308;
                                                                STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 9 ) ,  (int) ( (ITEMP3 - 9) ) )  ) ; 
                                                                __context__.SourceCodeLine = 309;
                                                                IMARKER1 = (ushort) ( 0 ) ; 
                                                                __context__.SourceCodeLine = 310;
                                                                IMARKER1 = (ushort) ( Functions.Find( "\u0000" , STEMP1 ) ) ; 
                                                                __context__.SourceCodeLine = 311;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IMARKER1 > 0 ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 313;
                                                                    STEMP1  .UpdateValue ( Functions.Left ( STEMP1 ,  (int) ( (IMARKER1 - 1) ) )  ) ; 
                                                                    __context__.SourceCodeLine = 314;
                                                                    IMARKER1 = (ushort) ( 0 ) ; 
                                                                    } 
                                                                
                                                                __context__.SourceCodeLine = 316;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SLINETEXT[ ITEMP2 ] != STEMP1))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 318;
                                                                    SLINETEXT [ ITEMP2 ]  .UpdateValue ( STEMP1  ) ; 
                                                                    __context__.SourceCodeLine = 319;
                                                                    NET_LINE_TEXT [ ITEMP2]  .UpdateValue ( SLINETEXT [ ITEMP2 ]  ) ; 
                                                                    } 
                                                                
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 322;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NLSC" , STEMP ) > 0 ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 324;
                                                                    ITEMP1 = (ushort) ( Functions.Find( "!1NLSC" , STEMP ) ) ; 
                                                                    __context__.SourceCodeLine = 325;
                                                                    ITEMP2 = (ushort) ( (Functions.Atoi( Functions.Mid( STEMP , (int)( (ITEMP1 + 2) ) , (int)( 8 ) ) ) + 1) ) ; 
                                                                    __context__.SourceCodeLine = 326;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( STEMP , (int)( 7 ) , (int)( 1 ) ) == "-"))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 328;
                                                                        ITEMP2 = (ushort) ( 0 ) ; 
                                                                        } 
                                                                    
                                                                    __context__.SourceCodeLine = 330;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICURSORPOSITION != ITEMP2))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 332;
                                                                        ICURSORPOSITION = (ushort) ( ITEMP2 ) ; 
                                                                        __context__.SourceCodeLine = 333;
                                                                        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                                                                        ushort __FN_FOREND_VAL__1 = (ushort)10; 
                                                                        int __FN_FORSTEP_VAL__1 = (int)1; 
                                                                        for ( A  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (A  >= __FN_FORSTART_VAL__1) && (A  <= __FN_FOREND_VAL__1) ) : ( (A  <= __FN_FORSTART_VAL__1) && (A  >= __FN_FOREND_VAL__1) ) ; A  += (ushort)__FN_FORSTEP_VAL__1) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 335;
                                                                            NET_CURSOR_POSITION_LINE [ A]  .Value = (ushort) ( 0 ) ; 
                                                                            __context__.SourceCodeLine = 333;
                                                                            } 
                                                                        
                                                                        __context__.SourceCodeLine = 337;
                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICURSORPOSITION > 0 ))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 339;
                                                                            NET_CURSOR_POSITION_LINE [ ICURSORPOSITION]  .Value = (ushort) ( 1 ) ; 
                                                                            } 
                                                                        
                                                                        } 
                                                                    
                                                                    __context__.SourceCodeLine = 342;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "P" , Functions.Mid( STEMP , (int)( 8 ) , (int)( 1 ) ) ) > 0 ))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 344;
                                                                        ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
                                                                        ushort __FN_FOREND_VAL__2 = (ushort)10; 
                                                                        int __FN_FORSTEP_VAL__2 = (int)1; 
                                                                        for ( A  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (A  >= __FN_FORSTART_VAL__2) && (A  <= __FN_FOREND_VAL__2) ) : ( (A  <= __FN_FORSTART_VAL__2) && (A  >= __FN_FOREND_VAL__2) ) ; A  += (ushort)__FN_FORSTEP_VAL__2) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 346;
                                                                            SLINETEXT [ A ]  .UpdateValue ( ""  ) ; 
                                                                            __context__.SourceCodeLine = 347;
                                                                            NET_LINE_TEXT [ A]  .UpdateValue ( SLINETEXT [ A ]  ) ; 
                                                                            __context__.SourceCodeLine = 344;
                                                                            } 
                                                                        
                                                                        } 
                                                                    
                                                                    } 
                                                                
                                                                else 
                                                                    {
                                                                    __context__.SourceCodeLine = 351;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NAT" , STEMP ) > 0 ))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 353;
                                                                        ITEMP1 = (ushort) ( Functions.Find( "!1NAT" , STEMP ) ) ; 
                                                                        __context__.SourceCodeLine = 354;
                                                                        STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1NAT" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1NAT" )) - ITEMP1) ) )  ) ; 
                                                                        __context__.SourceCodeLine = 355;
                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNATARTIST != STEMP1))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 357;
                                                                            SNATARTIST  .UpdateValue ( STEMP1  ) ; 
                                                                            __context__.SourceCodeLine = 358;
                                                                            NAT_ARTIST__DOLLAR__  .UpdateValue ( SNATARTIST  ) ; 
                                                                            } 
                                                                        
                                                                        __context__.SourceCodeLine = 360;
                                                                        STEMP1  .UpdateValue ( ""  ) ; 
                                                                        __context__.SourceCodeLine = 361;
                                                                        STEMP  .UpdateValue ( ""  ) ; 
                                                                        } 
                                                                    
                                                                    else 
                                                                        {
                                                                        __context__.SourceCodeLine = 363;
                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NAL" , STEMP ) > 0 ))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 365;
                                                                            ITEMP1 = (ushort) ( Functions.Find( "!1NAL" , STEMP ) ) ; 
                                                                            __context__.SourceCodeLine = 366;
                                                                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1NAL" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1NAL" )) - ITEMP1) ) )  ) ; 
                                                                            __context__.SourceCodeLine = 367;
                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNATALBUM != STEMP1))  ) ) 
                                                                                { 
                                                                                __context__.SourceCodeLine = 369;
                                                                                SNATALBUM  .UpdateValue ( STEMP1  ) ; 
                                                                                __context__.SourceCodeLine = 370;
                                                                                NAT_ALBUM__DOLLAR__  .UpdateValue ( SNATALBUM  ) ; 
                                                                                } 
                                                                            
                                                                            __context__.SourceCodeLine = 372;
                                                                            STEMP1  .UpdateValue ( ""  ) ; 
                                                                            __context__.SourceCodeLine = 373;
                                                                            STEMP  .UpdateValue ( ""  ) ; 
                                                                            } 
                                                                        
                                                                        else 
                                                                            {
                                                                            __context__.SourceCodeLine = 375;
                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NTI" , STEMP ) > 0 ))  ) ) 
                                                                                { 
                                                                                __context__.SourceCodeLine = 377;
                                                                                ITEMP1 = (ushort) ( Functions.Find( "!1NTI" , STEMP ) ) ; 
                                                                                __context__.SourceCodeLine = 378;
                                                                                STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1NTI" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1NTI" )) - ITEMP1) ) )  ) ; 
                                                                                __context__.SourceCodeLine = 379;
                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNATTITLE != STEMP1))  ) ) 
                                                                                    { 
                                                                                    __context__.SourceCodeLine = 381;
                                                                                    SNATTITLE  .UpdateValue ( STEMP1  ) ; 
                                                                                    __context__.SourceCodeLine = 382;
                                                                                    NAT_TITLE__DOLLAR__  .UpdateValue ( SNATTITLE  ) ; 
                                                                                    } 
                                                                                
                                                                                __context__.SourceCodeLine = 384;
                                                                                STEMP1  .UpdateValue ( ""  ) ; 
                                                                                __context__.SourceCodeLine = 385;
                                                                                STEMP  .UpdateValue ( ""  ) ; 
                                                                                } 
                                                                            
                                                                            else 
                                                                                {
                                                                                __context__.SourceCodeLine = 387;
                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NTM" , STEMP ) > 0 ))  ) ) 
                                                                                    { 
                                                                                    __context__.SourceCodeLine = 389;
                                                                                    ITEMP1 = (ushort) ( Functions.Find( "!1NTM" , STEMP ) ) ; 
                                                                                    __context__.SourceCodeLine = 390;
                                                                                    STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1NTM" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1NTM" )) - ITEMP1) ) )  ) ; 
                                                                                    __context__.SourceCodeLine = 391;
                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNATTIME != STEMP1))  ) ) 
                                                                                        { 
                                                                                        __context__.SourceCodeLine = 393;
                                                                                        SNATTIME  .UpdateValue ( STEMP1  ) ; 
                                                                                        __context__.SourceCodeLine = 394;
                                                                                        NAT_TIME__DOLLAR__  .UpdateValue ( SNATTIME  ) ; 
                                                                                        } 
                                                                                    
                                                                                    __context__.SourceCodeLine = 396;
                                                                                    STEMP1  .UpdateValue ( ""  ) ; 
                                                                                    __context__.SourceCodeLine = 397;
                                                                                    STEMP  .UpdateValue ( ""  ) ; 
                                                                                    } 
                                                                                
                                                                                else 
                                                                                    {
                                                                                    __context__.SourceCodeLine = 399;
                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NTR" , STEMP ) > 0 ))  ) ) 
                                                                                        { 
                                                                                        __context__.SourceCodeLine = 401;
                                                                                        ITEMP1 = (ushort) ( Functions.Find( "!1NTR" , STEMP ) ) ; 
                                                                                        __context__.SourceCodeLine = 402;
                                                                                        STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1NTR" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1NTR" )) - ITEMP1) ) )  ) ; 
                                                                                        __context__.SourceCodeLine = 403;
                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNATTRACK != STEMP1))  ) ) 
                                                                                            { 
                                                                                            __context__.SourceCodeLine = 405;
                                                                                            SNATTRACK  .UpdateValue ( STEMP1  ) ; 
                                                                                            __context__.SourceCodeLine = 406;
                                                                                            NAT_TRACK__DOLLAR__  .UpdateValue ( SNATTRACK  ) ; 
                                                                                            } 
                                                                                        
                                                                                        __context__.SourceCodeLine = 408;
                                                                                        STEMP1  .UpdateValue ( ""  ) ; 
                                                                                        __context__.SourceCodeLine = 409;
                                                                                        STEMP  .UpdateValue ( ""  ) ; 
                                                                                        } 
                                                                                    
                                                                                    else 
                                                                                        {
                                                                                        __context__.SourceCodeLine = 411;
                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NST" , STEMP ) > 0 ))  ) ) 
                                                                                            { 
                                                                                            __context__.SourceCodeLine = 413;
                                                                                            ITEMP1 = (ushort) ( Functions.Find( "!1NAT" , STEMP ) ) ; 
                                                                                            __context__.SourceCodeLine = 414;
                                                                                            STEMP1  .UpdateValue ( Functions.Chr (  (int) ( Byte( STEMP , (int)( 6 ) ) ) )  ) ; 
                                                                                            __context__.SourceCodeLine = 415;
                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNATPLAY != STEMP1))  ) ) 
                                                                                                { 
                                                                                                __context__.SourceCodeLine = 417;
                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (STEMP1 == "P") ) && Functions.TestForTrue ( Functions.BoolToInt (INETDELAY != 1) )) ))  ) ) 
                                                                                                    { 
                                                                                                    __context__.SourceCodeLine = 419;
                                                                                                    SNATPLAY  .UpdateValue ( STEMP1  ) ; 
                                                                                                    __context__.SourceCodeLine = 420;
                                                                                                    NAT_PLAY__DOLLAR__  .UpdateValue ( SNATPLAY  ) ; 
                                                                                                    } 
                                                                                                
                                                                                                else 
                                                                                                    {
                                                                                                    __context__.SourceCodeLine = 422;
                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (STEMP1 == "P") ) && Functions.TestForTrue ( Functions.BoolToInt (INETDELAY == 1) )) ))  ) ) 
                                                                                                        { 
                                                                                                        __context__.SourceCodeLine = 424;
                                                                                                        SNATPLAY  .UpdateValue ( STEMP1  ) ; 
                                                                                                        } 
                                                                                                    
                                                                                                    else 
                                                                                                        { 
                                                                                                        __context__.SourceCodeLine = 428;
                                                                                                        SNATPLAY  .UpdateValue ( STEMP1  ) ; 
                                                                                                        __context__.SourceCodeLine = 429;
                                                                                                        NAT_PLAY__DOLLAR__  .UpdateValue ( SNATPLAY  ) ; 
                                                                                                        } 
                                                                                                    
                                                                                                    }
                                                                                                
                                                                                                } 
                                                                                            
                                                                                            __context__.SourceCodeLine = 432;
                                                                                            STEMP1  .UpdateValue ( Functions.Chr (  (int) ( Byte( STEMP , (int)( 7 ) ) ) )  ) ; 
                                                                                            __context__.SourceCodeLine = 433;
                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNATREPEAT != STEMP1))  ) ) 
                                                                                                { 
                                                                                                __context__.SourceCodeLine = 435;
                                                                                                SNATREPEAT  .UpdateValue ( STEMP1  ) ; 
                                                                                                __context__.SourceCodeLine = 436;
                                                                                                NAT_REPEAT__DOLLAR__  .UpdateValue ( SNATREPEAT  ) ; 
                                                                                                } 
                                                                                            
                                                                                            __context__.SourceCodeLine = 438;
                                                                                            STEMP1  .UpdateValue ( Functions.Chr (  (int) ( Byte( STEMP , (int)( 8 ) ) ) )  ) ; 
                                                                                            __context__.SourceCodeLine = 439;
                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNATSHUFFLE != STEMP1))  ) ) 
                                                                                                { 
                                                                                                __context__.SourceCodeLine = 441;
                                                                                                SNATSHUFFLE  .UpdateValue ( STEMP1  ) ; 
                                                                                                __context__.SourceCodeLine = 442;
                                                                                                NAT_SHUFFLE__DOLLAR__  .UpdateValue ( SNATSHUFFLE  ) ; 
                                                                                                } 
                                                                                            
                                                                                            __context__.SourceCodeLine = 444;
                                                                                            STEMP1  .UpdateValue ( ""  ) ; 
                                                                                            __context__.SourceCodeLine = 445;
                                                                                            STEMP  .UpdateValue ( ""  ) ; 
                                                                                            } 
                                                                                        
                                                                                        else 
                                                                                            {
                                                                                            __context__.SourceCodeLine = 447;
                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NKY" , STEMP ) > 0 ))  ) ) 
                                                                                                { 
                                                                                                __context__.SourceCodeLine = 449;
                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "00" , STEMP ) > 0 ))  ) ) 
                                                                                                    { 
                                                                                                    __context__.SourceCodeLine = 451;
                                                                                                    IWAITING = (ushort) ( 0 ) ; 
                                                                                                    } 
                                                                                                
                                                                                                else 
                                                                                                    { 
                                                                                                    __context__.SourceCodeLine = 455;
                                                                                                    IWAITING = (ushort) ( 1 ) ; 
                                                                                                    } 
                                                                                                
                                                                                                } 
                                                                                            
                                                                                            else 
                                                                                                {
                                                                                                __context__.SourceCodeLine = 458;
                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NPU" , STEMP ) > 0 ))  ) ) 
                                                                                                    { 
                                                                                                    __context__.SourceCodeLine = 460;
                                                                                                    SDISPLAYTYPE  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 6 ) ,  (int) ( 1 ) )  ) ; 
                                                                                                    __context__.SourceCodeLine = 461;
                                                                                                    POPUP_TYPE_VALUE  .UpdateValue ( SDISPLAYTYPE  ) ; 
                                                                                                    __context__.SourceCodeLine = 462;
                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SDISPLAYTYPE == "T"))  ) ) 
                                                                                                        { 
                                                                                                        __context__.SourceCodeLine = 464;
                                                                                                        IMARKER1 = (ushort) ( Functions.Find( "\u0000" , STEMP ) ) ; 
                                                                                                        __context__.SourceCodeLine = 465;
                                                                                                        IMARKER2 = (ushort) ( Functions.Find( "\u0000" , STEMP , (IMARKER1 + 1) ) ) ; 
                                                                                                        __context__.SourceCodeLine = 466;
                                                                                                        IMARKER3 = (ushort) ( Functions.Find( "\u0000" , STEMP , (IMARKER2 + 1) ) ) ; 
                                                                                                        __context__.SourceCodeLine = 467;
                                                                                                        IMARKER4 = (ushort) ( Functions.Find( "\u0000" , STEMP , (IMARKER3 + 1) ) ) ; 
                                                                                                        __context__.SourceCodeLine = 468;
                                                                                                        IMARKER5 = (ushort) ( Functions.Find( "\u0000" , STEMP , (IMARKER4 + 1) ) ) ; 
                                                                                                        __context__.SourceCodeLine = 469;
                                                                                                        TOP_TITLE_TEXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 7 ) ,  (int) ( (IMARKER1 - 7) ) )  ) ; 
                                                                                                        __context__.SourceCodeLine = 470;
                                                                                                        POPUP_TITLE_TEXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER1 + 1) ) ,  (int) ( (IMARKER2 - (IMARKER1 + 1)) ) )  ) ; 
                                                                                                        __context__.SourceCodeLine = 471;
                                                                                                        POPUP_MESSAGE_TEXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER2 + 1) ) ,  (int) ( (IMARKER3 - (IMARKER2 + 1)) ) )  ) ; 
                                                                                                        __context__.SourceCodeLine = 472;
                                                                                                        ICURSORPOINTER = (ushort) ( (IMARKER3 + 1) ) ; 
                                                                                                        __context__.SourceCodeLine = 473;
                                                                                                        ICURSOR = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( (IMARKER3 + 1) ) , (int)( 1 ) ) ) ) ; 
                                                                                                        __context__.SourceCodeLine = 474;
                                                                                                        
                                                                                                            {
                                                                                                            int __SPLS_TMPVAR__SWTCH_1__ = ((int)ICURSOR);
                                                                                                            
                                                                                                                { 
                                                                                                                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 0) ) ) ) 
                                                                                                                    { 
                                                                                                                    __context__.SourceCodeLine = 478;
                                                                                                                    BUTTON_1_HIGHLIGHTED  .Value = (ushort) ( 0 ) ; 
                                                                                                                    __context__.SourceCodeLine = 479;
                                                                                                                    BUTTON_2_HIGHLIGHTED  .Value = (ushort) ( 0 ) ; 
                                                                                                                    } 
                                                                                                                
                                                                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                                                                                                                    { 
                                                                                                                    __context__.SourceCodeLine = 483;
                                                                                                                    BUTTON_2_HIGHLIGHTED  .Value = (ushort) ( 0 ) ; 
                                                                                                                    __context__.SourceCodeLine = 484;
                                                                                                                    BUTTON_1_HIGHLIGHTED  .Value = (ushort) ( 1 ) ; 
                                                                                                                    } 
                                                                                                                
                                                                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                                                                                                                    { 
                                                                                                                    __context__.SourceCodeLine = 488;
                                                                                                                    BUTTON_1_HIGHLIGHTED  .Value = (ushort) ( 0 ) ; 
                                                                                                                    __context__.SourceCodeLine = 489;
                                                                                                                    BUTTON_2_HIGHLIGHTED  .Value = (ushort) ( 1 ) ; 
                                                                                                                    } 
                                                                                                                
                                                                                                                } 
                                                                                                                
                                                                                                            }
                                                                                                            
                                                                                                        
                                                                                                        __context__.SourceCodeLine = 492;
                                                                                                        BUTTON_1_TEXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER3 + 2) ) ,  (int) ( (IMARKER4 - (IMARKER3 + 2)) ) )  ) ; 
                                                                                                        __context__.SourceCodeLine = 493;
                                                                                                        BUTTON_2_TEXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER4 + 1) ) ,  (int) ( (IMARKER5 - (IMARKER4 + 1)) ) )  ) ; 
                                                                                                        } 
                                                                                                    
                                                                                                    else 
                                                                                                        {
                                                                                                        __context__.SourceCodeLine = 495;
                                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SDISPLAYTYPE == "B"))  ) ) 
                                                                                                            { 
                                                                                                            __context__.SourceCodeLine = 497;
                                                                                                            IMARKER1 = (ushort) ( Functions.Find( "\u0000" , STEMP ) ) ; 
                                                                                                            __context__.SourceCodeLine = 498;
                                                                                                            IMARKER2 = (ushort) ( Functions.Find( "\u0000" , STEMP , (IMARKER1 + 1) ) ) ; 
                                                                                                            __context__.SourceCodeLine = 499;
                                                                                                            IMARKER3 = (ushort) ( Functions.Find( "\u0000" , STEMP , (IMARKER2 + 1) ) ) ; 
                                                                                                            __context__.SourceCodeLine = 500;
                                                                                                            IMARKER4 = (ushort) ( Functions.Find( "\u0000" , STEMP , (IMARKER3 + 1) ) ) ; 
                                                                                                            __context__.SourceCodeLine = 501;
                                                                                                            IMARKER5 = (ushort) ( Functions.Find( "\u0000" , STEMP , (IMARKER4 + 1) ) ) ; 
                                                                                                            __context__.SourceCodeLine = 502;
                                                                                                            TOP_TITLE_TEXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 7 ) ,  (int) ( (IMARKER1 - 7) ) )  ) ; 
                                                                                                            __context__.SourceCodeLine = 503;
                                                                                                            POPUP_TITLE_TEXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER1 + 1) ) ,  (int) ( (IMARKER2 - (IMARKER1 + 1)) ) )  ) ; 
                                                                                                            __context__.SourceCodeLine = 504;
                                                                                                            POPUP_MESSAGE_TEXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER2 + 1) ) ,  (int) ( (IMARKER3 - (IMARKER2 + 1)) ) )  ) ; 
                                                                                                            __context__.SourceCodeLine = 505;
                                                                                                            ICURSORPOINTER = (ushort) ( (IMARKER3 + 1) ) ; 
                                                                                                            __context__.SourceCodeLine = 506;
                                                                                                            ICURSOR = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( (IMARKER3 + 1) ) , (int)( 1 ) ) ) ) ; 
                                                                                                            __context__.SourceCodeLine = 507;
                                                                                                            
                                                                                                                {
                                                                                                                int __SPLS_TMPVAR__SWTCH_2__ = ((int)ICURSOR);
                                                                                                                
                                                                                                                    { 
                                                                                                                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 0) ) ) ) 
                                                                                                                        { 
                                                                                                                        __context__.SourceCodeLine = 511;
                                                                                                                        BUTTON_1_HIGHLIGHTED  .Value = (ushort) ( 0 ) ; 
                                                                                                                        __context__.SourceCodeLine = 512;
                                                                                                                        BUTTON_2_HIGHLIGHTED  .Value = (ushort) ( 0 ) ; 
                                                                                                                        } 
                                                                                                                    
                                                                                                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 1) ) ) ) 
                                                                                                                        { 
                                                                                                                        __context__.SourceCodeLine = 516;
                                                                                                                        BUTTON_2_HIGHLIGHTED  .Value = (ushort) ( 0 ) ; 
                                                                                                                        __context__.SourceCodeLine = 517;
                                                                                                                        BUTTON_1_HIGHLIGHTED  .Value = (ushort) ( 1 ) ; 
                                                                                                                        } 
                                                                                                                    
                                                                                                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 2) ) ) ) 
                                                                                                                        { 
                                                                                                                        __context__.SourceCodeLine = 521;
                                                                                                                        BUTTON_1_HIGHLIGHTED  .Value = (ushort) ( 0 ) ; 
                                                                                                                        __context__.SourceCodeLine = 522;
                                                                                                                        BUTTON_2_HIGHLIGHTED  .Value = (ushort) ( 1 ) ; 
                                                                                                                        } 
                                                                                                                    
                                                                                                                    } 
                                                                                                                    
                                                                                                                }
                                                                                                                
                                                                                                            
                                                                                                            __context__.SourceCodeLine = 525;
                                                                                                            BUTTON_1_TEXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER3 + 2) ) ,  (int) ( (IMARKER4 - (IMARKER3 + 2)) ) )  ) ; 
                                                                                                            __context__.SourceCodeLine = 526;
                                                                                                            BUTTON_2_TEXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER4 + 1) ) ,  (int) ( (IMARKER5 - (IMARKER4 + 1)) ) )  ) ; 
                                                                                                            } 
                                                                                                        
                                                                                                        else 
                                                                                                            {
                                                                                                            __context__.SourceCodeLine = 528;
                                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SDISPLAYTYPE == "L"))  ) ) 
                                                                                                                { 
                                                                                                                __context__.SourceCodeLine = 532;
                                                                                                                IMARKER1 = (ushort) ( Functions.Find( "\u0000" , STEMP ) ) ; 
                                                                                                                __context__.SourceCodeLine = 533;
                                                                                                                IMARKER2 = (ushort) ( Functions.Find( "\u0000" , STEMP , (IMARKER1 + 1) ) ) ; 
                                                                                                                __context__.SourceCodeLine = 534;
                                                                                                                IMARKER3 = (ushort) ( Functions.Find( "\u0000" , STEMP , (IMARKER2 + 1) ) ) ; 
                                                                                                                __context__.SourceCodeLine = 535;
                                                                                                                IMARKER4 = (ushort) ( Functions.Find( "\u0000" , STEMP , (IMARKER3 + 1) ) ) ; 
                                                                                                                __context__.SourceCodeLine = 536;
                                                                                                                IMARKER5 = (ushort) ( Functions.Find( "\u0000" , STEMP , (IMARKER4 + 1) ) ) ; 
                                                                                                                __context__.SourceCodeLine = 537;
                                                                                                                IMARKER6 = (ushort) ( Functions.Find( "\u0000" , STEMP , (IMARKER5 + 1) ) ) ; 
                                                                                                                __context__.SourceCodeLine = 538;
                                                                                                                IMARKER7 = (ushort) ( Functions.Find( "\u0000" , STEMP , (IMARKER6 + 1) ) ) ; 
                                                                                                                __context__.SourceCodeLine = 539;
                                                                                                                IMARKER8 = (ushort) ( Functions.Find( "\u0000" , STEMP , (IMARKER7 + 1) ) ) ; 
                                                                                                                __context__.SourceCodeLine = 540;
                                                                                                                IMARKER9 = (ushort) ( Functions.Find( "\u0000" , STEMP , (IMARKER8 + 1) ) ) ; 
                                                                                                                __context__.SourceCodeLine = 541;
                                                                                                                IMARKER10 = (ushort) ( Functions.Find( "\u0000" , STEMP , (IMARKER9 + 1) ) ) ; 
                                                                                                                __context__.SourceCodeLine = 542;
                                                                                                                IMARKER11 = (ushort) ( Functions.Find( "\u0000" , STEMP , (IMARKER10 + 1) ) ) ; 
                                                                                                                __context__.SourceCodeLine = 543;
                                                                                                                IMARKER12 = (ushort) ( Functions.Find( "\u0000" , STEMP , (IMARKER11 + 1) ) ) ; 
                                                                                                                __context__.SourceCodeLine = 544;
                                                                                                                IMARKER13 = (ushort) ( Functions.Find( "\u0000" , STEMP , (IMARKER12 + 1) ) ) ; 
                                                                                                                __context__.SourceCodeLine = 545;
                                                                                                                IMARKER14 = (ushort) ( Functions.Find( "\u0000" , STEMP , (IMARKER13 + 1) ) ) ; 
                                                                                                                __context__.SourceCodeLine = 546;
                                                                                                                IMARKER15 = (ushort) ( Functions.Find( "\u0000" , STEMP , (IMARKER14 + 1) ) ) ; 
                                                                                                                __context__.SourceCodeLine = 547;
                                                                                                                TOP_TITLE_TEXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 7 ) ,  (int) ( (IMARKER1 - 7) ) )  ) ; 
                                                                                                                __context__.SourceCodeLine = 548;
                                                                                                                ITEM_TITLE_1_TEXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER1 + 1) ) ,  (int) ( (IMARKER2 - (IMARKER1 + 1)) ) )  ) ; 
                                                                                                                __context__.SourceCodeLine = 549;
                                                                                                                ITEM_PARAMETER_1_TEXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER2 + 1) ) ,  (int) ( (IMARKER3 - (IMARKER2 + 1)) ) )  ) ; 
                                                                                                                __context__.SourceCodeLine = 550;
                                                                                                                ITEM_TITLE_2_TEXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER3 + 1) ) ,  (int) ( (IMARKER4 - (IMARKER3 + 1)) ) )  ) ; 
                                                                                                                __context__.SourceCodeLine = 551;
                                                                                                                ITEM_PARAMETER_2_TEXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER4 + 1) ) ,  (int) ( (IMARKER5 - (IMARKER4 + 1)) ) )  ) ; 
                                                                                                                __context__.SourceCodeLine = 552;
                                                                                                                ITEM_TITLE_3_TEXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER1 + 1) ) ,  (int) ( (IMARKER6 - (IMARKER5 + 1)) ) )  ) ; 
                                                                                                                __context__.SourceCodeLine = 553;
                                                                                                                ITEM_PARAMETER_3_TEXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER1 + 1) ) ,  (int) ( (IMARKER7 - (IMARKER6 + 1)) ) )  ) ; 
                                                                                                                __context__.SourceCodeLine = 554;
                                                                                                                ITEM_TITLE_4_TEXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER1 + 1) ) ,  (int) ( (IMARKER8 - (IMARKER7 + 1)) ) )  ) ; 
                                                                                                                __context__.SourceCodeLine = 555;
                                                                                                                ITEM_PARAMETER_4_TEXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER1 + 1) ) ,  (int) ( (IMARKER9 - (IMARKER8 + 1)) ) )  ) ; 
                                                                                                                __context__.SourceCodeLine = 556;
                                                                                                                ITEM_TITLE_5_TEXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER1 + 1) ) ,  (int) ( (IMARKER10 - (IMARKER9 + 1)) ) )  ) ; 
                                                                                                                __context__.SourceCodeLine = 557;
                                                                                                                ITEM_PARAMETER_5_TEXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER1 + 1) ) ,  (int) ( (IMARKER11 - (IMARKER10 + 1)) ) )  ) ; 
                                                                                                                __context__.SourceCodeLine = 558;
                                                                                                                ITEM_TITLE_6_TEXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER1 + 1) ) ,  (int) ( (IMARKER12 - (IMARKER11 + 1)) ) )  ) ; 
                                                                                                                __context__.SourceCodeLine = 559;
                                                                                                                ITEM_PARAMETER_6_TEXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER1 + 1) ) ,  (int) ( (IMARKER13 - (IMARKER12 + 1)) ) )  ) ; 
                                                                                                                __context__.SourceCodeLine = 560;
                                                                                                                ICURSORPOINTER = (ushort) ( (IMARKER13 + 1) ) ; 
                                                                                                                __context__.SourceCodeLine = 561;
                                                                                                                ICURSOR = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( (IMARKER13 + 1) ) , (int)( 1 ) ) ) ) ; 
                                                                                                                __context__.SourceCodeLine = 562;
                                                                                                                
                                                                                                                    {
                                                                                                                    int __SPLS_TMPVAR__SWTCH_3__ = ((int)ICURSOR);
                                                                                                                    
                                                                                                                        { 
                                                                                                                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 0) ) ) ) 
                                                                                                                            { 
                                                                                                                            __context__.SourceCodeLine = 566;
                                                                                                                            BUTTON_1_HIGHLIGHTED  .Value = (ushort) ( 0 ) ; 
                                                                                                                            __context__.SourceCodeLine = 567;
                                                                                                                            BUTTON_2_HIGHLIGHTED  .Value = (ushort) ( 0 ) ; 
                                                                                                                            } 
                                                                                                                        
                                                                                                                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 1) ) ) ) 
                                                                                                                            { 
                                                                                                                            __context__.SourceCodeLine = 571;
                                                                                                                            BUTTON_2_HIGHLIGHTED  .Value = (ushort) ( 0 ) ; 
                                                                                                                            __context__.SourceCodeLine = 572;
                                                                                                                            BUTTON_1_HIGHLIGHTED  .Value = (ushort) ( 1 ) ; 
                                                                                                                            } 
                                                                                                                        
                                                                                                                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 2) ) ) ) 
                                                                                                                            { 
                                                                                                                            __context__.SourceCodeLine = 576;
                                                                                                                            BUTTON_1_HIGHLIGHTED  .Value = (ushort) ( 0 ) ; 
                                                                                                                            __context__.SourceCodeLine = 577;
                                                                                                                            BUTTON_2_HIGHLIGHTED  .Value = (ushort) ( 1 ) ; 
                                                                                                                            } 
                                                                                                                        
                                                                                                                        } 
                                                                                                                        
                                                                                                                    }
                                                                                                                    
                                                                                                                
                                                                                                                __context__.SourceCodeLine = 580;
                                                                                                                BUTTON_1_TEXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER13 + 2) ) ,  (int) ( (IMARKER14 - (IMARKER13 + 2)) ) )  ) ; 
                                                                                                                __context__.SourceCodeLine = 581;
                                                                                                                BUTTON_2_TEXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER14 + 1) ) ,  (int) ( (IMARKER15 - (IMARKER14 + 1)) ) )  ) ; 
                                                                                                                } 
                                                                                                            
                                                                                                            }
                                                                                                        
                                                                                                        }
                                                                                                    
                                                                                                    } 
                                                                                                
                                                                                                }
                                                                                            
                                                                                            }
                                                                                        
                                                                                        }
                                                                                    
                                                                                    }
                                                                                
                                                                                }
                                                                            
                                                                            }
                                                                        
                                                                        }
                                                                    
                                                                    }
                                                                
                                                                }
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                } 
            
            __context__.SourceCodeLine = 130;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DELIMITER_TYPE_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 590;
        switch ((int)DELIMITER_TYPE  .UshortValue)
        
            { 
            case 1 : 
            
                { 
                __context__.SourceCodeLine = 592;
                SDELIMITER  .UpdateValue ( "\u001A"  ) ; 
                __context__.SourceCodeLine = 592;
                break ; 
                } 
            
            goto case 2 ;
            case 2 : 
            
                { 
                __context__.SourceCodeLine = 593;
                SDELIMITER  .UpdateValue ( "\u001A\u000D"  ) ; 
                __context__.SourceCodeLine = 593;
                break ; 
                } 
            
            goto case 3 ;
            case 3 : 
            
                { 
                __context__.SourceCodeLine = 594;
                SDELIMITER  .UpdateValue ( "\u001A\u000D\u000A"  ) ; 
                __context__.SourceCodeLine = 594;
                break ; 
                } 
            
            break;
            } 
            
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 604;
        IFLAG1 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 605;
        STEMP  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 606;
        STEMP1  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 607;
        ITEMP = (ushort) ( 100 ) ; 
        __context__.SourceCodeLine = 608;
        INETDELAY = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5000, this );
    STEMP1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    STUNER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 24, this );
    STUNERZONE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 24, this );
    STUNER3  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 24, this );
    STUNER4  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 24, this );
    SNATARTIST  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 70, this );
    SNATALBUM  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 70, this );
    SNATTITLE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 70, this );
    SNATTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 70, this );
    SNATPLAY  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
    SNATREPEAT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
    SNATSHUFFLE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
    SNATTRACK  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 70, this );
    STEMPCMD  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 25, this );
    SDISPLAYTYPE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
    STEMP2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
    SDELIMITER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    SLINETEXT  = new CrestronString[ 11 ];
    for( uint i = 0; i < 11; i++ )
        SLINETEXT [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 70, this );
    
    NET_FF_REW_PUSHED = new Crestron.Logos.SplusObjects.DigitalInput( NET_FF_REW_PUSHED__DigitalInput__, this );
    m_DigitalInputList.Add( NET_FF_REW_PUSHED__DigitalInput__, NET_FF_REW_PUSHED );
    
    SEND_KEYBOARD = new Crestron.Logos.SplusObjects.DigitalInput( SEND_KEYBOARD__DigitalInput__, this );
    m_DigitalInputList.Add( SEND_KEYBOARD__DigitalInput__, SEND_KEYBOARD );
    
    PROCESS_FROM_DEVICE = new Crestron.Logos.SplusObjects.DigitalInput( PROCESS_FROM_DEVICE__DigitalInput__, this );
    m_DigitalInputList.Add( PROCESS_FROM_DEVICE__DigitalInput__, PROCESS_FROM_DEVICE );
    
    BUTTON_1_HIGHLIGHTED = new Crestron.Logos.SplusObjects.DigitalOutput( BUTTON_1_HIGHLIGHTED__DigitalOutput__, this );
    m_DigitalOutputList.Add( BUTTON_1_HIGHLIGHTED__DigitalOutput__, BUTTON_1_HIGHLIGHTED );
    
    BUTTON_2_HIGHLIGHTED = new Crestron.Logos.SplusObjects.DigitalOutput( BUTTON_2_HIGHLIGHTED__DigitalOutput__, this );
    m_DigitalOutputList.Add( BUTTON_2_HIGHLIGHTED__DigitalOutput__, BUTTON_2_HIGHLIGHTED );
    
    NET_CURSOR_POSITION_LINE = new InOutArray<DigitalOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        NET_CURSOR_POSITION_LINE[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( NET_CURSOR_POSITION_LINE__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( NET_CURSOR_POSITION_LINE__DigitalOutput__ + i, NET_CURSOR_POSITION_LINE[i+1] );
    }
    
    TUNER_BAND_IN = new Crestron.Logos.SplusObjects.AnalogInput( TUNER_BAND_IN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( TUNER_BAND_IN__AnalogSerialInput__, TUNER_BAND_IN );
    
    DELIMITER_TYPE = new Crestron.Logos.SplusObjects.AnalogInput( DELIMITER_TYPE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( DELIMITER_TYPE__AnalogSerialInput__, DELIMITER_TYPE );
    
    SLEEP_TIME = new Crestron.Logos.SplusObjects.AnalogOutput( SLEEP_TIME__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SLEEP_TIME__AnalogSerialOutput__, SLEEP_TIME );
    
    MAIN_VOLUME_IN = new Crestron.Logos.SplusObjects.AnalogOutput( MAIN_VOLUME_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MAIN_VOLUME_IN__AnalogSerialOutput__, MAIN_VOLUME_IN );
    
    ZONE_2_VOLUME_IN = new Crestron.Logos.SplusObjects.AnalogOutput( ZONE_2_VOLUME_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZONE_2_VOLUME_IN__AnalogSerialOutput__, ZONE_2_VOLUME_IN );
    
    ZONE_3_VOLUME_IN = new Crestron.Logos.SplusObjects.AnalogOutput( ZONE_3_VOLUME_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZONE_3_VOLUME_IN__AnalogSerialOutput__, ZONE_3_VOLUME_IN );
    
    ZONE_4_VOLUME_IN = new Crestron.Logos.SplusObjects.AnalogOutput( ZONE_4_VOLUME_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZONE_4_VOLUME_IN__AnalogSerialOutput__, ZONE_4_VOLUME_IN );
    
    KEYBOARD_INPUT_TEXT = new Crestron.Logos.SplusObjects.StringInput( KEYBOARD_INPUT_TEXT__AnalogSerialInput__, 128, this );
    m_StringInputList.Add( KEYBOARD_INPUT_TEXT__AnalogSerialInput__, KEYBOARD_INPUT_TEXT );
    
    TUNER_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, TUNER_FREQUENCY__DOLLAR__ );
    
    TUNER_ZONE_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TUNER_ZONE_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TUNER_ZONE_FREQUENCY__DOLLAR____AnalogSerialOutput__, TUNER_ZONE_FREQUENCY__DOLLAR__ );
    
    TUNER_ZONE_3_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TUNER_ZONE_3_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TUNER_ZONE_3_FREQUENCY__DOLLAR____AnalogSerialOutput__, TUNER_ZONE_3_FREQUENCY__DOLLAR__ );
    
    TUNER_ZONE_4_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TUNER_ZONE_4_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TUNER_ZONE_4_FREQUENCY__DOLLAR____AnalogSerialOutput__, TUNER_ZONE_4_FREQUENCY__DOLLAR__ );
    
    NAT_ARTIST__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NAT_ARTIST__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAT_ARTIST__DOLLAR____AnalogSerialOutput__, NAT_ARTIST__DOLLAR__ );
    
    NAT_ALBUM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NAT_ALBUM__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAT_ALBUM__DOLLAR____AnalogSerialOutput__, NAT_ALBUM__DOLLAR__ );
    
    NAT_TITLE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NAT_TITLE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAT_TITLE__DOLLAR____AnalogSerialOutput__, NAT_TITLE__DOLLAR__ );
    
    NAT_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NAT_TIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAT_TIME__DOLLAR____AnalogSerialOutput__, NAT_TIME__DOLLAR__ );
    
    NAT_PLAY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NAT_PLAY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAT_PLAY__DOLLAR____AnalogSerialOutput__, NAT_PLAY__DOLLAR__ );
    
    NAT_REPEAT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NAT_REPEAT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAT_REPEAT__DOLLAR____AnalogSerialOutput__, NAT_REPEAT__DOLLAR__ );
    
    NAT_SHUFFLE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NAT_SHUFFLE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAT_SHUFFLE__DOLLAR____AnalogSerialOutput__, NAT_SHUFFLE__DOLLAR__ );
    
    NAT_TRACK__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NAT_TRACK__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAT_TRACK__DOLLAR____AnalogSerialOutput__, NAT_TRACK__DOLLAR__ );
    
    POPUP_TYPE_VALUE = new Crestron.Logos.SplusObjects.StringOutput( POPUP_TYPE_VALUE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( POPUP_TYPE_VALUE__AnalogSerialOutput__, POPUP_TYPE_VALUE );
    
    TOP_TITLE_TEXT = new Crestron.Logos.SplusObjects.StringOutput( TOP_TITLE_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TOP_TITLE_TEXT__AnalogSerialOutput__, TOP_TITLE_TEXT );
    
    POPUP_TITLE_TEXT = new Crestron.Logos.SplusObjects.StringOutput( POPUP_TITLE_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( POPUP_TITLE_TEXT__AnalogSerialOutput__, POPUP_TITLE_TEXT );
    
    POPUP_MESSAGE_TEXT = new Crestron.Logos.SplusObjects.StringOutput( POPUP_MESSAGE_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( POPUP_MESSAGE_TEXT__AnalogSerialOutput__, POPUP_MESSAGE_TEXT );
    
    ITEM_TITLE_1_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ITEM_TITLE_1_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ITEM_TITLE_1_TEXT__AnalogSerialOutput__, ITEM_TITLE_1_TEXT );
    
    ITEM_PARAMETER_1_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ITEM_PARAMETER_1_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ITEM_PARAMETER_1_TEXT__AnalogSerialOutput__, ITEM_PARAMETER_1_TEXT );
    
    ITEM_TITLE_2_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ITEM_TITLE_2_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ITEM_TITLE_2_TEXT__AnalogSerialOutput__, ITEM_TITLE_2_TEXT );
    
    ITEM_PARAMETER_2_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ITEM_PARAMETER_2_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ITEM_PARAMETER_2_TEXT__AnalogSerialOutput__, ITEM_PARAMETER_2_TEXT );
    
    ITEM_TITLE_3_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ITEM_TITLE_3_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ITEM_TITLE_3_TEXT__AnalogSerialOutput__, ITEM_TITLE_3_TEXT );
    
    ITEM_PARAMETER_3_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ITEM_PARAMETER_3_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ITEM_PARAMETER_3_TEXT__AnalogSerialOutput__, ITEM_PARAMETER_3_TEXT );
    
    ITEM_TITLE_4_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ITEM_TITLE_4_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ITEM_TITLE_4_TEXT__AnalogSerialOutput__, ITEM_TITLE_4_TEXT );
    
    ITEM_PARAMETER_4_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ITEM_PARAMETER_4_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ITEM_PARAMETER_4_TEXT__AnalogSerialOutput__, ITEM_PARAMETER_4_TEXT );
    
    ITEM_TITLE_5_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ITEM_TITLE_5_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ITEM_TITLE_5_TEXT__AnalogSerialOutput__, ITEM_TITLE_5_TEXT );
    
    ITEM_PARAMETER_5_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ITEM_PARAMETER_5_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ITEM_PARAMETER_5_TEXT__AnalogSerialOutput__, ITEM_PARAMETER_5_TEXT );
    
    ITEM_TITLE_6_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ITEM_TITLE_6_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ITEM_TITLE_6_TEXT__AnalogSerialOutput__, ITEM_TITLE_6_TEXT );
    
    ITEM_PARAMETER_6_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ITEM_PARAMETER_6_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ITEM_PARAMETER_6_TEXT__AnalogSerialOutput__, ITEM_PARAMETER_6_TEXT );
    
    BUTTON_1_TEXT = new Crestron.Logos.SplusObjects.StringOutput( BUTTON_1_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( BUTTON_1_TEXT__AnalogSerialOutput__, BUTTON_1_TEXT );
    
    BUTTON_2_TEXT = new Crestron.Logos.SplusObjects.StringOutput( BUTTON_2_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( BUTTON_2_TEXT__AnalogSerialOutput__, BUTTON_2_TEXT );
    
    TO_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_DEVICE__DOLLAR____AnalogSerialOutput__, TO_DEVICE__DOLLAR__ );
    
    NET_LINE_TEXT = new InOutArray<StringOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        NET_LINE_TEXT[i+1] = new Crestron.Logos.SplusObjects.StringOutput( NET_LINE_TEXT__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( NET_LINE_TEXT__AnalogSerialOutput__ + i, NET_LINE_TEXT[i+1] );
    }
    
    FROM_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_DEVICE__DOLLAR____AnalogSerialInput__, 65000, this );
    m_StringInputList.Add( FROM_DEVICE__DOLLAR____AnalogSerialInput__, FROM_DEVICE__DOLLAR__ );
    
    WNETDELAY_Callback = new WaitFunction( WNETDELAY_CallbackFn );
    
    SEND_KEYBOARD.OnDigitalPush.Add( new InputChangeHandlerWrapper( SEND_KEYBOARD_OnPush_0, false ) );
    NET_FF_REW_PUSHED.OnDigitalRelease.Add( new InputChangeHandlerWrapper( NET_FF_REW_PUSHED_OnRelease_1, false ) );
    NET_FF_REW_PUSHED.OnDigitalPush.Add( new InputChangeHandlerWrapper( NET_FF_REW_PUSHED_OnPush_2, false ) );
    FROM_DEVICE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_DEVICE__DOLLAR___OnChange_3, true ) );
    DELIMITER_TYPE.OnAnalogChange.Add( new InputChangeHandlerWrapper( DELIMITER_TYPE_OnChange_4, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_INTEGRA_DTR_70_4_IP_V1_1_FEEDBACK ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction WNETDELAY_Callback;


const uint NET_FF_REW_PUSHED__DigitalInput__ = 0;
const uint SEND_KEYBOARD__DigitalInput__ = 1;
const uint PROCESS_FROM_DEVICE__DigitalInput__ = 2;
const uint TUNER_BAND_IN__AnalogSerialInput__ = 0;
const uint DELIMITER_TYPE__AnalogSerialInput__ = 1;
const uint KEYBOARD_INPUT_TEXT__AnalogSerialInput__ = 2;
const uint FROM_DEVICE__DOLLAR____AnalogSerialInput__ = 3;
const uint BUTTON_1_HIGHLIGHTED__DigitalOutput__ = 0;
const uint BUTTON_2_HIGHLIGHTED__DigitalOutput__ = 1;
const uint SLEEP_TIME__AnalogSerialOutput__ = 0;
const uint MAIN_VOLUME_IN__AnalogSerialOutput__ = 1;
const uint ZONE_2_VOLUME_IN__AnalogSerialOutput__ = 2;
const uint ZONE_3_VOLUME_IN__AnalogSerialOutput__ = 3;
const uint ZONE_4_VOLUME_IN__AnalogSerialOutput__ = 4;
const uint TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 5;
const uint TUNER_ZONE_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 6;
const uint TUNER_ZONE_3_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 7;
const uint TUNER_ZONE_4_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 8;
const uint NAT_ARTIST__DOLLAR____AnalogSerialOutput__ = 9;
const uint NAT_ALBUM__DOLLAR____AnalogSerialOutput__ = 10;
const uint NAT_TITLE__DOLLAR____AnalogSerialOutput__ = 11;
const uint NAT_TIME__DOLLAR____AnalogSerialOutput__ = 12;
const uint NAT_PLAY__DOLLAR____AnalogSerialOutput__ = 13;
const uint NAT_REPEAT__DOLLAR____AnalogSerialOutput__ = 14;
const uint NAT_SHUFFLE__DOLLAR____AnalogSerialOutput__ = 15;
const uint NAT_TRACK__DOLLAR____AnalogSerialOutput__ = 16;
const uint POPUP_TYPE_VALUE__AnalogSerialOutput__ = 17;
const uint TOP_TITLE_TEXT__AnalogSerialOutput__ = 18;
const uint POPUP_TITLE_TEXT__AnalogSerialOutput__ = 19;
const uint POPUP_MESSAGE_TEXT__AnalogSerialOutput__ = 20;
const uint ITEM_TITLE_1_TEXT__AnalogSerialOutput__ = 21;
const uint ITEM_PARAMETER_1_TEXT__AnalogSerialOutput__ = 22;
const uint ITEM_TITLE_2_TEXT__AnalogSerialOutput__ = 23;
const uint ITEM_PARAMETER_2_TEXT__AnalogSerialOutput__ = 24;
const uint ITEM_TITLE_3_TEXT__AnalogSerialOutput__ = 25;
const uint ITEM_PARAMETER_3_TEXT__AnalogSerialOutput__ = 26;
const uint ITEM_TITLE_4_TEXT__AnalogSerialOutput__ = 27;
const uint ITEM_PARAMETER_4_TEXT__AnalogSerialOutput__ = 28;
const uint ITEM_TITLE_5_TEXT__AnalogSerialOutput__ = 29;
const uint ITEM_PARAMETER_5_TEXT__AnalogSerialOutput__ = 30;
const uint ITEM_TITLE_6_TEXT__AnalogSerialOutput__ = 31;
const uint ITEM_PARAMETER_6_TEXT__AnalogSerialOutput__ = 32;
const uint BUTTON_1_TEXT__AnalogSerialOutput__ = 33;
const uint BUTTON_2_TEXT__AnalogSerialOutput__ = 34;
const uint TO_DEVICE__DOLLAR____AnalogSerialOutput__ = 35;
const uint NET_CURSOR_POSITION_LINE__DigitalOutput__ = 2;
const uint NET_LINE_TEXT__AnalogSerialOutput__ = 36;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
