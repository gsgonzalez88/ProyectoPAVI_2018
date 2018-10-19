namespace GestorInformatico.GUIlayer
{
    partial class frmMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarca));
            this.lblCamposObli = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.colIdMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbMarca = new System.Windows.Forms.GroupBox();
            this.btnAlta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.grbMarca.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCamposObli
            // 
            this.lblCamposObli.AutoSize = true;
            this.lblCamposObli.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCamposObli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCamposObli.Location = new System.Drawing.Point(6, 16);
            this.lblCamposObli.Name = "lblCamposObli";
            this.lblCamposObli.Size = new System.Drawing.Size(105, 15);
            this.lblCamposObli.TabIndex = 5;
            this.lblCamposObli.Text = "Campos Obligatorios";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 41);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(65, 15);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(77, 38);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::GestorInformatico.Properties.Resources.add;
            this.btnAgregar.Location = new System.Drawing.Point(84, 64);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(27, 30);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Image = ((System.Drawing.Image)(resources.GetObject("btnBaja.Image")));
            this.btnBaja.Location = new System.Drawing.Point(150, 64);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(27, 30);
            this.btnBaja.TabIndex = 3;
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // dgvMarca
            // 
            this.dgvMarca.AllowUserToAddRows = false;
            this.dgvMarca.AllowUserToDeleteRows = false;
            this.dgvMarca.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdMarca,
            this.colDescripcion,
            this.colEstado});
            this.dgvMarca.Location = new System.Drawing.Point(244, 12);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.ReadOnly = true;
            this.dgvMarca.Size = new System.Drawing.Size(245, 108);
            this.dgvMarca.TabIndex = 4;
            this.dgvMarca.SelectionChanged += new System.EventHandler(this.dgvMarca_SelectionChanged);
            // 
            // colIdMarca
            // 
            this.colIdMarca.DataPropertyName = "IdMarca";
            this.colIdMarca.HeaderText = "IdMarca";
            this.colIdMarca.Name = "colIdMarca";
            this.colIdMarca.ReadOnly = true;
            this.colIdMarca.Visible = false;
            // 
            // colDescripcion
            // 
            this.colDescripcion.DataPropertyName = "Descripcion";
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "Descripcion1";
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // grbMarca
            // 
            this.grbMarca.Controls.Add(this.btnAlta);
            this.grbMarca.Controls.Add(this.lblCamposObli);
            this.grbMarca.Controls.Add(this.lblDescripcion);
            this.grbMarca.Controls.Add(this.btnBaja);
            this.grbMarca.Controls.Add(this.txtDescripcion);
            this.grbMarca.Controls.Add(this.btnAgregar);
            this.grbMarca.Location = new System.Drawing.Point(12, 12);
            this.grbMarca.Name = "grbMarca";
            this.grbMarca.Size = new System.Drawing.Size(200, 108);
            this.grbMarca.TabIndex = 7;
            this.grbMarca.TabStop = false;
            // 
            // btnAlta
            // 
            this.btnAlta.Image = global::GestorInformatico.Properties.Resources.accept;
            this.btnAlta.Location = new System.Drawing.Point(117, 64);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(27, 30);
            this.btnAlta.TabIndex = 2;
            this.btnAlta.UseVisualStyleBackColor = true;
            // 
            // frmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(501, 129);
            this.Controls.Add(this.grbMarca);
            this.Controls.Add(this.dgvMarca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMarca";
            this.Text = "Marca";
            this.Load += new System.EventHandler(this.frmMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            this.grbMarca.ResumeLayout(false);
            this.grbMarca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCamposObli;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.GroupBox grbMarca;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}