namespace GestorInformatico.GUIlayer
{
    partial class frmArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticulo));
            this.cboArticulo = new System.Windows.Forms.ComboBox();
            this.txtStockIngr = new System.Windows.Forms.TextBox();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.lblStockIngr = new System.Windows.Forms.Label();
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.ColIdArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbArticulo = new System.Windows.Forms.GroupBox();
            this.lblCamposObli = new System.Windows.Forms.Label();
            this.btnActualizarStock = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            this.grbArticulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboArticulo
            // 
            this.cboArticulo.FormattingEnabled = true;
            this.cboArticulo.Location = new System.Drawing.Point(102, 37);
            this.cboArticulo.Name = "cboArticulo";
            this.cboArticulo.Size = new System.Drawing.Size(175, 21);
            this.cboArticulo.TabIndex = 0;
            this.cboArticulo.TextChanged += new System.EventHandler(this.cboArticulo_TextChanged);
            // 
            // txtStockIngr
            // 
            this.txtStockIngr.Location = new System.Drawing.Point(102, 61);
            this.txtStockIngr.Name = "txtStockIngr";
            this.txtStockIngr.Size = new System.Drawing.Size(175, 20);
            this.txtStockIngr.TabIndex = 1;
            // 
            // lblArticulo
            // 
            this.lblArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArticulo.Location = new System.Drawing.Point(6, 40);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(90, 15);
            this.lblArticulo.TabIndex = 2;
            this.lblArticulo.Text = "Artículo";
            // 
            // lblStockIngr
            // 
            this.lblStockIngr.AutoSize = true;
            this.lblStockIngr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStockIngr.Location = new System.Drawing.Point(6, 64);
            this.lblStockIngr.Name = "lblStockIngr";
            this.lblStockIngr.Size = new System.Drawing.Size(90, 15);
            this.lblStockIngr.TabIndex = 3;
            this.lblStockIngr.Text = "Stock Ingresante";
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.AllowUserToAddRows = false;
            this.dgvArticulo.AllowUserToDeleteRows = false;
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdArticulo,
            this.ColDescripcion,
            this.ColStockActual,
            this.ColStockMinimo,
            this.ColPrecio,
            this.ColEstado});
            this.dgvArticulo.Location = new System.Drawing.Point(12, 118);
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.ReadOnly = true;
            this.dgvArticulo.Size = new System.Drawing.Size(545, 150);
            this.dgvArticulo.TabIndex = 4;
            // 
            // ColIdArticulo
            // 
            this.ColIdArticulo.DataPropertyName = "IdArticulo";
            this.ColIdArticulo.HeaderText = "IdArticulo";
            this.ColIdArticulo.Name = "ColIdArticulo";
            this.ColIdArticulo.ReadOnly = true;
            this.ColIdArticulo.Visible = false;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.DataPropertyName = "Descripcion";
            this.ColDescripcion.HeaderText = "Descripción";
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            // 
            // ColStockActual
            // 
            this.ColStockActual.DataPropertyName = "StockActual";
            this.ColStockActual.HeaderText = "Stock Actual";
            this.ColStockActual.Name = "ColStockActual";
            this.ColStockActual.ReadOnly = true;
            // 
            // ColStockMinimo
            // 
            this.ColStockMinimo.DataPropertyName = "StockMinimo";
            this.ColStockMinimo.HeaderText = "Stock Mínimo";
            this.ColStockMinimo.Name = "ColStockMinimo";
            this.ColStockMinimo.ReadOnly = true;
            // 
            // ColPrecio
            // 
            this.ColPrecio.DataPropertyName = "Precio";
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            // 
            // ColEstado
            // 
            this.ColEstado.DataPropertyName = "Descripcion1";
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.ReadOnly = true;
            // 
            // grbArticulo
            // 
            this.grbArticulo.Controls.Add(this.lblCamposObli);
            this.grbArticulo.Controls.Add(this.lblArticulo);
            this.grbArticulo.Controls.Add(this.cboArticulo);
            this.grbArticulo.Controls.Add(this.txtStockIngr);
            this.grbArticulo.Controls.Add(this.lblStockIngr);
            this.grbArticulo.Location = new System.Drawing.Point(12, 12);
            this.grbArticulo.Name = "grbArticulo";
            this.grbArticulo.Size = new System.Drawing.Size(286, 100);
            this.grbArticulo.TabIndex = 5;
            this.grbArticulo.TabStop = false;
            // 
            // lblCamposObli
            // 
            this.lblCamposObli.AutoSize = true;
            this.lblCamposObli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCamposObli.Location = new System.Drawing.Point(6, 16);
            this.lblCamposObli.Name = "lblCamposObli";
            this.lblCamposObli.Size = new System.Drawing.Size(105, 15);
            this.lblCamposObli.TabIndex = 0;
            this.lblCamposObli.Text = "Campos Obligatorios";
            // 
            // btnActualizarStock
            // 
            this.btnActualizarStock.Image = global::GestorInformatico.Properties.Resources.arrow_refresh;
            this.btnActualizarStock.Location = new System.Drawing.Point(350, 52);
            this.btnActualizarStock.Name = "btnActualizarStock";
            this.btnActualizarStock.Size = new System.Drawing.Size(26, 23);
            this.btnActualizarStock.TabIndex = 6;
            this.btnActualizarStock.UseVisualStyleBackColor = true;
            this.btnActualizarStock.Click += new System.EventHandler(this.btnActualizarStock_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::GestorInformatico.Properties.Resources.pencil_add;
            this.btnEditar.Location = new System.Drawing.Point(446, 52);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(26, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Image = global::GestorInformatico.Properties.Resources.accept;
            this.btnAlta.Location = new System.Drawing.Point(382, 52);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(26, 23);
            this.btnAlta.TabIndex = 9;
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Image = global::GestorInformatico.Properties.Resources.delete;
            this.btnBaja.Location = new System.Drawing.Point(414, 52);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(26, 23);
            this.btnBaja.TabIndex = 10;
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::GestorInformatico.Properties.Resources.add;
            this.btnNuevo.Location = new System.Drawing.Point(478, 52);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(26, 23);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(570, 281);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnActualizarStock);
            this.Controls.Add(this.grbArticulo);
            this.Controls.Add(this.dgvArticulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArticulo";
            this.Text = "Artículo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmArticulo_FormClosing);
            this.Load += new System.EventHandler(this.frmArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            this.grbArticulo.ResumeLayout(false);
            this.grbArticulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboArticulo;
        private System.Windows.Forms.TextBox txtStockIngr;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Label lblStockIngr;
        private System.Windows.Forms.DataGridView dgvArticulo;
        private System.Windows.Forms.GroupBox grbArticulo;
        private System.Windows.Forms.Label lblCamposObli;
        private System.Windows.Forms.Button btnActualizarStock;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
        private System.Windows.Forms.Button btnNuevo;

    }
}