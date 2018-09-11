using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName,"Omega","Fuentes");

            Fonts.AddFontResource(startupPath + "\\Doodle Gum.ttf");
            Fonts.AddFontResource(startupPath + "\\K26ToyBlocks123.ttf");
            Fonts.AddFontResource(startupPath + "\\Patchwork Stitchlings.ttf");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dificultades());
        }
    }
}
