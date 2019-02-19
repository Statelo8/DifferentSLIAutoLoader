using System;
using System.Windows.Forms;

namespace DifferentSLIAutoTools
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0].ToLower().Equals("/nogui"))
                {
                    Logic.NoGui();
                    System.Environment.Exit(0);
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
