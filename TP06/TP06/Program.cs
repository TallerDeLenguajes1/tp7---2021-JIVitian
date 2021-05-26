using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP06.Controller;

namespace TP06
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            //var filename = Path.Combine(path, "WindowsFormsApplication1.exe");
            //var assembly = Assembly.LoadFile(filename);
            //var programType = assembly.GetTypes().FirstOrDefault(c => c.Name == "Program"); // <-- if you don't know the full namespace and when it is unique.
            //var method = programType.GetMethod("Start", BindingFlags.Public | BindingFlags.Static);
            //method.Invoke(null, new object[] { });
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ViewCalculadora());
        }
    }
}
