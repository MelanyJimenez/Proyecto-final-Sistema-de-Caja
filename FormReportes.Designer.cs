namespace Sistema_de_caja
{
    partial class FormReportes
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
            lbReportes = new Label();
            dataGridView1 = new DataGridView();
            ColNventas = new DataGridViewTextBoxColumn();
            ColFecha = new DataGridViewTextBoxColumn();
            ColTotal = new DataGridViewTextBoxColumn();
            lbTotalRecaud = new Label();
            lbTotalVentas = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.Size = new Size(199, 450);
            panel1.TabIndex = 3;
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
            button2.Click += button2_Click;
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
            // lbReportes
            // 
            lbReportes.AutoSize = true;
            lbReportes.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbReportes.Location = new Point(219, 26);
            lbReportes.Name = "lbReportes";
            lbReportes.Size = new Size(226, 29);
            lbReportes.TabIndex = 7;
            lbReportes.Text = "Reportes de venta";
            lbReportes.Click += lbReportes_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColNventas, ColFecha, ColTotal });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.GridColor = SystemColors.Window;
            dataGridView1.Location = new Point(199, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(549, 320);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // ColNventas
            // 
            ColNventas.HeaderText = "N° Venta";
            ColNventas.Name = "ColNventas";
            // 
            // ColFecha
            // 
            ColFecha.HeaderText = "Fecha";
            ColFecha.Name = "ColFecha";
            // 
            // ColTotal
            // 
            ColTotal.HeaderText = "Total";
            ColTotal.Name = "ColTotal";
            // 
            // lbTotalRecaud
            // 
            lbTotalRecaud.AutoSize = true;
            lbTotalRecaud.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalRecaud.Location = new Point(219, 100);
            lbTotalRecaud.Name = "lbTotalRecaud";
            lbTotalRecaud.Size = new Size(0, 20);
            lbTotalRecaud.TabIndex = 12;
            // 
            // lbTotalVentas
            // 
            lbTotalVentas.AutoSize = true;
            lbTotalVentas.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalVentas.Location = new Point(491, 100);
            lbTotalVentas.Name = "lbTotalVentas";
            lbTotalVentas.Size = new Size(0, 20);
            lbTotalVentas.TabIndex = 13;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 450);
            Controls.Add(lbTotalVentas);
            Controls.Add(lbTotalRecaud);
            Controls.Add(dataGridView1);
            Controls.Add(lbReportes);
            Controls.Add(panel1);
            Name = "FormReportes";
            Text = "FormReportes";
            Load += FormReportes_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button btCaja;
        private Label lbReportes;
        private DataGridView dataGridView1;
        private Label lbTotalRecaud;
        private Label lbTotalVentas;
        private DataGridViewTextBoxColumn ColNventas;
        private DataGridViewTextBoxColumn ColFecha;
        private DataGridViewTextBoxColumn ColTotal;
    }
}