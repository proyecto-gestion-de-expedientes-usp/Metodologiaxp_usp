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
    public partial class Frm_buscar_demandado : Form
    {
        string campo;

        Capas.conexion cone = new Capas.conexion();
        Capas.validaciones val = new Capas.validaciones();
        public Frm_buscar_demandado()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            campo = "NUM_DOC";
            txt_buscar.Focus();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            campo = "REGISTRO";
            txt_buscar.Focus();
        }

        private void Frm_buscar_demandado_Load(object sender, EventArgs e)
        {
            dgdatos.DataSource = mostrar();

            //col();
        }
        //public void col()
        //{
        //    dgdatos.Columns[0].HeaderText = "ID";
        //    dgdatos.Columns[1].HeaderText = "ID_PERSONA";
        //    dgdatos.Columns[2].HeaderText = "PERSONA";
        //    dgdatos.Columns[3].HeaderText = "NUM_DOC";
        //    dgdatos.Columns[4].HeaderText = "REGISTRO";
        //}
        public DataTable mostrar()
        {
            cone.con.Open();
            string sql = "select * from View_Demandado";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;
        }

        private void Frm_buscar_demandado_Activated(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor = txt_buscar.Text;
            dgdatos.DataSource = buscar(campo, valor);

            txt_buscar.Focus();
        }
        public DataTable buscar(string campo, string valor)
        {

            cone.con.Open();
            string sql = "select * from View_Demandado where " + campo + " like '" + valor + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cone.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cone.con.Close();
            return dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgdatos.DataSource = mostrar();
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                val.SoloNumeros(e);
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    txt_buscar.Clear();
                }
            }
            if (radioButton4.Checked == true)
            {
                val.SoloNumeros(e);
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    txt_buscar.Clear();
                }
            }

            if (radioButton1.Checked == true)
            {
                val.SoloLetras(e);
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    txt_buscar.Clear();
                }
            }
        }

        private void dgdatos_DoubleClick(object sender, EventArgs e)
        {
            Program.id_demandado = Convert.ToString(dgdatos.CurrentRow.Cells[0].Value);
            Program.nom_demandado = Convert.ToString(dgdatos.CurrentRow.Cells[2].Value);
            this.Hide();
        }
    }
}
