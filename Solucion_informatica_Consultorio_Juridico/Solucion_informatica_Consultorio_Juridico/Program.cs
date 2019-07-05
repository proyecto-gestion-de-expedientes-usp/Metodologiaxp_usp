using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucion_informatica_Consultorio_Juridico
{
    static class Program
    {

        //para formulario Registro Demandado

        public static string idper;
        public static string nomper;

        //para formulario Registro Demandante

        public static string idpers;
        public static string nompers;

        //para formulario Registro Anexos
        public static string anid;
        public static string anom;
        public static string anomr;
        public static string adoc;
        public static string afech;

        //para formulario Registro Documento
        public static string docid;
        public static string docnom;
        public static string docnomr;
        public static string docdoc;
        public static string docfech;


        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frm_Menu_Admin());
            //Application.Run(new frm_demandado());
            //Application.Run(new frm_demandante());
            //Application.Run(new Frm_Estado_Usuario());
            //Application.Run(new frm_buscar_estadousu());
            Application.Run(new Frm_Estadoabog());
            //Application.Run(new frm_Anexos());
        }
    }
}
