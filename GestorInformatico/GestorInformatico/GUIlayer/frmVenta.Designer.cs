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
            this.txtNroVenta = new System.Windows.Forms.TextBox();
            this.lblNroVenta = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.grbVenta = new System.Windows.Forms.GroupBox();
            this.lblFormaDePago = new System.Windows.Forms.Label();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.lblArtículo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.cboArticulo = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.btnDpto = new System.Windows.Forms.Button();
            this.grbDetalles = new System.Windows.Forms.GroupBox();
            this.colCodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblDescTotal = new System.Windows.Forms.Label();
            this.txtDescTotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.grbVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.grbDetalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNroVenta
            // 
            this.txtNroVenta.Location = new System.Drawing.Point(82, 14);
            this.txtNroVenta.Name = "txtNroVenta";
            this.txtNroVenta.Size = new System.Drawing.Size(126, 20);
            this.txtNroVenta.TabIndex = 7;
            // 
            // lblNroVenta
            // 
            this.lblNroVenta.AutoSize = true;
            this.lblNroVenta.BackColor = System.Drawing.SystemColors.Control;
            this.lblNroVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNroVenta.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroVenta.Location = new System.Drawing.Point(6, 16);
            this.lblNroVenta.Name = "lblNroVenta";
            this.lblNroVenta.Size = new System.Drawing.Size(61, 17);
            this.lblNroVenta.TabIndex = 15;
            this.lblNroVenta.Text = "Nro. Venta";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(541, 13);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(126, 20);
            this.txtFecha.TabIndex = 18;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(319, 377);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // lblFecha
            // 
            this.lblFecha.BackColor = System.Drawing.SystemColors.Control;
            this.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFecha.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(446, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(80, 17);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "Fecha";
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.SystemColors.Control;
            this.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCliente.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(6, 42);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(61, 17);
            this.lblCliente.TabIndex = 54;
            this.lblCliente.Text = "Cliente";
            // 
            // grbVenta
            // 
            this.grbVenta.Controls.Add(this.txtCliente);
            this.grbVenta.Controls.Add(this.btnDpto);
            this.grbVenta.Controls.Add(this.txtPrecio);
            this.grbVenta.Controls.Add(this.txtDescuento);
            this.grbVenta.Controls.Add(this.txtCantidad);
            this.grbVenta.Controls.Add(this.cboArticulo);
            this.grbVenta.Controls.Add(this.lblDescuento);
            this.grbVenta.Controls.Add(this.lblPrecio);
            this.grbVenta.Controls.Add(this.lblCantidad);
            this.grbVenta.Controls.Add(this.lblArtículo);
            this.grbVenta.Controls.Add(this.cboFormaPago);
            this.grbVenta.Controls.Add(this.lblFormaDePago);
            this.grbVenta.Controls.Add(this.lblNroVenta);
            this.grbVenta.Controls.Add(this.txtNroVenta);
            this.grbVenta.Controls.Add(this.txtFecha);
            this.grbVenta.Controls.Add(this.lblFecha);
            this.grbVenta.Controls.Add(this.lblCliente);
            this.grbVenta.Location = new System.Drawing.Point(12, 12);
            this.grbVenta.Name = "grbVenta";
            this.grbVenta.Size = new System.Drawing.Size(676, 114);
            this.grbVenta.TabIndex = 25;
            this.grbVenta.TabStop = false;
            this.grbVenta.Text = "Venta";
            // 
            // lblFormaDePago
            // 
            this.lblFormaDePago.AutoSize = true;
            this.lblFormaDePago.BackColor = System.Drawing.SystemColors.Control;
            this.lblFormaDePago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFormaDePago.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaDePago.Location = new System.Drawing.Point(446, 42);
            this.lblFormaDePago.Name = "lblFormaDePago";
            this.lblFormaDePago.Size = new System.Drawing.Size(80, 17);
            this.lblFormaDePago.TabIndex = 55;
            this.lblFormaDePago.Text = "Forma de Pago";
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Location = new System.Drawing.Point(541, 40);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(126, 21);
            this.cboFormaPago.TabIndex = 57;
            // 
            // lblArtículo
            // 
            this.lblArtículo.AutoSize = true;
            this.lblArtículo.BackColor = System.Drawing.SystemColors.Control;
            this.lblArtículo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArtículo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtículo.Location = new System.Drawing.Point(41, 79);
            this.lblArtículo.Name = "lblArtículo";
            this.lblArtículo.Size = new System.Drawing.Size(49, 17);
            this.lblArtículo.TabIndex = 58;
            this.lblArtículo.Text = "Artículo";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.SystemColors.Control;
            this.lblCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCantidad.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(247, 81);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 17);
            this.lblCantidad.TabIndex = 59;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.SystemColors.Control;
            this.lblPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrecio.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(392, 79);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(39, 17);
            this.lblPrecio.TabIndex = 60;
            this.lblPrecio.Text = "Precio";
            // 
            // lblDescuento
            // 
            this.lblDescuento.BackColor = System.Drawing.SystemColors.Control;
            this.lblDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescuento.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(528, 78);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(61, 17);
            this.lblDescuento.TabIndex = 61;
            this.lblDescuento.Text = "Descuento";
            // 
            // cboArticulo
            // 
            this.cboArticulo.FormattingEnabled = true;
            this.cboArticulo.Location = new System.Drawing.Point(96, 78);
            this.cboArticulo.Name = "cboArticulo";
            this.cboArticulo.Size = new System.Drawing.Size(126, 21);
            this.cboArticulo.TabIndex = 62;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(307, 78);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(61, 20);
            this.txtCantidad.TabIndex = 63;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(595, 77);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(72, 20);
            this.txtDescuento.TabIndex = 64;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(437, 78);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(61, 20);
            this.txtPrecio.TabIndex = 65;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodProd,
            this.colNombre,
            this.colPrecioUnitario,
            this.colCantidad,
            this.colDescuento,
            this.colSubtotal});
            this.dgvDetalles.Location = new System.Drawing.Point(15, 19);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.Size = new System.Drawing.Size(643, 150);
            this.dgvDetalles.TabIndex = 66;
            // 
            // btnDpto
            // 
            this.btnDpto.Image = ((System.Drawing.Image)(resources.GetObject("btnDpto.Image")));
            this.btnDpto.Location = new System.Drawing.Point(6, 72);
            this.btnDpto.Name = "btnDpto";
            this.btnDpto.Size = new System.Drawing.Size(29, 29);
            this.btnDpto.TabIndex = 66;
            this.btnDpto.UseVisualStyleBackColor = true;
            // 
            // grbDetalles
            // 
            this.grbDetalles.Controls.Add(this.btnEliminar);
            this.grbDetalles.Controls.Add(this.btnModificar);
            this.grbDetalles.Controls.Add(this.lblTotal);
            this.grbDetalles.Controls.Add(this.txtTotal);
            this.grbDetalles.Controls.Add(this.txtDescTotal);
            this.grbDetalles.Controls.Add(this.lblDescTotal);
            this.grbDetalles.Controls.Add(this.txtSubtotal);
            this.grbDetalles.Controls.Add(this.lblSubtotal);
            this.grbDetalles.Controls.Add(this.dgvDetalles);
            this.grbDetalles.Location = new System.Drawing.Point(12, 132);
            this.grbDetalles.Name = "grbDetalles";
            this.grbDetalles.Size = new System.Drawing.Size(676, 239);
            this.grbDetalles.TabIndex = 67;
            this.grbDetalles.TabStop = false;
            this.grbDetalles.Text = "Detalles";
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
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotal.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(519, 170);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(61, 17);
            this.lblSubtotal.TabIndex = 67;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(586, 169);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(72, 20);
            this.txtSubtotal.TabIndex = 67;
            // 
            // lblDescTotal
            // 
            this.lblDescTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblDescTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescTotal.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescTotal.Location = new System.Drawing.Point(519, 191);
            this.lblDescTotal.Name = "lblDescTotal";
            this.lblDescTotal.Size = new System.Drawing.Size(61, 17);
            this.lblDescTotal.TabIndex = 67;
            this.lblDescTotal.Text = "Descuento";
            // 
            // txtDescTotal
            // 
            this.txtDescTotal.Location = new System.Drawing.Point(586, 190);
            this.txtDescTotal.Name = "txtDescTotal";
            this.txtDescTotal.Size = new System.Drawing.Size(72, 20);
            this.txtDescTotal.TabIndex = 68;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(586, 211);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(72, 20);
            this.txtTotal.TabIndex = 69;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(519, 212);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 17);
            this.lblTotal.TabIndex = 70;
            this.lblTotal.Text = "Total";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(349, 200);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(27, 29);
            this.btnEliminar.TabIndex = 72;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(316, 200);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(27, 29);
            this.btnModificar.TabIndex = 71;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(82, 40);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(126, 20);
            this.txtCliente.TabIndex = 67;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(700, 408);
            this.Controls.Add(this.grbDetalles);
            this.Controls.Add(this.grbVenta);
            this.Controls.Add(this.btnImprimir);
            this.Name = "frmVenta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            this.grbVenta.ResumeLayout(false);
            this.grbVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.grbDetalles.ResumeLayout(false);
            this.grbDetalles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNroVenta;
        private System.Windows.Forms.Label lblNroVenta;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.GroupBox grbVenta;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cboArticulo;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblArtículo;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.Label lblFormaDePago;
        private System.Windows.Forms.Button btnDpto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.GroupBox grbDetalles;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDescTotal;
        private System.Windows.Forms.Label lblDescTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtCliente;
    }
}