namespace Menu_General1.Forms
{
    partial class FormCargos
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbBuscar = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNMODIFICAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.BTNNUEVO = new System.Windows.Forms.Button();
            this.BTNSALIR = new System.Windows.Forms.Button();
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboProfesión = new System.Windows.Forms.ComboBox();
            this.BTNMOSTRAR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTel2 = new System.Windows.Forms.TextBox();
            this.txtTel1 = new System.Windows.Forms.TextBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(300, 349);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(416, 20);
            this.txtBuscar.TabIndex = 96;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(165, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 94;
            this.label8.Text = "Ingrese datos a buscar";
            // 
            // cbBuscar
            // 
            this.cbBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbBuscar.AutoSize = true;
            this.cbBuscar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscar.Location = new System.Drawing.Point(723, 351);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(66, 17);
            this.cbBuscar.TabIndex = 97;
            this.cbBuscar.Text = "Buscar:";
            this.cbBuscar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.BTNELIMINAR);
            this.groupBox1.Controls.Add(this.BTNMODIFICAR);
            this.groupBox1.Controls.Add(this.BTNGUARDAR);
            this.groupBox1.Controls.Add(this.BTNNUEVO);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 66);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones:";
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.Location = new System.Drawing.Point(732, 19);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(170, 35);
            this.BTNELIMINAR.TabIndex = 81;
            this.BTNELIMINAR.Text = "ELIMINAR";
            this.BTNELIMINAR.UseVisualStyleBackColor = true;
            // 
            // BTNMODIFICAR
            // 
            this.BTNMODIFICAR.Location = new System.Drawing.Point(501, 19);
            this.BTNMODIFICAR.Name = "BTNMODIFICAR";
            this.BTNMODIFICAR.Size = new System.Drawing.Size(170, 35);
            this.BTNMODIFICAR.TabIndex = 80;
            this.BTNMODIFICAR.Text = "MODIFICAR";
            this.BTNMODIFICAR.UseVisualStyleBackColor = true;
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.Location = new System.Drawing.Point(268, 19);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(170, 35);
            this.BTNGUARDAR.TabIndex = 79;
            this.BTNGUARDAR.Text = "GUARDAR";
            this.BTNGUARDAR.UseVisualStyleBackColor = true;
            // 
            // BTNNUEVO
            // 
            this.BTNNUEVO.Location = new System.Drawing.Point(33, 19);
            this.BTNNUEVO.Name = "BTNNUEVO";
            this.BTNNUEVO.Size = new System.Drawing.Size(170, 35);
            this.BTNNUEVO.TabIndex = 78;
            this.BTNNUEVO.Text = "NUEVO";
            this.BTNNUEVO.UseVisualStyleBackColor = true;
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTNSALIR.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIR.Location = new System.Drawing.Point(820, 343);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(100, 30);
            this.BTNSALIR.TabIndex = 98;
            this.BTNSALIR.Text = "SALIR";
            this.BTNSALIR.UseVisualStyleBackColor = true;
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Location = new System.Drawing.Point(13, 381);
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.Size = new System.Drawing.Size(934, 255);
            this.dgvDocentes.TabIndex = 99;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.cboProfesión);
            this.groupBox3.Controls.Add(this.BTNMOSTRAR);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtCorreo);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtTel2);
            this.groupBox3.Controls.Add(this.txtTel1);
            this.groupBox3.Controls.Add(this.txtLugar);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
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
            this.groupBox3.Location = new System.Drawing.Point(13, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(934, 215);
            this.groupBox3.TabIndex = 92;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Frm_Cargos";
            // 
            // cboProfesión
            // 
            this.cboProfesión.FormattingEnabled = true;
            this.cboProfesión.Location = new System.Drawing.Point(557, 169);
            this.cboProfesión.Name = "cboProfesión";
            this.cboProfesión.Size = new System.Drawing.Size(216, 21);
            this.cboProfesión.TabIndex = 83;
            this.cboProfesión.Text = "<<Seleccionar la Profesion>>";
            // 
            // BTNMOSTRAR
            // 
            this.BTNMOSTRAR.Location = new System.Drawing.Point(807, 27);
            this.BTNMOSTRAR.Name = "BTNMOSTRAR";
            this.BTNMOSTRAR.Size = new System.Drawing.Size(111, 39);
            this.BTNMOSTRAR.TabIndex = 82;
            this.BTNMOSTRAR.Text = "MOSTRAR";
            this.BTNMOSTRAR.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "Profesion:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(557, 127);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(216, 20);
            this.txtCorreo.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Correo:";
            // 
            // txtTel2
            // 
            this.txtTel2.Location = new System.Drawing.Point(557, 89);
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(216, 20);
            this.txtTel2.TabIndex = 74;
            // 
            // txtTel1
            // 
            this.txtTel1.Location = new System.Drawing.Point(557, 54);
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(216, 20);
            this.txtTel1.TabIndex = 73;
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(557, 19);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(216, 20);
            this.txtLugar.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "Telefono2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Telefono1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Lugar/Procedencia:";
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
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(145, 132);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(216, 20);
            this.txtNombres.TabIndex = 62;
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
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(-159, -90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1276, 42);
            this.label10.TabIndex = 93;
            this.label10.Text = "                                         REGISTROS DE CONTRATOS                  " +
    "                       ";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(-154, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1275, 42);
            this.label9.TabIndex = 100;
            this.label9.Text = "                                             REGISTROS DE CARGOS                 " +
    "                            ";
            // 
            // FormCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 641);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTNSALIR);
            this.Controls.Add(this.dgvDocentes);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label10);
            this.Name = "FormCargos";
            this.Text = "FormCargos";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button BTNMODIFICAR;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.Button BTNNUEVO;
        private System.Windows.Forms.Button BTNSALIR;
        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboProfesión;
        private System.Windows.Forms.Button BTNMOSTRAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTel2;
        private System.Windows.Forms.TextBox txtTel1;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}