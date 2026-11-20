namespace Sistema_de_caja
{
    public partial class FormCaja : Form
    {
        FormProductos FormProductos;
        FormReportes FrmReportes;
        private Usuario _usuarioActual;
        private RepositorioVentas _repositorioVentas;
        private RepositorioProductos _repositorioProductos;
        public FormCaja(Usuario usuario)
        {
            InitializeComponent();
            this._usuarioActual = usuario;
            this._repositorioVentas = new RepositorioVentas();
            this._repositorioProductos = new RepositorioProductos();
        }

        public Usuario ObtenerUsuarioActual()
        {
            return _usuarioActual;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (FormProductos == null || FormProductos.IsDisposed)
            {
                FormProductos = new FormProductos(this, _usuarioActual.ObtenerId());
            }
            FormProductos.ActualizarCataloogo();
            FormProductos.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FrmReportes == null || FrmReportes.IsDisposed)
            {
                FrmReportes = new FormReportes( this, _usuarioActual.ObtenerId());
            }
            FrmReportes.CargarReporte();
            FrmReportes.Show();
            this.Hide();
        }

        private void textCodBarras_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarCodigo()
        {
            if (string.IsNullOrWhiteSpace(textCodBarras.Text) || string.IsNullOrWhiteSpace(textCant.Text))
            {
                MessageBox.Show("Debe ingresar el código de barras y la cantidad.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigoBusqueda = textCodBarras.Text.Trim();

            if (!int.TryParse(textCant.Text.Trim(), out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int IdUsuario = _usuarioActual.ObtenerId();
            Producto productoBuscar = _repositorioProductos.BuscarCodigo(IdUsuario, codigoBusqueda);

            if (productoBuscar != null)
            {
                double precio = productoBuscar.ObtenerPrecio();
                double subtotal = precio * cantidad;

                dataGridView1.Rows.Add(
                    productoBuscar.ObtenerCodBarras(),
                    productoBuscar.ObtenerDescripcion(),
                    cantidad,
                    precio,
                    subtotal
                );

                ActualizarTotal();

                textCodBarras.Clear();
                textCant.Text = "1";
                textCodBarras.Focus();
            }
            else
            {
                MessageBox.Show("El producto no se encuentra en tu catalogo");
            }
        }

        private void textCant_TextChanged(object sender, EventArgs e)
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            AgregarCodigo();
        }

        private double ActualizarTotal()
        {
            double total = 0;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (!fila.IsNewRow && fila.Cells[4].Value != null)
                {
                    total += Convert.ToDouble(fila.Cells[4].Value);
                }
            }

            lbMontoSubT.Text = $"${total:N2}";
            lbMontoT.Text = $"${total:N2}";

            return total;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos cargados en esta venta", "La caja esta vacia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double totalVenta = ActualizarTotal();

            string textPago = Microsoft.VisualBasic.Interaction.InputBox(
                $"Total a pagar: ${totalVenta:N2} \n Ingresar el monto abonado por el cliente:",
                "Proceso de cobro",
                ""
                );

            if(double.TryParse(textPago, out double montoAbonado))
            {
                if( montoAbonado< totalVenta)
                {
                    MessageBox.Show($"El monto ingresado (${montoAbonado:N2}) es menor total a pagar (${totalVenta:N2})",
                        "Pago insuficiente", MessageBoxButtons.OK , MessageBoxIcon.Error); 
                    return;
                }

                try
                {
                    int idUsuario = _usuarioActual.ObtenerId();
                    List<DetalleVenta> listaDetalles = new List<DetalleVenta>();

                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        if (!fila.IsNewRow && fila.Cells[0].Value != null)
                        {
                            string codigoBarra = fila.Cells[0].Value.ToString().Trim();
                            int cantidad = Convert.ToInt32(fila.Cells[2].Value);
                            double precioUnitario = Convert.ToDouble(fila.Cells[3].Value);

                            Producto produ = _repositorioProductos.BuscarCodigo(idUsuario, codigoBarra);
                            listaDetalles.Add(new DetalleVenta(produ.ObtenerId(), codigoBarra, cantidad, precioUnitario));


                            _repositorioProductos.DescontarStock(idUsuario, codigoBarra, cantidad);
                        }
                    }
                    Venta nuevaVenta = new Venta(0, DateTime.Now, totalVenta, idUsuario);
                    int nroVenta = _repositorioVentas.GuardarVenta(nuevaVenta, listaDetalles);

                    double vuelto = montoAbonado - totalVenta;

                    MessageBox.Show($"Venta realizada\n" + $"Total de la venta: ${totalVenta:N2}\n" +
                        $"Monto abonado: ${montoAbonado:N2}\n" + $"Su vuelto es: ${vuelto:N2}","Cobro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al descontar stock"+ ex.Message , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un monto valido por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                DialogResult resultado = MessageBox.Show("¿Esta seguro de sacar este producto?", "Sacar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

                    ActualizarTotal();
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un producto para eliminar", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btNuevaVenta_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            textCodBarras.Clear();
            textCant.Text = "1";
            ActualizarTotal();
            textCodBarras.Focus();
        }
    }
}