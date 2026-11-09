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
        public FormProductos(FormCaja formCaja)
        {
            InitializeComponent();
            this.frmCaja = formCaja;
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }

        private void btCaja_Click(object sender, EventArgs e)
        {
            frmCaja.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
