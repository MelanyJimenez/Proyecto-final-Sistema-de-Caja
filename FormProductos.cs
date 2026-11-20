using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_caja
{
    public partial class FormProductos : Form
    {
        private FormCaja frmCaja;
        private FormReportes frmReportes;
        private RepositorioProductos _repositorioProductos;
        private string codigoSelect;
        private int _usuarioActual;
        public FormProductos(FormCaja frmCaja, int UsuarioActual)
        {
            InitializeComponent();
            this._usuarioActual = UsuarioActual;
            this.frmCaja = frmCaja;

            this._repositorioProductos = new RepositorioProductos();

            ActualizarCataloogo();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btCaja_Click(object sender, EventArgs e)
        {
            frmCaja.Show();
            Hide();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }

        public void ActualizarCataloogo()
        {
            try
            {
                dataGridView1.Rows.Clear();

                int idUsuario = frmCaja.ObtenerUsuarioActual().ObtenerId();
                List<Producto> listarProducto = _repositorioProductos.ObtenerProductos(idUsuario);

                foreach (Producto p in listarProducto)
                {
                    dataGridView1.Rows.Add(
                     p.ObtenerCodBarras(),
                     p.ObtenerDescripcion(),
                     p.ObtenerPrecio(),
                     p.ObtenerStock(),
                     p.ObtenerCategoria()
                     );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando el catalogo" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textCodBarras.Text) || string.IsNullOrWhiteSpace(textNombreP.Text) ||
                string.IsNullOrWhiteSpace(textPrecio.Text) || string.IsNullOrWhiteSpace(textStock.Text) ||
                cbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Complete todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(textPrecio.Text.Trim(), out double precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textStock.Text.Trim(), out int stock) || stock < 0)
            {
                MessageBox.Show("El stock debe ser mayor o igual a 0 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string codigo = textCodBarras.Text.Trim();
                string descripcion = textNombreP.Text.Trim();
                string categoria = cbCategoria.SelectedItem.ToString();
                int idUsuario = frmCaja.ObtenerUsuarioActual().ObtenerId();

                Producto nuevoP = new Producto(0, codigo, descripcion, precio, stock, categoria, idUsuario);
                _repositorioProductos.Agregar(idUsuario, nuevoP);

                MessageBox.Show("Se agrego el producto correctamente :)", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpiar();
                ActualizarCataloogo();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "El codigo ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al guardar el producto :(" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un producto a eliminar", "Ojoo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string contraseñaIngresada = Interaction.InputBox(
                "Esto eliminara el producto de forma permanente de su catalogo. \n Ingrese su contraseña para confirmar",
                "Se necesita autorizacion",
                ""
            );

            if (string.IsNullOrWhiteSpace(contraseñaIngresada))
            {
                return;
            }

            Usuario usuarioActual = frmCaja.ObtenerUsuarioActual();
            ValidarUsuario validar = new ValidarUsuario();

            if (validar.ValidarLogin(usuarioActual.ObtenerNombreUs(), contraseñaIngresada) == null)
            {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            DialogResult confirmar = MessageBox.Show("¿Esta seguro de eliminar este producto?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmar == DialogResult.Yes)
            {
                try
                {
                    string codigoSelec = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    int idUsuario = usuarioActual.ObtenerId();

                    Producto productoEliminar = _repositorioProductos.BuscarCodigo(idUsuario, codigoSelec);
                    if (productoEliminar != null)
                    {
                        _repositorioProductos.EliminarProducto(productoEliminar.ObtenerId(), idUsuario);
                        MessageBox.Show("Producto eliminado correctamente", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ActualizarCataloogo();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el producto ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Limpiar()
        {
            textCodBarras.Clear();
            textNombreP.Clear();
            textPrecio.Clear();
            textStock.Clear();
            cbCategoria.SelectedIndex = -1;
            textCodBarras.Focus();
        }

        private void btSumarStock_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un producto para aumentarle stock", "Porfavor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            codigoSelect = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string nombreProducto = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            lbAgregarStock.Text = $"Sumar stock:{nombreProducto}";
            numericUpDownStock.Value = 1;

            PnelSumStock.Visible = true;
            PnelSumStock.BringToFront();
            numericUpDownStock.Focus();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PnelSumStock_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                int cantSumaStock = (int)numericUpDownStock.Value;
                int idUsu = frmCaja.ObtenerUsuarioActual().ObtenerId();
                codigoSelect = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                _repositorioProductos.SumarStock(idUsu, cantSumaStock, codigoSelect);
                MessageBox.Show($"Se sumaron {cantSumaStock} unidades correctamente.", "Bien", MessageBoxButtons.OK, MessageBoxIcon.Information);

                PnelSumStock.Visible = false;
                codigoSelect = null;

                ActualizarCataloogo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            PnelSumStock.Visible = false;
            codigoSelect = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (frmReportes == null || frmReportes.IsDisposed)
            {
                frmReportes = new FormReportes( frmCaja, _usuarioActual);
            }
            frmReportes.CargarReporte();
            frmReportes.Show();
            this.Hide();
        }
    }
}
