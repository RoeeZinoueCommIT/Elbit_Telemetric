
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace RT_Viewer.Framework
{
    public class PFDMoudle : IModule
    {

        public struct PFDData
        {
            public uint pitch;
            public uint roll;

        }
        public PFDData pfdData;

        public PFDMoudle(SocketHandler.enumDevice_id deviceID)
        {
            deviceIdConnected = deviceID;
            pfdData = new PFDData();
        }

        public override bool update(byte[] msg, uint size, uint type, uint source)
        {
            
            int length;
            IntPtr ptr;
            length = Marshal.SizeOf(pfdData);
            ptr = Marshal.AllocHGlobal(length);
            Marshal.Copy(msg, 0, ptr, length);
            pfdData = (PFDData)Marshal.PtrToStructure(ptr, pfdData.GetType());
            Marshal.FreeHGlobal(ptr);
            DoInvoke(new IModuleEventArgs(this.deviceIdConnected));
            return true;
        }
    }
}


