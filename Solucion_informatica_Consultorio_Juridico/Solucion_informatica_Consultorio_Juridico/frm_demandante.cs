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
    public partial class frm_demandante : Form
    {
        string campo;

        Capas.conexion cone = new Capas.conexion();
        //componentes.c_exp otn = new componentes.c_exp();
        public frm_demandante()
        {
            InitializeComponent();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            if (txt_iddo.Text.Trim() == "" || txt_idper.Text.Trim() == "" || txt_reg.Text.Trim() == "")
            {
                MessageBox.Show("SE PROHIBEN CAMPOS VACIOS");
            }
            else
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_insertar_demandante", cone.con);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@demte_id", SqlDbType.Int);
                    cmd.Parameters.Add("@pers_id", SqlDbType.Int);
                    cmd.Parameters.Add("@demte_registro", SqlDbType.VarChar, 20);


                    cmd.Parameters["@demte_id"].Value = txt_iddo.Text;
                    cmd.Parameters["@pers_id"].Value = txt_idper.Text;
                    cmd.Parameters["@demte_registro"].Value = txt_reg.Text;


                    cone.con.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Los datos fueron insertados correctamente");

                    cone.con.Close();
                    dgdatos.DataSource = mostrar();
                }


                catch (Exception ex)
                {
                    cone.con.Close();
                    MessageBox.Show(ex.Message, "Error al Grabar");
                }
            }
        }


        public DataTable mostrar()
        {

            cone.con.Open();
            string sql = "select * from Demandante";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;

        }

        public void col()
        {
            dgdatos.Columns[0].HeaderText = "ID";
            dgdatos.Columns[1].HeaderText = "ID_PERSONA";
            dgdatos.Columns[2].HeaderText = "REGISTRO";


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            campo = "demte_id";
            txt_buscar.Focus();
        }

        private void frm_demandante_Load(object sender, EventArgs e)
        {
            dgdatos.DataSource = mostrar();

            col();
        }

        private void btn_buscar1_Click(object sender, EventArgs e)
        {
            string valor = txt_buscar.Text;
            dgdatos.DataSource = buscar(campo, valor);

            txt_buscar.Focus();
        }

        public DataTable buscar(string campo, string valor)
        {

            cone.con.Open();
            string sql = "select * from Demandante where " + campo + " like '" + valor + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            campo = "pers_id";
            txt_buscar.Focus();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            campo = "demte_registro";
            txt_buscar.Focus();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (txt_iddo.Text.Trim() == "" || txt_idper.Text.Trim() == "" || txt_reg.Text.Trim() == "")
            {
                MessageBox.Show("SE PROHIBEN CAMPOS VACIOS");
            }
            else
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_actualizar_demandante", cone.con);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@demte_id", SqlDbType.Int);
                    cmd.Parameters.Add("@pers_id", SqlDbType.Int);
                    cmd.Parameters.Add("@demte_registro", SqlDbType.VarChar, 20);


                    cmd.Parameters["@demte_id"].Value = txt_iddo.Text;
                    cmd.Parameters["@pers_id"].Value = txt_idper.Text;
                    cmd.Parameters["@demte_registro"].Value = txt_reg.Text;

                    cone.con.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Los datos fueron actualizados correctamente");

                    cone.con.Close();
                    dgdatos.DataSource = mostrar();
                }


                catch (Exception ex)
                {
                    cone.con.Close();
                    MessageBox.Show(ex.Message, "Error al Actualizar");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_idper.Text = "";
            txt_iddo.Text = "";
            txt_reg.Text = "";
        }

        private void dgdatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = dgdatos.CurrentRow.Index;

            txt_iddo.Text = dgdatos.CurrentRow.Cells[0].Value.ToString();
            txt_idper.Text = dgdatos.CurrentRow.Cells[1].Value.ToString();
            txt_reg.Text = dgdatos.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frm_registrar_persona frm = new frm_registrar_persona();

            // frm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}