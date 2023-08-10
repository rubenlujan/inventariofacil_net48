namespace InventarioFacil
{
    partial class frmDocMov
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.gpMain = new System.Windows.Forms.GroupBox();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.btnConcepto = new System.Windows.Forms.Button();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAlmacen = new System.Windows.Forms.Label();
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.txtAlmacen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gvArticulos = new System.Windows.Forms.DataGridView();
            this.gbItems = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.MaskedTextBox();
            this.txtPrecioU = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCostoU = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.btnArticulo = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_U = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo_U = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.gpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvArticulos)).BeginInit();
            this.gbItems.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(53, 457);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = global::InventarioFacil.Properties.Resources.add_48;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(51, 52);
            this.btnNuevo.ToolTipText = "Nuevo Registro";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(51, 6);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::InventarioFacil.Properties.Resources.edit_48;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(51, 52);
            this.btnEditar.ToolTipText = "Editar Registro";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(51, 6);
            // 
            // btnBorrar
            // 
            this.btnBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBorrar.Image = global::InventarioFacil.Properties.Resources.delete48;
            this.btnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(51, 52);
            this.btnBorrar.ToolTipText = "Borrar Registro";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(51, 6);
            // 
            // btnGrabar
            // 
            this.btnGrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGrabar.Enabled = false;
            this.btnGrabar.Image = global::InventarioFacil.Properties.Resources.save_48_a;
            this.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(51, 52);
            this.btnGrabar.ToolTipText = "Grabar datos";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(51, 6);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = global::InventarioFacil.Properties.Resources.cancel_48;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(51, 52);
            this.btnCancelar.ToolTipText = "Cancelar acción";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(51, 6);
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = global::InventarioFacil.Properties.Resources.exit_48;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(51, 52);
            this.btnSalir.ToolTipText = "Cerrar pantalla";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gpMain
            // 
            this.gpMain.Controls.Add(this.txtComentarios);
            this.gpMain.Controls.Add(this.label1);
            this.gpMain.Controls.Add(this.lblConcepto);
            this.gpMain.Controls.Add(this.btnConcepto);
            this.gpMain.Controls.Add(this.txtConcepto);
            this.gpMain.Controls.Add(this.label15);
            this.gpMain.Controls.Add(this.txtStatus);
            this.gpMain.Controls.Add(this.label8);
            this.gpMain.Controls.Add(this.dtFecha);
            this.gpMain.Controls.Add(this.label3);
            this.gpMain.Controls.Add(this.txtNumero);
            this.gpMain.Controls.Add(this.label2);
            this.gpMain.Controls.Add(this.lblAlmacen);
            this.gpMain.Controls.Add(this.btnAlmacen);
            this.gpMain.Controls.Add(this.txtAlmacen);
            this.gpMain.Controls.Add(this.label7);
            this.gpMain.Location = new System.Drawing.Point(56, 12);
            this.gpMain.Name = "gpMain";
            this.gpMain.Size = new System.Drawing.Size(696, 179);
            this.gpMain.TabIndex = 40;
            this.gpMain.TabStop = false;
            this.gpMain.Text = "Datos";
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(91, 106);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(597, 57);
            this.txtComentarios.TabIndex = 49;
            this.txtComentarios.Tag = "input";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Comentarios:";
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Location = new System.Drawing.Point(161, 50);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(16, 13);
            this.lblConcepto.TabIndex = 46;
            this.lblConcepto.Text = "...";
            // 
            // btnConcepto
            // 
            this.btnConcepto.AutoSize = true;
            this.btnConcepto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConcepto.Image = global::InventarioFacil.Properties.Resources.Question2;
            this.btnConcepto.Location = new System.Drawing.Point(133, 45);
            this.btnConcepto.Name = "btnConcepto";
            this.btnConcepto.Size = new System.Drawing.Size(22, 22);
            this.btnConcepto.TabIndex = 47;
            this.btnConcepto.UseVisualStyleBackColor = true;
            this.btnConcepto.Click += new System.EventHandler(this.btnConcepto_Click);
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(91, 46);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(36, 20);
            this.txtConcepto.TabIndex = 1;
            this.txtConcepto.Tag = "input";
            this.txtConcepto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConcepto_KeyPress);
            this.txtConcepto.Leave += new System.EventHandler(this.txtConcepto_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "Concepto:";
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(410, 76);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(115, 20);
            this.txtStatus.TabIndex = 4;
            this.txtStatus.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Status:";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(237, 74);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(85, 20);
            this.dtFecha.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Fecha:";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(90, 74);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(64, 20);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Número:";
            // 
            // lblAlmacen
            // 
            this.lblAlmacen.AutoSize = true;
            this.lblAlmacen.Location = new System.Drawing.Point(160, 22);
            this.lblAlmacen.Name = "lblAlmacen";
            this.lblAlmacen.Size = new System.Drawing.Size(16, 13);
            this.lblAlmacen.TabIndex = 19;
            this.lblAlmacen.Text = "...";
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.AutoSize = true;
            this.btnAlmacen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAlmacen.Image = global::InventarioFacil.Properties.Resources.Question2;
            this.btnAlmacen.Location = new System.Drawing.Point(132, 17);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(22, 22);
            this.btnAlmacen.TabIndex = 20;
            this.btnAlmacen.UseVisualStyleBackColor = true;
            this.btnAlmacen.Click += new System.EventHandler(this.btnAlmacen_Click);
            // 
            // txtAlmacen
            // 
            this.txtAlmacen.Location = new System.Drawing.Point(90, 18);
            this.txtAlmacen.Name = "txtAlmacen";
            this.txtAlmacen.Size = new System.Drawing.Size(36, 20);
            this.txtAlmacen.TabIndex = 0;
            this.txtAlmacen.Tag = "input";
            this.txtAlmacen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlmacen_KeyPress);
            this.txtAlmacen.Leave += new System.EventHandler(this.txtAlmacen_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Almacen:";
            // 
            // gvArticulos
            // 
            this.gvArticulos.AllowUserToAddRows = false;
            this.gvArticulos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvArticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvArticulos.BackgroundColor = System.Drawing.Color.White;
            this.gvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Partida,
            this.Codigo,
            this.Descripcion,
            this.Cantidad,
            this.Precio_U,
            this.Costo_U});
            this.gvArticulos.Location = new System.Drawing.Point(57, 265);
            this.gvArticulos.Name = "gvArticulos";
            this.gvArticulos.ReadOnly = true;
            this.gvArticulos.Size = new System.Drawing.Size(696, 180);
            this.gvArticulos.TabIndex = 43;
            // 
            // gbItems
            // 
            this.gbItems.Controls.Add(this.txtCantidad);
            this.gbItems.Controls.Add(this.txtPrecioU);
            this.gbItems.Controls.Add(this.label9);
            this.gbItems.Controls.Add(this.txtArticulo);
            this.gbItems.Controls.Add(this.btnAgregar);
            this.gbItems.Controls.Add(this.txtCostoU);
            this.gbItems.Controls.Add(this.label12);
            this.gbItems.Controls.Add(this.label11);
            this.gbItems.Controls.Add(this.lblArticulo);
            this.gbItems.Controls.Add(this.btnArticulo);
            this.gbItems.Controls.Add(this.label10);
            this.gbItems.Enabled = false;
            this.gbItems.Location = new System.Drawing.Point(56, 197);
            this.gbItems.Name = "gbItems";
            this.gbItems.Size = new System.Drawing.Size(696, 62);
            this.gbItems.TabIndex = 42;
            this.gbItems.TabStop = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txtCantidad.Location = new System.Drawing.Point(231, 18);
            this.txtCantidad.Mask = "99999";
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(52, 20);
            this.txtCantidad.TabIndex = 28;
            this.txtCantidad.Tag = "input";
            this.txtCantidad.ValidatingType = typeof(int);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtPrecioU
            // 
            this.txtPrecioU.Location = new System.Drawing.Point(358, 16);
            this.txtPrecioU.Name = "txtPrecioU";
            this.txtPrecioU.Size = new System.Drawing.Size(64, 20);
            this.txtPrecioU.TabIndex = 29;
            this.txtPrecioU.Text = "0";
            this.txtPrecioU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioU_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Precio U:";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(60, 17);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(66, 20);
            this.txtArticulo.TabIndex = 27;
            this.txtArticulo.Tag = "input";
            this.txtArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArticulo_KeyPress);
            this.txtArticulo.Leave += new System.EventHandler(this.txtArticulo_Leave);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(600, 16);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(67, 22);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCostoU
            // 
            this.txtCostoU.Location = new System.Drawing.Point(518, 16);
            this.txtCostoU.Name = "txtCostoU";
            this.txtCostoU.Size = new System.Drawing.Size(66, 20);
            this.txtCostoU.TabIndex = 30;
            this.txtCostoU.Text = "0";
            this.txtCostoU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostoU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoU_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(452, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Costo U:";
            this.label12.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(178, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Cantidad:";
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblArticulo.Location = new System.Drawing.Point(13, 38);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(19, 13);
            this.lblArticulo.TabIndex = 23;
            this.lblArticulo.Text = "...";
            // 
            // btnArticulo
            // 
            this.btnArticulo.AutoSize = true;
            this.btnArticulo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnArticulo.Image = global::InventarioFacil.Properties.Resources.Question2;
            this.btnArticulo.Location = new System.Drawing.Point(133, 16);
            this.btnArticulo.Name = "btnArticulo";
            this.btnArticulo.Size = new System.Drawing.Size(22, 22);
            this.btnArticulo.TabIndex = 22;
            this.btnArticulo.UseVisualStyleBackColor = true;
            this.btnArticulo.Click += new System.EventHandler(this.btnArticulo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Articulo:";
            // 
            // Partida
            // 
            this.Partida.Frozen = true;
            this.Partida.HeaderText = "Part";
            this.Partida.Name = "Partida";
            this.Partida.ReadOnly = true;
            this.Partida.Width = 50;
            // 
            // Codigo
            // 
            this.Codigo.Frozen = true;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 65;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 88;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 74;
            // 
            // Precio_U
            // 
            this.Precio_U.HeaderText = "Precio U";
            this.Precio_U.Name = "Precio_U";
            this.Precio_U.ReadOnly = true;
            // 
            // Costo_U
            // 
            this.Costo_U.HeaderText = "Costo U";
            this.Costo_U.Name = "Costo_U";
            this.Costo_U.ReadOnly = true;
            // 
            // frmDocMov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 457);
            this.ControlBox = false;
            this.Controls.Add(this.gvArticulos);
            this.Controls.Add(this.gbItems);
            this.Controls.Add(this.gpMain);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDocMov";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimientos al Inventario";
            this.Load += new System.EventHandler(this.frmDocMov_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gpMain.ResumeLayout(false);
            this.gpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvArticulos)).EndInit();
            this.gbItems.ResumeLayout(false);
            this.gbItems.PerformLayout();
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
        private System.Windows.Forms.GroupBox gpMain;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.Button btnConcepto;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAlmacen;
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.TextBox txtAlmacen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gvArticulos;
        private System.Windows.Forms.GroupBox gbItems;
        private System.Windows.Forms.MaskedTextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecioU;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCostoU;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Button btnArticulo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_U;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo_U;
    }
}