﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Solucion_informatica_Consultorio_Juridico
{
    public partial class Frm_reg_historialjuzg : Form
    {
        string campo;
        string c;

        Capas.conexion cone = new Capas.conexion();
        Capas.validaciones val = new Capas.validaciones();
        public Frm_reg_historialjuzg()
        {
            InitializeComponent();
        }

        private void Frm_reg_historialjuzg_Load(object sender, EventArgs e)
        {
            dgdatos.DataSource = mostrar();
            generar_id();

            col();
        }
        public void generar_id()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(Max(cast(juzg_id as int)),0)+1 from Historial_Juzgado", cone.con);
            DataTable sqlex = new DataTable();
            sda.Fill(sqlex);

            txt_id.Text = sqlex.Rows[0][0].ToString();
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            campo = "juzg_descripcion";
            txt_buscar.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txt_descripcion.Enabled = false;
            //txt_pronunciamiento.Enabled = false;
            //dt_derivacion.Enabled = false;
            //dt_notificacion.Enabled = false;
            //dt_recepcion.Enabled = false;
            //dt_solucion.Enabled = false;
            //dt_resolucion.Enabled = false;
            //button1.Enabled = false;
            //button3.Enabled = true;
            if (Capas.validaciones.ValidarFormulario(this, errorProvider1) == false)

            {

                try
                {

                    SqlCommand cmd = new SqlCommand("sp_insertar_historialjuzg", cone.con);

                    cmd.CommandType = CommandType.StoredProcedure;

                    //cmd.Parameters.Add("@juzg_id", SqlDbType.Int);
                    cmd.Parameters.Add("@juzg_descripcion", SqlDbType.VarChar, 50);
                    cmd.Parameters.Add("@juzg_fecharecepcion", SqlDbType.Date);
                    cmd.Parameters.Add("@juzg_pronunciamiento", SqlDbType.VarChar, 50);
                    cmd.Parameters.Add("@juzg_fechaderivacion", SqlDbType.Date);
                    cmd.Parameters.Add("@juzg_fechaemisionresol", SqlDbType.Date);
                    cmd.Parameters.Add("@juzg_fechanotificacion", SqlDbType.Date);
                    cmd.Parameters.Add("@juzg_fechasolucion", SqlDbType.Date);



                    //cmd.Parameters["@juzg_id"].Value = txt_id.Text;
                    cmd.Parameters["@juzg_descripcion"].Value = txt_descripcion.Text;
                    cmd.Parameters["@juzg_fecharecepcion"].Value = dt_recepcion.Text;
                    cmd.Parameters["@juzg_pronunciamiento"].Value = txt_pronunciamiento.Text;
                    cmd.Parameters["@juzg_fechaderivacion"].Value = dt_derivacion.Text;
                    cmd.Parameters["@juzg_fechaemisionresol"].Value = dt_resolucion.Text;
                    cmd.Parameters["@juzg_fechanotificacion"].Value = dt_notificacion.Text;
                    cmd.Parameters["@juzg_fechasolucion"].Value = dt_solucion.Text;



                    cone.con.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Los datos fueron insertados correctamente");

                    cone.con.Close();
                    dgdatos.DataSource = mostrar();
                    //txt_id.Text = Convert.ToString(dgdatos.RowCount - 1);
                }


                catch (Exception ex)
                {
                    cone.con.Close();
                    MessageBox.Show(ex.Message, "Error al Grabar");
                }
            }

            else {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int seleccionar;
            seleccionar = this.dgdatos.SelectedRows.Count;

            if (seleccionar == 0)

            {
                MessageBox.Show("Para modificar debe seleccionar una Fila en la tabla");
           
            if (txt_id.Text.Trim() == "" || txt_descripcion.Text.Trim() == "" || txt_pronunciamiento.Text.Trim() == "")
            {
                MessageBox.Show("Se Prohiben Campos Vacios");
            }
            }
            else
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_actualizar_historialjuzg", cone.con);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@juzg_id", SqlDbType.Int);
                    cmd.Parameters.Add("@juzg_descripcion", SqlDbType.VarChar, 50);
                    cmd.Parameters.Add("@juzg_fecharecepcion", SqlDbType.Date);
                    cmd.Parameters.Add("@juzg_pronunciamiento", SqlDbType.VarChar, 50);
                    cmd.Parameters.Add("@juzg_fechaderivacion", SqlDbType.Date);
                    cmd.Parameters.Add("@juzg_fechaemisionresol", SqlDbType.Date);
                    cmd.Parameters.Add("@juzg_fechanotificacion", SqlDbType.Date);
                    cmd.Parameters.Add("@juzg_fechasolucion", SqlDbType.Date);



                    cmd.Parameters["@juzg_id"].Value = txt_id.Text;
                    cmd.Parameters["@juzg_descripcion"].Value = txt_descripcion.Text;
                    cmd.Parameters["@juzg_fecharecepcion"].Value = dt_recepcion.Text;
                    cmd.Parameters["@juzg_pronunciamiento"].Value = txt_pronunciamiento.Text;
                    cmd.Parameters["@juzg_fechaderivacion"].Value = dt_derivacion.Text;
                    cmd.Parameters["@juzg_fechaemisionresol"].Value = dt_resolucion.Text;
                    cmd.Parameters["@juzg_fechanotificacion"].Value = dt_notificacion.Text;
                    cmd.Parameters["@juzg_fechasolucion"].Value = dt_solucion.Text;

                    cone.con.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Los datos fueron actualizados correctamente");

                    cone.con.Close();
                    dgdatos.DataSource = mostrar();
                    //txt_id.Text = Convert.ToString(dgdatos.RowCount - 1);
                }


                catch (Exception ex)
                {
                    cone.con.Close();
                    MessageBox.Show(ex.Message, "Error al Actualizar");
                }
            }
        }

        public DataTable mostrar()
        {

            cone.con.Open();
            string sql = "select * from Historial_Juzgado";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;

        }

        public void col()
        {
            dgdatos.Columns[0].HeaderText = "ID";
            dgdatos.Columns[1].HeaderText = "DESCRIPCION";
            dgdatos.Columns[2].HeaderText = "F_RECEPCION";
            dgdatos.Columns[3].HeaderText = "PRONUNCIAMIENTO";
            dgdatos.Columns[4].HeaderText = "F_DERIVACION";
            dgdatos.Columns[5].HeaderText = "F_EMISION_RESOL";
            dgdatos.Columns[6].HeaderText = "F_NOTIFICACION";
            dgdatos.Columns[7].HeaderText = "F_SOLUCION";
         
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string valor = txt_buscar.Text;
            dgdatos.DataSource = buscar(campo, valor);

            txt_buscar.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string valor = dt1.Text;
            dgdatos.DataSource = busc(c, valor);

        }
        
        public DataTable buscar(string campo, string valor)
        {

            cone.con.Open();
            string sql = "select * from Historial_Juzgado where " + campo + " like '" + valor + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;

        }


        public DataTable busc(string campo, string valor)
        {

            cone.con.Open();
            string sql = "select * from Historial_Juzgado where " + campo + " like '" + valor + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;

        }


        private void button3_Click(object sender, EventArgs e)
        {
            //txt_descripcion.Enabled = true;
            //txt_pronunciamiento.Enabled = true;
            //dt_derivacion.Enabled = true;
            //dt_notificacion.Enabled = true;
            //dt_recepcion.Enabled = true;
            //dt_solucion.Enabled = true;
            //dt_resolucion.Enabled = true;
            //button1.Enabled = true;
            //button3.Enabled = false;
            txt_descripcion.Text = "";
            txt_pronunciamiento.Text = "";
            txt_buscar.Text = "";
            txt_descripcion.Focus();
            generar_id();
            //txt_id.Text = Convert.ToString(dgdatos.RowCount - 1);

        }

        private void Frm_reg_historialjuzg_Activated(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton3.Checked = true;
            //txt_id.Text = Convert.ToString(dgdatos.RowCount - 1);
            generar_id();
            this.dt_recepcion.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            campo = "juzg_pronunciamiento";
            txt_buscar.Focus();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            c = "juzg_fecharecepcion";
            txt_buscar.Focus();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
          c = "juzg_fechaderivacion";
            txt_buscar.Focus();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
         c = "juzg_fechaemisionresol";
            txt_buscar.Focus();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            c= "juzg_fechanotificacion";
            txt_buscar.Focus();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            c= "juzg_fechasolucion";
            txt_buscar.Focus();
        }

        private void dgdatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = dgdatos.CurrentRow.Index;

            txt_id.Text = dgdatos.CurrentRow.Cells[0].Value.ToString();
            txt_descripcion.Text = dgdatos.CurrentRow.Cells[1].Value.ToString();
            dt_recepcion.Text = dgdatos.CurrentRow.Cells[2].Value.ToString();
            txt_pronunciamiento.Text = dgdatos.CurrentRow.Cells[3].Value.ToString();
            dt_derivacion.Text = dgdatos.CurrentRow.Cells[4].Value.ToString();
            dt_resolucion.Text = dgdatos.CurrentRow.Cells[5].Value.ToString();
            dt_notificacion.Text = dgdatos.CurrentRow.Cells[6].Value.ToString();
            dt_solucion.Text = dgdatos.CurrentRow.Cells[7].Value.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                val.SoloNumeros(e);
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    txt_buscar.Clear();
                }
            }

            
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            campo = "juzg_id";
            txt_buscar.Focus();
        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txt_pronunciamiento_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void dt_recepcion_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void dt_recepcion_Validating(object sender, CancelEventArgs e)
        {
         

      



        }

        private void dt_derivacion_Validating(object sender, CancelEventArgs e)
        {
            if (dt_derivacion.Value < DateTime.Today)
            {
                e.Cancel = true;
                MessageBox.Show("Debe Ingresar una fecha Futura", "Derivaciòn");
            }
        }

        private void dt_derivacion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dt_resolucion_Validating(object sender, CancelEventArgs e)
        {
            if (dt_resolucion.Value < DateTime.Today)
            {
                e.Cancel = true;
                MessageBox.Show("Debe Ingresar una fecha Futura", "Resoluciòn");
            }
        }

        private void dt_notificacion_Validating(object sender, CancelEventArgs e)
        {
            if (dt_notificacion.Value < DateTime.Today)
            {
                e.Cancel = true;
                MessageBox.Show("Debe Ingresar una fecha Futura", "Notificaciòn");
            }
        }

        private void dt_solucion_Validating(object sender, CancelEventArgs e)
        {
            if (dt_solucion.Value < DateTime.Today)
            {
                e.Cancel = true;
                MessageBox.Show("Debe Ingresar una fecha Futura", "Soluciòn");
            }
        }
    }
}
