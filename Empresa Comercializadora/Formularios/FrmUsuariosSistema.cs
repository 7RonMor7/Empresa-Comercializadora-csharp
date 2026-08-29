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
    public partial class FrmUsuariosSistema : Form
    {
        private string _rolUsuario;
        public FrmUsuariosSistema(string rolUsuario)
        {
            InitializeComponent();
            _rolUsuario = rolUsuario;
            CargarCombo();
        }
        private UsuarioRepositorio repoUsuario = new UsuarioRepositorio();

        private void CargarCombo()
        {
            // ComboBox de rol
            cboRol.Items.Clear();
            cboRol.Items.Add("Administrativo");
            cboRol.Items.Add("Empleado");
            cboRol.SelectedIndex = 0;
        }
        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdUsuario.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string correo = txtCorreo.Text;
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            // Obtener el valor del RadioButton para Rol y Estado
            string rol = cboRol.SelectedItem.ToString();
            string estado;
            if (radioActivo.Checked == false && radioInactivo.Checked == false)
            {
                MessageBox.Show("Por favor, seleccione un estado para el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (radioActivo.Checked == true)
                {
                    estado = "Activo";
                }
                else
                {
                    estado = "Inactivo";
                }
            }

            bool exito = repoUsuario.CrearUsuario(id, nombre, apellido, correo, usuario, contrasena, rol, estado);

            if (exito)
            {
                MessageBox.Show("Usuario creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpiar formulario...
            }
            else
            {
                MessageBox.Show("Error al crear usuario. Verifica que el ID, Usuario o Correo no existan.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresarPrinc_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal(_rolUsuario);
            principal.Show();
            this.Hide();
        }

        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdUsuario.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string correo = txtCorreo.Text;
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            // Obtener el valor del RadioButton para Rol y Estado
            string rol = cboRol.SelectedItem.ToString();
            string estado;
            if (radioActivo.Checked == false && radioInactivo.Checked == false)
            {
                MessageBox.Show("Por favor, seleccione un estado para el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (radioActivo.Checked == true)
                {
                    estado = "Activo";
                }
                else
                {
                    estado = "Inactivo";
                }
            }

            bool exito = repoUsuario.ActualizarUsuario(id, nombre, apellido, correo, usuario, contrasena, rol, estado);

            if (exito)
            {
                MessageBox.Show("Usuario actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpiar formulario...
            }
            else
            {
                MessageBox.Show("Error al actualizar usuario. Verifica que el ID, Usuario o Correo no existan.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdUsuario.Text))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }

            if (!int.TryParse(txtIdUsuario.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número");
                return;
            }

            try
            {
                Usuario usuario = repoUsuario.ObtenerPorId(id);
                if (usuario != null)
                {
                    // Cargar en el formulario
                    txtNombre.Text = usuario.Nombre;
                    txtApellido.Text = usuario.Apellido;
                    txtCorreo.Text = usuario.Correo;
                    /*txtUsuario.Text = usuario.Usuario;*/
                    txtContrasena.Text = usuario.Contrasena;
                    cboRol.SelectedItem = usuario.Rol;
                    if (usuario.Estado == "Activo")
                    {
                        radioActivo.Checked = true;
                    }
                    else
                    {
                        radioInactivo.Checked = true;
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FrmUsuariosSistema_FormClosing(object sender, FormClosingEventArgs e)
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
            txtIdUsuario.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtUsuario.Clear();
            txtContrasena.Clear();
            cboRol.SelectedIndex = 0;
            radioActivo.Checked = false;
            radioInactivo.Checked = false;
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
