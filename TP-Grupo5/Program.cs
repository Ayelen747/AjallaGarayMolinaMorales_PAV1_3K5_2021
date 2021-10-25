using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Grupo5.GUILayer;

namespace TP_Grupo5
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmTransaccionFactura());
            Application.Run(new frmConsultaCliente());
            //Application.Run(new frmLogin());
            //Application.Run(new frmPrincipal());
            //Application.Run(new frmConsultarBarrio());
        }
    }
}
