using _5._3_DATAGRIDVIEW;
using System;
using System.Windows.Forms;

namespace _5._3_DATAGRIDVIEW
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}