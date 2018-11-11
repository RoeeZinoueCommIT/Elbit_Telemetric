using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Globalization;

namespace RT_Viewer.Framework
{
    public class NTPModule : IModule
    {
        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        public struct NTPStruct
        {
            public UInt64 timestamp;
            public uint isNTPServerConnected;
            public uint server_addr;
            public uint server_port;
        }


        public NTPStruct ntpStruct;
        public string utcTime;
        public const UInt64 C_NTP_PERIOD_1970_TO_2000 = 946684800U;

        public NTPModule(SocketHandler.enumDevice_id deviceID)
        {
            ntpStruct = new NTPStruct();
            deviceIdConnected = deviceID;
    
            utcTime = "N\\A";
            ntpStruct.isNTPServerConnected = 0;
            ntpStruct.timestamp   = 0;
            ntpStruct.server_addr = 0;
            ntpStruct.server_port = 0;
        }


        public override bool update(byte[] msg, uint size, uint type, uint source)
        {
            int length;
            IntPtr ptr;

            length = Marshal.SizeOf(typeof(NTPStruct));
            ptr = Marshal.AllocHGlobal(length);
            Marshal.Copy(msg, 0, ptr, length);
            NTPStruct tempNTPBlock = (NTPStruct)Marshal.PtrToStructure(ptr, ntpStruct.GetType());
            Marshal.FreeHGlobal(ptr);

            ntpStruct.timestamp             = tempNTPBlock.timestamp;
            ntpStruct.isNTPServerConnected  = tempNTPBlock.isNTPServerConnected;
            ntpStruct.server_addr           = tempNTPBlock.server_addr;
            ntpStruct.server_port           = tempNTPBlock.server_port;

            UInt64 unixTimestamp2000 = ntpStruct.timestamp / 1000; // convert to second
            DateTime Unix2000 = new DateTime(2000, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc); // reference time from 1/1/2000
            Unix2000 = Unix2000.AddSeconds(unixTimestamp2000);
            TimeZone localZone = TimeZone.CurrentTimeZone;
            DateTime currentUTC = localZone.ToLocalTime(Unix2000); // Fix time by TimeZone

            //utcTime = currentUTC.ToString();

            utcTime = convertTimeStampToUtc(ntpStruct.timestamp);
            if (ntpStruct.isNTPServerConnected == 0)
            {
              utcTime = "N\\A";
            }

            DoInvoke(new IModuleEventArgs(this.deviceIdConnected));
            
            return true;
        }

        /* getting a timeStamp from 1/1/2000 in milisecound and return UTC time*/
        public static string convertTimeStampToUtc(UInt64 timeStamp)
        {
            UInt64 unixTimestamp2000 = timeStamp / 1000; // convert to second
            DateTime Unix2000 = new DateTime(2000, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc); // reference time from 1/1/2000
            if (unixTimestamp2000 > int.MaxValue)
            {
                return "Unvalid UTC";
            }
            Unix2000 = Unix2000.AddSeconds(unixTimestamp2000);
            TimeZone localZone = TimeZone.CurrentTimeZone;
            DateTime currentUTC = localZone.ToLocalTime(Unix2000); // Fix time by TimeZone
            return currentUTC.ToString();
        }
        public static string getIPStringFromInt(uint ip)
        {
            string result = BitConverter.GetBytes(ip)[0] + "." + BitConverter.GetBytes(ip)[1] + "." + BitConverter.GetBytes(ip)[2] + "." + BitConverter.GetBytes(ip)[3];
            return result;
        }
        public static string getIPStringFromInt(int ip)
        {
            string result = BitConverter.GetBytes(ip)[0] + "." + BitConverter.GetBytes(ip)[1] + "." + BitConverter.GetBytes(ip)[2] + "." + BitConverter.GetBytes(ip)[3];
            return result;
        }


    }
}
