﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GasStationManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           // if (args.Count() > 0)
                Application.Run(new GasStationManagement.View.MainStart_Frm());
        }
    }
}
