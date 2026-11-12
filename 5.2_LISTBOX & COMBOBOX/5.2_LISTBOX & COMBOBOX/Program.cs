using System;
using System.Windows.Forms;

namespace _5._2_LISTBOX___COMBOBOX
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