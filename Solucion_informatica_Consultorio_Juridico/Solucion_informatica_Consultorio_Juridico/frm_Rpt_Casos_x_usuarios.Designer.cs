namespace Solucion_informatica_Consultorio_Juridico
{
    partial class frm_Rpt_Casos_x_usuarios
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
            this.dp_ini = new System.Windows.Forms.DateTimePicker();
            this.dp_fini = new System.Windows.Forms.DateTimePicker();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dp_ini
            // 
            this.dp_ini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_ini.Location = new System.Drawing.Point(139, 37);
            this.dp_ini.Name = "dp_ini";
            this.dp_ini.Size = new System.Drawing.Size(95, 20);
            this.dp_ini.TabIndex = 0;
            // 
            // dp_fini
            // 
            this.dp_fini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_fini.Location = new System.Drawing.Point(403, 37);
            this.dp_fini.Name = "dp_fini";
            this.dp_fini.Size = new System.Drawing.Size(95, 20);
            this.dp_fini.TabIndex = 0;
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(139, 79);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(133, 20);
            this.txt_dni.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 131);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(776, 307);
            this.crystalReportViewer1.TabIndex = 3;
            // 
            // btn_reporte
            // 
            this.btn_reporte.Location = new System.Drawing.Point(558, 71);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(75, 23);
            this.btn_reporte.TabIndex = 4;
            this.btn_reporte.Text = "Reportar";
            this.btn_reporte.UseVisualStyleBackColor = true;
            this.btn_reporte.Click += new System.EventHandler(this.btn_reporte_Click);
            // 
            // frm_Rpt_Casos_x_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.dp_fini);
            this.Controls.Add(this.dp_ini);
            this.Name = "frm_Rpt_Casos_x_usuarios";
            this.Text = "Reporte Casos por Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dp_ini;
        private System.Windows.Forms.DateTimePicker dp_fini;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btn_reporte;
    }
}