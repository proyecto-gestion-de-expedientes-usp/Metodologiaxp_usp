using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucion_informatica_Consultorio_Juridico
{
    public partial class frm_Rpt_Casos_x_usuarios : Form
    {
        public frm_Rpt_Casos_x_usuarios()
        {
            InitializeComponent();
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            Reportes.RPT_Caso_usuario_ciclo xd = new Reportes.RPT_Caso_usuario_ciclo();
            xd.SetParameterValue("@fechaDesde", dp_ini.Text);
            xd.SetParameterValue("@fechaHasta", dp_ini.Text);
            xd.SetParameterValue("@usu_dni", txt_dni.Text);
            crystalReportViewer1.ReportSource = xd;
        }
    }
    }

