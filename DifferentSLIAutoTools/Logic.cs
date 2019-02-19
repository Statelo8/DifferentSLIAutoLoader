using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DifferentSLIAutoTools
{
    class Logic
    {
        public static void NoGui()
        {
            LoadDriver();
            dsefix(true);
        }
        public static void LoadDriver()
        {
            Process s = new Process();
            s.StartInfo.FileName = System.AppDomain.CurrentDomain.BaseDirectory + "shark\\Sea.exe";
            s.StartInfo.Verb = "runas";
            s.Start();
            s.WaitForExit();
            Thread.Sleep(1000);
            dsefix(false);
            ManagementObjectSearcher searcher =
             new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            foreach (ManagementObject mo in searcher.Get())
            {
                PropertyData name = mo.Properties["Description"];
                Process devManViewProc = new Process();
                devManViewProc.StartInfo.FileName = System.AppDomain.CurrentDomain.BaseDirectory + "devmanview\\DevManView.exe";
                devManViewProc.StartInfo.Arguments = "/disable_enable \"" + name.Value + "\"";
                devManViewProc.StartInfo.Verb = "runas";
                devManViewProc.Start();
                devManViewProc.WaitForExit();
            }
        }
        public static void dsefix(bool withArgument)
        {
            Process de = new Process();
            de.StartInfo.FileName = System.AppDomain.CurrentDomain.BaseDirectory + "dsefix\\dsefix.exe";
            if (withArgument) de.StartInfo.Arguments = "-e";
            de.StartInfo.Verb = "runas";
            de.Start();
            de.WaitForExit();
        }
    }
}
