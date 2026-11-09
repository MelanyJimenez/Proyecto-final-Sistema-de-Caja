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
        private Usuario usuarioActual;

        public FormReportes(Usuario usuario)
        {
            InitializeComponent();
           this.usuarioActual= usuario;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCaja_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
