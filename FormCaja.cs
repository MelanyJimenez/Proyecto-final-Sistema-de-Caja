namespace Sistema_de_caja
{
    public partial class FormCaja : Form
    {
        FormProductos FormProductos;
        private Usuario _usuarioActual;
        public FormCaja(Usuario usuario)
        {
            InitializeComponent();
            this._usuarioActual = usuario;
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

        }
    }
}