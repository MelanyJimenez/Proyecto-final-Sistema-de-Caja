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
            button2 = new Button();
            btCaja = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            coCodigo = new DataGridViewTextBoxColumn();
            CoDesc = new DataGridViewTextBoxColumn();
            CoPrecio = new DataGridViewTextBoxColumn();
            ColStock = new DataGridViewTextBoxColumn();
            ColCategoria = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            textCant = new TextBox();
            lbCantidad = new Label();
            btAgregar = new Button();
            textCodBarras = new TextBox();
            lbCodBarras = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlText;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btCaja);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 461);
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
            button3.TabIndex = 2;
            button3.Text = "Reportes";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.WindowText;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(0, 100);
            button2.Name = "button2";
            button2.Size = new Size(200, 32);
            button2.TabIndex = 1;
            button2.Text = "Productos";
            button2.UseVisualStyleBackColor = false;
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
            btCaja.TabIndex = 0;
            btCaja.Text = "Caja";
            btCaja.UseVisualStyleBackColor = false;
            btCaja.Click += btCaja_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(222, 50);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar producto";
            textBox1.Size = new Size(213, 23);
            textBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(222, 15);
            label1.Name = "label1";
            label1.Size = new Size(131, 29);
            label1.TabIndex = 6;
            label1.Text = "Productos";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { coCodigo, CoDesc, CoPrecio, ColStock, ColCategoria });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.GridColor = SystemColors.Window;
            dataGridView1.Location = new Point(199, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(610, 350);
            dataGridView1.TabIndex = 8;
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
            CoPrecio.HeaderText = "Precio";
            CoPrecio.Name = "CoPrecio";
            // 
            // ColStock
            // 
            ColStock.HeaderText = "Stock";
            ColStock.Name = "ColStock";
            // 
            // ColCategoria
            // 
            ColCategoria.HeaderText = "Categoria";
            ColCategoria.Name = "ColCategoria";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lbCodBarras);
            groupBox1.Controls.Add(textCant);
            groupBox1.Controls.Add(lbCantidad);
            groupBox1.Controls.Add(btAgregar);
            groupBox1.Controls.Add(textCodBarras);
            groupBox1.Location = new Point(199, 270);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(608, 191);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // textCant
            // 
            textCant.Location = new Point(17, 90);
            textCant.Name = "textCant";
            textCant.Size = new Size(441, 23);
            textCant.TabIndex = 1;
            // 
            // lbCantidad
            // 
            lbCantidad.AutoSize = true;
            lbCantidad.Location = new Point(17, 72);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(125, 15);
            lbCantidad.TabIndex = 9;
            lbCantidad.Text = "Nombre del Producto:";
            // 
            // btAgregar
            // 
            btAgregar.BackColor = SystemColors.GradientActiveCaption;
            btAgregar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAgregar.ForeColor = SystemColors.ActiveCaptionText;
            btAgregar.Location = new Point(488, 147);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(101, 27);
            btAgregar.TabIndex = 2;
            btAgregar.Text = "Agregar";
            btAgregar.UseVisualStyleBackColor = false;
            // 
            // textCodBarras
            // 
            textCodBarras.Location = new Point(17, 37);
            textCodBarras.Name = "textCodBarras";
            textCodBarras.Size = new Size(262, 23);
            textCodBarras.TabIndex = 0;
            // 
            // lbCodBarras
            // 
            lbCodBarras.AutoSize = true;
            lbCodBarras.Location = new Point(17, 19);
            lbCodBarras.Name = "lbCodBarras";
            lbCodBarras.Size = new Size(100, 15);
            lbCodBarras.TabIndex = 7;
            lbCodBarras.Text = "Codigo de barras:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 126);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 10;
            label2.Text = "Precio de venta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 126);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 11;
            label3.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(328, 19);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 12;
            label4.Text = "Categoria:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(17, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(183, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(281, 147);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(177, 23);
            textBox3.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(328, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(130, 23);
            comboBox1.TabIndex = 15;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 461);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FormProductos";
            Text = "FormProductos";
            Load += FormProductos_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button btCaja;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn coCodigo;
        private DataGridViewTextBoxColumn CoDesc;
        private DataGridViewTextBoxColumn CoPrecio;
        private DataGridViewTextBoxColumn ColStock;
        private DataGridViewTextBoxColumn ColCategoria;
        private GroupBox groupBox1;
        private Label label2;
        private Label lbCodBarras;
        private TextBox textCant;
        private Label lbCantidad;
        private Button btAgregar;
        private TextBox textCodBarras;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private ComboBox comboBox1;
    }
}