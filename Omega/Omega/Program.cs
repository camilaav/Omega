﻿using System;
using System.IO;
using System.Windows.Forms;


namespace Omega
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Bienvenida());
        }
    }
}
