using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_caja
{
    public partial class FormReportes : Form
    {
        private FormCaja frmCaja;
        private FormProductos frmProductos;
        private RepositorioReportes _repoReportes;
        private int _UsuarioActual;
        public FormReportes(FormCaja frmCaja,int UsuarioActual)
        {
            InitializeComponent();
            this.frmCaja = frmCaja;
            this._UsuarioActual = UsuarioActual;
            this._repoReportes = new RepositorioReportes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (frmProductos == null || frmProductos.IsDisposed)
                frmProductos = new FormProductos(frmCaja, _UsuarioActual);

            frmProductos.Show();
            Hide();
        }

        private void btCaja_Click(object sender, EventArgs e)
        {
            frmCaja.Show();
            Hide();
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbReportes_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void CargarReporte()
        {
            try
            {
                List<Venta> listaVentas = _repoReportes.ObtenerVentas(_UsuarioActual);

                dataGridView1.Rows.Clear();
                double totalRecaudado = 0;

                foreach (Venta v in listaVentas)
                {
                    dataGridView1.Rows.Add(
                        v.ObtenerIdVenta(),
                        v.ObtenerFecha().ToString("dd/MM/yyyy HH:mm"),
                        "$" + v.ObtenerTotal().ToString("N2")
                    );

                    totalRecaudado += v.ObtenerTotal();
                }

                lbTotalVentas.Text = "Total de ventas: " + listaVentas.Count;
                lbTotalRecaud.Text = "Total recaudado: $" + totalRecaudado.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
