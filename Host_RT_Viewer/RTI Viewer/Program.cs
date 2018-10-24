using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace RT_Viewer
{
    static class Program
    {
        [DllImport("user32.dll")]
        public static extern bool ShowWindowAsync(HandleRef hWnd, int nCmdShow);
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        public const int SW_RESTORE = 9;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /* Only one instance of RT Viewer is Allowed in one computer*/
            Mutex mutex = new System.Threading.Mutex(false, "ViewerAppMtx");
            try
            {
                if (mutex.WaitOne(0, false))
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new RT_Viewer.Forms.SettingsForm()); 
                    Application.Run(new RTViewerForm()); 
                }
                else
                {
                    //MessageBox.Show("An instance of the RT Viewer application is already running.","RT Viewer Dialog");
                    SwitchToCurrent();
                    System.Environment.Exit(0);
                }
            }
            finally
            {
                if (mutex != null)
                {
                    mutex.Close();
                    mutex = null;
                }
            }

        }
        
        static void SwitchToCurrent()
        {
            IntPtr hWnd = IntPtr.Zero;
            Process process = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(process.ProcessName);
            foreach (Process _process in processes)
            {
                // Get the first instance that is not this instance, has the
                // same process name and was started from the same file name
                // and location. Also check that the process has a valid
                // window handle in this session to filter out other user's
                // processes.
                if (_process.Id != process.Id &&
                  //_process.MainModule.FileName == process.MainModule.FileName &&
                  _process.MainWindowHandle != IntPtr.Zero)
                {
                    hWnd = _process.MainWindowHandle;
                    ShowWindowAsync(new HandleRef(null, hWnd), SW_RESTORE);
                    SetForegroundWindow(hWnd);
                    break;
                }
            }
        }
    }
}
