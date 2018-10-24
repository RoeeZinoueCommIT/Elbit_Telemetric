using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace RT_Viewer.Framework
{
    public class NVMModule : IModule
    {

        public struct ReadNVRAMStruct
        {
            public uint gcs_id;
        }



        public ReadNVRAMStruct nvramData;
        public int timeElapsedSinceRequest; // for loading icon when request to burn nvram (time elapsed in second)
        public bool isWritingRequested;
        public NVMModule(SocketHandler.enumDevice_id deviceID)
        {
            deviceIdConnected = deviceID;
            timeElapsedSinceRequest = 0;
            isWritingRequested = false;
        }

        public override bool update(byte[] msg, uint size, uint type, uint source)
        {
            int length;
            IntPtr ptr;

            length = Marshal.SizeOf(nvramData);
            ptr = Marshal.AllocHGlobal(length);
            Marshal.Copy(msg, 0, ptr, length);
            nvramData = (ReadNVRAMStruct)Marshal.PtrToStructure(ptr, nvramData.GetType());
            Marshal.FreeHGlobal(ptr);

            DoInvoke(new IModuleEventArgs(this.deviceIdConnected));
            return true;
        }

    }
}
