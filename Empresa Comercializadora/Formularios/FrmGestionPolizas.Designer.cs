namespace Empresa_Comercializadora.Formularios
{
    partial class FrmGestionPolizas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionPolizas));
            this.btnActualizarEstadoPoliza = new System.Windows.Forms.Button();
            this.dgvPolizas = new System.Windows.Forms.DataGridView();
            this.btnListarPoliza = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarCampos = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscarIDPoliza = new Guna.UI2.WinForms.Guna2Button();
            this.txtIdPoliza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerarCertPoliza = new System.Windows.Forms.Button();
            this.dateFinPoliza = new System.Windows.Forms.DateTimePicker();
            this.dateInicioPoliza = new System.Windows.Forms.DateTimePicker();
            this.btnActualizarPoliza = new System.Windows.Forms.Button();
            this.txtboxObservaciones = new System.Windows.Forms.RichTextBox();
            this.btnCrearPoliza = new System.Windows.Forms.Button();
            this.txtMontoPoliza = new System.Windows.Forms.Label();
            this.txtIdClientePoliza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdSeguroPoliza = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnRegresarPrinc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizarEstadoPoliza
            // 
            this.btnActualizarEstadoPoliza.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarEstadoPoliza.Image")));
            this.btnActualizarEstadoPoliza.Location = new System.Drawing.Point(1474, 149);
            this.btnActualizarEstadoPoliza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizarEstadoPoliza.Name = "btnActualizarEstadoPoliza";
            this.btnActualizarEstadoPoliza.Size = new System.Drawing.Size(73, 60);
            this.btnActualizarEstadoPoliza.TabIndex = 46;
            this.btnActualizarEstadoPoliza.UseVisualStyleBackColor = true;
            this.btnActualizarEstadoPoliza.Click += new System.EventHandler(this.btnActualizarEstadoPoliza_Click);
            // 
            // dgvPolizas
            // 
            this.dgvPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolizas.Location = new System.Drawing.Point(786, 227);
            this.dgvPolizas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPolizas.Name = "dgvPolizas";
            this.dgvPolizas.RowHeadersWidth = 51;
            this.dgvPolizas.RowTemplate.Height = 24;
            this.dgvPolizas.Size = new System.Drawing.Size(583, 616);
            this.dgvPolizas.TabIndex = 45;
            // 
            // btnListarPoliza
            // 
            this.btnListarPoliza.Image = ((System.Drawing.Image)(resources.GetObject("btnListarPoliza.Image")));
            this.btnListarPoliza.Location = new System.Drawing.Point(1365, 150);
            this.btnListarPoliza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListarPoliza.Name = "btnListarPoliza";
            this.btnListarPoliza.Size = new System.Drawing.Size(73, 59);
            this.btnListarPoliza.TabIndex = 41;
            this.btnListarPoliza.UseVisualStyleBackColor = true;
            this.btnListarPoliza.Click += new System.EventHandler(this.btnListarPoliza_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiarCampos);
            this.groupBox1.Controls.Add(this.btnBuscarIDPoliza);
            this.groupBox1.Controls.Add(this.txtIdPoliza);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnGenerarCertPoliza);
            this.groupBox1.Controls.Add(this.dateFinPoliza);
            this.groupBox1.Controls.Add(this.dateInicioPoliza);
            this.groupBox1.Controls.Add(this.btnActualizarPoliza);
            this.groupBox1.Controls.Add(this.txtboxObservaciones);
            this.groupBox1.Controls.Add(this.btnCrearPoliza);
            this.groupBox1.Controls.Add(this.txtMontoPoliza);
            this.groupBox1.Controls.Add(this.txtIdClientePoliza);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIdSeguroPoliza);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Century", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 227);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(752, 616);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Poliza";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.btnLimpiarCampos.Location = new System.Drawing.Point(476, 290);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(203, 48);
            this.btnLimpiarCampos.TabIndex = 31;
            this.btnLimpiarCampos.Text = "Limpiar";
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnBuscarIDPoliza
            // 
            this.btnBuscarIDPoliza.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarIDPoliza.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarIDPoliza.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarIDPoliza.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarIDPoliza.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBuscarIDPoliza.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscarIDPoliza.ForeColor = System.Drawing.Color.White;
            this.btnBuscarIDPoliza.Location = new System.Drawing.Point(476, 126);
            this.btnBuscarIDPoliza.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarIDPoliza.Name = "btnBuscarIDPoliza";
            this.btnBuscarIDPoliza.Size = new System.Drawing.Size(203, 48);
            this.btnBuscarIDPoliza.TabIndex = 30;
            this.btnBuscarIDPoliza.Text = "Buscar ID : ";
            this.btnBuscarIDPoliza.Click += new System.EventHandler(this.btnBuscarIDPoliza_Click);
            // 
            // txtIdPoliza
            // 
            this.txtIdPoliza.Location = new System.Drawing.Point(211, 58);
            this.txtIdPoliza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdPoliza.Name = "txtIdPoliza";
            this.txtIdPoliza.Size = new System.Drawing.Size(152, 29);
            this.txtIdPoliza.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "ID Poliza:";
            // 
            // btnGenerarCertPoliza
            // 
            this.btnGenerarCertPoliza.Location = new System.Drawing.Point(476, 205);
            this.btnGenerarCertPoliza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarCertPoliza.Name = "btnGenerarCertPoliza";
            this.btnGenerarCertPoliza.Size = new System.Drawing.Size(203, 59);
            this.btnGenerarCertPoliza.TabIndex = 27;
            this.btnGenerarCertPoliza.Text = "Generar Certificado";
            this.btnGenerarCertPoliza.UseVisualStyleBackColor = true;
            this.btnGenerarCertPoliza.Click += new System.EventHandler(this.btnGenerarCertPoliza_Click);
            // 
            // dateFinPoliza
            // 
            this.dateFinPoliza.Location = new System.Drawing.Point(211, 348);
            this.dateFinPoliza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateFinPoliza.Name = "dateFinPoliza";
            this.dateFinPoliza.Size = new System.Drawing.Size(200, 29);
            this.dateFinPoliza.TabIndex = 25;
            // 
            // dateInicioPoliza
            // 
            this.dateInicioPoliza.Location = new System.Drawing.Point(211, 290);
            this.dateInicioPoliza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateInicioPoliza.Name = "dateInicioPoliza";
            this.dateInicioPoliza.Size = new System.Drawing.Size(200, 29);
            this.dateInicioPoliza.TabIndex = 24;
            // 
            // btnActualizarPoliza
            // 
            this.btnActualizarPoliza.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarPoliza.Image")));
            this.btnActualizarPoliza.Location = new System.Drawing.Point(607, 43);
            this.btnActualizarPoliza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizarPoliza.Name = "btnActualizarPoliza";
            this.btnActualizarPoliza.Size = new System.Drawing.Size(72, 59);
            this.btnActualizarPoliza.TabIndex = 26;
            this.btnActualizarPoliza.UseVisualStyleBackColor = true;
            this.btnActualizarPoliza.Click += new System.EventHandler(this.btnActualizarPoliza_Click);
            // 
            // txtboxObservaciones
            // 
            this.txtboxObservaciones.Location = new System.Drawing.Point(211, 408);
            this.txtboxObservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxObservaciones.Name = "txtboxObservaciones";
            this.txtboxObservaciones.Size = new System.Drawing.Size(439, 163);
            this.txtboxObservaciones.TabIndex = 23;
            this.txtboxObservaciones.Text = "";
            // 
            // btnCrearPoliza
            // 
            this.btnCrearPoliza.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearPoliza.Image")));
            this.btnCrearPoliza.Location = new System.Drawing.Point(476, 43);
            this.btnCrearPoliza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrearPoliza.Name = "btnCrearPoliza";
            this.btnCrearPoliza.Size = new System.Drawing.Size(72, 59);
            this.btnCrearPoliza.TabIndex = 26;
            this.btnCrearPoliza.UseVisualStyleBackColor = true;
            this.btnCrearPoliza.Click += new System.EventHandler(this.btnCrearPoliza_Click);
            // 
            // txtMontoPoliza
            // 
            this.txtMontoPoliza.AutoSize = true;
            this.txtMontoPoliza.Location = new System.Drawing.Point(207, 187);
            this.txtMontoPoliza.Name = "txtMontoPoliza";
            this.txtMontoPoliza.Size = new System.Drawing.Size(21, 22);
            this.txtMontoPoliza.TabIndex = 22;
            this.txtMontoPoliza.Text = "0";
            // 
            // txtIdClientePoliza
            // 
            this.txtIdClientePoliza.Location = new System.Drawing.Point(211, 239);
            this.txtIdClientePoliza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdClientePoliza.Name = "txtIdClientePoliza";
            this.txtIdClientePoliza.Size = new System.Drawing.Size(152, 29);
            this.txtIdClientePoliza.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID Cliente:";
            // 
            // txtIdSeguroPoliza
            // 
            this.txtIdSeguroPoliza.Location = new System.Drawing.Point(211, 123);
            this.txtIdSeguroPoliza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdSeguroPoliza.Name = "txtIdSeguroPoliza";
            this.txtIdSeguroPoliza.Size = new System.Drawing.Size(152, 29);
            this.txtIdSeguroPoliza.TabIndex = 11;
            this.txtIdSeguroPoliza.TextChanged += new System.EventHandler(this.txtIdSeguroPoliza_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "ID Seguro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fecha de inicio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha de fin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Monto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Observaciones:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-27, -7);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1641, 890);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            // 
            // btnRegresarPrinc
            // 
            this.btnRegresarPrinc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRegresarPrinc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegresarPrinc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegresarPrinc.Location = new System.Drawing.Point(1389, 795);
            this.btnRegresarPrinc.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresarPrinc.Name = "btnRegresarPrinc";
            this.btnRegresarPrinc.Size = new System.Drawing.Size(140, 48);
            this.btnRegresarPrinc.TabIndex = 47;
            this.btnRegresarPrinc.Text = "Regresar";
            this.btnRegresarPrinc.UseVisualStyleBackColor = false;
            this.btnRegresarPrinc.Click += new System.EventHandler(this.btnRegresarPrinc_Click);
            // 
            // FrmGestionPolizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1605, 875);
            this.Controls.Add(this.btnRegresarPrinc);
            this.Controls.Add(this.btnActualizarEstadoPoliza);
            this.Controls.Add(this.dgvPolizas);
            this.Controls.Add(this.btnListarPoliza);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmGestionPolizas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Polizas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGestionPolizas_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnActualizarEstadoPoliza;
        private System.Windows.Forms.DataGridView dgvPolizas;
        private System.Windows.Forms.Button btnListarPoliza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerarCertPoliza;
        private System.Windows.Forms.DateTimePicker dateFinPoliza;
        private System.Windows.Forms.DateTimePicker dateInicioPoliza;
        private System.Windows.Forms.Button btnActualizarPoliza;
        private System.Windows.Forms.RichTextBox txtboxObservaciones;
        private System.Windows.Forms.Button btnCrearPoliza;
        private System.Windows.Forms.Label txtMontoPoliza;
        private System.Windows.Forms.TextBox txtIdClientePoliza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdSeguroPoliza;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnRegresarPrinc;
        private System.Windows.Forms.TextBox txtIdPoliza;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnBuscarIDPoliza;
        private Guna.UI2.WinForms.Guna2Button btnLimpiarCampos;
    }
}