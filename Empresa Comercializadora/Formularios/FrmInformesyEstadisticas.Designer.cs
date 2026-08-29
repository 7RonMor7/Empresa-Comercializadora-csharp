namespace Empresa_Comercializadora.Formularios
{
    partial class FrmInformesyEstadisticas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnVolver = new Guna.UI2.WinForms.Guna2Button();
            this.rbtPastel1 = new System.Windows.Forms.RadioButton();
            this.rbtColumnas1 = new System.Windows.Forms.RadioButton();
            this.rbtPiramide1 = new System.Windows.Forms.RadioButton();
            this.rbtBarras1 = new System.Windows.Forms.RadioButton();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.rbtPastel2 = new System.Windows.Forms.RadioButton();
            this.rbtColumnas2 = new System.Windows.Forms.RadioButton();
            this.rbtPiramide2 = new System.Windows.Forms.RadioButton();
            this.rbtBarras2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pgbEstado = new System.Windows.Forms.ProgressBar();
            this.lblEstado = new System.Windows.Forms.Label();
            this.chartPagosTipo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPagosMes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPagosTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPagosMes)).BeginInit();
            this.SuspendLayout();
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
            this.btnVolver.Location = new System.Drawing.Point(1015, 712);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(140, 48);
            this.btnVolver.TabIndex = 29;
            this.btnVolver.Text = "Regresar";
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // rbtPastel1
            // 
            this.rbtPastel1.AutoSize = true;
            this.rbtPastel1.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPastel1.Location = new System.Drawing.Point(1424, 159);
            this.rbtPastel1.Margin = new System.Windows.Forms.Padding(4);
            this.rbtPastel1.Name = "rbtPastel1";
            this.rbtPastel1.Size = new System.Drawing.Size(85, 32);
            this.rbtPastel1.TabIndex = 41;
            this.rbtPastel1.TabStop = true;
            this.rbtPastel1.Text = "Pastel";
            this.rbtPastel1.UseVisualStyleBackColor = true;
            // 
            // rbtColumnas1
            // 
            this.rbtColumnas1.AutoSize = true;
            this.rbtColumnas1.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtColumnas1.Location = new System.Drawing.Point(1424, 188);
            this.rbtColumnas1.Margin = new System.Windows.Forms.Padding(4);
            this.rbtColumnas1.Name = "rbtColumnas1";
            this.rbtColumnas1.Size = new System.Drawing.Size(121, 32);
            this.rbtColumnas1.TabIndex = 40;
            this.rbtColumnas1.TabStop = true;
            this.rbtColumnas1.Text = "Columnas";
            this.rbtColumnas1.UseVisualStyleBackColor = true;
            // 
            // rbtPiramide1
            // 
            this.rbtPiramide1.AutoSize = true;
            this.rbtPiramide1.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPiramide1.Location = new System.Drawing.Point(1424, 216);
            this.rbtPiramide1.Margin = new System.Windows.Forms.Padding(4);
            this.rbtPiramide1.Name = "rbtPiramide1";
            this.rbtPiramide1.Size = new System.Drawing.Size(112, 32);
            this.rbtPiramide1.TabIndex = 39;
            this.rbtPiramide1.TabStop = true;
            this.rbtPiramide1.Text = "Piramide";
            this.rbtPiramide1.UseVisualStyleBackColor = true;
            // 
            // rbtBarras1
            // 
            this.rbtBarras1.AutoSize = true;
            this.rbtBarras1.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtBarras1.Location = new System.Drawing.Point(1424, 131);
            this.rbtBarras1.Margin = new System.Windows.Forms.Padding(4);
            this.rbtBarras1.Name = "rbtBarras1";
            this.rbtBarras1.Size = new System.Drawing.Size(87, 32);
            this.rbtBarras1.TabIndex = 38;
            this.rbtBarras1.TabStop = true;
            this.rbtBarras1.Text = "Barras";
            this.rbtBarras1.UseVisualStyleBackColor = true;
            // 
            // dgvPagos
            // 
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Location = new System.Drawing.Point(13, 260);
            this.dgvPagos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.RowHeadersWidth = 51;
            this.dgvPagos.Size = new System.Drawing.Size(812, 437);
            this.dgvPagos.TabIndex = 37;
            this.dgvPagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagos_CellContentClick);
            // 
            // rbtPastel2
            // 
            this.rbtPastel2.AutoSize = true;
            this.rbtPastel2.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPastel2.Location = new System.Drawing.Point(1424, 500);
            this.rbtPastel2.Margin = new System.Windows.Forms.Padding(4);
            this.rbtPastel2.Name = "rbtPastel2";
            this.rbtPastel2.Size = new System.Drawing.Size(85, 32);
            this.rbtPastel2.TabIndex = 36;
            this.rbtPastel2.TabStop = true;
            this.rbtPastel2.Text = "Pastel";
            this.rbtPastel2.UseVisualStyleBackColor = true;
            // 
            // rbtColumnas2
            // 
            this.rbtColumnas2.AutoSize = true;
            this.rbtColumnas2.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtColumnas2.Location = new System.Drawing.Point(1424, 528);
            this.rbtColumnas2.Margin = new System.Windows.Forms.Padding(4);
            this.rbtColumnas2.Name = "rbtColumnas2";
            this.rbtColumnas2.Size = new System.Drawing.Size(121, 32);
            this.rbtColumnas2.TabIndex = 35;
            this.rbtColumnas2.TabStop = true;
            this.rbtColumnas2.Text = "Columnas";
            this.rbtColumnas2.UseVisualStyleBackColor = true;
            // 
            // rbtPiramide2
            // 
            this.rbtPiramide2.AutoSize = true;
            this.rbtPiramide2.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPiramide2.Location = new System.Drawing.Point(1424, 557);
            this.rbtPiramide2.Margin = new System.Windows.Forms.Padding(4);
            this.rbtPiramide2.Name = "rbtPiramide2";
            this.rbtPiramide2.Size = new System.Drawing.Size(112, 32);
            this.rbtPiramide2.TabIndex = 34;
            this.rbtPiramide2.TabStop = true;
            this.rbtPiramide2.Text = "Piramide";
            this.rbtPiramide2.UseVisualStyleBackColor = true;
            // 
            // rbtBarras2
            // 
            this.rbtBarras2.AutoSize = true;
            this.rbtBarras2.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtBarras2.Location = new System.Drawing.Point(1424, 472);
            this.rbtBarras2.Margin = new System.Windows.Forms.Padding(4);
            this.rbtBarras2.Name = "rbtBarras2";
            this.rbtBarras2.Size = new System.Drawing.Size(87, 32);
            this.rbtBarras2.TabIndex = 33;
            this.rbtBarras2.TabStop = true;
            this.rbtBarras2.Text = "Barras";
            this.rbtBarras2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboProducto);
            this.groupBox1.Controls.Add(this.lblHora);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.pgbEstado);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Font = new System.Drawing.Font("Perpetua", 14F);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(812, 240);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Seguros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione el tipo de seguro:";
            // 
            // cboProducto
            // 
            this.cboProducto.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(296, 27);
            this.cboProducto.Margin = new System.Windows.Forms.Padding(4);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(225, 36);
            this.cboProducto.TabIndex = 5;
            this.cboProducto.Text = "Seleccione:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(137, 84);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(56, 28);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(19, 84);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(62, 28);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // pgbEstado
            // 
            this.pgbEstado.Location = new System.Drawing.Point(19, 210);
            this.pgbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.pgbEstado.Name = "pgbEstado";
            this.pgbEstado.Size = new System.Drawing.Size(785, 22);
            this.pgbEstado.TabIndex = 9;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(13, 175);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(77, 28);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado:";
            // 
            // chartPagosTipo
            // 
            chartArea3.Name = "ChartArea1";
            this.chartPagosTipo.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartPagosTipo.Legends.Add(legend3);
            this.chartPagosTipo.Location = new System.Drawing.Point(865, 28);
            this.chartPagosTipo.Name = "chartPagosTipo";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartPagosTipo.Series.Add(series3);
            this.chartPagosTipo.Size = new System.Drawing.Size(529, 300);
            this.chartPagosTipo.TabIndex = 42;
            this.chartPagosTipo.Text = "chart1";
            // 
            // chartPagosMes
            // 
            chartArea4.Name = "ChartArea1";
            this.chartPagosMes.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartPagosMes.Legends.Add(legend4);
            this.chartPagosMes.Location = new System.Drawing.Point(865, 372);
            this.chartPagosMes.Name = "chartPagosMes";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartPagosMes.Series.Add(series4);
            this.chartPagosMes.Size = new System.Drawing.Size(529, 300);
            this.chartPagosMes.TabIndex = 43;
            this.chartPagosMes.Text = "chart2";
            // 
            // FrmInformesyEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1605, 875);
            this.Controls.Add(this.chartPagosMes);
            this.Controls.Add(this.chartPagosTipo);
            this.Controls.Add(this.rbtPastel1);
            this.Controls.Add(this.rbtColumnas1);
            this.Controls.Add(this.rbtPiramide1);
            this.Controls.Add(this.rbtBarras1);
            this.Controls.Add(this.dgvPagos);
            this.Controls.Add(this.rbtPastel2);
            this.Controls.Add(this.rbtColumnas2);
            this.Controls.Add(this.rbtPiramide2);
            this.Controls.Add(this.rbtBarras2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVolver);
            this.Name = "FrmInformesyEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informes y Estadisticas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInformesyEstadisticas_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPagosTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPagosMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnVolver;
        private System.Windows.Forms.RadioButton rbtPastel1;
        private System.Windows.Forms.RadioButton rbtColumnas1;
        private System.Windows.Forms.RadioButton rbtPiramide1;
        private System.Windows.Forms.RadioButton rbtBarras1;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.RadioButton rbtPastel2;
        private System.Windows.Forms.RadioButton rbtColumnas2;
        private System.Windows.Forms.RadioButton rbtPiramide2;
        private System.Windows.Forms.RadioButton rbtBarras2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ProgressBar pgbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPagosTipo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPagosMes;
        private System.Windows.Forms.Timer timer1;
    }
}