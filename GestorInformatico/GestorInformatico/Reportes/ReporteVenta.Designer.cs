namespace GestorInformatico.Reportes
{
    partial class ReporteVenta
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.grbFecha = new System.Windows.Forms.GroupBox();
            this.btnInformeFecha = new System.Windows.Forms.Button();
            this.grbEmpleado = new System.Windows.Forms.GroupBox();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.btnInformeEmpleado = new System.Windows.Forms.Button();
            this.grbArticulo = new System.Windows.Forms.GroupBox();
            this.btnInformeArticulo = new System.Windows.Forms.Button();
            this.grbFecha.SuspendLayout();
            this.grbEmpleado.SuspendLayout();
            this.grbArticulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(6, 19);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(127, 20);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.Value = new System.DateTime(2018, 11, 19, 0, 0, 0, 0);
            // 
            // grbFecha
            // 
            this.grbFecha.Controls.Add(this.btnInformeFecha);
            this.grbFecha.Controls.Add(this.dtpFecha);
            this.grbFecha.Location = new System.Drawing.Point(12, 12);
            this.grbFecha.Name = "grbFecha";
            this.grbFecha.Size = new System.Drawing.Size(141, 86);
            this.grbFecha.TabIndex = 2;
            this.grbFecha.TabStop = false;
            this.grbFecha.Text = "Filtrar por fecha";
            // 
            // btnInformeFecha
            // 
            this.btnInformeFecha.Location = new System.Drawing.Point(27, 45);
            this.btnInformeFecha.Name = "btnInformeFecha";
            this.btnInformeFecha.Size = new System.Drawing.Size(75, 23);
            this.btnInformeFecha.TabIndex = 2;
            this.btnInformeFecha.Text = "Generar";
            this.btnInformeFecha.UseVisualStyleBackColor = true;
            this.btnInformeFecha.Click += new System.EventHandler(this.btnInformeFecha_Click);
            // 
            // grbEmpleado
            // 
            this.grbEmpleado.Controls.Add(this.cboEmpleado);
            this.grbEmpleado.Controls.Add(this.btnInformeEmpleado);
            this.grbEmpleado.Location = new System.Drawing.Point(159, 12);
            this.grbEmpleado.Name = "grbEmpleado";
            this.grbEmpleado.Size = new System.Drawing.Size(135, 86);
            this.grbEmpleado.TabIndex = 3;
            this.grbEmpleado.TabStop = false;
            this.grbEmpleado.Text = "Filtrar por empleado";
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(6, 19);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cboEmpleado.TabIndex = 1;
            // 
            // btnInformeEmpleado
            // 
            this.btnInformeEmpleado.Location = new System.Drawing.Point(29, 46);
            this.btnInformeEmpleado.Name = "btnInformeEmpleado";
            this.btnInformeEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnInformeEmpleado.TabIndex = 0;
            this.btnInformeEmpleado.Text = "Generar";
            this.btnInformeEmpleado.UseVisualStyleBackColor = true;
            this.btnInformeEmpleado.Click += new System.EventHandler(this.btnInformeEmpleado_Click);
            // 
            // grbArticulo
            // 
            this.grbArticulo.Controls.Add(this.btnInformeArticulo);
            this.grbArticulo.Location = new System.Drawing.Point(300, 12);
            this.grbArticulo.Name = "grbArticulo";
            this.grbArticulo.Size = new System.Drawing.Size(137, 86);
            this.grbArticulo.TabIndex = 4;
            this.grbArticulo.TabStop = false;
            this.grbArticulo.Text = "Articulos mas vendidos";
            // 
            // btnInformeArticulo
            // 
            this.btnInformeArticulo.Location = new System.Drawing.Point(32, 45);
            this.btnInformeArticulo.Name = "btnInformeArticulo";
            this.btnInformeArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnInformeArticulo.TabIndex = 0;
            this.btnInformeArticulo.Text = "Generar";
            this.btnInformeArticulo.UseVisualStyleBackColor = true;
            this.btnInformeArticulo.Click += new System.EventHandler(this.btnInformeArticulo_Click);
            // 
            // ReporteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 106);
            this.Controls.Add(this.grbArticulo);
            this.Controls.Add(this.grbEmpleado);
            this.Controls.Add(this.grbFecha);
            this.Name = "ReporteVenta";
            this.Text = "ReporteVenta";
            this.Load += new System.EventHandler(this.ReporteVenta_Load);
            this.grbFecha.ResumeLayout(false);
            this.grbEmpleado.ResumeLayout(false);
            this.grbArticulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox grbFecha;
        private System.Windows.Forms.Button btnInformeFecha;
        private System.Windows.Forms.GroupBox grbEmpleado;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.Button btnInformeEmpleado;
        private System.Windows.Forms.GroupBox grbArticulo;
        private System.Windows.Forms.Button btnInformeArticulo;

    }
}