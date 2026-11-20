using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_caja
{
    public partial class FormLogin : Form
    {
        private readonly ValidarUsuario _repositorio = new ValidarUsuario();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            using (var formRegistrarse = new FormRegistrarse())
            {
                formRegistrarse.ShowDialog();
            }
            Show();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {

        }

        private void textContraseña_TextChanged(object sender, EventArgs e)
        {
            textContraseña.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) btIngresar_Click(sender, e);
            };
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btIngresar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textusuario.Text) || string.IsNullOrWhiteSpace(textContraseña.Text))
            {
                MessageBox.Show("Completa todos los campos.", "Mensaje de Error");
                return;
            }

            try
            {
                Usuario usuario = _repositorio.ValidarLogin(textusuario.Text.Trim(), textContraseña.Text);

                if (usuario == null)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Mensaje de Error");
                    textContraseña.Clear();
                    textContraseña.Focus();
                    return;
                }

                var formCaja = new FormCaja(usuario);
                formCaja.FormClosed += (s, args) => Close();
                formCaja.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message, "Error");
            }
        }

        private void textusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
