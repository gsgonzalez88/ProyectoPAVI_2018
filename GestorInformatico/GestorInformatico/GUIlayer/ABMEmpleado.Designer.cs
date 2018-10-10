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
            this.Telefono = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombreEmp = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblNroCalle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.rbtInactivo = new System.Windows.Forms.RadioButton();
            this.rbtActivo = new System.Windows.Forms.RadioButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCamposOb = new System.Windows.Forms.Label();
            this.grBoxEmpleados.SuspendLayout();
            this.grBoxDomicilio.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // grBoxEmpleados
            // 
            this.grBoxEmpleados.Controls.Add(this.cmbTDoc);
            this.grBoxEmpleados.Controls.Add(this.txtTelefono);
            this.grBoxEmpleados.Controls.Add(this.txtNroDocumento);
            this.grBoxEmpleados.Controls.Add(this.Telefono);
            this.grBoxEmpleados.Controls.Add(this.label3);
            this.grBoxEmpleados.Controls.Add(this.txtEmail);
            this.grBoxEmpleados.Controls.Add(this.lblEmail);
            this.grBoxEmpleados.Controls.Add(this.label2);
            this.grBoxEmpleados.Controls.Add(this.lblApellido);
            this.grBoxEmpleados.Controls.Add(this.lblNombre);
            this.grBoxEmpleados.Controls.Add(this.txtApellido);
            this.grBoxEmpleados.Controls.Add(this.txtNombreEmp);
            this.grBoxEmpleados.Location = new System.Drawing.Point(12, 12);
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
            // Telefono
            // 
            this.Telefono.BackColor = System.Drawing.SystemColors.Window;
            this.Telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Telefono.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono.Location = new System.Drawing.Point(6, 177);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(103, 21);
            this.Telefono.TabIndex = 25;
            this.Telefono.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "N° Documento";
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
            this.lblEmail.BackColor = System.Drawing.SystemColors.Window;
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(6, 145);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(103, 21);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Email";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tipo Documento";
            // 
            // lblApellido
            // 
            this.lblApellido.BackColor = System.Drawing.SystemColors.Window;
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
            this.lblNombre.BackColor = System.Drawing.SystemColors.Window;
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
            this.lblCalle.BackColor = System.Drawing.SystemColors.Window;
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
            this.lblNroCalle.BackColor = System.Drawing.SystemColors.Window;
            this.lblNroCalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNroCalle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCalle.Location = new System.Drawing.Point(6, 49);
            this.lblNroCalle.Name = "lblNroCalle";
            this.lblNroCalle.Size = new System.Drawing.Size(103, 21);
            this.lblNroCalle.TabIndex = 19;
            this.lblNroCalle.Text = "Numero";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Provincia";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.BackColor = System.Drawing.SystemColors.Window;
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
            this.lblDepartamento.BackColor = System.Drawing.SystemColors.Window;
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
            this.lblBarrio.BackColor = System.Drawing.SystemColors.Window;
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
            this.grBoxDomicilio.Controls.Add(this.label4);
            this.grBoxDomicilio.Controls.Add(this.lblBarrio);
            this.grBoxDomicilio.Controls.Add(this.lblLocalidad);
            this.grBoxDomicilio.Controls.Add(this.lblDepartamento);
            this.grBoxDomicilio.Location = new System.Drawing.Point(302, 12);
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
            this.cmbProvin.SelectedIndexChanged += new System.EventHandler(this.cmbProvin_SelectedIndexChanged);
            // 
            // cmbDepto
            // 
            this.cmbDepto.FormattingEnabled = true;
            this.cmbDepto.Location = new System.Drawing.Point(126, 115);
            this.cmbDepto.Name = "cmbDepto";
            this.cmbDepto.Size = new System.Drawing.Size(119, 21);
            this.cmbDepto.TabIndex = 46;
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(126, 149);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(119, 21);
            this.cmbLocalidad.TabIndex = 46;
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
            // rbtInactivo
            // 
            this.rbtInactivo.AutoSize = true;
            this.rbtInactivo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtInactivo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtInactivo.Location = new System.Drawing.Point(161, 18);
            this.rbtInactivo.Name = "rbtInactivo";
            this.rbtInactivo.Size = new System.Drawing.Size(69, 19);
            this.rbtInactivo.TabIndex = 43;
            this.rbtInactivo.TabStop = true;
            this.rbtInactivo.Text = "Inactivo";
            this.rbtInactivo.UseVisualStyleBackColor = false;
            // 
            // rbtActivo
            // 
            this.rbtActivo.AutoSize = true;
            this.rbtActivo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtActivo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtActivo.Location = new System.Drawing.Point(93, 18);
            this.rbtActivo.Name = "rbtActivo";
            this.rbtActivo.Size = new System.Drawing.Size(62, 19);
            this.rbtActivo.TabIndex = 42;
            this.rbtActivo.TabStop = true;
            this.rbtActivo.Text = "Activo";
            this.rbtActivo.UseVisualStyleBackColor = false;
            this.rbtActivo.CheckedChanged += new System.EventHandler(this.rbtActivo_CheckedChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.SystemColors.Window;
            this.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(18, 18);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(69, 21);
            this.lblEstado.TabIndex = 41;
            this.lblEstado.Text = "Estado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.BtnSalir);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.rbtInactivo);
            this.groupBox1.Controls.Add(this.rbtActivo);
            this.groupBox1.Location = new System.Drawing.Point(12, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 47);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(439, 13);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(27, 29);
            this.btnEliminar.TabIndex = 53;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(406, 13);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(27, 29);
            this.btnActualizar.TabIndex = 52;
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(373, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(27, 29);
            this.btnBuscar.TabIndex = 51;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(472, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 29);
            this.button2.TabIndex = 50;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(538, 13);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(27, 29);
            this.BtnSalir.TabIndex = 49;
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(505, 13);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(27, 29);
            this.btnGuardar.TabIndex = 48;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Apellido,
            this.dataGridViewTextBoxColumn2,
            this.Estado});
            this.dgvEmpleado.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvEmpleado.Location = new System.Drawing.Point(614, 12);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.Size = new System.Drawing.Size(473, 265);
            this.dgvEmpleado.TabIndex = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "NroDocumento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // lblCamposOb
            // 
            this.lblCamposOb.BackColor = System.Drawing.SystemColors.Window;
            this.lblCamposOb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCamposOb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamposOb.Location = new System.Drawing.Point(12, 280);
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
            this.ClientSize = new System.Drawing.Size(1101, 309);
            this.Controls.Add(this.lblCamposOb);
            this.Controls.Add(this.dgvEmpleado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grBoxDomicilio);
            this.Controls.Add(this.grBoxEmpleados);
            this.Controls.Add(this.textBox4);
            this.Name = "ABMEmpleado";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.ABMEmpleado_Load);
            this.grBoxEmpleados.ResumeLayout(false);
            this.grBoxEmpleados.PerformLayout();
            this.grBoxDomicilio.ResumeLayout(false);
            this.grBoxDomicilio.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxEmpleados;
        private System.Windows.Forms.TextBox txtNombreEmp;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNroCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grBoxDomicilio;
        private System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.RadioButton rbtInactivo;
        public System.Windows.Forms.RadioButton rbtActivo;
        private System.Windows.Forms.Label lblEstado;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCalle;
        public System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        public System.Windows.Forms.ComboBox cmbTDoc;
        private System.Windows.Forms.Label lblCamposOb;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button btnGuardar;
    }
}