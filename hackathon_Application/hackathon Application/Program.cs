using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace hackathon_Application
{
    static class Program

    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static List<string> Cartitems = new List<string>();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new regisration());
        }
    }
}
