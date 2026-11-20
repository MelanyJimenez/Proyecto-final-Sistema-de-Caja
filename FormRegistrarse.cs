using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_caja
{
    public partial class FormRegistrarse : Form
    {
        private readonly ValidarUsuario _repositorio = new ValidarUsuario();
        public FormRegistrarse()
        {
            InitializeComponent();

        }

        private void btInicioSesion_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textNombre.Text) || string.IsNullOrWhiteSpace(textCorreo.Text) || string.IsNullOrWhiteSpace(textcontra.Text) || string.IsNullOrWhiteSpace(textNombreT.Text) || string.IsNullOrWhiteSpace(textConfirmacion.Text))
            {
                MessageBox.Show("Completa todos los campos.", "Mensaje de Error");
                return;
            }

            if (textcontra.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.", "Mensaje de Error");
                return;
            }
            if (!textCorreo.Text.Contains("@"))
            {
                MessageBox.Show("El email ingresado no es valido");
                return;
            }

            if (textcontra.Text != textConfirmacion.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Mensaje de Error");
                return;
            }

            try
            {
                _repositorio.registrarse(textNombre.Text.Trim(), textCorreo.Text.Trim(), textConfirmacion.Text.Trim(), textNombreT.Text.Trim());
                MessageBox.Show("Su cuenta fa fue creada con exito. Ahora puede iniciar sesion.");
                Close();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }

        private void FormRegistrarse_Load(object sender, EventArgs e)
        {

        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
            }
            catch (Exception ex)
            {

                this.Show();
                MessageBox.Show("Error al abrir el formulario de registro: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
