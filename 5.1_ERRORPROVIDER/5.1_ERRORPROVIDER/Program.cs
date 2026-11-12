using System;
using System.Windows.Forms;

namespace _5._1_ERRORPROVIDER
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