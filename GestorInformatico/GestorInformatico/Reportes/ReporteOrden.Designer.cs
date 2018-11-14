namespace GestorInformatico.Reportes
{
    partial class ReporteOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteOrden));
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.ckbMarca = new System.Windows.Forms.CheckBox();
            this.ckbSolicitante = new System.Windows.Forms.CheckBox();
            this.ckbEncargado = new System.Windows.Forms.CheckBox();
            this.ckbEstado = new System.Windows.Forms.CheckBox();
            this.ckbFecha = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbSolicitante = new System.Windows.Forms.ComboBox();
            this.cmbEncargado = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(98, 10);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(213, 21);
            this.cmbMarca.TabIndex = 2;
            // 
            // ckbMarca
            // 
            this.ckbMarca.AutoSize = true;
            this.ckbMarca.Location = new System.Drawing.Point(12, 12);
            this.ckbMarca.Name = "ckbMarca";
            this.ckbMarca.Size = new System.Drawing.Size(56, 17);
            this.ckbMarca.TabIndex = 3;
            this.ckbMarca.Text = "Marca";
            this.ckbMarca.UseVisualStyleBackColor = true;
            this.ckbMarca.CheckedChanged += new System.EventHandler(this.ckbMarca_CheckedChanged);
            // 
            // ckbSolicitante
            // 
            this.ckbSolicitante.AutoSize = true;
            this.ckbSolicitante.Location = new System.Drawing.Point(12, 45);
            this.ckbSolicitante.Name = "ckbSolicitante";
            this.ckbSolicitante.Size = new System.Drawing.Size(75, 17);
            this.ckbSolicitante.TabIndex = 4;
            this.ckbSolicitante.Text = "Solicitante";
            this.ckbSolicitante.UseVisualStyleBackColor = true;
            this.ckbSolicitante.CheckedChanged += new System.EventHandler(this.ckbSolicitante_CheckedChanged);
            // 
            // ckbEncargado
            // 
            this.ckbEncargado.AutoSize = true;
            this.ckbEncargado.Location = new System.Drawing.Point(12, 81);
            this.ckbEncargado.Name = "ckbEncargado";
            this.ckbEncargado.Size = new System.Drawing.Size(78, 17);
            this.ckbEncargado.TabIndex = 5;
            this.ckbEncargado.Text = "Encargado";
            this.ckbEncargado.UseVisualStyleBackColor = true;
            this.ckbEncargado.CheckedChanged += new System.EventHandler(this.ckbEncargado_CheckedChanged);
            // 
            // ckbEstado
            // 
            this.ckbEstado.AutoSize = true;
            this.ckbEstado.Location = new System.Drawing.Point(12, 119);
            this.ckbEstado.Name = "ckbEstado";
            this.ckbEstado.Size = new System.Drawing.Size(59, 17);
            this.ckbEstado.TabIndex = 6;
            this.ckbEstado.Text = "Estado";
            this.ckbEstado.UseVisualStyleBackColor = true;
            this.ckbEstado.CheckedChanged += new System.EventHandler(this.ckbEstado_CheckedChanged);
            // 
            // ckbFecha
            // 
            this.ckbFecha.AutoSize = true;
            this.ckbFecha.Location = new System.Drawing.Point(12, 156);
            this.ckbFecha.Name = "ckbFecha";
            this.ckbFecha.Size = new System.Drawing.Size(91, 17);
            this.ckbFecha.TabIndex = 7;
            this.ckbFecha.Text = "Fecha desde:";
            this.ckbFecha.UseVisualStyleBackColor = true;
            this.ckbFecha.CheckedChanged += new System.EventHandler(this.ckbFecha_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Image = global::GestorInformatico.Properties.Resources.arrow_refresh;
            this.button2.Location = new System.Drawing.Point(236, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(109, 153);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(108, 20);
            this.dtpDesde.TabIndex = 9;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(264, 153);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(108, 20);
            this.dtpHasta.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hasta";
            // 
            // button1
            // 
            this.button1.Image = global::GestorInformatico.Properties.Resources.printer;
            this.button1.Location = new System.Drawing.Point(155, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbSolicitante
            // 
            this.cmbSolicitante.FormattingEnabled = true;
            this.cmbSolicitante.Location = new System.Drawing.Point(98, 41);
            this.cmbSolicitante.Name = "cmbSolicitante";
            this.cmbSolicitante.Size = new System.Drawing.Size(213, 21);
            this.cmbSolicitante.TabIndex = 12;
            // 
            // cmbEncargado
            // 
            this.cmbEncargado.FormattingEnabled = true;
            this.cmbEncargado.Location = new System.Drawing.Point(98, 77);
            this.cmbEncargado.Name = "cmbEncargado";
            this.cmbEncargado.Size = new System.Drawing.Size(213, 21);
            this.cmbEncargado.TabIndex = 13;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(98, 115);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(213, 21);
            this.cmbEstado.TabIndex = 14;
            // 
            // ReporteOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(379, 226);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbEncargado);
            this.Controls.Add(this.cmbSolicitante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ckbFecha);
            this.Controls.Add(this.ckbEstado);
            this.Controls.Add(this.ckbEncargado);
            this.Controls.Add(this.ckbSolicitante);
            this.Controls.Add(this.ckbMarca);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteOrden";
            this.Text = "Reporte Orden";
            this.Load += new System.EventHandler(this.ReporteOrden_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.CheckBox ckbMarca;
        private System.Windows.Forms.CheckBox ckbSolicitante;
        private System.Windows.Forms.CheckBox ckbEncargado;
        private System.Windows.Forms.CheckBox ckbEstado;
        private System.Windows.Forms.CheckBox ckbFecha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSolicitante;
        private System.Windows.Forms.ComboBox cmbEncargado;
        private System.Windows.Forms.ComboBox cmbEstado;
    }
}