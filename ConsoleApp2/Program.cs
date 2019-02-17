using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Management;
using System.Collections;
using System.Threading;
namespace DifferentSLIAutoLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            Process s = new Process();
            s.StartInfo.FileName = System.AppDomain.CurrentDomain.BaseDirectory + "shark\\Sea.exe";
            s.StartInfo.Verb = "runas";
            s.Start();
            s.WaitForExit();
            Thread.Sleep(1000);
            Process d = new Process();
            d.StartInfo.FileName = System.AppDomain.CurrentDomain.BaseDirectory + "dsefix\\dsefix.exe";
            d.StartInfo.Verb = "runas";
            d.Start();
            d.WaitForExit();
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
            Process de = new Process();
            de.StartInfo.FileName = System.AppDomain.CurrentDomain.BaseDirectory + "dsefix\\dsefix.exe";
            de.StartInfo.Arguments = "-e";
            de.StartInfo.Verb = "runas";
            de.Start();
            de.WaitForExit();
        }
    }
}
