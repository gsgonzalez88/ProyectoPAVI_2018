﻿namespace GestorInformatico.GUIlayer
{
    partial class frmFormaPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormaPago));
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.dgvFormaPago = new System.Windows.Forms.DataGridView();
            this.colIdFormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbFormaPago = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormaPago)).BeginInit();
            this.grbFormaPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::GestorInformatico.Properties.Resources.pencil_add;
            this.btnModificar.Location = new System.Drawing.Point(171, 98);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(38, 38);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblDescuento
            // 
            this.lblDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescuento.Location = new System.Drawing.Point(6, 74);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(65, 20);
            this.lblDescuento.TabIndex = 4;
            this.lblDescuento.Text = "Descuento";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(77, 44);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(132, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(77, 72);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(132, 20);
            this.txtDescuento.TabIndex = 6;
            // 
            // dgvFormaPago
            // 
            this.dgvFormaPago.AllowUserToAddRows = false;
            this.dgvFormaPago.AllowUserToDeleteRows = false;
            this.dgvFormaPago.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvFormaPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormaPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdFormaPago,
            this.colDescripcion,
            this.colDescuento});
            this.dgvFormaPago.Location = new System.Drawing.Point(240, 8);
            this.dgvFormaPago.Name = "dgvFormaPago";
            this.dgvFormaPago.ReadOnly = true;
            this.dgvFormaPago.Size = new System.Drawing.Size(245, 150);
            this.dgvFormaPago.TabIndex = 7;
            // 
            // colIdFormaPago
            // 
            this.colIdFormaPago.DataPropertyName = "IdTipoFP";
            this.colIdFormaPago.HeaderText = "IdFormaPago";
            this.colIdFormaPago.Name = "colIdFormaPago";
            this.colIdFormaPago.ReadOnly = true;
            this.colIdFormaPago.Visible = false;
            // 
            // colDescripcion
            // 
            this.colDescripcion.DataPropertyName = "Descripcion";
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            // 
            // colDescuento
            // 
            this.colDescuento.DataPropertyName = "Descuento";
            this.colDescuento.HeaderText = "Descuento";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.ReadOnly = true;
            // 
            // grbFormaPago
            // 
            this.grbFormaPago.Controls.Add(this.label2);
            this.grbFormaPago.Controls.Add(this.label1);
            this.grbFormaPago.Controls.Add(this.lblDescuento);
            this.grbFormaPago.Controls.Add(this.btnGuardar);
            this.grbFormaPago.Controls.Add(this.txtDescuento);
            this.grbFormaPago.Controls.Add(this.btnModificar);
            this.grbFormaPago.Controls.Add(this.txtDescripcion);
            this.grbFormaPago.Location = new System.Drawing.Point(10, 8);
            this.grbFormaPago.Name = "grbFormaPago";
            this.grbFormaPago.Size = new System.Drawing.Size(224, 150);
            this.grbFormaPago.TabIndex = 8;
            this.grbFormaPago.TabStop = false;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Campos Obligatorios";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Descripcion";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::GestorInformatico.Properties.Resources.accept;
            this.btnGuardar.Location = new System.Drawing.Point(127, 98);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(38, 38);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmFormaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(494, 168);
            this.Controls.Add(this.grbFormaPago);
            this.Controls.Add(this.dgvFormaPago);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFormaPago";
            this.Text = "Forma de Pago";
            this.Load += new System.EventHandler(this.frmFormaPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormaPago)).EndInit();
            this.grbFormaPago.ResumeLayout(false);
            this.grbFormaPago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.DataGridView dgvFormaPago;
        private System.Windows.Forms.GroupBox grbFormaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdFormaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescuento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}