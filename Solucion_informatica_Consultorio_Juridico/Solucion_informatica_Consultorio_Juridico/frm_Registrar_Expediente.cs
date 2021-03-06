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
    public partial class frm_Registrar_Expediente : Form
    {
        Clases.Validacioes validadcion = new Clases.Validacioes();
        Capas.conexion cone = new Capas.conexion();
        Clases.Datos sad = new Clases.Datos();
        string campo;

        public void limpiar()
        {
            txt_id_mov_exp.Text = "";
            txt_moxep.Text = "";
            txt_id_juzgados.Text = "";
            txt_juz.Text = "";
            txt_id_doc.Text="";
            txt_materia.Text = "";
            txt_sentencia.Text = "";
            txt_expediente.Text = "";
            txt_secretaria_juzgado.Text = "";
            txt_resolucion.Text = "";
            txt_ciudad.Text = "";
            txt_vistos.Text = "";
            
        }
        public frm_Registrar_Expediente()
        {
            InitializeComponent();
        }

        private void frm_Registrar_Expediente_Load(object sender, EventArgs e)
        {
            generarid();
            mostrar();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            btn_buscar_movExp.Enabled = false;
            btn_buscar_juzgado.Enabled = false;
            btn_buscar_doc.Enabled = false;
            txt_materia.Enabled = false;
            txt_sentencia.Enabled = false;
            txt_expediente.Enabled = false;
            txt_secretaria_juzgado.Enabled = false;
            dp_ini.Enabled = false;
            txt_resolucion.Enabled = false;
            txt_ciudad.Enabled = false;
            dp_fin.Enabled = false;
            txt_vistos.Enabled = false;
            btn_limpiar.Enabled = true;
            btn_modificar.Enabled = false;
            btn_limpiar.Enabled = true;

            try
            {

                SqlCommand cmd = new SqlCommand("insertar_exp", cone.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("@exp_id", SqlDbType.Int);
                cmd.Parameters.Add("@movexp", SqlDbType.Int);
                cmd.Parameters.Add("@juzg_id", SqlDbType.Int);
                cmd.Parameters.Add("@doc", SqlDbType.Int);
                cmd.Parameters.Add("@exp_nrosentencia", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@exp_expediente", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@exp_secrejuzg", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@exp_fechainicio", SqlDbType.Date);
                cmd.Parameters.Add("@exp_materia", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@exp_resolucionnro", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@exp_ciudad", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@exp_fecha", SqlDbType.Date);
                cmd.Parameters.Add("@exp_vistos", SqlDbType.VarChar, 30);


                //cmd.Parameters["@exp_id"].Value = txt_id_exp.Text;
                cmd.Parameters["@movexp"].Value = txt_id_mov_exp.Text;
                cmd.Parameters["@juzg_id"].Value = txt_id_juzgados.Text;
                cmd.Parameters["@doc"].Value = txt_id_doc.Text;
                cmd.Parameters["@exp_nrosentencia"].Value = txt_sentencia.Text;
                cmd.Parameters["@exp_expediente"].Value = txt_expediente.Text;
                cmd.Parameters["@exp_secrejuzg"].Value = txt_secretaria_juzgado.Text;
                cmd.Parameters["@exp_fechainicio"].Value = dp_ini.Text;
                cmd.Parameters["@exp_materia"].Value = txt_materia.Text;
                cmd.Parameters["@exp_resolucionnro"].Value = txt_resolucion.Text;
                cmd.Parameters["@exp_ciudad"].Value = txt_ciudad.Text;
                cmd.Parameters["@exp_fecha"].Value = dp_fin.Text;
                cmd.Parameters["@exp_vistos"].Value = txt_vistos.Text;



                cone.con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron insertados correctamente");
                generarid();
                //mostrar();
                cone.con.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            btn_buscar_movExp.Enabled = true;
            btn_buscar_juzgado.Enabled = true;
            btn_buscar_doc.Enabled = true;
            txt_materia.Enabled = true;
            txt_sentencia.Enabled = true;
            txt_expediente.Enabled = true;
            txt_secretaria_juzgado.Enabled = true;
            dp_ini.Enabled = true;
            txt_resolucion.Enabled = true;
            txt_ciudad.Enabled = true;
            dp_fin.Enabled = true;
            txt_vistos.Enabled = true;
            btn_guardar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_limpiar.Enabled = true;
            try
            {

                SqlCommand cmd = new SqlCommand("actualizar_exp", cone.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@exp_id", SqlDbType.Int);
                cmd.Parameters.Add("@movexp", SqlDbType.Int);
                cmd.Parameters.Add("@juzg_id", SqlDbType.Int);
                cmd.Parameters.Add("@doc", SqlDbType.Int);
                cmd.Parameters.Add("@exp_nrosentencia", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@exp_expediente", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@exp_secrejuzg", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@exp_fechainicio", SqlDbType.Date);
                cmd.Parameters.Add("@exp_materia", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@exp_resolucionnro", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@exp_ciudad", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@exp_fecha", SqlDbType.Date);
                cmd.Parameters.Add("@exp_vistos", SqlDbType.VarChar, 30);


                cmd.Parameters["@exp_id"].Value = txt_id_exp.Text;
                cmd.Parameters["@movexp"].Value = txt_id_mov_exp.Text;
                cmd.Parameters["@juzg_id"].Value = txt_id_juzgados.Text;
                cmd.Parameters["@doc"].Value = txt_id_doc.Text;
                cmd.Parameters["@exp_nrosentencia"].Value = txt_sentencia.Text;
                cmd.Parameters["@exp_expediente"].Value = txt_expediente.Text;
                cmd.Parameters["@exp_secrejuzg"].Value = txt_secretaria_juzgado.Text;
                cmd.Parameters["@exp_fechainicio"].Value = dp_ini.Text;
                cmd.Parameters["@exp_materia"].Value = txt_materia.Text;
                cmd.Parameters["@exp_resolucionnro"].Value = txt_resolucion.Text;
                cmd.Parameters["@exp_ciudad"].Value = txt_ciudad.Text;
                cmd.Parameters["@exp_fecha"].Value = dp_fin.Text;
                cmd.Parameters["@exp_vistos"].Value = txt_vistos.Text;



                cone.con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron insertados correctamente");
                generarid();
                //mostrar();
                cone.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            limpiar();
        }
        public void generarid()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(Max(cast(exp_id as int)),0)+1 from Expediente", cone.con);
            DataTable sqlex = new DataTable();
            sda.Fill(sqlex);
            txt_id_exp.Text = sqlex.Rows[0][0].ToString();
            cone.con.Close();
        }
        public void mostrar()
        {

            dgv_datos.DataSource = sad.mostrarexp();
        }

        private void txt_sentencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloNumeros(e);
        }

        private void txt_ciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadcion.soloLetras(e);
        }

        private void txt_resolucion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txt_materia_Validated(object sender, EventArgs e)
        {
            if (txt_materia.Text.Trim() == "")
            {
                errormateria.SetError(txt_materia, "Ingrese Materia");
            }
        }

        private void txt_sentencia_Validated(object sender, EventArgs e)
        {
            if (txt_sentencia.Text.Trim() == "")
            {
                errorNROSentencia.SetError(txt_sentencia, "Ingrese Nro Sentencia");
            }
        }

        private void txt_expediente_Validated(object sender, EventArgs e)
        {
            if (txt_expediente.Text.Trim() == "")
            {
                errorExpe.SetError(txt_expediente, "Ingrese Exppediente");
            }
        }

        private void txt_secretaria_juzgado_Validated(object sender, EventArgs e)
        {
            if (txt_secretaria_juzgado.Text.Trim() == "")
            {
                errorSecretaria.SetError(txt_secretaria_juzgado, "Ingrese Secretaria Juzgado");
            }
        }

        private void txt_resolucion_Validated(object sender, EventArgs e)
        {
            if (txt_resolucion.Text.Trim() == "")
            {
                errorNroResol.SetError(txt_resolucion, "Ingrese Nro Resolución");
            }
        }

        private void txt_ciudad_Validated(object sender, EventArgs e)
        {
           
        }

        private void frm_Registrar_Expediente_Activated(object sender, EventArgs e)
        {
            txt_id_mov_exp.Text = Program.idmovexp;
            txt_moxep.Text = Program.nromovexp;

            txt_id_juzgados.Text = Program.idjuzgado;
            txt_juz.Text = Program.juzgadonom;

            txt_id_doc.Text = Program.iddocumen;
            txt_doc.Text = Program.nomdocum;

        
            
            
        }

        private void btn_buscar_movExp_Click(object sender, EventArgs e)
        {
            frm_buscar_movimiento_Exp v = new frm_buscar_movimiento_Exp();
            v.ShowDialog();
        }

        private void btn_buscar_juzgado_Click(object sender, EventArgs e)
        {
            frm_buscar_historial_juz l = new frm_buscar_historial_juz();
            l.ShowDialog();
        }

        private void btn_buscar_doc_Click(object sender, EventArgs e)
        {
            frm_buscar_documento o = new frm_buscar_documento();
            o.ShowDialog();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            btn_buscar_movExp.Enabled = true;
            btn_buscar_juzgado.Enabled = true;
            btn_buscar_doc.Enabled = true;
            txt_materia.Enabled = true;
            txt_sentencia.Enabled = true;
            txt_expediente.Enabled = true;
            txt_secretaria_juzgado.Enabled = true;
            dp_ini.Enabled = true;
            txt_resolucion.Enabled = true;
            txt_ciudad.Enabled = true;
            dp_fin.Enabled = true;
            txt_vistos.Enabled = true;
            btn_guardar.Enabled = true;
            btn_modificar.Enabled = false;
            btn_limpiar.Enabled = false;
            limpiar();
        }

        private void txt_expediente_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string valor = txt_buscar.Text;
            dgv_datos.DataSource = buscar( valor);

            txt_buscar.Focus();
        }
        public DataTable buscar(string valor)
        {

            cone.con.Open();
            string sql = "select * from Expediente where exp_nrosentencia  like '" + valor + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;
        }
    }

}