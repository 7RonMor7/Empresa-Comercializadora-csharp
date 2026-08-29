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
using static Guna.UI2.Native.WinApi;

namespace Empresa_Comercializadora.Formularios
{
    public partial class FrmGestionClientes : Form
    {
        private string _rolUsuario;

        private ClienteRepositorio clienteRepo = new ClienteRepositorio();
        public FrmGestionClientes(string rolUsuario)
        {
            InitializeComponent();
            _rolUsuario = rolUsuario;
        }

        private void FrmGestionClientes_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CargarHistorialCombo();
            CargarClientes();
            LimpiarFormulario();    
        }

        private void ConfigurarGrid()
        {
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.ReadOnly = true;
            dgvClientes.Columns.Clear();

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdCliente",
                DataPropertyName = "IdCliente",
                HeaderText = "ID",
                Width = 50
            });

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                Width = 120
            });

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Apellido",
                DataPropertyName = "Apellido",
                HeaderText = "Apellido",
                Width = 120
            });

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Telefono",
                DataPropertyName = "Telefono",
                HeaderText = "Teléfono",
                Width = 100
            });

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Correo",
                DataPropertyName = "Correo",
                HeaderText = "Correo",
                Width = 180
            });

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "HistorialCrediticio",
                DataPropertyName = "HistorialCrediticio",
                HeaderText = "Historial",
                Width = 100
            });
        }

        private void CargarHistorialCombo()
        {
            cmbHistorial.Items.Clear();
            cmbHistorial.Items.Add("Bueno");
            cmbHistorial.Items.Add("Regular");
            cmbHistorial.Items.Add("Malo");
            cmbHistorial.SelectedIndex = 0;
        }

        private void CargarClientes()
        {
            try
            {
                DataTable dt = clienteRepo.Listar();
                dgvClientes.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarId.Text))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }

            if (!int.TryParse(txtBuscarId.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número");
                return;
            }

            try
            {
                Cliente cliente = clienteRepo.ObtenerPorId(id);
                if (cliente != null)
                {
                    // Mostrar en el grid
                    DataTable dt = new DataTable();
                    dt.Columns.Add("IdCliente", typeof(int));
                    dt.Columns.Add("Nombre", typeof(string));
                    dt.Columns.Add("Apellido", typeof(string));
                    dt.Columns.Add("Telefono", typeof(string));
                    dt.Columns.Add("Correo", typeof(string));
                    dt.Columns.Add("HistorialCrediticio", typeof(string));

                    dt.Rows.Add(cliente.IdCliente, cliente.Nombre, cliente.Apellido,
                               cliente.Telefono, cliente.Correo, cliente.HistorialCrediticio);

                    dgvClientes.DataSource = dt;

                    // Cargar en el formulario
                    txtIdCliente.Text = cliente.IdCliente.ToString();
                    txtNombres.Text = cliente.Nombre;
                    txtApellidos.Text = cliente.Apellido;
                    txtDireccion.Text = cliente.Direccion;
                    txtTelefono.Text = cliente.Telefono;
                    txtCorreo.Text = cliente.Correo;
                    cmbHistorial.SelectedItem = cliente.HistorialCrediticio;
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            txtBuscarId.Clear();
            CargarClientes();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            txtNombres.Focus();
        }

        // Registrar cliente
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente
            {
                IdCliente = int.Parse(txtIdCliente.Text),
                Nombre = txtNombres.Text,
                Apellido = txtApellidos.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text,
                HistorialCrediticio = cmbHistorial.SelectedItem.ToString()
            };
            clienteRepo.Registrar(cliente);
            MessageBox.Show("Se ha registrado el cliente!");

        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente
            {
                IdCliente = int.Parse(txtIdCliente.Text),
                Nombre = txtNombres.Text,
                Apellido = txtApellidos.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text,
                HistorialCrediticio = cmbHistorial.SelectedItem.ToString()
            };
            clienteRepo.Actualizar(cli);
            MessageBox.Show("Se ha actualizado el cliente!"); 
            
        }

        private void btnVerDetalleCliente_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtIdCliente.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            cmbHistorial.SelectedIndex = 0;
            dgvClientes.ClearSelection();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnEditarCliente_Click(sender, e);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal(_rolUsuario);
            principal.Show();
            this.Hide();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmGestionClientes_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
