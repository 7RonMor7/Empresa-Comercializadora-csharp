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
    public partial class frmConfirmacion : Form
    {
        public frmConfirmacion(string mensaje, string titulo = "Confirmacion")
        {
            InitializeComponent();
            this.Text = titulo;
            lblMensaje.Text = mensaje;
        }

        /*//Instanciar el formulario de confirmacion
            using (frmConfirmacion frm = new frmConfirmacion("¿Está seguro que desea salir del sistema?", "Comercializadora Don Chucho"))
            {
                var resultado = frm.ShowDialog(); // Formulario modal
                if (resultado == DialogResult.No)
                {
                    e.Cancel = true; // Cancelar el cierre del formulario

                } else
                {
                    Application.ExitThread();
                }
            }*/

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Hide();
        }
    }
}
