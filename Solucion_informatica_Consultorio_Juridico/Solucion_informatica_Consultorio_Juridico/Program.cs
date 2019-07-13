using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucion_informatica_Consultorio_Juridico
{
    static class Program
    {

        //para formulario Registro Movimiento Expediente

        public static string idusu;
        public static string nomusu;

        public static string id_demandado;
        public static string nom_demandado;

        public static string id_demandante;
        public static string nom_demandante;

        public static string idanexo;
        public static string nomanexo;

        public static string idabogado;
        public static string nomabogado;

        //para formulario registro exxpediente
        public static string idmovexp;
        public static string nromovexp;

        public static string idjuzgado;
        public static string juzgadonom;

        public static string iddocumen;
        public static string nomdocum;


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
            //Application.Run(new Frm_reporte());
            Application.Run(new frm_Login());
            //Application.Run(new Frm_reg_historialjuzg());

        }
    }
}
