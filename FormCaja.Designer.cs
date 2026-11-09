namespace Sistema_de_caja
{
    partial class FormCaja
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            btProductos = new Button();
            btCaja = new Button();
            panel2 = new Panel();
            groupBoxTotalVenta = new GroupBox();
            lbMontoT = new Label();
            lbMontoSubT = new Label();
            lbTotal = new Label();
            lbSubtotal = new Label();
            btCobrar = new Button();
            btNuevaVenta = new Button();
            btAgregar = new Button();
            dataGridView1 = new DataGridView();
            coCodigo = new DataGridViewTextBoxColumn();
            CoDesc = new DataGridViewTextBoxColumn();
            CoCant = new DataGridViewTextBoxColumn();
            CoPrecio = new DataGridViewTextBoxColumn();
            CoImporte = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            textCodBarras = new TextBox();
            lbCodBarras = new Label();
            groupBox1 = new GroupBox();
            textCant = new TextBox();
            lbCantidad = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxTotalVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(216, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 29);
            label1.TabIndex = 0;
            label1.Text = "Caja";
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
            panel1.Size = new Size(199, 452);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
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
            btProductos.TabIndex = 1;
            btProductos.Text = "Productos";
            btProductos.UseVisualStyleBackColor = false;
            btProductos.Click += button2_Click;
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
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(groupBoxTotalVenta);
            panel2.Controls.Add(btCobrar);
            panel2.Controls.Add(btNuevaVenta);
            panel2.Dock = DockStyle.Right;
            panel2.ForeColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(809, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 452);
            panel2.TabIndex = 3;
            // 
            // groupBoxTotalVenta
            // 
            groupBoxTotalVenta.BackColor = SystemColors.ControlLightLight;
            groupBoxTotalVenta.Controls.Add(lbMontoT);
            groupBoxTotalVenta.Controls.Add(lbMontoSubT);
            groupBoxTotalVenta.Controls.Add(lbTotal);
            groupBoxTotalVenta.Controls.Add(lbSubtotal);
            groupBoxTotalVenta.Location = new Point(6, 12);
            groupBoxTotalVenta.Name = "groupBoxTotalVenta";
            groupBoxTotalVenta.Size = new Size(185, 91);
            groupBoxTotalVenta.TabIndex = 4;
            groupBoxTotalVenta.TabStop = false;
            // 
            // lbMontoT
            // 
            lbMontoT.AutoSize = true;
            lbMontoT.BackColor = SystemColors.Window;
            lbMontoT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMontoT.ForeColor = SystemColors.ActiveCaptionText;
            lbMontoT.Location = new Point(113, 65);
            lbMontoT.Name = "lbMontoT";
            lbMontoT.Size = new Size(40, 21);
            lbMontoT.TabIndex = 3;
            lbMontoT.Text = "0,00";
            // 
            // lbMontoSubT
            // 
            lbMontoSubT.AutoSize = true;
            lbMontoSubT.BackColor = SystemColors.Window;
            lbMontoSubT.ForeColor = SystemColors.ActiveCaptionText;
            lbMontoSubT.Location = new Point(125, 13);
            lbMontoSubT.Name = "lbMontoSubT";
            lbMontoSubT.Size = new Size(28, 15);
            lbMontoSubT.TabIndex = 2;
            lbMontoSubT.Text = "0,00";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.BackColor = SystemColors.Window;
            lbTotal.ForeColor = SystemColors.ActiveCaptionText;
            lbTotal.Location = new Point(6, 70);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(36, 15);
            lbTotal.TabIndex = 1;
            lbTotal.Text = "Total:";
            // 
            // lbSubtotal
            // 
            lbSubtotal.AutoSize = true;
            lbSubtotal.BackColor = SystemColors.Window;
            lbSubtotal.ForeColor = SystemColors.ActiveCaptionText;
            lbSubtotal.Location = new Point(4, 13);
            lbSubtotal.Name = "lbSubtotal";
            lbSubtotal.Size = new Size(54, 15);
            lbSubtotal.TabIndex = 0;
            lbSubtotal.Text = "Subtotal:";
            // 
            // btCobrar
            // 
            btCobrar.BackColor = SystemColors.ControlText;
            btCobrar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCobrar.ForeColor = Color.Lime;
            btCobrar.Location = new Point(6, 102);
            btCobrar.Name = "btCobrar";
            btCobrar.Size = new Size(185, 59);
            btCobrar.TabIndex = 3;
            btCobrar.Text = "F2 - Cobrar";
            btCobrar.UseVisualStyleBackColor = false;
            btCobrar.Click += button5_Click;
            // 
            // btNuevaVenta
            // 
            btNuevaVenta.BackColor = SystemColors.Window;
            btNuevaVenta.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btNuevaVenta.ForeColor = SystemColors.ActiveCaptionText;
            btNuevaVenta.Location = new Point(6, 197);
            btNuevaVenta.Name = "btNuevaVenta";
            btNuevaVenta.Size = new Size(185, 35);
            btNuevaVenta.TabIndex = 4;
            btNuevaVenta.Text = "F4 - Nueva venta";
            btNuevaVenta.UseVisualStyleBackColor = false;
            // 
            // btAgregar
            // 
            btAgregar.BackColor = SystemColors.GradientActiveCaption;
            btAgregar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAgregar.ForeColor = SystemColors.ActiveCaptionText;
            btAgregar.Location = new Point(489, 44);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(101, 27);
            btAgregar.TabIndex = 2;
            btAgregar.Text = "Agregar";
            btAgregar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { coCodigo, CoDesc, CoCant, CoPrecio, CoImporte });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.GridColor = SystemColors.Window;
            dataGridView1.Location = new Point(199, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(610, 350);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
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
            // CoCant
            // 
            CoCant.HeaderText = "Cantidad";
            CoCant.Name = "CoCant";
            // 
            // CoPrecio
            // 
            CoPrecio.HeaderText = "Precio";
            CoPrecio.Name = "CoPrecio";
            // 
            // CoImporte
            // 
            CoImporte.HeaderText = "Importe";
            CoImporte.Name = "CoImporte";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(216, 44);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar producto";
            textBox1.Size = new Size(213, 23);
            textBox1.TabIndex = 5;
            // 
            // textCodBarras
            // 
            textCodBarras.Location = new Point(17, 44);
            textCodBarras.Name = "textCodBarras";
            textCodBarras.Size = new Size(270, 23);
            textCodBarras.TabIndex = 0;
            textCodBarras.TextChanged += textCodBarras_TextChanged;
            // 
            // lbCodBarras
            // 
            lbCodBarras.AutoSize = true;
            lbCodBarras.Location = new Point(17, 26);
            lbCodBarras.Name = "lbCodBarras";
            lbCodBarras.Size = new Size(100, 15);
            lbCodBarras.TabIndex = 7;
            lbCodBarras.Text = "Codigo de barras:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textCant);
            groupBox1.Controls.Add(lbCantidad);
            groupBox1.Controls.Add(btAgregar);
            groupBox1.Controls.Add(textCodBarras);
            groupBox1.Controls.Add(lbCodBarras);
            groupBox1.Location = new Point(199, 352);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(608, 100);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // textCant
            // 
            textCant.Location = new Point(312, 44);
            textCant.Name = "textCant";
            textCant.Size = new Size(141, 23);
            textCant.TabIndex = 1;
            // 
            // lbCantidad
            // 
            lbCantidad.AutoSize = true;
            lbCantidad.Location = new Point(312, 26);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(58, 15);
            lbCantidad.TabIndex = 9;
            lbCantidad.Text = "Cantidad:";
            // 
            // FormCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 452);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            KeyPreview = true;
            Name = "FormCaja";
            Text = "Caja";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBoxTotalVenta.ResumeLayout(false);
            groupBoxTotalVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button button3;
        private Button btProductos;
        private Button btCaja;
        private Panel panel2;
        private Button btNuevaVenta;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn coCodigo;
        private DataGridViewTextBoxColumn CoDesc;
        private DataGridViewTextBoxColumn CoCant;
        private DataGridViewTextBoxColumn CoPrecio;
        private DataGridViewTextBoxColumn CoImporte;
        private Button btAgregar;
        private Button btCobrar;
        private TextBox textCodBarras;
        private Label lbCodBarras;
        private GroupBox groupBoxTotalVenta;
        private Label lbTotal;
        private Label lbSubtotal;
        private GroupBox groupBox1;
        private TextBox textCant;
        private Label lbCantidad;
        private Label lbMontoT;
        private Label lbMontoSubT;
    }
}
