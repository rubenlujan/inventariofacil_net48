namespace InventarioFacil.UI
{
    partial class frmItemsDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGrabar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.gpDatos = new System.Windows.Forms.GroupBox();
            this.btnUploadPic = new System.Windows.Forms.Button();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtCodBar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCostoU = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPrecioU = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.itemPhoto = new System.Windows.Forms.PictureBox();
            this.cboUMed = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvKardex = new System.Windows.Forms.DataGridView();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.gpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPhoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvKardex)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.toolStripSeparator1,
            this.btnEditar,
            this.toolStripSeparator2,
            this.btnBorrar,
            this.toolStripSeparator3,
            this.btnGrabar,
            this.toolStripSeparator4,
            this.btnCancelar,
            this.toolStripSeparator5,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(71, 512);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = global::InventarioFacil.UI.Properties.Resources.add_48;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(69, 52);
            this.btnNuevo.ToolTipText = "Nuevo Registro";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(69, 6);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::InventarioFacil.UI.Properties.Resources.edit_48;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(69, 52);
            this.btnEditar.ToolTipText = "Editar Registro";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(69, 6);
            // 
            // btnBorrar
            // 
            this.btnBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBorrar.Image = global::InventarioFacil.UI.Properties.Resources.delete48;
            this.btnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(69, 52);
            this.btnBorrar.ToolTipText = "Borrar Registro";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(69, 6);
            // 
            // btnGrabar
            // 
            this.btnGrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGrabar.Enabled = false;
            this.btnGrabar.Image = global::InventarioFacil.UI.Properties.Resources.save_48_a;
            this.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(69, 52);
            this.btnGrabar.ToolTipText = "Grabar datos";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(69, 6);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = global::InventarioFacil.UI.Properties.Resources.cancel_48;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 52);
            this.btnCancelar.ToolTipText = "Cancelar acción";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(69, 6);
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = global::InventarioFacil.UI.Properties.Resources.exit_48;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(69, 52);
            this.btnSalir.ToolTipText = "Cerrar pantalla";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gpDatos
            // 
            this.gpDatos.Controls.Add(this.btnUploadPic);
            this.gpDatos.Controls.Add(this.txtNotas);
            this.gpDatos.Controls.Add(this.label17);
            this.gpDatos.Controls.Add(this.cboStatus);
            this.gpDatos.Controls.Add(this.lblStatus);
            this.gpDatos.Controls.Add(this.txtCodBar);
            this.gpDatos.Controls.Add(this.label3);
            this.gpDatos.Controls.Add(this.cboCategoria);
            this.gpDatos.Controls.Add(this.label18);
            this.gpDatos.Controls.Add(this.txtCostoU);
            this.gpDatos.Controls.Add(this.label16);
            this.gpDatos.Controls.Add(this.txtPrecioU);
            this.gpDatos.Controls.Add(this.label15);
            this.gpDatos.Controls.Add(this.txtDescripcion);
            this.gpDatos.Controls.Add(this.label4);
            this.gpDatos.Controls.Add(this.txtExistencia);
            this.gpDatos.Controls.Add(this.label11);
            this.gpDatos.Controls.Add(this.itemPhoto);
            this.gpDatos.Controls.Add(this.cboUMed);
            this.gpDatos.Controls.Add(this.label5);
            this.gpDatos.Controls.Add(this.txtItem);
            this.gpDatos.Controls.Add(this.txtCodigo);
            this.gpDatos.Controls.Add(this.label2);
            this.gpDatos.Controls.Add(this.label1);
            this.gpDatos.Location = new System.Drawing.Point(99, 0);
            this.gpDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpDatos.Name = "gpDatos";
            this.gpDatos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpDatos.Size = new System.Drawing.Size(972, 288);
            this.gpDatos.TabIndex = 2;
            this.gpDatos.TabStop = false;
            this.gpDatos.Text = "Datos del artículo";
            // 
            // btnUploadPic
            // 
            this.btnUploadPic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUploadPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadPic.Location = new System.Drawing.Point(750, 246);
            this.btnUploadPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUploadPic.Name = "btnUploadPic";
            this.btnUploadPic.Size = new System.Drawing.Size(168, 28);
            this.btnUploadPic.TabIndex = 122;
            this.btnUploadPic.Text = "Subir Imagen";
            this.btnUploadPic.UseVisualStyleBackColor = true;
            this.btnUploadPic.Click += new System.EventHandler(this.btnUploadPic_Click);
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(121, 176);
            this.txtNotas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(581, 59);
            this.txtNotas.TabIndex = 18;
            this.txtNotas.Tag = "input";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(23, 198);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 20);
            this.label17.TabIndex = 120;
            this.label17.Text = "Notas:";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboStatus.Location = new System.Drawing.Point(119, 255);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(112, 24);
            this.cboStatus.TabIndex = 19;
            this.cboStatus.Tag = "input";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(23, 258);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 16);
            this.lblStatus.TabIndex = 118;
            this.lblStatus.Text = "Status:";
            // 
            // txtCodBar
            // 
            this.txtCodBar.Location = new System.Drawing.Point(499, 95);
            this.txtCodBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodBar.Name = "txtCodBar";
            this.txtCodBar.Size = new System.Drawing.Size(204, 22);
            this.txtCodBar.TabIndex = 15;
            this.txtCodBar.Tag = "input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 116;
            this.label3.Text = "Código Barras:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(123, 97);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(232, 24);
            this.cboCategoria.TabIndex = 14;
            this.cboCategoria.Tag = "input";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(23, 107);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 16);
            this.label18.TabIndex = 114;
            this.label18.Text = "Categoría:";
            // 
            // txtCostoU
            // 
            this.txtCostoU.Location = new System.Drawing.Point(355, 142);
            this.txtCostoU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCostoU.Name = "txtCostoU";
            this.txtCostoU.Size = new System.Drawing.Size(88, 22);
            this.txtCostoU.TabIndex = 17;
            this.txtCostoU.Tag = "input";
            this.txtCostoU.Text = "0";
            this.txtCostoU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(265, 145);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 16);
            this.label16.TabIndex = 113;
            this.label16.Text = "Costo U:";
            // 
            // txtPrecioU
            // 
            this.txtPrecioU.Location = new System.Drawing.Point(123, 142);
            this.txtPrecioU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioU.Name = "txtPrecioU";
            this.txtPrecioU.Size = new System.Drawing.Size(88, 22);
            this.txtPrecioU.TabIndex = 16;
            this.txtPrecioU.Tag = "input";
            this.txtPrecioU.Text = "0";
            this.txtPrecioU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 145);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 16);
            this.label15.TabIndex = 111;
            this.label15.Text = "Precio U.:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(119, 63);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(584, 22);
            this.txtDescripcion.TabIndex = 13;
            this.txtDescripcion.Tag = "input";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 109;
            this.label4.Text = "Descripción:";
            // 
            // txtExistencia
            // 
            this.txtExistencia.Enabled = false;
            this.txtExistencia.Location = new System.Drawing.Point(582, 141);
            this.txtExistencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(52, 22);
            this.txtExistencia.TabIndex = 106;
            this.txtExistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(486, 145);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 16);
            this.label11.TabIndex = 107;
            this.label11.Text = "Existencia:";
            // 
            // itemPhoto
            // 
            this.itemPhoto.Location = new System.Drawing.Point(712, 15);
            this.itemPhoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itemPhoto.Name = "itemPhoto";
            this.itemPhoto.Size = new System.Drawing.Size(240, 222);
            this.itemPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemPhoto.TabIndex = 105;
            this.itemPhoto.TabStop = false;
            // 
            // cboUMed
            // 
            this.cboUMed.FormattingEnabled = true;
            this.cboUMed.ItemHeight = 16;
            this.cboUMed.Location = new System.Drawing.Point(587, 28);
            this.cboUMed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboUMed.Name = "cboUMed";
            this.cboUMed.Size = new System.Drawing.Size(116, 24);
            this.cboUMed.TabIndex = 12;
            this.cboUMed.Tag = "input";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 103;
            this.label5.Text = "U. Medida:";
            // 
            // txtItem
            // 
            this.txtItem.Enabled = false;
            this.txtItem.Location = new System.Drawing.Point(119, 30);
            this.txtItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(85, 22);
            this.txtItem.TabIndex = 10;
            this.txtItem.Tag = "";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(288, 28);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(176, 22);
            this.txtCodigo.TabIndex = 11;
            this.txtCodigo.Tag = "input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "SKU:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Item";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gvKardex);
            this.groupBox2.Location = new System.Drawing.Point(99, 294);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(952, 209);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historial de Movimientos";
            // 
            // gvKardex
            // 
            this.gvKardex.AllowUserToAddRows = false;
            this.gvKardex.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvKardex.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gvKardex.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvKardex.BackgroundColor = System.Drawing.Color.White;
            this.gvKardex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvKardex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvKardex.Location = new System.Drawing.Point(3, 17);
            this.gvKardex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvKardex.Name = "gvKardex";
            this.gvKardex.ReadOnly = true;
            this.gvKardex.RowHeadersWidth = 51;
            this.gvKardex.Size = new System.Drawing.Size(946, 190);
            this.gvKardex.TabIndex = 42;
            // 
            // frmItemsDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 512);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpDatos);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmItemsDetail";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Artículos";
            this.Load += new System.EventHandler(this.frmItemsDetail_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gpDatos.ResumeLayout(false);
            this.gpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPhoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvKardex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnBorrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnGrabar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.GroupBox gpDatos;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboUMed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox itemPhoto;
        private System.Windows.Forms.TextBox txtCostoU;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPrecioU;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCodBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gvKardex;
        private System.Windows.Forms.Button btnUploadPic;
        private System.Windows.Forms.OpenFileDialog fileDialog;
    }
}