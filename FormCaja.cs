namespace Sistema_de_caja
{
    public partial class FormCaja : Form
    {
        FormProductos FormProductos;
        private Usuario _usuarioActual;
        private RepositorioProductos _repositorioProductos;
        public FormCaja(Usuario usuario)
        {
            InitializeComponent();
            this._usuarioActual = usuario;
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
            if (FormProductos == null)
            {
                FormProductos = new FormProductos(this);
            }
            FormProductos.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

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

        private void ActualizarTotal()
        {
            double total = 0;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.Cells[4].Value != null)
                {
                    total += Convert.ToDouble(fila.Cells[4].Value);
                }
            }

            lbMontoSubT.Text = total.ToString("C2");
            lbMontoT.Text = total.ToString("C2");
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