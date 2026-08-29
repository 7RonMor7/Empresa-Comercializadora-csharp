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
using Empresa_Comercializadora.Modelo;

namespace Empresa_Comercializadora.Formularios
{
    public partial class FrmGestionSeguros : Form
    {
        private string _rolUsuario;

        private SeguroRepositorio seguroRepo = new SeguroRepositorio();
        private AseguradoraRepositorio aseguradoraRepo = new AseguradoraRepositorio();
        private int? idSeguroActual = null;
        public FrmGestionSeguros(string rolUsuario)
        {
            InitializeComponent();
            _rolUsuario = rolUsuario;
        }

        private void FrmGestionSeguros_Load_1(object sender, EventArgs e)
        {
            try
            {
                ConfigurarDataGridView();
                CargarComboTipos();
                CargarAseguradoras();
                CargarSeguros();
                MostrarVista("lista");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar el formulario: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region CONFIGURACIÓN INICIAL

        private void ConfigurarDataGridView()
        {
            dgvSeguros.AutoGenerateColumns = false;
            dgvSeguros.AllowUserToAddRows = false;
            dgvSeguros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSeguros.MultiSelect = false;
            dgvSeguros.ReadOnly = true;
            dgvSeguros.RowHeadersVisible = false;
            dgvSeguros.Columns.Clear();

            // Estilos alternados
            dgvSeguros.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#F9F9F9");
            dgvSeguros.DefaultCellStyle.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#007ACC");

            dgvSeguros.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdSeguro",
                DataPropertyName = "IdSeguro",
                HeaderText = "ID",
                Width = 60
            });

            dgvSeguros.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Aseguradora",
                DataPropertyName = "Aseguradora",
                HeaderText = "Aseguradora",
                Width = 180
            });

            dgvSeguros.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Tipo",
                DataPropertyName = "Tipo",
                HeaderText = "Tipo",
                Width = 120
            });

            dgvSeguros.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cobertura",
                DataPropertyName = "Cobertura",
                HeaderText = "Cobertura",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvSeguros.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Costo",
                DataPropertyName = "Costo",
                HeaderText = "Costo",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgvSeguros.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DuracionMeses",
                DataPropertyName = "DuracionMeses",
                HeaderText = "Meses",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });
        }

        private void CargarComboTipos()
        {
            // ComboBox de búsqueda
            cmbTipoBusqueda.Items.Clear();
            cmbTipoBusqueda.Items.Add("Todos");
            cmbTipoBusqueda.Items.Add("Vida");
            cmbTipoBusqueda.Items.Add("Salud");
            cmbTipoBusqueda.Items.Add("Automóvil");
            cmbTipoBusqueda.Items.Add("Hogar");
            cmbTipoBusqueda.Items.Add("Otro");
            cmbTipoBusqueda.SelectedIndex = 0;

            // ComboBox de formulario
            cmbTipoForm.Items.Clear();
            cmbTipoForm.Items.Add("Vida");
            cmbTipoForm.Items.Add("Salud");
            cmbTipoForm.Items.Add("Automóvil");
            cmbTipoForm.Items.Add("Hogar");
            cmbTipoForm.Items.Add("Otro");
            cmbTipoForm.SelectedIndex = 0;
        }

        private void CargarAseguradoras()
        {
            try
            {
                var aseguradoras = aseguradoraRepo.ListarTodas();
                cmbAseguradoraForm.DataSource = aseguradoras;
                cmbAseguradoraForm.DisplayMember = "Nombre";
                cmbAseguradoraForm.ValueMember = "IdAseguradora";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar aseguradoras: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region CONTROL DE VISTAS

        private void MostrarVista(string vista)
        {
            pnlLista.Visible = false;
            pnlFormulario.Visible = false;
            pnlDetalle.Visible = false;

            switch (vista.ToLower())
            {
                case "lista":
                    pnlLista.Visible = true;
                    pnlLista.BringToFront();
                    break;
                case "formulario":
                    pnlFormulario.Visible = true;
                    pnlFormulario.BringToFront();
                    break;
                case "detalle":
                    pnlDetalle.Visible = true;
                    pnlDetalle.BringToFront();
                    break;
            }
        }

        #endregion

        //region LISTADO Y BÚSQUEDA

        private void CargarSeguros()
        {
            try
            {
                DataTable dt = seguroRepo.Listar();
                dgvSeguros.DataSource = dt;
                lblTotal.Text = $"Total de seguros: {dt.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar seguros: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void guna2HtmlLabel12_Click(object sender, EventArgs e)
        { }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string tipo = cmbTipoBusqueda.SelectedItem.ToString();
                string aseguradora = txtAseguradoraBusqueda.Text.Trim();

                decimal? costoMin = null;
                if (!string.IsNullOrWhiteSpace(txtCostoMin.Text))
                {
                    if (decimal.TryParse(txtCostoMin.Text, out decimal valorMin))
                        costoMin = valorMin;
                }

                decimal? costoMax = null;
                if (!string.IsNullOrWhiteSpace(txtCostoMax.Text))
                {
                    if (decimal.TryParse(txtCostoMax.Text, out decimal valorMax))
                        costoMax = valorMax;
                }

                int? duracionMin = null;
                if (!string.IsNullOrWhiteSpace(txtDuracionMin.Text))
                {
                    if (int.TryParse(txtDuracionMin.Text, out int valorDurMin))
                        duracionMin = valorDurMin;
                }

                int? duracionMax = null;
                if (!string.IsNullOrWhiteSpace(txtDuracionMax.Text))
                {
                    if (int.TryParse(txtDuracionMax.Text, out int valorDurMax))
                        duracionMax = valorDurMax;
                }

                DataTable dt = seguroRepo.BuscarAvanzado(tipo, aseguradora,
                    costoMin, costoMax, duracionMin, duracionMax);

                dgvSeguros.DataSource = dt;
                lblTotal.Text = $"Resultados encontrados: {dt.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la búsqueda: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idSeguroActual = null;
            LimpiarFormulario();
            lblTituloForm.Text = "➕ NUEVO SEGURO";
            MostrarVista("formulario");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSeguros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un seguro para eliminar",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string aseguradora = dgvSeguros.SelectedRows[0].Cells["Aseguradora"].Value.ToString();
            string tipo = dgvSeguros.SelectedRows[0].Cells["Tipo"].Value.ToString();

            DialogResult resultado = MessageBox.Show(
                $"¿Está seguro de eliminar el seguro de {tipo} de {aseguradora}?\n\n" +
                "Esta acción no se puede deshacer.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    int idSeguro = Convert.ToInt32(dgvSeguros.SelectedRows[0].Cells["IdSeguro"].Value);
                    seguroRepo.Eliminar(idSeguro);
                    CargarSeguros();
                    MessageBox.Show("Seguro eliminado correctamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvSeguros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un seguro para editar",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idSeguro = Convert.ToInt32(dgvSeguros.SelectedRows[0].Cells["IdSeguro"].Value);
            CargarDatosFormulario(idSeguro);
            lblTituloForm.Text = "✏️ EDITAR SEGURO";
            MostrarVista("formulario");
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvSeguros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un seguro para ver detalle",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idSeguro = Convert.ToInt32(dgvSeguros.SelectedRows[0].Cells["IdSeguro"].Value);
            CargarDetalle(idSeguro);
            MostrarVista("detalle");
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
            CargarSeguros();
        }

        private void LimpiarFiltros()
        {
            cmbTipoBusqueda.SelectedIndex = 0;
            txtAseguradoraBusqueda.Clear();
            txtCostoMin.Clear();
            txtCostoMax.Clear();
            txtDuracionMin.Clear();
            txtDuracionMax.Clear();
        }

        private void LimpiarFormulario()
        {
            if (cmbAseguradoraForm.Items.Count > 0)
                cmbAseguradoraForm.SelectedIndex = 0;

            cmbTipoForm.SelectedIndex = 0;
            txtCoberturaForm.Clear();
            txtCostoForm.Clear();
            nudDuracionForm.Value = 12;
            txtBeneficiosForm.Clear();
            txtExclusionesForm.Clear();
            txtCondicionesForm.Clear();
        }

        private void CargarDatosFormulario(int idSeguro)
        {
            try
            {
                Seguro seguro = seguroRepo.ObtenerPorId(idSeguro);

                if (seguro != null)
                {
                    idSeguroActual = idSeguro;
                    cmbAseguradoraForm.SelectedValue = seguro.IdAseguradora;
                    cmbTipoForm.SelectedItem = seguro.Tipo;
                    txtCoberturaForm.Text = seguro.Cobertura;
                    txtCostoForm.Text = seguro.Costo.ToString("F2");
                    nudDuracionForm.Value = seguro.DuracionMeses;
                    txtBeneficiosForm.Text = seguro.Beneficios ?? "";
                    txtExclusionesForm.Text = seguro.Exclusiones ?? "";
                    txtCondicionesForm.Text = seguro.Condiciones ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSeguros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }
        private void txtCostoMin_TextChanged(object sender, EventArgs e)
        { }
        private void txtCostoMax_TextChanged(object sender, EventArgs e)
        { }
        private void txtDuracionMin_TextChanged(object sender, EventArgs e)
        {  }
        private void txtDuracionMax_TextChanged(object sender, EventArgs e)
        {  }

        private void btnGuardarForm_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposFormulario())
                return;

            try
            {
                Seguro seguro = new Seguro
                {
                    IdAseguradora = (int)cmbAseguradoraForm.SelectedValue,
                    Tipo = cmbTipoForm.SelectedItem.ToString(),
                    Cobertura = txtCoberturaForm.Text.Trim(),
                    Costo = Convert.ToDecimal(txtCostoForm.Text),
                    DuracionMeses = (int)nudDuracionForm.Value,
                    Beneficios = txtBeneficiosForm.Text.Trim(),
                    Exclusiones = txtExclusionesForm.Text.Trim(),
                    Condiciones = txtCondicionesForm.Text.Trim()
                };

                if (idSeguroActual == null) // Nuevo
                {
                    seguroRepo.Registrar(seguro);
                    MessageBox.Show("✅ Seguro registrado correctamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Editar
                {
                    seguro.IdSeguro = idSeguroActual.Value;
                    seguroRepo.Actualizar(seguro);
                    MessageBox.Show("✅ Seguro actualizado correctamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CargarSeguros();
                MostrarVista("lista");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al guardar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCamposFormulario()
        {
            if (cmbAseguradoraForm.SelectedIndex == -1)
            {
                MessageBox.Show("⚠️ Debe seleccionar una aseguradora",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbAseguradoraForm.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCoberturaForm.Text))
            {
                MessageBox.Show("⚠️ La cobertura es obligatoria",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCoberturaForm.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCostoForm.Text))
            {
                MessageBox.Show("⚠️ El costo es obligatorio",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCostoForm.Focus();
                return false;
            }

            if (!decimal.TryParse(txtCostoForm.Text, out decimal costo) || costo <= 0)
            {
                MessageBox.Show("⚠️ El costo debe ser un número positivo válido",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCostoForm.Focus();
                return false;
            }

            if (nudDuracionForm.Value <= 0)
            {
                MessageBox.Show("⚠️ La duración debe ser mayor a 0",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudDuracionForm.Focus();
                return false;
            }

            return true;
        }


        private void btnCancelarForm_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de cancelar? Se perderán los cambios no guardados.",
                "Confirmar cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                MostrarVista("lista");
            }
        }

        private void txtCostoForm_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números, punto decimal y tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Solo permitir un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        private void CargarDetalle(int idSeguro)
        {
            try
            {
                Seguro seguro = seguroRepo.ObtenerPorId(idSeguro);

                if (seguro != null)
                {
                    lblIdSeguroDetalle.Text = seguro.IdSeguro.ToString();
                    lblAseguradoraDetalle.Text = seguro.NombreAseguradora;
                    lblTipoDetalle.Text = seguro.Tipo;
                    lblCostoDetalle.Text = seguro.Costo.ToString("C2");
                    lblDuracionDetalle.Text = seguro.DuracionMeses + " meses";

                    txtCoberturaDetalle.Text = seguro.Cobertura;

                    txtBeneficiosDetalle.Text = string.IsNullOrEmpty(seguro.Beneficios) ?
                        "No se especificaron beneficios para este seguro." : seguro.Beneficios;

                    txtExclusionesDetalle.Text = string.IsNullOrEmpty(seguro.Exclusiones) ?
                        "No se especificaron exclusiones para este seguro." : seguro.Exclusiones;

                    txtCondicionesDetalle.Text = string.IsNullOrEmpty(seguro.Condiciones) ?
                        "No se especificaron condiciones para este seguro." : seguro.Condiciones;
                }
                else
                {
                    MessageBox.Show("No se encontró el seguro seleccionado",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MostrarVista("lista");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalle: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MostrarVista("lista");
            }
        }
        private void txtCostoForm_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolverDetalle_Click(object sender, EventArgs e)
        {
            MostrarVista("lista");
        }

        private void txtCostoMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtCostoMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCostoMin_KeyPress(sender, e);
        }

        private void txtDuracionMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDuracionMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDuracionMin_KeyPress(sender, e);

        }

        private void dgvSeguros_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnVerDetalle_Click(sender, e);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal(_rolUsuario);
            principal.Show();
            this.Hide();
        }

        private void FrmGestionSeguros_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txtCoberturaForm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
