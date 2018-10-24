using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RT_Viewer.Framework
{
    abstract public class IModule
    {
        //members
        public SocketHandler.enumDevice_id deviceIdConnected; // connected to RTC1 or RTC2

        public delegate void IModuleHandler(object sender, IModuleEventArgs args); //will be invoked when update
        public event IModuleHandler ModuleEvent;


        //method
        public IModule()
        {
            
        }

        public abstract bool update(byte[] msg, uint size, uint type,uint source); // will implement in the module

        /* this method will called invoke to the inherited object*/
        protected virtual void DoInvoke(IModuleEventArgs e)
        {
            IModuleHandler handler = ModuleEvent;
            if (handler != null)
            {
                handler(this, e);
            }
        }


    }

    public class IModuleEventArgs : EventArgs
    {
        public SocketHandler.enumDevice_id device_id { get; set; }
        public IModuleEventArgs(SocketHandler.enumDevice_id deviceID)
        {
            this.device_id = deviceID;
        }
    }

}
