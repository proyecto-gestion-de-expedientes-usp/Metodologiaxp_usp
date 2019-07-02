namespace Solucion_informatica_Consultorio_Juridico
{
    partial class frm_Registrar_Expediente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscar_doc = new System.Windows.Forms.Button();
            this.btn_buscar_juzgado = new System.Windows.Forms.Button();
            this.btn_buscar_movExp = new System.Windows.Forms.Button();
            this.dp_fin = new System.Windows.Forms.DateTimePicker();
            this.dp_ini = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_resolucion = new System.Windows.Forms.TextBox();
            this.txt_materia = new System.Windows.Forms.TextBox();
            this.txt_id_doc = new System.Windows.Forms.TextBox();
            this.txt_vistos = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.txt_secretaria_juzgado = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.txt_id_juzgados = new System.Windows.Forms.TextBox();
            this.txt_expediente = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.txt_id_mov_exp = new System.Windows.Forms.TextBox();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.txt_sentencia = new System.Windows.Forms.TextBox();
            this.txt_id_exp = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(596, 221);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 35;
            this.btn_exit.Text = "Salir";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(456, 221);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 36;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(309, 221);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 37;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(162, 221);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 38;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.dgv_datos);
            this.groupBox2.Location = new System.Drawing.Point(12, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(824, 266);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(363, 32);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(174, 17);
            this.radioButton3.TabIndex = 34;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Busqueda por Demandante Dni";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(184, 32);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(171, 17);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Busqueda por Demandado Dni";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(162, 17);
            this.radioButton1.TabIndex = 34;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Busqueda por Nª Expediente";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(16, 56);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(521, 20);
            this.textBox9.TabIndex = 33;
            // 
            // dgv_datos
            // 
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Location = new System.Drawing.Point(16, 82);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.Size = new System.Drawing.Size(792, 178);
            this.dgv_datos.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_buscar_doc);
            this.groupBox1.Controls.Add(this.btn_buscar_juzgado);
            this.groupBox1.Controls.Add(this.btn_buscar_movExp);
            this.groupBox1.Controls.Add(this.dp_fin);
            this.groupBox1.Controls.Add(this.dp_ini);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_resolucion);
            this.groupBox1.Controls.Add(this.txt_materia);
            this.groupBox1.Controls.Add(this.txt_id_doc);
            this.groupBox1.Controls.Add(this.txt_vistos);
            this.groupBox1.Controls.Add(this.textBox15);
            this.groupBox1.Controls.Add(this.txt_secretaria_juzgado);
            this.groupBox1.Controls.Add(this.textBox14);
            this.groupBox1.Controls.Add(this.txt_id_juzgados);
            this.groupBox1.Controls.Add(this.txt_expediente);
            this.groupBox1.Controls.Add(this.textBox16);
            this.groupBox1.Controls.Add(this.txt_id_mov_exp);
            this.groupBox1.Controls.Add(this.txt_ciudad);
            this.groupBox1.Controls.Add(this.txt_sentencia);
            this.groupBox1.Controls.Add(this.txt_id_exp);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(824, 182);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expediente";
            // 
            // btn_buscar_doc
            // 
            this.btn_buscar_doc.Location = new System.Drawing.Point(311, 115);
            this.btn_buscar_doc.Name = "btn_buscar_doc";
            this.btn_buscar_doc.Size = new System.Drawing.Size(44, 23);
            this.btn_buscar_doc.TabIndex = 55;
            this.btn_buscar_doc.Text = "....";
            this.btn_buscar_doc.UseVisualStyleBackColor = true;
            // 
            // btn_buscar_juzgado
            // 
            this.btn_buscar_juzgado.Location = new System.Drawing.Point(311, 89);
            this.btn_buscar_juzgado.Name = "btn_buscar_juzgado";
            this.btn_buscar_juzgado.Size = new System.Drawing.Size(44, 23);
            this.btn_buscar_juzgado.TabIndex = 55;
            this.btn_buscar_juzgado.Text = "....";
            this.btn_buscar_juzgado.UseVisualStyleBackColor = true;
            // 
            // btn_buscar_movExp
            // 
            this.btn_buscar_movExp.Location = new System.Drawing.Point(311, 60);
            this.btn_buscar_movExp.Name = "btn_buscar_movExp";
            this.btn_buscar_movExp.Size = new System.Drawing.Size(44, 23);
            this.btn_buscar_movExp.TabIndex = 55;
            this.btn_buscar_movExp.Text = "....";
            this.btn_buscar_movExp.UseVisualStyleBackColor = true;
            // 
            // dp_fin
            // 
            this.dp_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_fin.Location = new System.Drawing.Point(697, 85);
            this.dp_fin.Name = "dp_fin";
            this.dp_fin.Size = new System.Drawing.Size(100, 20);
            this.dp_fin.TabIndex = 54;
            // 
            // dp_ini
            // 
            this.dp_ini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_ini.Location = new System.Drawing.Point(481, 117);
            this.dp_ini.Name = "dp_ini";
            this.dp_ini.Size = new System.Drawing.Size(100, 20);
            this.dp_ini.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(385, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Nª de Resolucion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Materia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Fecha de inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "ID Documento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(636, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 47;
            this.label13.Text = "Vistos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Secretaria Juzgado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(622, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Fecha Fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "ID Juzgado ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Expediente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(636, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Ciudad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "ID Movimiento Expediente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Nª Sentencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "ID Expediente";
            // 
            // txt_resolucion
            // 
            this.txt_resolucion.Location = new System.Drawing.Point(481, 143);
            this.txt_resolucion.Name = "txt_resolucion";
            this.txt_resolucion.Size = new System.Drawing.Size(100, 20);
            this.txt_resolucion.TabIndex = 38;
            // 
            // txt_materia
            // 
            this.txt_materia.Location = new System.Drawing.Point(150, 141);
            this.txt_materia.Name = "txt_materia";
            this.txt_materia.Size = new System.Drawing.Size(49, 20);
            this.txt_materia.TabIndex = 37;
            // 
            // txt_id_doc
            // 
            this.txt_id_doc.Location = new System.Drawing.Point(150, 115);
            this.txt_id_doc.Name = "txt_id_doc";
            this.txt_id_doc.Size = new System.Drawing.Size(49, 20);
            this.txt_id_doc.TabIndex = 36;
            // 
            // txt_vistos
            // 
            this.txt_vistos.Location = new System.Drawing.Point(697, 111);
            this.txt_vistos.Name = "txt_vistos";
            this.txt_vistos.Size = new System.Drawing.Size(100, 20);
            this.txt_vistos.TabIndex = 35;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(205, 89);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 20);
            this.textBox15.TabIndex = 34;
            // 
            // txt_secretaria_juzgado
            // 
            this.txt_secretaria_juzgado.Location = new System.Drawing.Point(481, 89);
            this.txt_secretaria_juzgado.Name = "txt_secretaria_juzgado";
            this.txt_secretaria_juzgado.Size = new System.Drawing.Size(100, 20);
            this.txt_secretaria_juzgado.TabIndex = 34;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(205, 63);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 32;
            // 
            // txt_id_juzgados
            // 
            this.txt_id_juzgados.Location = new System.Drawing.Point(150, 89);
            this.txt_id_juzgados.Name = "txt_id_juzgados";
            this.txt_id_juzgados.Size = new System.Drawing.Size(49, 20);
            this.txt_id_juzgados.TabIndex = 33;
            // 
            // txt_expediente
            // 
            this.txt_expediente.Location = new System.Drawing.Point(481, 63);
            this.txt_expediente.Name = "txt_expediente";
            this.txt_expediente.Size = new System.Drawing.Size(100, 20);
            this.txt_expediente.TabIndex = 32;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(205, 115);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(100, 20);
            this.textBox16.TabIndex = 39;
            // 
            // txt_id_mov_exp
            // 
            this.txt_id_mov_exp.Location = new System.Drawing.Point(150, 63);
            this.txt_id_mov_exp.Name = "txt_id_mov_exp";
            this.txt_id_mov_exp.Size = new System.Drawing.Size(49, 20);
            this.txt_id_mov_exp.TabIndex = 31;
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Location = new System.Drawing.Point(697, 59);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(100, 20);
            this.txt_ciudad.TabIndex = 30;
            this.txt_ciudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ciudad_KeyPress);
            // 
            // txt_sentencia
            // 
            this.txt_sentencia.Location = new System.Drawing.Point(481, 37);
            this.txt_sentencia.Name = "txt_sentencia";
            this.txt_sentencia.Size = new System.Drawing.Size(100, 20);
            this.txt_sentencia.TabIndex = 39;
            this.txt_sentencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sentencia_KeyPress);
            // 
            // txt_id_exp
            // 
            this.txt_id_exp.Location = new System.Drawing.Point(150, 37);
            this.txt_id_exp.Name = "txt_id_exp";
            this.txt_id_exp.Size = new System.Drawing.Size(49, 20);
            this.txt_id_exp.TabIndex = 29;
            // 
            // frm_Registrar_Expediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 534);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Registrar_Expediente";
            this.Text = "frm_Registrar_Expediente";
            this.Load += new System.EventHandler(this.frm_Registrar_Expediente_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_buscar_doc;
        private System.Windows.Forms.Button btn_buscar_juzgado;
        private System.Windows.Forms.Button btn_buscar_movExp;
        private System.Windows.Forms.DateTimePicker dp_fin;
        private System.Windows.Forms.DateTimePicker dp_ini;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_resolucion;
        private System.Windows.Forms.TextBox txt_materia;
        private System.Windows.Forms.TextBox txt_id_doc;
        private System.Windows.Forms.TextBox txt_vistos;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox txt_secretaria_juzgado;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox txt_id_juzgados;
        private System.Windows.Forms.TextBox txt_expediente;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox txt_id_mov_exp;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.TextBox txt_sentencia;
        private System.Windows.Forms.TextBox txt_id_exp;
    }
}