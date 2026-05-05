namespace Menu_General1.Forms
{
    partial class FormGestionarEmpleados
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
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNNUEVO = new System.Windows.Forms.Button();
            this.cboTipodocumento = new System.Windows.Forms.ComboBox();
            this.BTNMOSTRAR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreo2 = new System.Windows.Forms.TextBox();
            this.txtCorreo1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNMODIFICAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbBuscar = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.BTNSALIR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechaingreso = new System.Windows.Forms.DateTimePicker();
            this.textTel2 = new System.Windows.Forms.TextBox();
            this.textTel1 = new System.Windows.Forms.TextBox();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboProfesion = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.Location = new System.Drawing.Point(732, 29);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(203, 46);
            this.BTNELIMINAR.TabIndex = 81;
            this.BTNELIMINAR.Text = "ELIMINAR";
            this.BTNELIMINAR.UseVisualStyleBackColor = true;
            this.BTNELIMINAR.Click += new System.EventHandler(this.BTNELIMINAR_Click);
            // 
            // BTNNUEVO
            // 
            this.BTNNUEVO.Location = new System.Drawing.Point(32, 29);
            this.BTNNUEVO.Name = "BTNNUEVO";
            this.BTNNUEVO.Size = new System.Drawing.Size(203, 46);
            this.BTNNUEVO.TabIndex = 78;
            this.BTNNUEVO.Text = "NUEVO";
            this.BTNNUEVO.UseVisualStyleBackColor = true;
            // 
            // cboTipodocumento
            // 
            this.cboTipodocumento.FormattingEnabled = true;
            this.cboTipodocumento.Location = new System.Drawing.Point(593, 139);
            this.cboTipodocumento.Name = "cboTipodocumento";
            this.cboTipodocumento.Size = new System.Drawing.Size(216, 21);
            this.cboTipodocumento.TabIndex = 83;
            this.cboTipodocumento.Text = "<<Seleccionar la Profesion>>";
            // 
            // BTNMOSTRAR
            // 
            this.BTNMOSTRAR.Location = new System.Drawing.Point(837, 27);
            this.BTNMOSTRAR.Name = "BTNMOSTRAR";
            this.BTNMOSTRAR.Size = new System.Drawing.Size(111, 39);
            this.BTNMOSTRAR.TabIndex = 82;
            this.BTNMOSTRAR.Text = "MOSTRAR";
            this.BTNMOSTRAR.UseVisualStyleBackColor = true;
            this.BTNMOSTRAR.Click += new System.EventHandler(this.BTNMOSTRAR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "Tipo Documento";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(593, 98);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(216, 20);
            this.txtObservaciones.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Observaciones";
            // 
            // txtCorreo2
            // 
            this.txtCorreo2.Location = new System.Drawing.Point(593, 54);
            this.txtCorreo2.Name = "txtCorreo2";
            this.txtCorreo2.Size = new System.Drawing.Size(216, 20);
            this.txtCorreo2.TabIndex = 74;
            // 
            // txtCorreo1
            // 
            this.txtCorreo1.Location = new System.Drawing.Point(593, 18);
            this.txtCorreo1.Name = "txtCorreo1";
            this.txtCorreo1.Size = new System.Drawing.Size(216, 20);
            this.txtCorreo1.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "Correo2:";
            // 
            // BTNMODIFICAR
            // 
            this.BTNMODIFICAR.Location = new System.Drawing.Point(501, 29);
            this.BTNMODIFICAR.Name = "BTNMODIFICAR";
            this.BTNMODIFICAR.Size = new System.Drawing.Size(203, 46);
            this.BTNMODIFICAR.TabIndex = 80;
            this.BTNMODIFICAR.Text = "MODIFICAR";
            this.BTNMODIFICAR.UseVisualStyleBackColor = true;
            this.BTNMODIFICAR.Click += new System.EventHandler(this.BTNMODIFICAR_Click);
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.Location = new System.Drawing.Point(268, 29);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(203, 46);
            this.BTNGUARDAR.TabIndex = 79;
            this.BTNGUARDAR.Text = "GUARDAR";
            this.BTNGUARDAR.UseVisualStyleBackColor = true;
            this.BTNGUARDAR.Click += new System.EventHandler(this.BTNGUARDAR_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(347, 527);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(416, 20);
            this.txtBuscar.TabIndex = 88;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(212, 527);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 86;
            this.label8.Text = "Ingrese datos a buscar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Correo1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Fecha/Nacimiento:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(145, 171);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(213, 20);
            this.dtpFecha.TabIndex = 67;
            // 
            // cbBuscar
            // 
            this.cbBuscar.AutoSize = true;
            this.cbBuscar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscar.Location = new System.Drawing.Point(788, 530);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(66, 17);
            this.cbBuscar.TabIndex = 89;
            this.cbBuscar.Text = "Buscar:";
            this.cbBuscar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTNELIMINAR);
            this.groupBox1.Controls.Add(this.BTNMODIFICAR);
            this.groupBox1.Controls.Add(this.BTNGUARDAR);
            this.groupBox1.Controls.Add(this.BTNNUEVO);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(84, 416);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(971, 92);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(145, 132);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(216, 20);
            this.txtNombres.TabIndex = 62;
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIR.Location = new System.Drawing.Point(880, 517);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(111, 39);
            this.BTNSALIR.TabIndex = 90;
            this.BTNSALIR.Text = "SALIR";
            this.BTNSALIR.UseVisualStyleBackColor = true;
            this.BTNSALIR.Click += new System.EventHandler(this.BTNSALIR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Nombres:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(145, 94);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(216, 20);
            this.txtApellidos.TabIndex = 60;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(145, 58);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(216, 20);
            this.txtDni.TabIndex = 59;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(145, 24);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(216, 20);
            this.txtCodigo.TabIndex = 49;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 57;
            this.label18.Text = "Apellidos:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(11, 61);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(31, 13);
            this.label22.TabIndex = 50;
            this.label22.Text = "DNI:";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(84, 575);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(971, 169);
            this.dgvEmpleados.TabIndex = 91;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboPais);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.cboDepartamento);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.cboProvincia);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.cboDistrito);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.cboProfesion);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.cboGenero);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textTel2);
            this.groupBox3.Controls.Add(this.textTel1);
            this.groupBox3.Controls.Add(this.textDireccion);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dtpFechaingreso);
            this.groupBox3.Controls.Add(this.cboTipodocumento);
            this.groupBox3.Controls.Add(this.BTNMOSTRAR);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtObservaciones);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtCorreo2);
            this.groupBox3.Controls.Add(this.txtCorreo1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dtpFecha);
            this.groupBox3.Controls.Add(this.txtNombres);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtApellidos);
            this.groupBox3.Controls.Add(this.txtDni);
            this.groupBox3.Controls.Add(this.txtCodigo);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(84, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(954, 345);
            this.groupBox3.TabIndex = 84;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Frm_Docentes";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 13);
            this.label19.TabIndex = 56;
            this.label19.Text = "Codigo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(50, -3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1084, 55);
            this.label10.TabIndex = 85;
            this.label10.Text = "              REGISTROS DE EMPLEADOS                  ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 85;
            this.label9.Text = "Fecha /Ingreso:";
            // 
            // dtpFechaingreso
            // 
            this.dtpFechaingreso.Location = new System.Drawing.Point(145, 209);
            this.dtpFechaingreso.Name = "dtpFechaingreso";
            this.dtpFechaingreso.Size = new System.Drawing.Size(213, 20);
            this.dtpFechaingreso.TabIndex = 84;
            // 
            // textTel2
            // 
            this.textTel2.Location = new System.Drawing.Point(145, 314);
            this.textTel2.Name = "textTel2";
            this.textTel2.Size = new System.Drawing.Size(216, 20);
            this.textTel2.TabIndex = 91;
            // 
            // textTel1
            // 
            this.textTel1.Location = new System.Drawing.Point(145, 278);
            this.textTel1.Name = "textTel1";
            this.textTel1.Size = new System.Drawing.Size(216, 20);
            this.textTel1.TabIndex = 90;
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(145, 244);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(216, 20);
            this.textDireccion.TabIndex = 86;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 89;
            this.label11.Text = "Telefono2:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 281);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 87;
            this.label12.Text = "Telefono1:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 88;
            this.label13.Text = "Direccion:";
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(593, 184);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(216, 21);
            this.cboGenero.TabIndex = 93;
            this.cboGenero.Text = "<<Seleccionar la Profesion>>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(459, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 92;
            this.label7.Text = "Genero:";
            // 
            // cboProfesion
            // 
            this.cboProfesion.FormattingEnabled = true;
            this.cboProfesion.Location = new System.Drawing.Point(593, 226);
            this.cboProfesion.Name = "cboProfesion";
            this.cboProfesion.Size = new System.Drawing.Size(216, 21);
            this.cboProfesion.TabIndex = 95;
            this.cboProfesion.Text = "<<Seleccionar la Profesion>>";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(459, 229);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 94;
            this.label14.Text = "Profesion:";
            // 
            // cboDistrito
            // 
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(788, 313);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(160, 21);
            this.cboDistrito.TabIndex = 97;
            this.cboDistrito.Text = "<<Seleccionar la Distrito>>";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(721, 317);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 96;
            this.label15.Text = "Distrito:";
            // 
            // cboProvincia
            // 
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(788, 273);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(160, 21);
            this.cboProvincia.TabIndex = 99;
            this.cboProvincia.Text = "<<Seleccionar la Provincia>>";
            this.cboProvincia.SelectedIndexChanged += new System.EventHandler(this.cboProvincia_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(721, 277);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 98;
            this.label16.Text = "Provincia:";
            // 
            // cboPais
            // 
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(557, 275);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(147, 21);
            this.cboPais.TabIndex = 103;
            this.cboPais.Text = "<<Seleccionar la Pais>>";
            this.cboPais.SelectedIndexChanged += new System.EventHandler(this.cboPais_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(464, 278);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 102;
            this.label17.Text = "Pais:";
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(557, 316);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(147, 21);
            this.cboDepartamento.TabIndex = 101;
            this.cboDepartamento.Text = "<<Seleccionar la Departamento>>";
            this.cboDepartamento.SelectedIndexChanged += new System.EventHandler(this.cboDepartamento_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(464, 318);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 13);
            this.label20.TabIndex = 100;
            this.label20.Text = "Departamento:";
            // 
            // FormGestionarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 809);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTNSALIR);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label10);
            this.Name = "FormGestionarEmpleados";
            this.Text = "FormGestionarEmpleados";
            this.Load += new System.EventHandler(this.FormGestionarEmpleados_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button BTNNUEVO;
        private System.Windows.Forms.ComboBox cboTipodocumento;
        private System.Windows.Forms.Button BTNMOSTRAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreo2;
        private System.Windows.Forms.TextBox txtCorreo1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTNMODIFICAR;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.CheckBox cbBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Button BTNSALIR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboProfesion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textTel2;
        private System.Windows.Forms.TextBox textTel1;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFechaingreso;
        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboDistrito;
        private System.Windows.Forms.Label label15;
    }
}