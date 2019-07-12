namespace Solucion_informatica_Consultorio_Juridico
{
    partial class frm_demandante
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_buscar1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_reg = new System.Windows.Forms.Button();
            this.dgdatos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_reg = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_idper = new Capas.ErrorTxtBox();
            this.txt_nomper = new Capas.ErrorTxtBox();
            this.txt_iddo = new Capas.ErrorTxtBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.txt_buscar);
            this.groupBox1.Controls.Add(this.btn_buscar1);
            this.groupBox1.Location = new System.Drawing.Point(385, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 69);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por :";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(385, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 47);
            this.button3.TabIndex = 32;
            this.button3.Text = "Mostrar Todo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(227, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 31;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Registro";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(130, 17);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(88, 17);
            this.radioButton3.TabIndex = 30;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Numero_Doc";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(5, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(122, 17);
            this.radioButton2.TabIndex = 29;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Código Demandante";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(6, 43);
            this.txt_buscar.MaxLength = 30;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(271, 20);
            this.txt_buscar.TabIndex = 27;
            this.txt_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_KeyPress);
            // 
            // btn_buscar1
            // 
            this.btn_buscar1.Location = new System.Drawing.Point(297, 43);
            this.btn_buscar1.Name = "btn_buscar1";
            this.btn_buscar1.Size = new System.Drawing.Size(82, 23);
            this.btn_buscar1.TabIndex = 28;
            this.btn_buscar1.Text = "Buscar";
            this.btn_buscar1.UseVisualStyleBackColor = true;
            this.btn_buscar1.Click += new System.EventHandler(this.btn_buscar1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Nuevo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(146, 245);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(67, 23);
            this.btn_modificar.TabIndex = 25;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_reg
            // 
            this.btn_reg.Location = new System.Drawing.Point(57, 245);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(67, 23);
            this.btn_reg.TabIndex = 24;
            this.btn_reg.Text = "Registrar";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // dgdatos
            // 
            this.dgdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdatos.Location = new System.Drawing.Point(387, 135);
            this.dgdatos.Name = "dgdatos";
            this.dgdatos.Size = new System.Drawing.Size(465, 197);
            this.dgdatos.TabIndex = 23;
            this.dgdatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdatos_CellClick);
            this.dgdatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdatos_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(155, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(416, 37);
            this.label4.TabIndex = 22;
            this.label4.Text = "REGISTRO DEMANDANTE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "....";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Registro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Persona";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // txt_reg
            // 
            this.txt_reg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_reg.FormattingEnabled = true;
            this.txt_reg.Items.AddRange(new object[] {
            "ConsultorioUSP",
            "Fuera de Consultorio"});
            this.txt_reg.Location = new System.Drawing.Point(96, 200);
            this.txt_reg.Name = "txt_reg";
            this.txt_reg.Size = new System.Drawing.Size(121, 21);
            this.txt_reg.TabIndex = 28;
            this.txt_reg.SelectedIndexChanged += new System.EventHandler(this.txt_reg_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txt_idper
            // 
            this.txt_idper.Enabled = false;
            this.txt_idper.Location = new System.Drawing.Point(84, 150);
            this.txt_idper.Name = "txt_idper";
            this.txt_idper.ReadOnly = true;
            this.txt_idper.Size = new System.Drawing.Size(56, 20);
            this.txt_idper.TabIndex = 29;
            this.txt_idper.Validar = true;
            this.txt_idper.TextChanged += new System.EventHandler(this.txt_idper_TextChanged);
            // 
            // txt_nomper
            // 
            this.txt_nomper.Enabled = false;
            this.txt_nomper.Location = new System.Drawing.Point(162, 150);
            this.txt_nomper.Name = "txt_nomper";
            this.txt_nomper.ReadOnly = true;
            this.txt_nomper.Size = new System.Drawing.Size(130, 20);
            this.txt_nomper.TabIndex = 30;
            this.txt_nomper.Validar = true;
            this.txt_nomper.TextChanged += new System.EventHandler(this.txt_nomper_TextChanged);
            // 
            // txt_iddo
            // 
            this.txt_iddo.Enabled = false;
            this.txt_iddo.Location = new System.Drawing.Point(84, 104);
            this.txt_iddo.Name = "txt_iddo";
            this.txt_iddo.ReadOnly = true;
            this.txt_iddo.Size = new System.Drawing.Size(56, 20);
            this.txt_iddo.TabIndex = 31;
            this.txt_iddo.Validar = true;
            this.txt_iddo.TextChanged += new System.EventHandler(this.txt_iddo_TextChanged);
            // 
            // frm_demandante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(876, 360);
            this.Controls.Add(this.txt_iddo);
            this.Controls.Add(this.txt_nomper);
            this.Controls.Add(this.txt_idper);
            this.Controls.Add(this.txt_reg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.dgdatos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_demandante";
            this.Text = "frm_demandante";
            this.Activated += new System.EventHandler(this.frm_demandante_Activated);
            this.Load += new System.EventHandler(this.frm_demandante_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_buscar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.DataGridView dgdatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox txt_reg;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Capas.ErrorTxtBox txt_nomper;
        private Capas.ErrorTxtBox txt_idper;
        private Capas.ErrorTxtBox txt_iddo;
    }
}