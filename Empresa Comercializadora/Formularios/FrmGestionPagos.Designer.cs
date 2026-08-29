namespace Empresa_Comercializadora.Formularios
{
    partial class FrmGestionPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionPagos));
            this.rbtListar = new System.Windows.Forms.RadioButton();
            this.dgvListadoPagos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumCuotas = new System.Windows.Forms.TextBox();
            this.btnLimpiarCampos = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscarPago = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipoSeguro = new System.Windows.Forms.ComboBox();
            this.txtClientePago = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdPolizaPago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImprimirComprobante = new System.Windows.Forms.Button();
            this.dateFechaPago = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.btnActualizarPago = new System.Windows.Forms.Button();
            this.btnGuardarPago = new System.Windows.Forms.Button();
            this.txtIdPago = new System.Windows.Forms.TextBox();
            this.txtMontoPago = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnVolver = new Guna.UI2.WinForms.Guna2Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvPagosFiltrado = new System.Windows.Forms.DataGridView();
            this.chkFiltrarFecha = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPagos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosFiltrado)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtListar
            // 
            this.rbtListar.AutoSize = true;
            this.rbtListar.Font = new System.Drawing.Font("Century", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rbtListar.Location = new System.Drawing.Point(36, 515);
            this.rbtListar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtListar.Name = "rbtListar";
            this.rbtListar.Size = new System.Drawing.Size(187, 26);
            this.rbtListar.TabIndex = 40;
            this.rbtListar.TabStop = true;
            this.rbtListar.Text = "Listado de Pagos";
            this.rbtListar.UseVisualStyleBackColor = true;
            this.rbtListar.CheckedChanged += new System.EventHandler(this.rbtListar_CheckedChanged);
            // 
            // dgvListadoPagos
            // 
            this.dgvListadoPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoPagos.Location = new System.Drawing.Point(36, 573);
            this.dgvListadoPagos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListadoPagos.Name = "dgvListadoPagos";
            this.dgvListadoPagos.RowHeadersWidth = 51;
            this.dgvListadoPagos.RowTemplate.Height = 24;
            this.dgvListadoPagos.Size = new System.Drawing.Size(525, 268);
            this.dgvListadoPagos.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumCuotas);
            this.groupBox1.Controls.Add(this.btnLimpiarCampos);
            this.groupBox1.Controls.Add(this.btnBuscarPago);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbTipoSeguro);
            this.groupBox1.Controls.Add(this.txtClientePago);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIdPolizaPago);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnImprimirComprobante);
            this.groupBox1.Controls.Add(this.dateFechaPago);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboFormaPago);
            this.groupBox1.Controls.Add(this.btnActualizarPago);
            this.groupBox1.Controls.Add(this.btnGuardarPago);
            this.groupBox1.Controls.Add(this.txtIdPago);
            this.groupBox1.Controls.Add(this.txtMontoPago);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Century", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 137);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1220, 355);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Pago";
            // 
            // txtNumCuotas
            // 
            this.txtNumCuotas.Location = new System.Drawing.Point(685, 100);
            this.txtNumCuotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumCuotas.Name = "txtNumCuotas";
            this.txtNumCuotas.Size = new System.Drawing.Size(144, 29);
            this.txtNumCuotas.TabIndex = 33;
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
            this.btnLimpiarCampos.Location = new System.Drawing.Point(939, 280);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(249, 48);
            this.btnLimpiarCampos.TabIndex = 32;
            this.btnLimpiarCampos.Text = "Limpiar";
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnBuscarPago
            // 
            this.btnBuscarPago.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarPago.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarPago.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarPago.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarPago.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBuscarPago.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscarPago.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPago.Location = new System.Drawing.Point(939, 224);
            this.btnBuscarPago.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarPago.Name = "btnBuscarPago";
            this.btnBuscarPago.Size = new System.Drawing.Size(249, 48);
            this.btnBuscarPago.TabIndex = 31;
            this.btnBuscarPago.Text = "Buscar ID ";
            this.btnBuscarPago.Click += new System.EventHandler(this.btnBuscarPago_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(488, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 22);
            this.label8.TabIndex = 30;
            this.label8.Text = "Tipo Seguro:";
            // 
            // cmbTipoSeguro
            // 
            this.cmbTipoSeguro.FormattingEnabled = true;
            this.cmbTipoSeguro.Location = new System.Drawing.Point(669, 221);
            this.cmbTipoSeguro.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoSeguro.Name = "cmbTipoSeguro";
            this.cmbTipoSeguro.Size = new System.Drawing.Size(160, 30);
            this.cmbTipoSeguro.TabIndex = 29;
            // 
            // txtClientePago
            // 
            this.txtClientePago.Location = new System.Drawing.Point(219, 221);
            this.txtClientePago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClientePago.Name = "txtClientePago";
            this.txtClientePago.Size = new System.Drawing.Size(225, 29);
            this.txtClientePago.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nombre Cliente:";
            // 
            // txtIdPolizaPago
            // 
            this.txtIdPolizaPago.Location = new System.Drawing.Point(149, 153);
            this.txtIdPolizaPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdPolizaPago.Name = "txtIdPolizaPago";
            this.txtIdPolizaPago.Size = new System.Drawing.Size(295, 29);
            this.txtIdPolizaPago.TabIndex = 26;
            this.txtIdPolizaPago.Enter += new System.EventHandler(this.txtIdPolizaPago_Enter);
            this.txtIdPolizaPago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdPolizaPago_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Id Poliza:";
            // 
            // btnImprimirComprobante
            // 
            this.btnImprimirComprobante.Location = new System.Drawing.Point(1037, 39);
            this.btnImprimirComprobante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImprimirComprobante.Name = "btnImprimirComprobante";
            this.btnImprimirComprobante.Size = new System.Drawing.Size(151, 158);
            this.btnImprimirComprobante.TabIndex = 24;
            this.btnImprimirComprobante.Text = "Imprimir Comprobante de Pago";
            this.btnImprimirComprobante.UseVisualStyleBackColor = true;
            this.btnImprimirComprobante.Click += new System.EventHandler(this.btnImprimirComprobante_Click);
            // 
            // dateFechaPago
            // 
            this.dateFechaPago.Location = new System.Drawing.Point(669, 151);
            this.dateFechaPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateFechaPago.Name = "dateFechaPago";
            this.dateFechaPago.Size = new System.Drawing.Size(200, 29);
            this.dateFechaPago.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fecha de Pago:";
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Location = new System.Drawing.Point(669, 46);
            this.cboFormaPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(233, 30);
            this.cboFormaPago.TabIndex = 20;
            // 
            // btnActualizarPago
            // 
            this.btnActualizarPago.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarPago.Image")));
            this.btnActualizarPago.Location = new System.Drawing.Point(939, 138);
            this.btnActualizarPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizarPago.Name = "btnActualizarPago";
            this.btnActualizarPago.Size = new System.Drawing.Size(72, 59);
            this.btnActualizarPago.TabIndex = 18;
            this.btnActualizarPago.UseVisualStyleBackColor = true;
            this.btnActualizarPago.Click += new System.EventHandler(this.btnActualizarPago_Click);
            // 
            // btnGuardarPago
            // 
            this.btnGuardarPago.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarPago.Image")));
            this.btnGuardarPago.Location = new System.Drawing.Point(939, 39);
            this.btnGuardarPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarPago.Name = "btnGuardarPago";
            this.btnGuardarPago.Size = new System.Drawing.Size(72, 59);
            this.btnGuardarPago.TabIndex = 16;
            this.btnGuardarPago.UseVisualStyleBackColor = true;
            this.btnGuardarPago.Click += new System.EventHandler(this.btnGuardarPago_Click);
            // 
            // txtIdPago
            // 
            this.txtIdPago.Location = new System.Drawing.Point(149, 46);
            this.txtIdPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdPago.Name = "txtIdPago";
            this.txtIdPago.Size = new System.Drawing.Size(295, 29);
            this.txtIdPago.TabIndex = 15;
            // 
            // txtMontoPago
            // 
            this.txtMontoPago.Location = new System.Drawing.Point(149, 97);
            this.txtMontoPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMontoPago.Name = "txtMontoPago";
            this.txtMontoPago.Size = new System.Drawing.Size(295, 29);
            this.txtMontoPago.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Id Pago:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Forma de Pago:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Monto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Número de cuotas:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-16, -49);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1624, 931);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVolver.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVolver.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVolver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVolver.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(1257, 793);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(140, 48);
            this.btnVolver.TabIndex = 42;
            this.btnVolver.Text = "Regresar";
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(589, 512);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 32);
            this.button1.TabIndex = 27;
            this.button1.Text = "Listado de Pagos por Filtro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvPagosFiltrado
            // 
            this.dgvPagosFiltrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagosFiltrado.Location = new System.Drawing.Point(589, 573);
            this.dgvPagosFiltrado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPagosFiltrado.Name = "dgvPagosFiltrado";
            this.dgvPagosFiltrado.RowHeadersWidth = 51;
            this.dgvPagosFiltrado.RowTemplate.Height = 24;
            this.dgvPagosFiltrado.Size = new System.Drawing.Size(643, 268);
            this.dgvPagosFiltrado.TabIndex = 43;
            // 
            // chkFiltrarFecha
            // 
            this.chkFiltrarFecha.AutoSize = true;
            this.chkFiltrarFecha.Font = new System.Drawing.Font("Century", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.chkFiltrarFecha.Location = new System.Drawing.Point(951, 518);
            this.chkFiltrarFecha.Name = "chkFiltrarFecha";
            this.chkFiltrarFecha.Size = new System.Drawing.Size(271, 26);
            this.chkFiltrarFecha.TabIndex = 31;
            this.chkFiltrarFecha.Text = "Filtrar por Fecha de Pago";
            this.chkFiltrarFecha.UseVisualStyleBackColor = true;
            // 
            // FrmGestionPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1605, 875);
            this.Controls.Add(this.chkFiltrarFecha);
            this.Controls.Add(this.dgvPagosFiltrado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.rbtListar);
            this.Controls.Add(this.dgvListadoPagos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmGestionPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Pagos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGestionPagos_FormClosing);
            this.Load += new System.EventHandler(this.FrmGestionPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPagos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosFiltrado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtListar;
        private System.Windows.Forms.DataGridView dgvListadoPagos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnImprimirComprobante;
        private System.Windows.Forms.DateTimePicker dateFechaPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.Button btnActualizarPago;
        private System.Windows.Forms.Button btnGuardarPago;
        private System.Windows.Forms.TextBox txtIdPago;
        private System.Windows.Forms.TextBox txtMontoPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button btnVolver;
        private System.Windows.Forms.TextBox txtIdPolizaPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPagosFiltrado;
        private System.Windows.Forms.TextBox txtClientePago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTipoSeguro;
        private System.Windows.Forms.CheckBox chkFiltrarFecha;
        private Guna.UI2.WinForms.Guna2Button btnBuscarPago;
        private Guna.UI2.WinForms.Guna2Button btnLimpiarCampos;
        private System.Windows.Forms.TextBox txtNumCuotas;
    }
}