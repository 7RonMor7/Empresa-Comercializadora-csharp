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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private UsuarioRepositorio repoUsuario = new UsuarioRepositorio();
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // 1. Capturar y limpiar datos de entrada
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text;

            // 2. Validar campos vacíos en la interfaz
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Debes ingresar el usuario y la contraseña.", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            // 3. Llamar a la lógica de la base de datos
            string rolUsuario = repoUsuario.ValidarLoginYObtenerRol(usuario, contrasena);

            // 4. Evaluar el resultado
            if (!string.IsNullOrEmpty(rolUsuario))
            {
                // Login Exitoso
                MessageBox.Show($"¡Bienvenido, {usuario}! Tu Rol es: {rolUsuario}", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // **********************************************
                // ** Siguiente Paso: Abrir la Ventana Principal **
                // Aquí debes abrir la ventana principal y, posiblemente, 
                // pasarle el rol del usuario para configurar los permisos.

                // Ejemplo: 
                // FormPrincipal principal = new FormPrincipal(rolUsuario);
                // principal.Show();
                // this.Hide(); 
                // **********************************************
                FrmPrincipal principal = new FrmPrincipal(rolUsuario);
                principal.Show();
                this.Hide();
            }
            else
            {
                // Login Fallido (Credenciales incorrectas o error en la BD)
                MessageBox.Show("Credenciales inválidas, usuario inactivo o error de sistema.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContrasena.Clear();
                txtContrasena.Focus();
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ingresar Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ingresar Usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "Ingrese Contraseña")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Black;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "Ingresar Contraseña";
                txtContrasena.ForeColor = Color.Gray;
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
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

