using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubliminaleWahrnehmungTest
{
    internal static class Program
    {
        private static IModelSubTest modelSubTest;
        private static IViewSubTest viewSubTest;
        private static IControllerSubTest controllerSubTest;
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ViewSubTest());
        }
    }
}
