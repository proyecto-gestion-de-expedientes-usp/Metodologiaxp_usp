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
    public partial class frm_RPT_PERSXDDO : Form
    {
        public frm_RPT_PERSXDDO()
        {
            InitializeComponent();
        }

        private void frm_RPT_PERSXDDO_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Reportes.RPT_PERSXDDO rep = new Reportes.RPT_PERSXDDO();
          
            crystalReportViewer1.ReportSource = rep;
        }
    }
}
