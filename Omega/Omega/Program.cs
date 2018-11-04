using System;
using System.IO;
using System.Windows.Forms;


namespace Omega
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Omega", "Fuentes");

            int result = -1;
            result = Fonts.AddFontResource(startupPath + "\\Doodle Gum.ttf");
            result = Fonts.AddFontResource(startupPath + "\\K26ToyBlocks123.ttf");
            result = Fonts.AddFontResource(startupPath + "\\Mad College.otf");
            result = Fonts.AddFontResource(startupPath + "\\Patchwork Stitchlings.ttf");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Memotest());
        }
    }
}
