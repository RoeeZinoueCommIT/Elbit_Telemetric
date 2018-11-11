using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace RT_Viewer.Framework
{
    public class APPModule:IModule
    {

        public struct APPStruct
        {

            public uint isRTCActive;
            public char[] RTCVersion;
            public char[] RTCBuildDate;
        }

        public string isRTCActive;
        public string RTCVersion;
        public string RTCBuildDate;
        public uint cpuUsage;
        public uint main_stack_usage;
        public uint log_stack_usage;
        public uint vtu_stack_usage;
        public uint pfd_stack_usage;
        public uint HBSVersionMajor;
        public uint HBSVersionMinor;
        public string rt1Ip;
        public string rt2Ip;
        public string rtDefaultGatway;
        public bool isRTAPPArrived = false;
        public APPStruct appStruct;

        public APPModule(SocketHandler.enumDevice_id deviceID)
        {
            appStruct = new APPStruct();
            deviceIdConnected = deviceID;
        }

        public override bool update(byte[] msg, uint size, uint type, uint source)
        {
           int indexReader = 0;

           uint isActiveInt = (uint) msg[0] | msg[1] | msg[2] | msg[3];
           indexReader += 4;
           RTCVersion = System.Text.Encoding.UTF8.GetString(msg, 4, 60).Replace("\0", string.Empty);
           indexReader += 60;
           RTCBuildDate = System.Text.Encoding.UTF8.GetString(msg, 64, 60).Replace("\0", string.Empty);
           indexReader += 60;

           cpuUsage = (uint)BitConverter.ToUInt32(msg, indexReader);
           indexReader += 4;
           main_stack_usage = (uint)BitConverter.ToUInt32(msg, indexReader);
           indexReader += 4;
           log_stack_usage = (uint)BitConverter.ToUInt32(msg, indexReader);
           indexReader += 4;
           vtu_stack_usage = (uint)BitConverter.ToUInt32(msg, indexReader);
           indexReader += 4;
           pfd_stack_usage = (uint)BitConverter.ToUInt32(msg, indexReader);
           indexReader += 4;
           if (isActiveInt == 1)
           {
               isRTCActive = "Active";
           }
           else
           {
               isRTCActive = "Passive";
           }
           HBSVersionMajor = (uint)BitConverter.ToUInt32(msg, indexReader);
           indexReader += 4;
           HBSVersionMinor = (uint)BitConverter.ToUInt32(msg, indexReader);
           indexReader += 4;
           /*RT1 IP*/

           rt1Ip = System.Text.Encoding.UTF8.GetString(msg, indexReader, 16).Replace("\0", string.Empty);
           indexReader += 16;
           /*RT2 IP*/
           rt2Ip = System.Text.Encoding.UTF8.GetString(msg, indexReader, 16).Replace("\0", string.Empty);
           indexReader += 16;
            /*Default gatway*/
           rtDefaultGatway = System.Text.Encoding.UTF8.GetString(msg, indexReader, 16).Replace("\0", string.Empty);
           indexReader += 16;
           isRTAPPArrived = true;
           DoInvoke(new IModuleEventArgs(this.deviceIdConnected));

           return true;
        }
    }
}
