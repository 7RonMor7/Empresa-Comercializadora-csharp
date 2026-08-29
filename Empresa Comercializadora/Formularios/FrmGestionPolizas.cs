using Empresa_Comercializadora.Modelo;
using Empresa_Comercializadora.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa_Comercializadora.Formularios
{
    public partial class FrmGestionPolizas : Form
    {
        private string _rolUsuario;
        public FrmGestionPolizas(string rolUsuario)
        {
            InitializeComponent();
            txtIdSeguroPoliza.KeyDown += txtidseguro_KeyDown;
            _rolUsuario = rolUsuario;
        }

        //Crear un objeto PolizaRepositorio
        PolizaRepositorio polizaRepo = new PolizaRepositorio();

        private void btnCrearPoliza_Click(object sender, EventArgs e)
        {
            Poliza poliza = new Poliza
            {
                IdPoliza = int.Parse(txtIdPoliza.Text),
                IdCliente = int.Parse(txtIdClientePoliza.Text),
                IdSeguro = int.Parse(txtIdSeguroPoliza.Text),
                FechaInicio = dateInicioPoliza.Value,
                FechaFin = dateFinPoliza.Value,
                Estado = "Vigente",
                Monto = decimal.Parse(txtMontoPoliza.Text),
                Observaciones = txtboxObservaciones.Text
            };
            polizaRepo.AgregarPoliza(poliza);
            MessageBox.Show("Se ha registrado la poliza!");
        }

        private void btnActualizarPoliza_Click(object sender, EventArgs e)
        {
            Poliza poliza = new Poliza
            {
                Estado = "Renovación",
                Monto = decimal.Parse(txtMontoPoliza.Text),
                FechaFin = dateFinPoliza.Value,
                Observaciones = txtboxObservaciones.Text
            };
            polizaRepo.ActualizarPoliza(poliza);
            MessageBox.Show("Se ha actualizado la poliza!");
        }

        private void btnListarPoliza_Click(object sender, EventArgs e)
        {
            dgvPolizas.DataSource = null;
            dgvPolizas.DataSource = polizaRepo.ListarPolizas();
        }

        private void btnActualizarEstadoPoliza_Click(object sender, EventArgs e)
        {
            polizaRepo.CancelarPolizasVencidas();
            MessageBox.Show("Pólizas vencidas actualizadas correctamente.", "Información");
            dgvPolizas.DataSource = polizaRepo.ListarPolizas();
        }

        private void btnGenerarCertPoliza_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdPoliza.Text, out int idPoliza))
            {
                MessageBox.Show("ID de póliza inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string folder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Certificados");
            System.IO.Directory.CreateDirectory(folder);
            string ruta = System.IO.Path.Combine(folder, $"Poliza_{idPoliza}.pdf");

            // Llamamos al método que ya tienes en PolizaRepositorio
            polizaRepo.GenerarCertificadoPDF(idPoliza, ruta);

            MessageBox.Show("Certificado generado correctamente:\n" + ruta, "Éxito");
        }

        private void txtIdSeguroPoliza_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegresarPrinc_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal(_rolUsuario);
            principal.Show();
            this.Hide();
        }

        private void CargarMontoPoliza()
        {
            if (int.TryParse(txtIdSeguroPoliza.Text, out int idSeguro))
            {
                var repo = new SeguroRepositorio();
                var seguro = repo.ObtenerPorId(idSeguro);
                if (seguro != null)
                {
                    txtMontoPoliza.Text = seguro.Costo.ToString("F2");
                }
                else
                {
                    txtMontoPoliza.Text = "";
                    MessageBox.Show("Seguro no encontrado.");
                }
            }
            else
            {
                txtMontoPoliza.Text = "";
                MessageBox.Show("ID de seguro inválido.");
            }
        }

        private void txtidseguro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CargarMontoPoliza();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnBuscarIDPoliza_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdPoliza.Text))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }

            if (!int.TryParse(txtIdPoliza.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número");
                return;
            }

            try
            {
                Poliza poliza = polizaRepo.ObtenerPorId(id);
                if (poliza != null)
                {
                    // Mostrar en el grid
                    DataTable dt = new DataTable();
                    dt.Columns.Add("IdPoliza", typeof(int));
                    dt.Columns.Add("IDCliente", typeof(int));
                    dt.Columns.Add("IdSeguro", typeof(int));
                    dt.Columns.Add("FechaInicio", typeof(DateTime));
                    dt.Columns.Add("FechaFin", typeof(DateTime));
                    dt.Columns.Add("Estado", typeof(string));
                    dt.Columns.Add("Monto", typeof(decimal));
                    dt.Columns.Add("Observaciones", typeof(string));

                    dt.Rows.Add(poliza.IdPoliza, poliza.IdCliente, poliza.IdSeguro, poliza.FechaInicio,
                               poliza.FechaFin, poliza.Estado, poliza.Monto, poliza.Observaciones);

                    dgvPolizas.DataSource = dt;

                    // Cargar en el formulario
                    txtIdPoliza.Text = poliza.IdPoliza.ToString();
                    txtIdClientePoliza.Text = poliza.IdCliente.ToString();
                    txtIdSeguroPoliza.Text = poliza.IdSeguro.ToString();
                    dateInicioPoliza.Value = poliza.FechaInicio;
                    dateFinPoliza.Value = poliza.FechaFin;
                    txtMontoPoliza.Text = poliza.Monto.ToString();
                    txtMontoPoliza.Text = poliza.Monto.ToString("F2");
                    txtboxObservaciones.Text = poliza.Observaciones;
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

        private void FrmGestionPolizas_FormClosing(object sender, FormClosingEventArgs e)
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
            txtIdPoliza.Clear();
            txtIdSeguroPoliza.Clear();
            txtMontoPoliza.Text = "0";
            txtIdClientePoliza.Clear();
            dateInicioPoliza.Value = DateTime.Today;
            dateFinPoliza.Value = DateTime.Today;
            txtboxObservaciones.Clear();
        }
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
