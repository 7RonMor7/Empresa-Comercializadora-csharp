namespace Empresa_Comercializadora.Formularios
{
    partial class FrmUsuariosSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuariosSistema));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.txtMontoPoliza = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioActivo = new System.Windows.Forms.RadioButton();
            this.radioInactivo = new System.Windows.Forms.RadioButton();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnRegresarPrinc = new System.Windows.Forms.Button();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.btnActualizarUsuario = new System.Windows.Forms.Button();
            this.btnBuscarID = new Guna.UI2.WinForms.Guna2Button();
            this.btnLimpiarCampos = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1605, 888);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarUsuario.Image")));
            this.btnGuardarUsuario.Location = new System.Drawing.Point(628, 414);
            this.btnGuardarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(72, 59);
            this.btnGuardarUsuario.TabIndex = 41;
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // txtMontoPoliza
            // 
            this.txtMontoPoliza.AutoSize = true;
            this.txtMontoPoliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoPoliza.Location = new System.Drawing.Point(181, 338);
            this.txtMontoPoliza.Name = "txtMontoPoliza";
            this.txtMontoPoliza.Size = new System.Drawing.Size(68, 20);
            this.txtMontoPoliza.TabIndex = 36;
            this.txtMontoPoliza.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Apellido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(181, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "ID Usuario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(181, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(181, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Usuario (sistema)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(181, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Contraseña";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(364, 282);
            this.txtIdUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(152, 22);
            this.txtIdUsuario.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(624, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Rol:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(624, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Estado";
            // 
            // radioActivo
            // 
            this.radioActivo.AutoSize = true;
            this.radioActivo.Location = new System.Drawing.Point(726, 337);
            this.radioActivo.Margin = new System.Windows.Forms.Padding(4);
            this.radioActivo.Name = "radioActivo";
            this.radioActivo.Size = new System.Drawing.Size(65, 20);
            this.radioActivo.TabIndex = 46;
            this.radioActivo.Text = "Activo";
            this.radioActivo.UseVisualStyleBackColor = true;
            // 
            // radioInactivo
            // 
            this.radioInactivo.AutoSize = true;
            this.radioInactivo.Location = new System.Drawing.Point(838, 337);
            this.radioInactivo.Margin = new System.Windows.Forms.Padding(4);
            this.radioInactivo.Name = "radioInactivo";
            this.radioInactivo.Size = new System.Drawing.Size(86, 20);
            this.radioInactivo.TabIndex = 48;
            this.radioInactivo.Text = "No Activo";
            this.radioInactivo.UseVisualStyleBackColor = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(364, 480);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(152, 22);
            this.txtUsuario.TabIndex = 49;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(364, 432);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(152, 22);
            this.txtCorreo.TabIndex = 50;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(364, 381);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(152, 22);
            this.txtApellido.TabIndex = 51;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(364, 337);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(152, 22);
            this.txtNombre.TabIndex = 52;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(364, 534);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(152, 22);
            this.txtContrasena.TabIndex = 53;
            // 
            // btnRegresarPrinc
            // 
            this.btnRegresarPrinc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRegresarPrinc.Location = new System.Drawing.Point(941, 690);
            this.btnRegresarPrinc.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresarPrinc.Name = "btnRegresarPrinc";
            this.btnRegresarPrinc.Size = new System.Drawing.Size(80, 38);
            this.btnRegresarPrinc.TabIndex = 54;
            this.btnRegresarPrinc.Text = "Regresar";
            this.btnRegresarPrinc.UseVisualStyleBackColor = false;
            this.btnRegresarPrinc.Click += new System.EventHandler(this.btnRegresarPrinc_Click);
            // 
            // cboRol
            // 
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(726, 279);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(198, 24);
            this.cboRol.TabIndex = 55;
            // 
            // btnActualizarUsuario
            // 
            this.btnActualizarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarUsuario.Image")));
            this.btnActualizarUsuario.Location = new System.Drawing.Point(743, 414);
            this.btnActualizarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizarUsuario.Name = "btnActualizarUsuario";
            this.btnActualizarUsuario.Size = new System.Drawing.Size(72, 59);
            this.btnActualizarUsuario.TabIndex = 56;
            this.btnActualizarUsuario.UseVisualStyleBackColor = true;
            this.btnActualizarUsuario.Click += new System.EventHandler(this.btnActualizarUsuario_Click);
            // 
            // btnBuscarID
            // 
            this.btnBuscarID.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarID.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBuscarID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscarID.ForeColor = System.Drawing.Color.White;
            this.btnBuscarID.Location = new System.Drawing.Point(628, 509);
            this.btnBuscarID.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarID.Name = "btnBuscarID";
            this.btnBuscarID.Size = new System.Drawing.Size(187, 48);
            this.btnBuscarID.TabIndex = 57;
            this.btnBuscarID.Text = "Buscar ID";
            this.btnBuscarID.Click += new System.EventHandler(this.btnBuscarID_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarCampos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarCampos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLimpiarCampos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLimpiarCampos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(628, 589);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(187, 48);
            this.btnLimpiarCampos.TabIndex = 58;
            this.btnLimpiarCampos.Text = "Limpiar";
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // FrmUsuariosSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1605, 875);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnBuscarID);
            this.Controls.Add(this.btnActualizarUsuario);
            this.Controls.Add(this.cboRol);
            this.Controls.Add(this.btnRegresarPrinc);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.radioInactivo);
            this.Controls.Add(this.radioActivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardarUsuario);
            this.Controls.Add(this.txtMontoPoliza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUsuariosSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios del Sistema";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUsuariosSistema_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.Label txtMontoPoliza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioActivo;
        private System.Windows.Forms.RadioButton radioInactivo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnRegresarPrinc;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Button btnActualizarUsuario;
        private Guna.UI2.WinForms.Guna2Button btnBuscarID;
        private Guna.UI2.WinForms.Guna2Button btnLimpiarCampos;
    }
}