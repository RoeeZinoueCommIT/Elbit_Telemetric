using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel;


namespace RT_Viewer.Framework
{
    public class HSTModule:IModule
    {

        public struct HSTStruct
        {
            public uint keepAliveState;
            public uint keepAliveRecievedCounter;
            public uint keepAliveSentCounter;

        }



        public HSTStruct hstStruct;
        public bool isKASentOK = false;
        public bool isKARecivedOK = false;
        public const int DELAY = 2;
        public int counterKAReceivedFailed = 0;
        public int counterKASentFailed = 0;

        public HSTModule(SocketHandler.enumDevice_id deviceID)
        {
            hstStruct = new HSTStruct();
            deviceIdConnected = deviceID;
        }

        public override bool update(byte[] msg, uint size, uint type, uint source)
        {
            int length;
            IntPtr ptr;
          
            length = Marshal.SizeOf(hstStruct);
            ptr = Marshal.AllocHGlobal(length);
            Marshal.Copy(msg, 0, ptr, length);
            HSTStruct tempHSTBlock = (HSTStruct)Marshal.PtrToStructure(ptr, hstStruct.GetType());
            Marshal.FreeHGlobal(ptr);

            if (tempHSTBlock.keepAliveSentCounter <= hstStruct.keepAliveSentCounter)
            {
                counterKASentFailed++;
            }
            else
            {
                counterKASentFailed = 0;
            }

            if (tempHSTBlock.keepAliveRecievedCounter <= hstStruct.keepAliveRecievedCounter)
            {
                counterKAReceivedFailed++;
            }
            else
            {
                counterKAReceivedFailed = 0;
            }

            if (counterKASentFailed > DELAY)
            {
                isKASentOK = false;
            }
            else
            {
                isKASentOK = true;
            }
            if (counterKAReceivedFailed > DELAY)
            {
                isKARecivedOK = false;
            }
            else
            {
                isKARecivedOK = true;
            }

            hstStruct.keepAliveState = tempHSTBlock.keepAliveState;
            hstStruct.keepAliveSentCounter = tempHSTBlock.keepAliveSentCounter;
            hstStruct.keepAliveRecievedCounter = tempHSTBlock.keepAliveRecievedCounter;

            DoInvoke(new IModuleEventArgs(this.deviceIdConnected));

            return true;
        }


    }

}
