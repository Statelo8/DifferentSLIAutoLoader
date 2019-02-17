using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Threading;
using System.Diagnostics;

namespace DifferentSLIAutoTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process de = new Process();
            de.StartInfo.FileName = System.AppDomain.CurrentDomain.BaseDirectory + "dsefix\\dsefix.exe";
            de.StartInfo.Arguments = "-e";
            de.StartInfo.Verb = "runas";
            de.Start();
            de.WaitForExit();
        }
    }
}
