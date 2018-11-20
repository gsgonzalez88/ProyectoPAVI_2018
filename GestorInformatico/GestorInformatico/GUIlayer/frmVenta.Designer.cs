namespace GestorInformatico.GUIlayer
{
    partial class frmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDNICli = new System.Windows.Forms.Label();
            this.grbVenta = new System.Windows.Forms.GroupBox();
            this.lblCamposObli = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.btnRegCliente = new System.Windows.Forms.Button();
            this.lblNombreCli = new System.Windows.Forms.Label();
            this.txtNombreCli = new System.Windows.Forms.TextBox();
            this.txtDNICli = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboArticulo = new System.Windows.Forms.ComboBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblArtículo = new System.Windows.Forms.Label();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.lblFormaDePago = new System.Windows.Forms.Label();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.colCodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDetalles = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnGuargar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grbVenta.SuspendLayout();
            this.grbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.grbDetalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(541, 13);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(126, 20);
            this.txtFecha.TabIndex = 14;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(376, 393);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(37, 38);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.BackColor = System.Drawing.SystemColors.Window;
            this.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFecha.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(446, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(80, 17);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha";
            // 
            // lblDNICli
            // 
            this.lblDNICli.BackColor = System.Drawing.SystemColors.Window;
            this.lblDNICli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDNICli.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNICli.Location = new System.Drawing.Point(6, 22);
            this.lblDNICli.Name = "lblDNICli";
            this.lblDNICli.Size = new System.Drawing.Size(50, 17);
            this.lblDNICli.TabIndex = 15;
            this.lblDNICli.Text = "DNI";
            // 
            // grbVenta
            // 
            this.grbVenta.Controls.Add(this.lblCamposObli);
            this.grbVenta.Controls.Add(this.txtPrecio);
            this.grbVenta.Controls.Add(this.lblPrecio);
            this.grbVenta.Controls.Add(this.txtCantidad);
            this.grbVenta.Controls.Add(this.grbCliente);
            this.grbVenta.Controls.Add(this.cboEmpleado);
            this.grbVenta.Controls.Add(this.lblEmpleado);
            this.grbVenta.Controls.Add(this.txtStock);
            this.grbVenta.Controls.Add(this.btnAgregar);
            this.grbVenta.Controls.Add(this.cboArticulo);
            this.grbVenta.Controls.Add(this.lblStock);
            this.grbVenta.Controls.Add(this.lblCantidad);
            this.grbVenta.Controls.Add(this.lblArtículo);
            this.grbVenta.Controls.Add(this.cboFormaPago);
            this.grbVenta.Controls.Add(this.lblFormaDePago);
            this.grbVenta.Controls.Add(this.txtFecha);
            this.grbVenta.Controls.Add(this.lblFecha);
            this.grbVenta.Location = new System.Drawing.Point(12, 12);
            this.grbVenta.Name = "grbVenta";
            this.grbVenta.Size = new System.Drawing.Size(676, 175);
            this.grbVenta.TabIndex = 29;
            this.grbVenta.TabStop = false;
            this.grbVenta.Text = "Venta";
            // 
            // lblCamposObli
            // 
            this.lblCamposObli.AutoSize = true;
            this.lblCamposObli.BackColor = System.Drawing.SystemColors.Window;
            this.lblCamposObli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCamposObli.Location = new System.Drawing.Point(12, 18);
            this.lblCamposObli.Name = "lblCamposObli";
            this.lblCamposObli.Size = new System.Drawing.Size(105, 15);
            this.lblCamposObli.TabIndex = 12;
            this.lblCamposObli.Text = "Campos Obligatorios";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(463, 140);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(59, 20);
            this.txtPrecio.TabIndex = 77;
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.SystemColors.Window;
            this.lblPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrecio.Location = new System.Drawing.Point(417, 141);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 17);
            this.lblPrecio.TabIndex = 23;
            this.lblPrecio.Text = "Precio";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(608, 140);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(59, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // grbCliente
            // 
            this.grbCliente.Controls.Add(this.btnRegCliente);
            this.grbCliente.Controls.Add(this.lblNombreCli);
            this.grbCliente.Controls.Add(this.txtNombreCli);
            this.grbCliente.Controls.Add(this.txtDNICli);
            this.grbCliente.Controls.Add(this.btnBuscar);
            this.grbCliente.Controls.Add(this.lblDNICli);
            this.grbCliente.Location = new System.Drawing.Point(6, 42);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Size = new System.Drawing.Size(328, 78);
            this.grbCliente.TabIndex = 75;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "Cliente";
            this.grbCliente.Enter += new System.EventHandler(this.grbCliente_Enter);
            // 
            // btnRegCliente
            // 
            this.btnRegCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnRegCliente.Image")));
            this.btnRegCliente.Location = new System.Drawing.Point(281, 25);
            this.btnRegCliente.Name = "btnRegCliente";
            this.btnRegCliente.Size = new System.Drawing.Size(37, 38);
            this.btnRegCliente.TabIndex = 18;
            this.btnRegCliente.UseVisualStyleBackColor = true;
            this.btnRegCliente.Click += new System.EventHandler(this.btnRegCliente_Click);
            // 
            // lblNombreCli
            // 
            this.lblNombreCli.BackColor = System.Drawing.SystemColors.Window;
            this.lblNombreCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombreCli.Location = new System.Drawing.Point(6, 49);
            this.lblNombreCli.Name = "lblNombreCli";
            this.lblNombreCli.Size = new System.Drawing.Size(50, 17);
            this.lblNombreCli.TabIndex = 16;
            this.lblNombreCli.Text = "Nombre";
            // 
            // txtNombreCli
            // 
            this.txtNombreCli.Location = new System.Drawing.Point(62, 47);
            this.txtNombreCli.Name = "txtNombreCli";
            this.txtNombreCli.Size = new System.Drawing.Size(171, 20);
            this.txtNombreCli.TabIndex = 17;
            // 
            // txtDNICli
            // 
            this.txtDNICli.Location = new System.Drawing.Point(62, 21);
            this.txtDNICli.Name = "txtDNICli";
            this.txtDNICli.Size = new System.Drawing.Size(171, 20);
            this.txtDNICli.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(239, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(37, 38);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(541, 89);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(126, 21);
            this.cboEmpleado.TabIndex = 4;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.BackColor = System.Drawing.SystemColors.Window;
            this.lblEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpleado.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(446, 91);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(80, 17);
            this.lblEmpleado.TabIndex = 20;
            this.lblEmpleado.Text = "Empleado";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(330, 139);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(59, 20);
            this.txtStock.TabIndex = 65;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(12, 129);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(37, 38);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnDpto_Click);
            // 
            // cboArticulo
            // 
            this.cboArticulo.FormattingEnabled = true;
            this.cboArticulo.Location = new System.Drawing.Point(110, 139);
            this.cboArticulo.Name = "cboArticulo";
            this.cboArticulo.Size = new System.Drawing.Size(147, 21);
            this.cboArticulo.TabIndex = 5;
            this.cboArticulo.TextChanged += new System.EventHandler(this.cboArticulo_TextChanged);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.SystemColors.Window;
            this.lblStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStock.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(288, 141);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(36, 17);
            this.lblStock.TabIndex = 22;
            this.lblStock.Text = "Stock";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.SystemColors.Window;
            this.lblCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCantidad.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(550, 141);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 17);
            this.lblCantidad.TabIndex = 24;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblArtículo
            // 
            this.lblArtículo.AutoSize = true;
            this.lblArtículo.BackColor = System.Drawing.SystemColors.Window;
            this.lblArtículo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArtículo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtículo.Location = new System.Drawing.Point(55, 141);
            this.lblArtículo.Name = "lblArtículo";
            this.lblArtículo.Size = new System.Drawing.Size(49, 17);
            this.lblArtículo.TabIndex = 21;
            this.lblArtículo.Text = "Artículo";
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Location = new System.Drawing.Point(541, 51);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(126, 21);
            this.cboFormaPago.TabIndex = 3;
            this.cboFormaPago.SelectedIndexChanged += new System.EventHandler(this.cboFormaPago_SelectedIndexChanged);
            // 
            // lblFormaDePago
            // 
            this.lblFormaDePago.AutoSize = true;
            this.lblFormaDePago.BackColor = System.Drawing.SystemColors.Window;
            this.lblFormaDePago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFormaDePago.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaDePago.Location = new System.Drawing.Point(446, 53);
            this.lblFormaDePago.Name = "lblFormaDePago";
            this.lblFormaDePago.Size = new System.Drawing.Size(80, 17);
            this.lblFormaDePago.TabIndex = 19;
            this.lblFormaDePago.Text = "Forma de Pago";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodProd,
            this.colNombre,
            this.colPrecioUnitario,
            this.colCantidad,
            this.colDescuento,
            this.colSubtotal});
            this.dgvDetalles.Location = new System.Drawing.Point(13, 19);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.Size = new System.Drawing.Size(652, 142);
            this.dgvDetalles.TabIndex = 27;
            // 
            // colCodProd
            // 
            this.colCodProd.HeaderText = "Cod. Prod.";
            this.colCodProd.Name = "colCodProd";
            this.colCodProd.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.HeaderText = "Precio Unitario";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // colDescuento
            // 
            this.colDescuento.HeaderText = "Descuento";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.ReadOnly = true;
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            // 
            // grbDetalles
            // 
            this.grbDetalles.Controls.Add(this.lblTotal);
            this.grbDetalles.Controls.Add(this.txtTotal);
            this.grbDetalles.Controls.Add(this.dgvDetalles);
            this.grbDetalles.Location = new System.Drawing.Point(12, 193);
            this.grbDetalles.Name = "grbDetalles";
            this.grbDetalles.Size = new System.Drawing.Size(676, 194);
            this.grbDetalles.TabIndex = 28;
            this.grbDetalles.TabStop = false;
            this.grbDetalles.Text = "Detalles";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.Window;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(528, 168);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 17);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(595, 167);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(72, 20);
            this.txtTotal.TabIndex = 26;
            // 
            // btnGuargar
            // 
            this.btnGuargar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuargar.Image")));
            this.btnGuargar.Location = new System.Drawing.Point(290, 393);
            this.btnGuargar.Name = "btnGuargar";
            this.btnGuargar.Size = new System.Drawing.Size(37, 38);
            this.btnGuargar.TabIndex = 8;
            this.btnGuargar.UseVisualStyleBackColor = true;
            this.btnGuargar.Click += new System.EventHandler(this.btnGuargar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(333, 393);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(37, 38);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(700, 441);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnGuargar);
            this.Controls.Add(this.grbDetalles);
            this.Controls.Add(this.grbVenta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVenta";
            this.Text = "Venta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVenta_FormClosing);
            this.Load += new System.EventHandler(this.frmVenta_Load);
            this.grbVenta.ResumeLayout(false);
            this.grbVenta.PerformLayout();
            this.grbCliente.ResumeLayout(false);
            this.grbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.grbDetalles.ResumeLayout(false);
            this.grbDetalles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDNICli;
        private System.Windows.Forms.GroupBox grbVenta;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cboArticulo;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblArtículo;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.Label lblFormaDePago;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.GroupBox grbDetalles;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtDNICli;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuargar;
        private System.Windows.Forms.GroupBox grbCliente;
        private System.Windows.Forms.Label lblNombreCli;
        private System.Windows.Forms.TextBox txtNombreCli;
        private System.Windows.Forms.Label lblCamposObli;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnRegCliente;
    }
}