﻿namespace Solucion_informatica_Consultorio_Juridico
{
    partial class frm_registrar_persona
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dp_fenaci = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_buscar_doc = new System.Windows.Forms.TextBox();
            this.dgv_pers = new System.Windows.Forms.DataGridView();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_telf = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_tip_Doc = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nro_documento = new System.Windows.Forms.TextBox();
            this.txt_domilega = new System.Windows.Forms.TextBox();
            this.txt_ubigeo = new System.Windows.Forms.TextBox();
            this.txt_depart = new System.Windows.Forms.TextBox();
            this.txt_prov = new System.Windows.Forms.TextBox();
            this.txt_ciud = new System.Windows.Forms.TextBox();
            this.txt_ape_mat = new System.Windows.Forms.TextBox();
            this.txt_ape_pat = new System.Windows.Forms.TextBox();
            this.txt_nomb = new System.Windows.Forms.TextBox();
            this.txt_id_tip_doc = new System.Windows.Forms.TextBox();
            this.txt_idper = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dp_fenaci);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btn_modificar);
            this.groupBox1.Controls.Add(this.btn_guardar);
            this.groupBox1.Controls.Add(this.btn_limpiar);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_telf);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cb_tip_Doc);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_nro_documento);
            this.groupBox1.Controls.Add(this.txt_domilega);
            this.groupBox1.Controls.Add(this.txt_ubigeo);
            this.groupBox1.Controls.Add(this.txt_depart);
            this.groupBox1.Controls.Add(this.txt_prov);
            this.groupBox1.Controls.Add(this.txt_ciud);
            this.groupBox1.Controls.Add(this.txt_ape_mat);
            this.groupBox1.Controls.Add(this.txt_ape_pat);
            this.groupBox1.Controls.Add(this.txt_nomb);
            this.groupBox1.Controls.Add(this.txt_id_tip_doc);
            this.groupBox1.Controls.Add(this.txt_idper);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Persona";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dp_fenaci
            // 
            this.dp_fenaci.CustomFormat = "yyyy-MM-dd";
            this.dp_fenaci.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dp_fenaci.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_fenaci.Location = new System.Drawing.Point(690, 45);
            this.dp_fenaci.MinDate = new System.DateTime(1945, 1, 1, 0, 0, 0, 0);
            this.dp_fenaci.Name = "dp_fenaci";
            this.dp_fenaci.Size = new System.Drawing.Size(74, 20);
            this.dp_fenaci.TabIndex = 40;
            this.dp_fenaci.ValueChanged += new System.EventHandler(this.dp_fenaci_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(576, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Fecha de Nacimiento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_buscar_doc);
            this.groupBox2.Controls.Add(this.dgv_pers);
            this.groupBox2.Location = new System.Drawing.Point(323, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 323);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Persona";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(213, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Busqueda por Nro Documento de Identidad";
            // 
            // txt_buscar_doc
            // 
            this.txt_buscar_doc.Location = new System.Drawing.Point(6, 52);
            this.txt_buscar_doc.Name = "txt_buscar_doc";
            this.txt_buscar_doc.Size = new System.Drawing.Size(274, 20);
            this.txt_buscar_doc.TabIndex = 40;
            this.txt_buscar_doc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_doc_KeyPress);
            // 
            // dgv_pers
            // 
            this.dgv_pers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pers.Location = new System.Drawing.Point(6, 81);
            this.dgv_pers.Name = "dgv_pers";
            this.dgv_pers.Size = new System.Drawing.Size(435, 236);
            this.dgv_pers.TabIndex = 39;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(125, 380);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 37;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(29, 380);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 36;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(217, 380);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 35;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(59, 308);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(59, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Telefono";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(122, 305);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(180, 20);
            this.txt_email.TabIndex = 32;
            this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
            // 
            // txt_telf
            // 
            this.txt_telf.Location = new System.Drawing.Point(122, 279);
            this.txt_telf.Name = "txt_telf";
            this.txt_telf.Size = new System.Drawing.Size(138, 20);
            this.txt_telf.TabIndex = 31;
            this.txt_telf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telf_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(320, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Nro Documento de Identidad";
            // 
            // cb_tip_Doc
            // 
            this.cb_tip_Doc.FormattingEnabled = true;
            this.cb_tip_Doc.Location = new System.Drawing.Point(181, 45);
            this.cb_tip_Doc.Name = "cb_tip_Doc";
            this.cb_tip_Doc.Size = new System.Drawing.Size(121, 21);
            this.cb_tip_Doc.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Domicilio Legal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Ubigeo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Departamento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Provincia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ciudad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Apellido materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Apellido paterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Id tipo de documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Id persona";
            // 
            // txt_nro_documento
            // 
            this.txt_nro_documento.Location = new System.Drawing.Point(470, 45);
            this.txt_nro_documento.Name = "txt_nro_documento";
            this.txt_nro_documento.Size = new System.Drawing.Size(100, 20);
            this.txt_nro_documento.TabIndex = 17;
            this.txt_nro_documento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nro_documento_KeyPress);
            // 
            // txt_domilega
            // 
            this.txt_domilega.Location = new System.Drawing.Point(122, 253);
            this.txt_domilega.Name = "txt_domilega";
            this.txt_domilega.Size = new System.Drawing.Size(180, 20);
            this.txt_domilega.TabIndex = 16;
            // 
            // txt_ubigeo
            // 
            this.txt_ubigeo.Location = new System.Drawing.Point(122, 227);
            this.txt_ubigeo.Name = "txt_ubigeo";
            this.txt_ubigeo.Size = new System.Drawing.Size(100, 20);
            this.txt_ubigeo.TabIndex = 15;
            // 
            // txt_depart
            // 
            this.txt_depart.Location = new System.Drawing.Point(122, 201);
            this.txt_depart.Name = "txt_depart";
            this.txt_depart.Size = new System.Drawing.Size(138, 20);
            this.txt_depart.TabIndex = 14;
            this.txt_depart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_depart_KeyPress);
            // 
            // txt_prov
            // 
            this.txt_prov.Location = new System.Drawing.Point(122, 175);
            this.txt_prov.Name = "txt_prov";
            this.txt_prov.Size = new System.Drawing.Size(138, 20);
            this.txt_prov.TabIndex = 13;
            this.txt_prov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prov_KeyPress);
            // 
            // txt_ciud
            // 
            this.txt_ciud.Location = new System.Drawing.Point(122, 149);
            this.txt_ciud.Name = "txt_ciud";
            this.txt_ciud.Size = new System.Drawing.Size(138, 20);
            this.txt_ciud.TabIndex = 12;
            this.txt_ciud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ciud_KeyPress);
            // 
            // txt_ape_mat
            // 
            this.txt_ape_mat.Location = new System.Drawing.Point(122, 123);
            this.txt_ape_mat.Name = "txt_ape_mat";
            this.txt_ape_mat.Size = new System.Drawing.Size(180, 20);
            this.txt_ape_mat.TabIndex = 11;
            this.txt_ape_mat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ape_mat_KeyPress);
            // 
            // txt_ape_pat
            // 
            this.txt_ape_pat.Location = new System.Drawing.Point(122, 97);
            this.txt_ape_pat.Name = "txt_ape_pat";
            this.txt_ape_pat.Size = new System.Drawing.Size(180, 20);
            this.txt_ape_pat.TabIndex = 10;
            this.txt_ape_pat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ape_pat_KeyPress);
            // 
            // txt_nomb
            // 
            this.txt_nomb.Location = new System.Drawing.Point(122, 71);
            this.txt_nomb.Name = "txt_nomb";
            this.txt_nomb.Size = new System.Drawing.Size(180, 20);
            this.txt_nomb.TabIndex = 9;
            this.txt_nomb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nomb_KeyPress);
            // 
            // txt_id_tip_doc
            // 
            this.txt_id_tip_doc.Location = new System.Drawing.Point(122, 45);
            this.txt_id_tip_doc.Name = "txt_id_tip_doc";
            this.txt_id_tip_doc.Size = new System.Drawing.Size(53, 20);
            this.txt_id_tip_doc.TabIndex = 18;
            // 
            // txt_idper
            // 
            this.txt_idper.Location = new System.Drawing.Point(122, 19);
            this.txt_idper.Name = "txt_idper";
            this.txt_idper.Size = new System.Drawing.Size(53, 20);
            this.txt_idper.TabIndex = 8;
            // 
            // frm_registrar_persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_registrar_persona";
            this.Text = "Registro Persona";
            this.Load += new System.EventHandler(this.frm_registrar_persona_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_telf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_tip_Doc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nro_documento;
        private System.Windows.Forms.TextBox txt_domilega;
        private System.Windows.Forms.TextBox txt_ubigeo;
        private System.Windows.Forms.TextBox txt_depart;
        private System.Windows.Forms.TextBox txt_prov;
        private System.Windows.Forms.TextBox txt_ciud;
        private System.Windows.Forms.TextBox txt_ape_mat;
        private System.Windows.Forms.TextBox txt_ape_pat;
        private System.Windows.Forms.TextBox txt_nomb;
        private System.Windows.Forms.TextBox txt_id_tip_doc;
        private System.Windows.Forms.TextBox txt_idper;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_buscar_doc;
        private System.Windows.Forms.DataGridView dgv_pers;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dp_fenaci;
    }
}