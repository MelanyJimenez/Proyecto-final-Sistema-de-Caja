namespace Sistema_de_caja
{
    partial class FormProductos
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
            panel1 = new Panel();
            button3 = new Button();
            btProductos = new Button();
            btCaja = new Button();
            btEliminar = new Button();
            grbAgregarP = new GroupBox();
            cbCategoria = new ComboBox();
            lbCategoria = new Label();
            textStock = new TextBox();
            lbStock = new Label();
            textPrecio = new TextBox();
            lbPrecio = new Label();
            textNombreP = new TextBox();
            lbNombreProducto = new Label();
            btAgregar = new Button();
            textCodBarras = new TextBox();
            lbCodBarras = new Label();
            dataGridView1 = new DataGridView();
            coCodigo = new DataGridViewTextBoxColumn();
            CoDesc = new DataGridViewTextBoxColumn();
            CoPrecio = new DataGridViewTextBoxColumn();
            CoStock = new DataGridViewTextBoxColumn();
            CoCategoria = new DataGridViewTextBoxColumn();
            lbfProductos = new Label();
            btSumarStock = new Button();
            PnelSumStock = new Panel();
            btCancelar = new Button();
            btConfirmar = new Button();
            numericUpDownStock = new NumericUpDown();
            lbAgregarStock = new Label();
            panel1.SuspendLayout();
            grbAgregarP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            PnelSumStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlText;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btProductos);
            panel1.Controls.Add(btCaja);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 451);
            panel1.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.WindowText;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(0, 130);
            button3.Name = "button3";
            button3.Size = new Size(200, 31);
            button3.TabIndex = 14;
            button3.Text = "Reportes";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btProductos
            // 
            btProductos.BackColor = SystemColors.WindowText;
            btProductos.FlatStyle = FlatStyle.Flat;
            btProductos.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btProductos.ForeColor = SystemColors.ControlLightLight;
            btProductos.Location = new Point(0, 100);
            btProductos.Name = "btProductos";
            btProductos.Size = new Size(200, 32);
            btProductos.TabIndex = 13;
            btProductos.Text = "Productos";
            btProductos.UseVisualStyleBackColor = false;
            // 
            // btCaja
            // 
            btCaja.BackColor = SystemColors.WindowText;
            btCaja.FlatStyle = FlatStyle.Flat;
            btCaja.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btCaja.ForeColor = SystemColors.ControlLightLight;
            btCaja.Location = new Point(0, 73);
            btCaja.Name = "btCaja";
            btCaja.Size = new Size(200, 30);
            btCaja.TabIndex = 12;
            btCaja.Text = "Caja";
            btCaja.UseVisualStyleBackColor = false;
            btCaja.Click += btCaja_Click;
            // 
            // btEliminar
            // 
            btEliminar.BackColor = SystemColors.GradientActiveCaption;
            btEliminar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btEliminar.ForeColor = SystemColors.ActiveCaptionText;
            btEliminar.Location = new Point(888, 97);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(101, 27);
            btEliminar.TabIndex = 7;
            btEliminar.Text = "Eliminar";
            btEliminar.UseVisualStyleBackColor = false;
            btEliminar.Click += btEliminar_Click;
            // 
            // grbAgregarP
            // 
            grbAgregarP.Controls.Add(cbCategoria);
            grbAgregarP.Controls.Add(lbCategoria);
            grbAgregarP.Controls.Add(textStock);
            grbAgregarP.Controls.Add(lbStock);
            grbAgregarP.Controls.Add(textPrecio);
            grbAgregarP.Controls.Add(lbPrecio);
            grbAgregarP.Controls.Add(textNombreP);
            grbAgregarP.Controls.Add(lbNombreProducto);
            grbAgregarP.Controls.Add(btAgregar);
            grbAgregarP.Controls.Add(textCodBarras);
            grbAgregarP.Controls.Add(lbCodBarras);
            grbAgregarP.Location = new Point(199, 254);
            grbAgregarP.Name = "grbAgregarP";
            grbAgregarP.Size = new Size(816, 197);
            grbAgregarP.TabIndex = 12;
            grbAgregarP.TabStop = false;
            grbAgregarP.Enter += groupBox1_Enter;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Items.AddRange(new object[] { "Bebidas", "Galletitas y Snacks", "Panificados", "Productos de Limpieza" });
            cbCategoria.Location = new Point(380, 40);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(193, 23);
            cbCategoria.TabIndex = 1;
            // 
            // lbCategoria
            // 
            lbCategoria.AutoSize = true;
            lbCategoria.Location = new Point(382, 22);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(61, 15);
            lbCategoria.TabIndex = 13;
            lbCategoria.Text = "Categoria:";
            // 
            // textStock
            // 
            textStock.Location = new Point(382, 139);
            textStock.Name = "textStock";
            textStock.Size = new Size(191, 23);
            textStock.TabIndex = 4;
            // 
            // lbStock
            // 
            lbStock.AutoSize = true;
            lbStock.Location = new Point(382, 121);
            lbStock.Name = "lbStock";
            lbStock.Size = new Size(39, 15);
            lbStock.TabIndex = 11;
            lbStock.Text = "Stock:";
            // 
            // textPrecio
            // 
            textPrecio.Location = new Point(17, 139);
            textPrecio.Name = "textPrecio";
            textPrecio.Size = new Size(270, 23);
            textPrecio.TabIndex = 3;
            // 
            // lbPrecio
            // 
            lbPrecio.AutoSize = true;
            lbPrecio.Location = new Point(17, 121);
            lbPrecio.Name = "lbPrecio";
            lbPrecio.Size = new Size(91, 15);
            lbPrecio.TabIndex = 3;
            lbPrecio.Text = "Precio de Venta:";
            // 
            // textNombreP
            // 
            textNombreP.Location = new Point(17, 89);
            textNombreP.Name = "textNombreP";
            textNombreP.Size = new Size(556, 23);
            textNombreP.TabIndex = 2;
            // 
            // lbNombreProducto
            // 
            lbNombreProducto.AutoSize = true;
            lbNombreProducto.Location = new Point(17, 71);
            lbNombreProducto.Name = "lbNombreProducto";
            lbNombreProducto.Size = new Size(125, 15);
            lbNombreProducto.TabIndex = 9;
            lbNombreProducto.Text = "Nombre del Producto:";
            // 
            // btAgregar
            // 
            btAgregar.BackColor = SystemColors.GradientActiveCaption;
            btAgregar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAgregar.ForeColor = SystemColors.ActiveCaptionText;
            btAgregar.Location = new Point(617, 71);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(173, 65);
            btAgregar.TabIndex = 5;
            btAgregar.Text = "Agregar";
            btAgregar.UseVisualStyleBackColor = false;
            btAgregar.Click += btAgregar_Click;
            // 
            // textCodBarras
            // 
            textCodBarras.Location = new Point(17, 40);
            textCodBarras.Name = "textCodBarras";
            textCodBarras.Size = new Size(270, 23);
            textCodBarras.TabIndex = 0;
            // 
            // lbCodBarras
            // 
            lbCodBarras.AutoSize = true;
            lbCodBarras.Location = new Point(17, 22);
            lbCodBarras.Name = "lbCodBarras";
            lbCodBarras.Size = new Size(100, 15);
            lbCodBarras.TabIndex = 7;
            lbCodBarras.Text = "Codigo de barras:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { coCodigo, CoDesc, CoPrecio, CoStock, CoCategoria });
            dataGridView1.GridColor = SystemColors.Window;
            dataGridView1.Location = new Point(199, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(816, 378);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // coCodigo
            // 
            coCodigo.HeaderText = "Codigo";
            coCodigo.Name = "coCodigo";
            // 
            // CoDesc
            // 
            CoDesc.HeaderText = "Descripcion";
            CoDesc.Name = "CoDesc";
            // 
            // CoPrecio
            // 
            CoPrecio.HeaderText = "Precio Unit.";
            CoPrecio.Name = "CoPrecio";
            // 
            // CoStock
            // 
            CoStock.HeaderText = "Stock";
            CoStock.Name = "CoStock";
            // 
            // CoCategoria
            // 
            CoCategoria.HeaderText = "Categoria";
            CoCategoria.Name = "CoCategoria";
            // 
            // lbfProductos
            // 
            lbfProductos.AutoSize = true;
            lbfProductos.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbfProductos.Location = new Point(216, 22);
            lbfProductos.Name = "lbfProductos";
            lbfProductos.Size = new Size(131, 29);
            lbfProductos.TabIndex = 13;
            lbfProductos.Text = "Productos";
            // 
            // btSumarStock
            // 
            btSumarStock.BackColor = SystemColors.GradientActiveCaption;
            btSumarStock.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSumarStock.ForeColor = SystemColors.ActiveCaptionText;
            btSumarStock.Location = new Point(781, 97);
            btSumarStock.Name = "btSumarStock";
            btSumarStock.Size = new Size(101, 27);
            btSumarStock.TabIndex = 6;
            btSumarStock.Text = "+ stock";
            btSumarStock.UseVisualStyleBackColor = false;
            btSumarStock.Click += btSumarStock_Click;
            // 
            // PnelSumStock
            // 
            PnelSumStock.BorderStyle = BorderStyle.FixedSingle;
            PnelSumStock.Controls.Add(btCancelar);
            PnelSumStock.Controls.Add(btConfirmar);
            PnelSumStock.Controls.Add(numericUpDownStock);
            PnelSumStock.Controls.Add(lbAgregarStock);
            PnelSumStock.Location = new Point(771, 130);
            PnelSumStock.Name = "PnelSumStock";
            PnelSumStock.Size = new Size(231, 118);
            PnelSumStock.TabIndex = 6;
            PnelSumStock.Visible = false;
            PnelSumStock.Paint += PnelSumStock_Paint;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(132, 81);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(75, 23);
            btCancelar.TabIndex = 10;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // btConfirmar
            // 
            btConfirmar.Location = new Point(30, 81);
            btConfirmar.Name = "btConfirmar";
            btConfirmar.Size = new Size(75, 23);
            btConfirmar.TabIndex = 9;
            btConfirmar.Text = "Confirmar";
            btConfirmar.UseVisualStyleBackColor = true;
            btConfirmar.Click += btConfirmar_Click;
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Location = new Point(30, 48);
            numericUpDownStock.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownStock.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(177, 23);
            numericUpDownStock.TabIndex = 8;
            numericUpDownStock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbAgregarStock
            // 
            lbAgregarStock.AutoSize = true;
            lbAgregarStock.Location = new Point(30, 15);
            lbAgregarStock.Name = "lbAgregarStock";
            lbAgregarStock.Size = new Size(0, 15);
            lbAgregarStock.TabIndex = 0;
            lbAgregarStock.Click += label1_Click;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 451);
            Controls.Add(PnelSumStock);
            Controls.Add(btSumarStock);
            Controls.Add(lbfProductos);
            Controls.Add(grbAgregarP);
            Controls.Add(btEliminar);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "FormProductos";
            Text = "FormProductos";
            Load += FormProductos_Load;
            panel1.ResumeLayout(false);
            grbAgregarP.ResumeLayout(false);
            grbAgregarP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            PnelSumStock.ResumeLayout(false);
            PnelSumStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button btProductos;
        private Button btCaja;
        private Button btEliminar;
        private GroupBox grbAgregarP;
        private TextBox textNombreP;
        private Label lbNombreProducto;
        private Button btAgregar;
        private TextBox textCodBarras;
        private Label lbCodBarras;
        private DataGridView dataGridView1;
        private TextBox textPrecio;
        private Label lbPrecio;
        private TextBox textStock;
        private Label lbStock;
        private ComboBox cbCategoria;
        private Label lbCategoria;
        private Label lbfProductos;
        private DataGridViewTextBoxColumn coCodigo;
        private DataGridViewTextBoxColumn CoDesc;
        private DataGridViewTextBoxColumn CoPrecio;
        private DataGridViewTextBoxColumn CoStock;
        private DataGridViewTextBoxColumn CoCategoria;
        private Button btSumarStock;
        private Panel PnelSumStock;
        private NumericUpDown numericUpDownStock;
        private Label lbAgregarStock;
        private Button btCancelar;
        private Button btConfirmar;
    }
}