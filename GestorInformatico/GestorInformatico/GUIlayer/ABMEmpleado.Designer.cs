namespace GestorInformatico
{
    partial class ABMEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMEmpleado));
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
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblNroCalle = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.ColIdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCamposOb = new System.Windows.Forms.Label();
            this.grBoxEmpleados.SuspendLayout();
            this.grBoxDomicilio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
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
            this.grBoxEmpleados.Location = new System.Drawing.Point(12, 46);
            this.grBoxEmpleados.Name = "grBoxEmpleados";
            this.grBoxEmpleados.Size = new System.Drawing.Size(284, 212);
            this.grBoxEmpleados.TabIndex = 2;
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
            this.grBoxDomicilio.Location = new System.Drawing.Point(302, 46);
            this.grBoxDomicilio.Name = "grBoxDomicilio";
            this.grBoxDomicilio.Size = new System.Drawing.Size(286, 212);
            this.grBoxDomicilio.TabIndex = 27;
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
            this.btnProvincia.Click += new System.EventHandler(this.btnProvincia_Click);
            // 
            // btnDpto
            // 
            this.btnDpto.Image = ((System.Drawing.Image)(resources.GetObject("btnDpto.Image")));
            this.btnDpto.Location = new System.Drawing.Point(251, 109);
            this.btnDpto.Name = "btnDpto";
            this.btnDpto.Size = new System.Drawing.Size(29, 29);
            this.btnDpto.TabIndex = 46;
            this.btnDpto.UseVisualStyleBackColor = true;
            this.btnDpto.Click += new System.EventHandler(this.btnDpto_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.Image = ((System.Drawing.Image)(resources.GetObject("btnLoc.Image")));
            this.btnLoc.Location = new System.Drawing.Point(251, 144);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(29, 29);
            this.btnLoc.TabIndex = 46;
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
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
            this.btnBarrio.Click += new System.EventHandler(this.btnBarrio_Click);
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(409, 67);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(119, 20);
            this.textBox4.TabIndex = 3;
            // 
            // btnBaja
            // 
            this.btnBaja.Image = ((System.Drawing.Image)(resources.GetObject("btnBaja.Image")));
            this.btnBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaja.Location = new System.Drawing.Point(554, 12);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(27, 29);
            this.btnBaja.TabIndex = 53;
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(488, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(27, 29);
            this.btnEditar.TabIndex = 52;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::GestorInformatico.Properties.Resources.add;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(455, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(27, 29);
            this.btnNuevo.TabIndex = 50;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Image = global::GestorInformatico.Properties.Resources.accept;
            this.btnAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlta.Location = new System.Drawing.Point(521, 12);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(27, 29);
            this.btnAlta.TabIndex = 48;
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.AllowUserToAddRows = false;
            this.dgvEmpleado.AllowUserToDeleteRows = false;
            this.dgvEmpleado.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdEmpleado,
            this.ColApellido,
            this.ColNombre,
            this.ColNroDoc,
            this.ColEstado,
            this.ColProvincia,
            this.ColDepto,
            this.ColLocalidad,
            this.ColBarrio,
            this.ColTelefono,
            this.ColMail,
            this.ColCalle,
            this.ColNroCalle});
            this.dgvEmpleado.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvEmpleado.Location = new System.Drawing.Point(15, 264);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.ReadOnly = true;
            this.dgvEmpleado.Size = new System.Drawing.Size(573, 285);
            this.dgvEmpleado.TabIndex = 50;
            this.dgvEmpleado.SelectionChanged += new System.EventHandler(this.dgvEmpleado_SelectionChanged);
            // 
            // ColIdEmpleado
            // 
            this.ColIdEmpleado.DataPropertyName = "IdEmpleado";
            this.ColIdEmpleado.HeaderText = "IdEmpleado";
            this.ColIdEmpleado.Name = "ColIdEmpleado";
            this.ColIdEmpleado.ReadOnly = true;
            this.ColIdEmpleado.Visible = false;
            // 
            // ColApellido
            // 
            this.ColApellido.DataPropertyName = "Apellido";
            this.ColApellido.HeaderText = "Apellido";
            this.ColApellido.Name = "ColApellido";
            this.ColApellido.ReadOnly = true;
            this.ColApellido.Width = 110;
            // 
            // ColNombre
            // 
            this.ColNombre.DataPropertyName = "Nombre";
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 110;
            // 
            // ColNroDoc
            // 
            this.ColNroDoc.DataPropertyName = "NroDoc";
            this.ColNroDoc.HeaderText = "Nro. Documento";
            this.ColNroDoc.Name = "ColNroDoc";
            this.ColNroDoc.ReadOnly = true;
            // 
            // ColEstado
            // 
            this.ColEstado.DataPropertyName = "Descripcion";
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.ReadOnly = true;
            // 
            // ColProvincia
            // 
            this.ColProvincia.DataPropertyName = "Descripcion1";
            this.ColProvincia.HeaderText = "Provincia";
            this.ColProvincia.Name = "ColProvincia";
            this.ColProvincia.ReadOnly = true;
            // 
            // ColDepto
            // 
            this.ColDepto.DataPropertyName = "Descripcion2";
            this.ColDepto.HeaderText = "Departamento";
            this.ColDepto.Name = "ColDepto";
            this.ColDepto.ReadOnly = true;
            // 
            // ColLocalidad
            // 
            this.ColLocalidad.DataPropertyName = "Descripcion3";
            this.ColLocalidad.HeaderText = "Localidad";
            this.ColLocalidad.Name = "ColLocalidad";
            this.ColLocalidad.ReadOnly = true;
            // 
            // ColBarrio
            // 
            this.ColBarrio.DataPropertyName = "Descripcion4";
            this.ColBarrio.HeaderText = "Barrio";
            this.ColBarrio.Name = "ColBarrio";
            this.ColBarrio.ReadOnly = true;
            // 
            // ColTelefono
            // 
            this.ColTelefono.DataPropertyName = "nroTelefono";
            this.ColTelefono.HeaderText = "Telefono";
            this.ColTelefono.Name = "ColTelefono";
            this.ColTelefono.ReadOnly = true;
            // 
            // ColMail
            // 
            this.ColMail.DataPropertyName = "Email";
            this.ColMail.HeaderText = "Mail";
            this.ColMail.Name = "ColMail";
            this.ColMail.ReadOnly = true;
            // 
            // ColCalle
            // 
            this.ColCalle.DataPropertyName = "Calle";
            this.ColCalle.HeaderText = "Calle";
            this.ColCalle.Name = "ColCalle";
            this.ColCalle.ReadOnly = true;
            // 
            // ColNroCalle
            // 
            this.ColNroCalle.DataPropertyName = "NroCalle";
            this.ColNroCalle.HeaderText = "Nro. Calle";
            this.ColNroCalle.Name = "ColNroCalle";
            this.ColNroCalle.ReadOnly = true;
            // 
            // lblCamposOb
            // 
            this.lblCamposOb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCamposOb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCamposOb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamposOb.Location = new System.Drawing.Point(18, 12);
            this.lblCamposOb.Name = "lblCamposOb";
            this.lblCamposOb.Size = new System.Drawing.Size(127, 20);
            this.lblCamposOb.TabIndex = 51;
            this.lblCamposOb.Text = "Campos Obligatorios";
            // 
            // ABMEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(603, 563);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.lblCamposOb);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvEmpleado);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grBoxDomicilio);
            this.Controls.Add(this.grBoxEmpleados);
            this.Controls.Add(this.textBox4);
            this.Name = "ABMEmpleado";
            this.Text = "Empleados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ABMEmpleado_FormClosing);
            this.Load += new System.EventHandler(this.ABMEmpleado_Load);
            this.grBoxEmpleados.ResumeLayout(false);
            this.grBoxEmpleados.PerformLayout();
            this.grBoxDomicilio.ResumeLayout(false);
            this.grBoxDomicilio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxEmpleados;
        private System.Windows.Forms.TextBox txtNombreEmp;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblNroCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grBoxDomicilio;
        private System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCalle;
        public System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNumeroCalle;
        public System.Windows.Forms.ComboBox cmbBarrio;
        public System.Windows.Forms.ComboBox cmbLocalidad;
        public System.Windows.Forms.ComboBox cmbDepto;
        public System.Windows.Forms.ComboBox cmbProvin;
        private System.Windows.Forms.Button btnBarrio;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnDpto;
        private System.Windows.Forms.Button btnProvincia;
        private System.Windows.Forms.DataGridView dgvEmpleado;
        public System.Windows.Forms.ComboBox cmbTDoc;
        private System.Windows.Forms.Label lblCamposOb;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNroDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNroCalle;
    }
}