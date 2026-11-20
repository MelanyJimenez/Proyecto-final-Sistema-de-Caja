namespace Sistema_de_caja
{
    partial class FormRegistrarse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            textcontra = new TextBox();
            lbContra = new Label();
            textNombre = new TextBox();
            lbNombre = new Label();
            textCorreo = new TextBox();
            lbCorreo = new Label();
            textConfirmacion = new TextBox();
            lbConfirmacion = new Label();
            btInicioSesion = new Button();
            btVolver = new Button();
            textNombreT = new TextBox();
            lbnombreT = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(203, 41);
            label3.Name = "label3";
            label3.Size = new Size(209, 42);
            label3.TabIndex = 5;
            label3.Text = "Registrarse";
            // 
            // textcontra
            // 
            textcontra.Location = new Point(77, 342);
            textcontra.Name = "textcontra";
            textcontra.PasswordChar = '*';
            textcontra.Size = new Size(254, 23);
            textcontra.TabIndex = 3;
            // 
            // lbContra
            // 
            lbContra.AutoSize = true;
            lbContra.Font = new Font("Segoe UI", 10F);
            lbContra.Location = new Point(77, 320);
            lbContra.Name = "lbContra";
            lbContra.Size = new Size(82, 19);
            lbContra.TabIndex = 8;
            lbContra.Text = "Contraseña:";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(77, 143);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(254, 23);
            textNombre.TabIndex = 0;
            textNombre.TextChanged += textNombre_TextChanged;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Segoe UI", 10F);
            lbNombre.Location = new Point(77, 121);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(132, 19);
            lbNombre.TabIndex = 6;
            lbNombre.Text = "Nombre de Usuario:";
            // 
            // textCorreo
            // 
            textCorreo.Location = new Point(77, 275);
            textCorreo.Name = "textCorreo";
            textCorreo.PlaceholderText = "ejemplo@gmail.com";
            textCorreo.Size = new Size(254, 23);
            textCorreo.TabIndex = 2;
            textCorreo.TextChanged += textCorreo_TextChanged;
            // 
            // lbCorreo
            // 
            lbCorreo.AutoSize = true;
            lbCorreo.Font = new Font("Segoe UI", 10F);
            lbCorreo.Location = new Point(77, 253);
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Size = new Size(124, 19);
            lbCorreo.TabIndex = 12;
            lbCorreo.Text = "Correo electronico:";
            // 
            // textConfirmacion
            // 
            textConfirmacion.Location = new Point(77, 408);
            textConfirmacion.Name = "textConfirmacion";
            textConfirmacion.PasswordChar = '*';
            textConfirmacion.Size = new Size(254, 23);
            textConfirmacion.TabIndex = 4;
            // 
            // lbConfirmacion
            // 
            lbConfirmacion.AutoSize = true;
            lbConfirmacion.Font = new Font("Segoe UI", 10F);
            lbConfirmacion.Location = new Point(77, 386);
            lbConfirmacion.Name = "lbConfirmacion";
            lbConfirmacion.Size = new Size(157, 19);
            lbConfirmacion.TabIndex = 10;
            lbConfirmacion.Text = "Confirme su contraseña:";
            // 
            // btInicioSesion
            // 
            btInicioSesion.BackColor = SystemColors.InactiveCaption;
            btInicioSesion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btInicioSesion.Location = new Point(194, 487);
            btInicioSesion.Name = "btInicioSesion";
            btInicioSesion.Size = new Size(218, 47);
            btInicioSesion.TabIndex = 5;
            btInicioSesion.Text = "Iniciar Sesion";
            btInicioSesion.UseVisualStyleBackColor = false;
            btInicioSesion.Click += btInicioSesion_Click;
            // 
            // btVolver
            // 
            btVolver.BackColor = SystemColors.InactiveCaption;
            btVolver.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btVolver.Location = new Point(483, 542);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(81, 39);
            btVolver.TabIndex = 6;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = false;
            btVolver.Click += btVolver_Click;
            // 
            // textNombreT
            // 
            textNombreT.Location = new Point(77, 213);
            textNombreT.Name = "textNombreT";
            textNombreT.Size = new Size(254, 23);
            textNombreT.TabIndex = 1;
            textNombreT.TextChanged += textBox1_TextChanged;
            // 
            // lbnombreT
            // 
            lbnombreT.AutoSize = true;
            lbnombreT.Font = new Font("Segoe UI", 10F);
            lbnombreT.Location = new Point(77, 191);
            lbnombreT.Name = "lbnombreT";
            lbnombreT.Size = new Size(125, 19);
            lbnombreT.TabIndex = 14;
            lbnombreT.Text = "Nombre de Tienda:";
            // 
            // FormRegistrarse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 593);
            Controls.Add(textNombreT);
            Controls.Add(lbnombreT);
            Controls.Add(btInicioSesion);
            Controls.Add(btVolver);
            Controls.Add(textCorreo);
            Controls.Add(lbCorreo);
            Controls.Add(textConfirmacion);
            Controls.Add(lbConfirmacion);
            Controls.Add(textcontra);
            Controls.Add(lbContra);
            Controls.Add(textNombre);
            Controls.Add(lbNombre);
            Controls.Add(label3);
            KeyPreview = true;
            Name = "FormRegistrarse";
            Text = "Login";
            Load += FormRegistrarse_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textcontra;
        private Label lbContra;
        private TextBox textNombre;
        private Label lbNombre;
        private TextBox textCorreo;
        private Label lbCorreo;
        private TextBox textConfirmacion;
        private Label lbConfirmacion;
        private Button btInicioSesion;
        private Button btVolver;
        private TextBox textNombreT;
        private Label lbnombreT;
    }
}