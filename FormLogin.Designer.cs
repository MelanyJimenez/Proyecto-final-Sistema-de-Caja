namespace Sistema_de_caja
{
    partial class FormLogin
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
            lbUsuario = new Label();
            textusuario = new TextBox();
            label2 = new Label();
            textContraseña = new TextBox();
            label3 = new Label();
            bt2 = new Button();
            btIngresar = new Button();
            SuspendLayout();
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Font = new Font("Segoe UI", 10F);
            lbUsuario.Location = new Point(101, 134);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(132, 19);
            lbUsuario.TabIndex = 0;
            lbUsuario.Text = "Nombre de Usuario:";
            lbUsuario.Click += label1_Click;
            // 
            // textusuario
            // 
            textusuario.Location = new Point(101, 156);
            textusuario.Name = "textusuario";
            textusuario.Size = new Size(254, 23);
            textusuario.TabIndex = 0;
            textusuario.TextChanged += textusuario_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(101, 206);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            // 
            // textContraseña
            // 
            textContraseña.Location = new Point(101, 228);
            textContraseña.Name = "textContraseña";
            textContraseña.PasswordChar = '*';
            textContraseña.Size = new Size(254, 23);
            textContraseña.TabIndex = 1;
            textContraseña.TextChanged += textContraseña_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(181, 61);
            label3.Name = "label3";
            label3.Size = new Size(110, 42);
            label3.TabIndex = 4;
            label3.Text = "Login";
            // 
            // bt2
            // 
            bt2.BackColor = SystemColors.InactiveCaption;
            bt2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt2.Location = new Point(334, 405);
            bt2.Name = "bt2";
            bt2.Size = new Size(103, 33);
            bt2.TabIndex = 3;
            bt2.Text = "Registrarse";
            bt2.UseVisualStyleBackColor = false;
            bt2.Click += button1_Click;
            // 
            // btIngresar
            // 
            btIngresar.BackColor = SystemColors.InactiveCaption;
            btIngresar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btIngresar.Location = new Point(101, 290);
            btIngresar.Name = "btIngresar";
            btIngresar.Size = new Size(254, 47);
            btIngresar.TabIndex = 2;
            btIngresar.Text = "Ingresar";
            btIngresar.UseVisualStyleBackColor = false;
            btIngresar.Click += btIngresar_Click_1;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 450);
            Controls.Add(btIngresar);
            Controls.Add(bt2);
            Controls.Add(label3);
            Controls.Add(textContraseña);
            Controls.Add(label2);
            Controls.Add(textusuario);
            Controls.Add(lbUsuario);
            KeyPreview = true;
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsuario;
        private TextBox textusuario;
        private Label label2;
        private TextBox textContraseña;
        private Label label3;
        private Button bt2;
        private Button btIngresar;
    }
}