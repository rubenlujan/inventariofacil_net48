namespace InventarioFacil.UI
{
    partial class frmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.PanelClientArea = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelDesktopHeader = new System.Windows.Forms.Panel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.btnChildFormClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnInvFisico = new System.Windows.Forms.Button();
            this.btnMovimientos = new System.Windows.Forms.Button();
            this.panelCatalogosSubMenu = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCatalogos = new System.Windows.Forms.Button();
            this.panelMenuHeader = new System.Windows.Forms.Panel();
            this.linkProfile = new System.Windows.Forms.LinkLabel();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.btnSideMenu = new System.Windows.Forms.PictureBox();
            this.lblRolName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.PanelClientArea.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panelDesktopHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSideMenu.SuspendLayout();
            this.panelCatalogosSubMenu.SuspendLayout();
            this.panelMenuHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSideMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelClientArea
            // 
            this.PanelClientArea.Controls.Add(this.panelDesktop);
            this.PanelClientArea.Controls.Add(this.panelSideMenu);
            this.PanelClientArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelClientArea.Location = new System.Drawing.Point(0, 0);
            this.PanelClientArea.Name = "PanelClientArea";
            this.PanelClientArea.Size = new System.Drawing.Size(1207, 837);
            this.PanelClientArea.TabIndex = 0;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.Control;
            this.panelDesktop.Controls.Add(this.panelDesktopHeader);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(307, 0);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(4);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(900, 837);
            this.panelDesktop.TabIndex = 8;
            // 
            // panelDesktopHeader
            // 
            this.panelDesktopHeader.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelDesktopHeader.Controls.Add(this.lblCaption);
            this.panelDesktopHeader.Controls.Add(this.btnChildFormClose);
            this.panelDesktopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDesktopHeader.Location = new System.Drawing.Point(0, 0);
            this.panelDesktopHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelDesktopHeader.Name = "panelDesktopHeader";
            this.panelDesktopHeader.Size = new System.Drawing.Size(900, 37);
            this.panelDesktopHeader.TabIndex = 18;
            this.panelDesktopHeader.Visible = false;
            // 
            // lblCaption
            // 
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.DimGray;
            this.lblCaption.Location = new System.Drawing.Point(40, 0);
            this.lblCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(565, 37);
            this.lblCaption.TabIndex = 18;
            this.lblCaption.Text = "Child Form Title";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnChildFormClose
            // 
            this.btnChildFormClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnChildFormClose.FlatAppearance.BorderSize = 0;
            this.btnChildFormClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnChildFormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChildFormClose.Image = ((System.Drawing.Image)(resources.GetObject("btnChildFormClose.Image")));
            this.btnChildFormClose.Location = new System.Drawing.Point(0, 0);
            this.btnChildFormClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnChildFormClose.Name = "btnChildFormClose";
            this.btnChildFormClose.Size = new System.Drawing.Size(40, 37);
            this.btnChildFormClose.TabIndex = 19;
            this.btnChildFormClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChildFormClose.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::InventarioFacil.UI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(338, 306);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.label2.Location = new System.Drawing.Point(270, 456);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Inventario Fácil v1.0";
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnLogout);
            this.panelSideMenu.Controls.Add(this.btnUsers);
            this.panelSideMenu.Controls.Add(this.btnReportes);
            this.panelSideMenu.Controls.Add(this.btnInvFisico);
            this.panelSideMenu.Controls.Add(this.btnMovimientos);
            this.panelSideMenu.Controls.Add(this.panelCatalogosSubMenu);
            this.panelSideMenu.Controls.Add(this.btnCatalogos);
            this.panelSideMenu.Controls.Add(this.panelMenuHeader);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(307, 837);
            this.panelSideMenu.TabIndex = 18;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.DarkGray;
            this.btnLogout.Image = global::InventarioFacil.UI.Properties.Resources.exit32;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 757);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(307, 80);
            this.btnLogout.TabIndex = 25;
            this.btnLogout.Tag = "bmenu";
            this.btnLogout.Text = "  Cerrar sesión";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.DarkGray;
            this.btnUsers.Image = global::InventarioFacil.UI.Properties.Resources.users32;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 712);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(307, 80);
            this.btnUsers.TabIndex = 20;
            this.btnUsers.Tag = "bmenu";
            this.btnUsers.Text = "  Usuarios";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.DarkGray;
            this.btnReportes.Image = global::InventarioFacil.UI.Properties.Resources.reports32;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 632);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(307, 80);
            this.btnReportes.TabIndex = 28;
            this.btnReportes.Tag = "bmenu";
            this.btnReportes.Text = "  Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnInvFisico
            // 
            this.btnInvFisico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvFisico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvFisico.FlatAppearance.BorderSize = 0;
            this.btnInvFisico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvFisico.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvFisico.ForeColor = System.Drawing.Color.DarkGray;
            this.btnInvFisico.Image = global::InventarioFacil.UI.Properties.Resources.fisico32;
            this.btnInvFisico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvFisico.Location = new System.Drawing.Point(0, 552);
            this.btnInvFisico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInvFisico.Name = "btnInvFisico";
            this.btnInvFisico.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnInvFisico.Size = new System.Drawing.Size(307, 80);
            this.btnInvFisico.TabIndex = 27;
            this.btnInvFisico.Tag = "bmenu";
            this.btnInvFisico.Text = "  Inventario Fisico";
            this.btnInvFisico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInvFisico.UseVisualStyleBackColor = true;
            // 
            // btnMovimientos
            // 
            this.btnMovimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovimientos.FlatAppearance.BorderSize = 0;
            this.btnMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovimientos.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimientos.ForeColor = System.Drawing.Color.DarkGray;
            this.btnMovimientos.Image = global::InventarioFacil.UI.Properties.Resources.movs32;
            this.btnMovimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovimientos.Location = new System.Drawing.Point(0, 472);
            this.btnMovimientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 15);
            this.btnMovimientos.Name = "btnMovimientos";
            this.btnMovimientos.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnMovimientos.Size = new System.Drawing.Size(307, 80);
            this.btnMovimientos.TabIndex = 22;
            this.btnMovimientos.Tag = "bmenu";
            this.btnMovimientos.Text = "  Movimientos";
            this.btnMovimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMovimientos.UseVisualStyleBackColor = true;
            // 
            // panelCatalogosSubMenu
            // 
            this.panelCatalogosSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(55)))));
            this.panelCatalogosSubMenu.Controls.Add(this.button6);
            this.panelCatalogosSubMenu.Controls.Add(this.button1);
            this.panelCatalogosSubMenu.Controls.Add(this.button5);
            this.panelCatalogosSubMenu.Controls.Add(this.button4);
            this.panelCatalogosSubMenu.Controls.Add(this.button3);
            this.panelCatalogosSubMenu.Controls.Add(this.button2);
            this.panelCatalogosSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCatalogosSubMenu.Location = new System.Drawing.Point(0, 222);
            this.panelCatalogosSubMenu.Name = "panelCatalogosSubMenu";
            this.panelCatalogosSubMenu.Size = new System.Drawing.Size(307, 250);
            this.panelCatalogosSubMenu.TabIndex = 26;
            this.panelCatalogosSubMenu.Tag = "subm";
            this.panelCatalogosSubMenu.Visible = false;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Silver;
            this.button6.Location = new System.Drawing.Point(0, 200);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(307, 40);
            this.button6.TabIndex = 5;
            this.button6.Text = "Tipo de Movimientos";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(0, 160);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(307, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Categorías";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Silver;
            this.button5.Location = new System.Drawing.Point(0, 120);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(307, 40);
            this.button5.TabIndex = 3;
            this.button5.Text = "Almacenes";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Silver;
            this.button4.Location = new System.Drawing.Point(0, 80);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(307, 40);
            this.button4.TabIndex = 2;
            this.button4.Text = "Proveedores";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(0, 40);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(307, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "Clientes";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(307, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "Artículos";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCatalogos
            // 
            this.btnCatalogos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnCatalogos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatalogos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCatalogos.FlatAppearance.BorderSize = 0;
            this.btnCatalogos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogos.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatalogos.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCatalogos.Image = global::InventarioFacil.UI.Properties.Resources.catalog;
            this.btnCatalogos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogos.Location = new System.Drawing.Point(0, 142);
            this.btnCatalogos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCatalogos.Name = "btnCatalogos";
            this.btnCatalogos.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnCatalogos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCatalogos.Size = new System.Drawing.Size(307, 80);
            this.btnCatalogos.TabIndex = 21;
            this.btnCatalogos.Tag = "bmenu";
            this.btnCatalogos.Text = "  Catálogos";
            this.btnCatalogos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCatalogos.UseVisualStyleBackColor = false;
            this.btnCatalogos.Click += new System.EventHandler(this.btnCatalogos_Click);
            // 
            // panelMenuHeader
            // 
            this.panelMenuHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelMenuHeader.Controls.Add(this.linkProfile);
            this.panelMenuHeader.Controls.Add(this.pictureBoxPhoto);
            this.panelMenuHeader.Controls.Add(this.btnSideMenu);
            this.panelMenuHeader.Controls.Add(this.lblRolName);
            this.panelMenuHeader.Controls.Add(this.lblName);
            this.panelMenuHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuHeader.Location = new System.Drawing.Point(0, 0);
            this.panelMenuHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenuHeader.Name = "panelMenuHeader";
            this.panelMenuHeader.Size = new System.Drawing.Size(307, 142);
            this.panelMenuHeader.TabIndex = 0;
            // 
            // linkProfile
            // 
            this.linkProfile.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linkProfile.AutoSize = true;
            this.linkProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkProfile.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.linkProfile.Location = new System.Drawing.Point(91, 101);
            this.linkProfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkProfile.Name = "linkProfile";
            this.linkProfile.Size = new System.Drawing.Size(97, 20);
            this.linkProfile.TabIndex = 16;
            this.linkProfile.TabStop = true;
            this.linkProfile.Text = "Editar Perfil";
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPhoto.Image = global::InventarioFacil.UI.Properties.Resources.profile;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(4, 42);
            this.pictureBoxPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(85, 79);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 13;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // btnSideMenu
            // 
            this.btnSideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSideMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnSideMenu.Image")));
            this.btnSideMenu.Location = new System.Drawing.Point(252, 6);
            this.btnSideMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnSideMenu.Name = "btnSideMenu";
            this.btnSideMenu.Size = new System.Drawing.Size(32, 32);
            this.btnSideMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSideMenu.TabIndex = 12;
            this.btnSideMenu.TabStop = false;
            this.btnSideMenu.Click += new System.EventHandler(this.btnSideMenu_Click);
            // 
            // lblRolName
            // 
            this.lblRolName.AutoSize = true;
            this.lblRolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolName.ForeColor = System.Drawing.Color.DarkGray;
            this.lblRolName.Location = new System.Drawing.Point(92, 77);
            this.lblRolName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRolName.Name = "lblRolName";
            this.lblRolName.Size = new System.Drawing.Size(107, 20);
            this.lblRolName.TabIndex = 15;
            this.lblRolName.Text = "Administrador";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblName.Location = new System.Drawing.Point(92, 51);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(112, 22);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Rubén Luján";
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 837);
            this.ControlBox = false;
            this.Controls.Add(this.PanelClientArea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario Fácil v1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.PanelClientArea.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.panelDesktopHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSideMenu.ResumeLayout(false);
            this.panelCatalogosSubMenu.ResumeLayout(false);
            this.panelMenuHeader.ResumeLayout(false);
            this.panelMenuHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSideMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelClientArea;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelSideMenu;
        internal System.Windows.Forms.Button btnLogout;
        internal System.Windows.Forms.Button btnMovimientos;
        internal System.Windows.Forms.Button btnCatalogos;
        internal System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Panel panelMenuHeader;
        private System.Windows.Forms.LinkLabel linkProfile;
        internal System.Windows.Forms.PictureBox pictureBoxPhoto;
        internal System.Windows.Forms.PictureBox btnSideMenu;
        internal System.Windows.Forms.Label lblRolName;
        internal System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panelDesktopHeader;
        internal System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Button btnChildFormClose;
        private System.Windows.Forms.Panel panelCatalogosSubMenu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button btnInvFisico;
        internal System.Windows.Forms.Button btnReportes;
    }
}