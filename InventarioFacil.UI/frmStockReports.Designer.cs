namespace InventarioFacil
{
    partial class frmStockReports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCAl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Button();
            this.txtCDel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbFechas = new System.Windows.Forms.GroupBox();
            this.dtAl = new System.Windows.Forms.DateTimePicker();
            this.dtDel = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPantalla = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPDF = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.gbCliente.SuspendLayout();
            this.gbFechas.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.button1);
            this.gbCliente.Controls.Add(this.txtCAl);
            this.gbCliente.Controls.Add(this.label1);
            this.gbCliente.Controls.Add(this.btnCliente);
            this.gbCliente.Controls.Add(this.txtCDel);
            this.gbCliente.Controls.Add(this.label7);
            this.gbCliente.Location = new System.Drawing.Point(12, 12);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(212, 94);
            this.gbCliente.TabIndex = 2;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Articulo";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Image = global::InventarioFacil.Properties.Resources.Question2;
            this.button1.Location = new System.Drawing.Point(160, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 106;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCAl
            // 
            this.txtCAl.Location = new System.Drawing.Point(69, 49);
            this.txtCAl.Name = "txtCAl";
            this.txtCAl.Size = new System.Drawing.Size(86, 20);
            this.txtCAl.TabIndex = 2;
            this.txtCAl.Text = "9";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 105;
            this.label1.Text = "Al:";
            // 
            // btnCliente
            // 
            this.btnCliente.AutoSize = true;
            this.btnCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCliente.Image = global::InventarioFacil.Properties.Resources.Question2;
            this.btnCliente.Location = new System.Drawing.Point(160, 21);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(22, 22);
            this.btnCliente.TabIndex = 103;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // txtCDel
            // 
            this.txtCDel.Location = new System.Drawing.Point(69, 21);
            this.txtCDel.Name = "txtCDel";
            this.txtCDel.Size = new System.Drawing.Size(86, 20);
            this.txtCDel.TabIndex = 0;
            this.txtCDel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 102;
            this.label7.Text = "Del:";
            // 
            // gbFechas
            // 
            this.gbFechas.Controls.Add(this.dtAl);
            this.gbFechas.Controls.Add(this.dtDel);
            this.gbFechas.Controls.Add(this.label4);
            this.gbFechas.Controls.Add(this.label5);
            this.gbFechas.Location = new System.Drawing.Point(230, 12);
            this.gbFechas.Name = "gbFechas";
            this.gbFechas.Size = new System.Drawing.Size(145, 94);
            this.gbFechas.TabIndex = 4;
            this.gbFechas.TabStop = false;
            this.gbFechas.Text = "Fecha:";
            // 
            // dtAl
            // 
            this.dtAl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAl.Location = new System.Drawing.Point(50, 49);
            this.dtAl.Name = "dtAl";
            this.dtAl.Size = new System.Drawing.Size(89, 20);
            this.dtAl.TabIndex = 6;
            // 
            // dtDel
            // 
            this.dtDel.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDel.Location = new System.Drawing.Point(50, 21);
            this.dtDel.Name = "dtDel";
            this.dtDel.Size = new System.Drawing.Size(89, 20);
            this.dtDel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 105;
            this.label4.Text = "Al:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 102;
            this.label5.Text = "Del:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowMerge = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPantalla,
            this.toolStripSeparator2,
            this.btnPDF,
            this.toolStripSeparator3,
            this.btnExcel,
            this.toolStripSeparator4,
            this.btnClose});
            this.toolStrip1.Location = new System.Drawing.Point(12, 121);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(238, 55);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPantalla
            // 
            this.btnPantalla.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPantalla.Image = global::InventarioFacil.Properties.Resources.monitor_icon;
            this.btnPantalla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPantalla.Name = "btnPantalla";
            this.btnPantalla.Size = new System.Drawing.Size(52, 52);
            this.btnPantalla.Text = "Mostrar en Pantalla";
            this.btnPantalla.Click += new System.EventHandler(this.btnPantalla_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // btnPDF
            // 
            this.btnPDF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPDF.Image = global::InventarioFacil.Properties.Resources.pdf;
            this.btnPDF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(52, 52);
            this.btnPDF.Text = "toolStripButton3";
            this.btnPDF.ToolTipText = "Exportar a PDF";
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 55);
            // 
            // btnExcel
            // 
            this.btnExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcel.Image = global::InventarioFacil.Properties.Resources.csv_icon;
            this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(52, 52);
            this.btnExcel.Text = "toolStripButton4";
            this.btnExcel.ToolTipText = "Exportar a Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 55);
            // 
            // btnClose
            // 
            this.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClose.Image = global::InventarioFacil.Properties.Resources.exit_48;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 52);
            this.btnClose.Text = "toolStripButton5";
            this.btnClose.ToolTipText = "Salir";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(8, 178);
            this.dgvData.Margin = new System.Windows.Forms.Padding(2);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(753, 185);
            this.dgvData.TabIndex = 8;
            this.dgvData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvData_CellFormatting);
            // 
            // frmStockReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 370);
            this.ControlBox = false;
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbFechas);
            this.Controls.Add(this.gbCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmStockReports";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes Inventario";
            this.Load += new System.EventHandler(this.frmStockReports_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbFechas.ResumeLayout(false);
            this.gbFechas.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCAl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.TextBox txtCDel;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.GroupBox gbFechas;
        private System.Windows.Forms.DateTimePicker dtAl;
        private System.Windows.Forms.DateTimePicker dtDel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPantalla;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnPDF;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.DataGridView dgvData;
    }
}