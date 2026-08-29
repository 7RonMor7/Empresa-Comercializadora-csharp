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
    public partial class FrmPrincipal : Form
    {
        
        private string _rolUsuario;
        public FrmPrincipal(string rolUsuario)
        {
            InitializeComponent();
            _rolUsuario = rolUsuario;

            ConfigurarPermisos();
        }

        private void ConfigurarPermisos()
        {
            if (_rolUsuario == "Empleado")
            {
                btnUsuariosSistema.Enabled = false;
                btn_ir_estadistica.Enabled = false;

                // Si deseas ocultarlos, usa:
                // btnGestionUsuarios.Visible = false;
                // btnInformes.Visible = false;
            }
        }

        private void btnGuardarPago_Click(object sender, EventArgs e)
        {
            FrmUsuariosSistema ventanausuarios = new FrmUsuariosSistema(_rolUsuario);
            ventanausuarios.Show();
            this.Hide();

        }

        private void btnRegresarPrinc_Click(object sender, EventArgs e)
        {
            Login ingreso = new Login();
            ingreso.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmGestionSeguros segurosq = new FrmGestionSeguros(_rolUsuario);
            segurosq.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmGestionPagos irPagos = new FrmGestionPagos(_rolUsuario);
            irPagos.Show();
            this.Hide();
        }

        private void btn_ir_Polizas_Click(object sender, EventArgs e)
        {
            FrmGestionPolizas irPolizas = new FrmGestionPolizas(_rolUsuario);
            irPolizas.Show();
            this.Hide();
        }

        private void btn_Ir_clientes_Click(object sender, EventArgs e)
        {
            FrmGestionClientes irCliente = new FrmGestionClientes(_rolUsuario);
            irCliente.Show();
            this.Hide();
        }

        private void btn_ir_estadistica_Click(object sender, EventArgs e)
        {
            FrmInformesyEstadisticas irEstadisticas = new FrmInformesyEstadisticas(_rolUsuario);
            irEstadisticas.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
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
