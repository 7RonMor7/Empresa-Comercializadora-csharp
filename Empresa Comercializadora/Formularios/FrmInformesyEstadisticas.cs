using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Empresa_Comercializadora.Formularios
{
    public partial class FrmInformesyEstadisticas : Form
    {
        private string _rolUsuario;
        private string cadena;
        public FrmInformesyEstadisticas(string rolUsuario)
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Text = "Gestión de Pagos - Estadísticas";
            cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

            // Conectar eventos de RadioButtons (Grupo 1 = tipo de seguro)
            rbtBarras1.CheckedChanged += rbtBarras1_CheckedChanged;
            rbtPastel1.CheckedChanged += rbtPastel1_CheckedChanged;
            rbtColumnas1.CheckedChanged += rbtColumnas1_CheckedChanged;
            rbtPiramide1.CheckedChanged += rbtPiramide1_CheckedChanged;

            // Conectar eventos de RadioButtons (Grupo 2 = pagos por mes)
            rbtBarras2.CheckedChanged += rbtBarras2_CheckedChanged;
            rbtPastel2.CheckedChanged += rbtPastel2_CheckedChanged;
            rbtColumnas2.CheckedChanged += rbtColumnas2_CheckedChanged;
            rbtPiramide2.CheckedChanged += rbtPiramide2_CheckedChanged;

            // Conectar el evento del ComboBox para filtrar el DataGridView
            cboProducto.SelectedIndexChanged += cboProducto_SelectedIndexChanged;

            // Establecer checks por defecto
            rbtBarras1.Checked = true;
            rbtBarras2.Checked = true;

            // Inicializar la barra de progreso y la etiqueta de estado 
            if (pgbEstado != null) pgbEstado.Visible = false;
            if (lblEstado != null) lblEstado.Text = "";
            _rolUsuario = rolUsuario;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal(_rolUsuario);
            principal.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm tt");
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            timer1.Start();

            // Llenar el ComboBox con tipos de seguro
            LlenarComboTiposSeguro();

            // Dibujar gráficos por defecto
            DibujarGraficoTipo(SeriesChartType.Bar);
            DibujarGraficoMes(SeriesChartType.Bar);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm tt");
        }



        // Combo de Tipos de Seguro
        private void LlenarComboTiposSeguro()
        {
            try
            {
                string sql = @"
                    SELECT 
                        IdSeguro,
                        Tipo AS DisplayText
                    FROM Seguros
                    ORDER BY Tipo;
                ";

                DataTable dt = new DataTable();
                dt.Columns.Add("IdSeguro", typeof(int));
                dt.Columns.Add("DisplayText", typeof(string));

                // Agregar una fila para "Todos" los tipos de seguro
                DataRow allRow = dt.NewRow();
                allRow["IdSeguro"] = 0; // Usaremos 0 como indicador para "Todos"
                allRow["DisplayText"] = "Todos los Seguros";
                dt.Rows.Add(allRow);

                using (SqlConnection conn = new SqlConnection(cadena))
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    DataTable segurosDt = new DataTable();
                    da.Fill(segurosDt);

                    // Importar las filas reales después de agregar "Todos"
                    foreach (DataRow row in segurosDt.Rows)
                    {
                        dt.ImportRow(row);
                    }
                }

                cboProducto.DisplayMember = "DisplayText";
                cboProducto.ValueMember = "IdSeguro";
                cboProducto.DataSource = dt;
                cboProducto.SelectedIndex = 0; // Seleccionar "Todos" por defecto
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tipos de seguro: " + ex.Message);
            }
        }

        // Evento ComboBox: Filtrar DGV por Tipo de Seguro
        private async void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Evitar que se ejecute al inicializar o si no hay valor
            if (cboProducto.SelectedValue == null) return;

            // Asegurarse de que se ha seleccionado un elemento
            if (cboProducto.SelectedIndex > -1)
            {
                if (int.TryParse(cboProducto.SelectedValue.ToString(), out int idSeguroSeleccionado))
                {
                    // INICIO DE CARGA
                    dgvPagos.Visible = false;
                    lblEstado.Text = $"Cargando datos para: {cboProducto.Text}...";
                    pgbEstado.Visible = true;
                    // El estilo Marquee es mejor para indicar que se está trabajando, sin mostrar un porcentaje.
                    pgbEstado.Style = ProgressBarStyle.Marquee;

                    try
                    {
                        // Llamar a la función de carga de forma asíncrona
                        await CargarTablaPagos(idSeguroSeleccionado);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al filtrar y cargar pagos: " + ex.Message);
                    }
                    finally
                    {
                        // FIN DE CARGA 
                        pgbEstado.Style = ProgressBarStyle.Blocks;
                        pgbEstado.Visible = false;
                        lblEstado.Text = "Carga de datos completa.";
                        dgvPagos.Visible = true;
                    }
                }
            }
        }


        // Tabla de pagos
        private async Task CargarTablaPagos(int idSeguroFiltro = 0)
        {
            string sql = @"
                SELECT 
                    P.IdPago,
                    C.Nombre + ' ' + C.Apellido AS Cliente,
                    S.Tipo AS Seguro,
                    P.NumeroCuota AS Cuota,
                    P.Monto,
                    P.FechaPago,
                    P.FormaPago
                FROM Pagos P
                INNER JOIN Polizas PL ON P.IdPoliza = PL.IdPoliza
                INNER JOIN Clientes C ON PL.IdCliente = C.IdCliente
                INNER JOIN Seguros S ON PL.IdSeguro = S.IdSeguro
                " + (idSeguroFiltro > 0 ? "WHERE S.IdSeguro = @IdSeguroFiltro" : "") + @"
                ORDER BY P.FechaPago DESC;
            ";

            try
            {
                // Esto hace que la barra de progreso sea visible
                await Task.Delay(3000); // Espera 3 segundos

                using (SqlConnection cn = new SqlConnection(cadena))
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    if (idSeguroFiltro > 0)
                    {
                        cmd.Parameters.AddWithValue("@IdSeguroFiltro", idSeguroFiltro);
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvPagos.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                // Relanzar la excepción para que el caller (cboProducto_SelectedIndexChanged) la maneje
                throw new Exception("Error en la consulta SQL para cargar pagos.", ex);
            }
        }


        // Gráfico por tipo de seguro
        private DataTable ObtenerDatosGraficoTipo()
        {
            string sql = @"
                SELECT 
                    ISNULL(S.Tipo,'SinTipo') AS Categoria,
                    COUNT(P.IdPoliza) AS TotalPolizas
                FROM Seguros S
                LEFT JOIN Polizas P ON S.IdSeguro = P.IdSeguro
                GROUP BY S.Tipo
                ORDER BY TotalPolizas DESC;
            ";

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(cadena))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                da.Fill(dt);
            }

            return dt;
        }

        private void DibujarGraficoTipo(SeriesChartType tipo)
        {
            DataTable dt = ObtenerDatosGraficoTipo();

            chartPagosTipo.Series.Clear();
            chartPagosTipo.ChartAreas.Clear();
            chartPagosTipo.Titles.Clear();
            chartPagosTipo.Legends.Clear();

            ChartArea area = new ChartArea("AreaTipo");
            area.BackColor = Color.WhiteSmoke;
            chartPagosTipo.ChartAreas.Add(area);

            Series serie = new Series("Pólizas por tipo");
            serie.ChartType = tipo;
            serie.IsValueShownAsLabel = true;
            serie.LabelForeColor = Color.Black;

            foreach (DataRow row in dt.Rows)
            {
                string cat = row["Categoria"].ToString();
                double val = row["TotalPolizas"] == DBNull.Value ? 0 : Convert.ToDouble(row["TotalPolizas"]);
                DataPoint p = new DataPoint();
                p.AxisLabel = cat;
                p.YValues = new double[] { val };
                p.Label = val.ToString();
                serie.Points.Add(p);
            }

            chartPagosTipo.Series.Add(serie);

            chartPagosTipo.Titles.Add("Cantidad de pólizas por tipo de seguro");
            chartPagosTipo.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);

            Legend legend = new Legend();
            legend.Docking = Docking.Top;
            chartPagosTipo.Legends.Add(legend);
        }

        // Gráfico por mes
        private DataTable ObtenerDatosGraficoMes()
        {
            string sql = @"
                SELECT FORMAT(FechaPago, 'yyyy-MM') AS Mes, SUM(Monto) AS Total
                FROM Pagos
                GROUP BY FORMAT(FechaPago, 'yyyy-MM')
                ORDER BY Mes;
            ";

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(cadena))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                da.Fill(dt);
            }

            return dt;
        }

        private void DibujarGraficoMes(SeriesChartType tipo)
        {
            DataTable dt = ObtenerDatosGraficoMes();

            chartPagosMes.Series.Clear();
            chartPagosMes.ChartAreas.Clear();
            chartPagosMes.Titles.Clear();
            chartPagosMes.Legends.Clear();

            ChartArea area = new ChartArea("AreaMes");
            area.BackColor = Color.WhiteSmoke;
            chartPagosMes.ChartAreas.Add(area);

            Series serie = new Series("Pagos Mensuales");
            serie.ChartType = tipo;
            serie.IsValueShownAsLabel = true;
            serie.LabelForeColor = Color.Black;

            foreach (DataRow row in dt.Rows)
            {
                string mes = row["Mes"].ToString();
                double total = row["Total"] == DBNull.Value ? 0 : Convert.ToDouble(row["Total"]);
                DataPoint p = new DataPoint();
                p.AxisLabel = mes;
                p.YValues = new double[] { total };
                p.Label = total.ToString("F2");
                serie.Points.Add(p);
            }

            chartPagosMes.Series.Add(serie);

            chartPagosMes.Titles.Add("Total recaudado por mes");
            chartPagosMes.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);

            Legend legend = new Legend();
            legend.Docking = Docking.Top;
            chartPagosMes.Legends.Add(legend);
        }


        // EVENTOS RADIOBUTTONS - TIPO DE SEGURO

        private void rbtBarras1_CheckedChanged(object sender, EventArgs e) { if (rbtBarras1.Checked) DibujarGraficoTipo(SeriesChartType.Bar); }
        private void rbtPastel1_CheckedChanged(object sender, EventArgs e) { if (rbtPastel1.Checked) DibujarGraficoTipo(SeriesChartType.Pie); }
        private void rbtColumnas1_CheckedChanged(object sender, EventArgs e) { if (rbtColumnas1.Checked) DibujarGraficoTipo(SeriesChartType.Column); }
        private void rbtPiramide1_CheckedChanged(object sender, EventArgs e) { if (rbtPiramide1.Checked) DibujarGraficoTipo(SeriesChartType.Pyramid); }

        // EVENTOS RADIOBUTTONS - PAGOS POR MES 
        private void rbtBarras2_CheckedChanged(object sender, EventArgs e) { if (rbtBarras2.Checked) DibujarGraficoMes(SeriesChartType.Bar); }
        private void rbtPastel2_CheckedChanged(object sender, EventArgs e) { if (rbtPastel2.Checked) DibujarGraficoMes(SeriesChartType.Pie); }
        private void rbtColumnas2_CheckedChanged(object sender, EventArgs e) { if (rbtColumnas2.Checked) DibujarGraficoMes(SeriesChartType.Column); }
        private void rbtPiramide2_CheckedChanged(object sender, EventArgs e) { if (rbtPiramide2.Checked) DibujarGraficoMes(SeriesChartType.Pyramid); }

        private void FrmInformesyEstadisticas_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Instanciar el formulario de confirmacion
            using (frmConfirmacion frm = new frmConfirmacion("¿Está seguro que desea salir del sistema?", "Comercializadora Don Chucho"))
            {
                var resultado = frm.ShowDialog(); // Formulario modal
                if (resultado == DialogResult.No)
                {
                    e.Cancel = true; // Cancelar el cierre del formulario

                }
                else
                {
                    Application.ExitThread();
                }
            }
        }

        private void dgvPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
