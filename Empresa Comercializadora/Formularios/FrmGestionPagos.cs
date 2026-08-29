using Empresa_Comercializadora.Repositorio;
using Empresa_Comercializadora.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Empresa_Comercializadora.Formularios
{
    public partial class FrmGestionPagos : Form
    {
        private string _rolUsuario;
        public FrmGestionPagos(string rolUsuario)
        {
            InitializeComponent();
            _rolUsuario = rolUsuario;
        }

        //Crear un objeto PagoRepositorio
        PagoRepositorio pagoRepo = new PagoRepositorio();
        PolizaRepositorio polRepo = new PolizaRepositorio();

        // Metodo para imprimir comprobante de pago

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Datos de ejemplo, reemplaza con los datos del pago seleccionado:
            int idPago = int.Parse(txtIdPago.Text);
            string fechaPago = dateFechaPago.Value.ToShortDateString();
            string formaPago = cboFormaPago.Text;
            decimal monto = decimal.Parse(txtMontoPago.Text);
            int numerocuota = int.Parse(txtNumCuotas.Text);


            // Diseño básico del comprobante
            Font fontTitle = new Font("Arial", 16, FontStyle.Bold);
            Font fontText = new Font("Arial", 12);
            int y = 100;

            e.Graphics.DrawString("COMPROBANTE DE PAGO", fontTitle, Brushes.DarkBlue, 200, 40);
            e.Graphics.DrawString($"Fecha de emisión: {DateTime.Now.ToShortDateString()}", fontText, Brushes.Black, 50, y); y += 30;
            /*e.Graphics.DrawString($"Cliente: {cliente}", fontText, Brushes.Black, 50, y); y += 25;
            e.Graphics.DrawString($"Seguro: {tipoSeguro}", fontText, Brushes.Black, 50, y); y += 25;*/
            e.Graphics.DrawString($"Fecha de pago: {fechaPago}", fontText, Brushes.Black, 50, y); y += 25;
            e.Graphics.DrawString($"Forma de pago: {formaPago}", fontText, Brushes.Black, 50, y); y += 25;
            e.Graphics.DrawString($"Monto: $ {monto:N2}", fontText, Brushes.Black, 50, y); y += 25;
            e.Graphics.DrawString($"Número de cuota: {numerocuota}", fontText, Brushes.Black, 50, y); y += 50;

            e.Graphics.DrawString("Gracias por su pago.", new Font("Arial", 10, FontStyle.Italic), Brushes.Gray, 50, y);
        }

        private void btnImprimirComprobante_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += PrintDoc_PrintPage;
            PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = printDoc
            };
            preview.ShowDialog(); // Mostrar vista previa antes de imprimir
        }

        private void btnGuardarPago_Click(object sender, EventArgs e)
        {
            Pago pago = new Pago
            {
                IdPago = int.Parse(txtIdPago.Text),
                IdPoliza = int.Parse(txtIdPago.Text),
                FechaPago = dateFechaPago.Value,
                FormaPago = cboFormaPago.Text,
                Monto = decimal.Parse(txtMontoPago.Text),
                NumeroCuota = int.Parse(txtNumCuotas.Text)
            };
            pagoRepo.Registrar(pago);
            MessageBox.Show("Se ha registrado el pago!");
        }

        private void btnActualizarPago_Click(object sender, EventArgs e)
        {
            Pago pago = new Pago
            {
                IdPago = int.Parse(txtIdPago.Text),
                IdPoliza = int.Parse(txtIdPago.Text),
                FechaPago = dateFechaPago.Value,
                FormaPago = cboFormaPago.Text,
                Monto = decimal.Parse(txtMontoPago.Text),
                NumeroCuota = int.Parse(txtNumCuotas.Text)
            };
            pagoRepo.Registrar(pago);
            MessageBox.Show("Se ha actualizado el pago!");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal(_rolUsuario);
            principal.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cliente = txtClientePago.Text;
            string tipo = cmbTipoSeguro.SelectedIndex > 0 ? cmbTipoSeguro.Text : "";
            DateTime? fecha = chkFiltrarFecha.Checked ? dateFechaPago.Value : (DateTime?)null;

            PagoRepositorio pagoRepo = new PagoRepositorio();
            dgvPagosFiltrado.DataSource = pagoRepo.FiltrarPagos(cliente, tipo, fecha);
        }

        private void CargarCombox()
        {
            // ComboBox de tipo de seguro
            cmbTipoSeguro.Items.Clear();
            cmbTipoSeguro.Items.Add("Todos");
            cmbTipoSeguro.Items.Add("Vida");
            cmbTipoSeguro.Items.Add("Salud");
            cmbTipoSeguro.Items.Add("Automóvil");
            cmbTipoSeguro.Items.Add("Hogar");
            cmbTipoSeguro.Items.Add("Otro");
            cmbTipoSeguro.SelectedIndex = 0;

            // ComboBox de forma de pago
            cboFormaPago.Items.Clear();
            cboFormaPago.Items.Add("Todos");
            cboFormaPago.Items.Add("Efectivo");
            cboFormaPago.Items.Add("Tarjeta");
            cboFormaPago.Items.Add("Transferencia");
            cboFormaPago.SelectedIndex = 0;
        }

        private void FrmGestionPagos_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar el formulario: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtListar_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = pagoRepo.Listar();
                dgvListadoPagos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBuscarPago_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdPago.Text))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }

            if (!int.TryParse(txtIdPago.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número");
                return;
            }

            try
            {
                Pago pago = pagoRepo.ObtenerPorId(id);
                if (pago != null)
                {

                    // Cargar en el formulario
                    cboFormaPago.Text = pago.FormaPago;
                    txtMontoPago.Text = pago.Monto.ToString();
                    txtNumCuotas.Text = pago.NumeroCuota.ToString();
                    txtIdPolizaPago.Text = pago.IdPoliza.ToString();
                    dateFechaPago.Value = pago.FechaPago;

                    // Obtener la póliza relacionada para conseguir el IdCliente
                    var polizaRepo = new PolizaRepositorio();
                    var poliza = polizaRepo.ObtenerPorId(pago.IdPoliza);

                    if (poliza != null)
                    {
                        // Obtener cliente por IdCliente y mostrar nombre completo
                        var clienteRepo = new ClienteRepositorio();
                        var cliente = clienteRepo.ObtenerPorId(poliza.IdCliente);

                        if (cliente != null)
                        {
                            txtClientePago.Text = $"{cliente.Nombre} {cliente.Apellido}";
                        }
                        else
                        {
                            // Si no se encuentra el cliente, mostrar el id como fallback
                            txtClientePago.Text = $"Cliente Id: {poliza.IdCliente}";
                        }
                    }
                    else
                    {
                        // Si no se encuentra la póliza, mostrar el IdPoliza como fallback
                        txtClientePago.Text = $"Póliza Id: {pago.IdPoliza}";
                    }

                }
                else
                {
                    MessageBox.Show("Pago no encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FrmGestionPagos_FormClosing(object sender, FormClosingEventArgs e)
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
        private void LimpiarFormulario()
        {
            txtIdPago.Clear();
            txtMontoPago.Clear();
            txtIdPolizaPago.Clear();
            txtClientePago.Clear();
            txtNumCuotas.Clear();
            cboFormaPago.SelectedIndex = 0;
            cmbTipoSeguro.SelectedIndex = 0;
            dateFechaPago.Value = DateTime.Today;
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void txtIdPolizaPago_Enter(object sender, EventArgs e)
        {
            /*if (string.IsNullOrWhiteSpace(txtIdPolizaPago.Text))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }

            if (!int.TryParse(txtIdPolizaPago.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número");
                return;
            }

            try
            {
                Poliza pol = polRepo.ObtenerPorId(id);
                if (pol != null)
                {

                    // Cargar en el formulario
                    txtMontoPago.Text = pol.Monto.ToString();

                    // Obtener cliente por IdCliente y mostrar nombre completo
                    var clienteRepo = new ClienteRepositorio();
                    var cliente = clienteRepo.ObtenerPorId(pol.IdCliente);

                    if (cliente != null)
                    {
                        txtClientePago.Text = $"{cliente.Nombre} {cliente.Apellido}";
                    }
                    else
                    {
                        // Si no se encuentra el cliente, mostrar el id como fallback
                        txtClientePago.Text = $"Cliente Id: {pol.IdCliente}";
                    }

                    // Obtener tipo de seguro por IdSeguro y mostrar su nombre
                    var seguroRepo = new SeguroRepositorio();
                    var seguro = seguroRepo.ObtenerPorId(pol.IdSeguro);
                    if (seguro != null)
                    {
                        cmbTipoSeguro.Text = seguro.Tipo;
                    }
                    else
                    {
                        // Si no se encuentra el seguro, mostrar el id como fallback
                        cmbTipoSeguro.Text = $"Seguro Id: {pol.IdSeguro}";
                    }
                }
                else
                {
                    MessageBox.Show("Poliza no encontrada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }*/
        }

        private void txtIdPolizaPago_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (string.IsNullOrWhiteSpace(txtIdPolizaPago.Text))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }
            */
            if (!int.TryParse(txtIdPolizaPago.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número");
                return;
            }

            try
            {
                Poliza pol = polRepo.ObtenerPorId(id);
                if (pol != null)
                {

                    // Cargar en el formulario
                    txtMontoPago.Text = pol.Monto.ToString();

                    // Obtener cliente por IdCliente y mostrar nombre completo
                    var clienteRepo = new ClienteRepositorio();
                    var cliente = clienteRepo.ObtenerPorId(pol.IdCliente);

                    if (cliente != null)
                    {
                        txtClientePago.Text = $"{cliente.Nombre} {cliente.Apellido}";
                    }
                    else
                    {
                        // Si no se encuentra el cliente, mostrar el id como fallback
                        txtClientePago.Text = $"Cliente Id: {pol.IdCliente}";
                    }

                    // Obtener tipo de seguro por IdSeguro y mostrar su nombre
                    var seguroRepo = new SeguroRepositorio();
                    var seguro = seguroRepo.ObtenerPorId(pol.IdSeguro);
                    if (seguro != null)
                    {
                        cmbTipoSeguro.Text = seguro.Tipo;
                    }
                    else
                    {
                        // Si no se encuentra el seguro, mostrar el id como fallback
                        cmbTipoSeguro.Text = $"Seguro Id: {pol.IdSeguro}";
                    }
                }
                else
                {
                    MessageBox.Show("Poliza no encontrada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
