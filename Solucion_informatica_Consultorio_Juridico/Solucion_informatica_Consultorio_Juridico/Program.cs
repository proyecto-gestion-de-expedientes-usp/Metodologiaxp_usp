using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucion_informatica_Consultorio_Juridico
{
    static class Program
    {




        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frm_demandado());

            //Application.Run(new frm_demandante());
            Application.Run(new frm_Menu_Admin());
        }
    }
}
