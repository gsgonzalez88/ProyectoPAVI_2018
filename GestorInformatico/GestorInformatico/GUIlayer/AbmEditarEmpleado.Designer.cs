namespace GestorInformatico.GUIlayer
{
    partial class AbmEditarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbmEditarEmpleado));
            this.grBoxEmpleados = new System.Windows.Forms.GroupBox();
            this.cmbTDoc = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombreEmp = new System.Windows.Forms.TextBox();
            this.grBoxDomicilio = new System.Windows.Forms.GroupBox();
            this.btnProvincia = new System.Windows.Forms.Button();
            this.btnDpto = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnBarrio = new System.Windows.Forms.Button();
            this.cmbProvin = new System.Windows.Forms.ComboBox();
            this.cmbDepto = new System.Windows.Forms.ComboBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.txtNumeroCalle = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblNroCalle = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblCamposOb = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grBoxEmpleados.SuspendLayout();
            this.grBoxDomicilio.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBoxEmpleados
            // 
            this.grBoxEmpleados.Controls.Add(this.cmbTDoc);
            this.grBoxEmpleados.Controls.Add(this.txtTelefono);
            this.grBoxEmpleados.Controls.Add(this.txtNroDocumento);
            this.grBoxEmpleados.Controls.Add(this.lblTelefono);
            this.grBoxEmpleados.Controls.Add(this.lblNroDoc);
            this.grBoxEmpleados.Controls.Add(this.txtEmail);
            this.grBoxEmpleados.Controls.Add(this.lblEmail);
            this.grBoxEmpleados.Controls.Add(this.lblTipoDoc);
            this.grBoxEmpleados.Controls.Add(this.lblApellido);
            this.grBoxEmpleados.Controls.Add(this.lblNombre);
            this.grBoxEmpleados.Controls.Add(this.txtApellido);
            this.grBoxEmpleados.Controls.Add(this.txtNombreEmp);
            this.grBoxEmpleados.Location = new System.Drawing.Point(12, 41);
            this.grBoxEmpleados.Name = "grBoxEmpleados";
            this.grBoxEmpleados.Size = new System.Drawing.Size(284, 212);
            this.grBoxEmpleados.TabIndex = 3;
            this.grBoxEmpleados.TabStop = false;
            this.grBoxEmpleados.Text = "Datos Personales";
            // 
            // cmbTDoc
            // 
            this.cmbTDoc.FormattingEnabled = true;
            this.cmbTDoc.Location = new System.Drawing.Point(130, 81);
            this.cmbTDoc.Name = "cmbTDoc";
            this.cmbTDoc.Size = new System.Drawing.Size(119, 21);
            this.cmbTDoc.TabIndex = 48;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(130, 176);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(119, 20);
            this.txtTelefono.TabIndex = 26;
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(130, 112);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(119, 20);
            this.txtNroDocumento.TabIndex = 26;
            // 
            // lblTelefono
            // 
            this.lblTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.lblTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTelefono.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(6, 177);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(103, 21);
            this.lblTelefono.TabIndex = 25;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.BackColor = System.Drawing.SystemColors.Control;
            this.lblNroDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNroDoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDoc.Location = new System.Drawing.Point(6, 113);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(103, 21);
            this.lblNroDoc.TabIndex = 17;
            this.lblNroDoc.Text = "N° Documento";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(130, 144);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(119, 20);
            this.txtEmail.TabIndex = 18;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(6, 145);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(103, 21);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Email";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.BackColor = System.Drawing.SystemColors.Control;
            this.lblTipoDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTipoDoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(6, 81);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(103, 21);
            this.lblTipoDoc.TabIndex = 16;
            this.lblTipoDoc.Text = "Tipo Documento";
            // 
            // lblApellido
            // 
            this.lblApellido.BackColor = System.Drawing.SystemColors.Control;
            this.lblApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblApellido.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(6, 49);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(103, 21);
            this.lblApellido.TabIndex = 15;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.SystemColors.Control;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 17);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(103, 21);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(130, 48);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(119, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // txtNombreEmp
            // 
            this.txtNombreEmp.Location = new System.Drawing.Point(130, 16);
            this.txtNombreEmp.Name = "txtNombreEmp";
            this.txtNombreEmp.Size = new System.Drawing.Size(119, 20);
            this.txtNombreEmp.TabIndex = 3;
            // 
            // grBoxDomicilio
            // 
            this.grBoxDomicilio.Controls.Add(this.btnProvincia);
            this.grBoxDomicilio.Controls.Add(this.btnDpto);
            this.grBoxDomicilio.Controls.Add(this.btnLoc);
            this.grBoxDomicilio.Controls.Add(this.btnBarrio);
            this.grBoxDomicilio.Controls.Add(this.cmbProvin);
            this.grBoxDomicilio.Controls.Add(this.cmbDepto);
            this.grBoxDomicilio.Controls.Add(this.cmbLocalidad);
            this.grBoxDomicilio.Controls.Add(this.cmbBarrio);
            this.grBoxDomicilio.Controls.Add(this.txtNumeroCalle);
            this.grBoxDomicilio.Controls.Add(this.txtCalle);
            this.grBoxDomicilio.Controls.Add(this.lblCalle);
            this.grBoxDomicilio.Controls.Add(this.lblNroCalle);
            this.grBoxDomicilio.Controls.Add(this.lblProvincia);
            this.grBoxDomicilio.Controls.Add(this.lblBarrio);
            this.grBoxDomicilio.Controls.Add(this.lblLocalidad);
            this.grBoxDomicilio.Controls.Add(this.lblDepartamento);
            this.grBoxDomicilio.Location = new System.Drawing.Point(302, 41);
            this.grBoxDomicilio.Name = "grBoxDomicilio";
            this.grBoxDomicilio.Size = new System.Drawing.Size(286, 212);
            this.grBoxDomicilio.TabIndex = 49;
            this.grBoxDomicilio.TabStop = false;
            this.grBoxDomicilio.Text = "Domicilio Personal";
            // 
            // btnProvincia
            // 
            this.btnProvincia.Image = ((System.Drawing.Image)(resources.GetObject("btnProvincia.Image")));
            this.btnProvincia.Location = new System.Drawing.Point(251, 76);
            this.btnProvincia.Name = "btnProvincia";
            this.btnProvincia.Size = new System.Drawing.Size(29, 29);
            this.btnProvincia.TabIndex = 47;
            this.btnProvincia.UseVisualStyleBackColor = true;
            // 
            // btnDpto
            // 
            this.btnDpto.Image = ((System.Drawing.Image)(resources.GetObject("btnDpto.Image")));
            this.btnDpto.Location = new System.Drawing.Point(251, 109);
            this.btnDpto.Name = "btnDpto";
            this.btnDpto.Size = new System.Drawing.Size(29, 29);
            this.btnDpto.TabIndex = 46;
            this.btnDpto.UseVisualStyleBackColor = true;
            // 
            // btnLoc
            // 
            this.btnLoc.Image = ((System.Drawing.Image)(resources.GetObject("btnLoc.Image")));
            this.btnLoc.Location = new System.Drawing.Point(251, 144);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(29, 29);
            this.btnLoc.TabIndex = 46;
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // btnBarrio
            // 
            this.btnBarrio.AccessibleDescription = "Nuevo";
            this.btnBarrio.Image = ((System.Drawing.Image)(resources.GetObject("btnBarrio.Image")));
            this.btnBarrio.Location = new System.Drawing.Point(251, 179);
            this.btnBarrio.Name = "btnBarrio";
            this.btnBarrio.Size = new System.Drawing.Size(29, 29);
            this.btnBarrio.TabIndex = 46;
            this.btnBarrio.UseVisualStyleBackColor = true;
            // 
            // cmbProvin
            // 
            this.cmbProvin.FormattingEnabled = true;
            this.cmbProvin.Location = new System.Drawing.Point(126, 81);
            this.cmbProvin.Name = "cmbProvin";
            this.cmbProvin.Size = new System.Drawing.Size(119, 21);
            this.cmbProvin.TabIndex = 46;
            this.cmbProvin.TextChanged += new System.EventHandler(this.cmbProvin_TextChanged);
            // 
            // cmbDepto
            // 
            this.cmbDepto.FormattingEnabled = true;
            this.cmbDepto.Location = new System.Drawing.Point(126, 115);
            this.cmbDepto.Name = "cmbDepto";
            this.cmbDepto.Size = new System.Drawing.Size(119, 21);
            this.cmbDepto.TabIndex = 46;
            this.cmbDepto.TextChanged += new System.EventHandler(this.cmbDepto_TextChanged);
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(126, 149);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(119, 21);
            this.cmbLocalidad.TabIndex = 46;
            this.cmbLocalidad.TextChanged += new System.EventHandler(this.cmbLocalidad_TextChanged);
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(126, 183);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(119, 21);
            this.cmbBarrio.TabIndex = 37;
            // 
            // txtNumeroCalle
            // 
            this.txtNumeroCalle.Location = new System.Drawing.Point(126, 48);
            this.txtNumeroCalle.Name = "txtNumeroCalle";
            this.txtNumeroCalle.Size = new System.Drawing.Size(119, 20);
            this.txtNumeroCalle.TabIndex = 28;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(126, 15);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(119, 20);
            this.txtCalle.TabIndex = 27;
            // 
            // lblCalle
            // 
            this.lblCalle.BackColor = System.Drawing.SystemColors.Control;
            this.lblCalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCalle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(6, 17);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(103, 21);
            this.lblCalle.TabIndex = 18;
            this.lblCalle.Text = "Calle";
            // 
            // lblNroCalle
            // 
            this.lblNroCalle.BackColor = System.Drawing.SystemColors.Control;
            this.lblNroCalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNroCalle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCalle.Location = new System.Drawing.Point(6, 49);
            this.lblNroCalle.Name = "lblNroCalle";
            this.lblNroCalle.Size = new System.Drawing.Size(103, 21);
            this.lblNroCalle.TabIndex = 19;
            this.lblNroCalle.Text = "Numero";
            // 
            // lblProvincia
            // 
            this.lblProvincia.BackColor = System.Drawing.SystemColors.Control;
            this.lblProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProvincia.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(6, 81);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(103, 21);
            this.lblProvincia.TabIndex = 20;
            this.lblProvincia.Text = "Provincia";
            // 
            // lblBarrio
            // 
            this.lblBarrio.BackColor = System.Drawing.SystemColors.Control;
            this.lblBarrio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBarrio.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(6, 177);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(103, 21);
            this.lblBarrio.TabIndex = 23;
            this.lblBarrio.Text = "Barrio";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.BackColor = System.Drawing.SystemColors.Control;
            this.lblLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLocalidad.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(6, 145);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(103, 21);
            this.lblLocalidad.TabIndex = 21;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.BackColor = System.Drawing.SystemColors.Control;
            this.lblDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDepartamento.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(6, 113);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(103, 21);
            this.lblDepartamento.TabIndex = 22;
            this.lblDepartamento.Text = "Departamento";
            // 
            // lblCamposOb
            // 
            this.lblCamposOb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCamposOb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCamposOb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamposOb.Location = new System.Drawing.Point(12, 9);
            this.lblCamposOb.Name = "lblCamposOb";
            this.lblCamposOb.Size = new System.Drawing.Size(127, 20);
            this.lblCamposOb.TabIndex = 52;
            this.lblCamposOb.Text = "Campos Obligatorios";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(258, 259);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 53;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // AbmEditarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 295);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblCamposOb);
            this.Controls.Add(this.grBoxDomicilio);
            this.Controls.Add(this.grBoxEmpleados);
            this.Name = "AbmEditarEmpleado";
            this.Text = "AbmEditarEmpleado";
            this.Load += new System.EventHandler(this.AbmEditarEmpleado_Load);
            this.grBoxEmpleados.ResumeLayout(false);
            this.grBoxEmpleados.PerformLayout();
            this.grBoxDomicilio.ResumeLayout(false);
            this.grBoxDomicilio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxEmpleados;
        public System.Windows.Forms.ComboBox cmbTDoc;
        public System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNroDoc;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombreEmp;
        private System.Windows.Forms.GroupBox grBoxDomicilio;
        public System.Windows.Forms.ComboBox cmbProvin;
        public System.Windows.Forms.ComboBox cmbDepto;
        public System.Windows.Forms.ComboBox cmbLocalidad;
        public System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.TextBox txtNumeroCalle;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblNroCalle;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblCamposOb;
        private System.Windows.Forms.Button btnProvincia;
        private System.Windows.Forms.Button btnDpto;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnBarrio;
        private System.Windows.Forms.Button btnAceptar;
    }
}