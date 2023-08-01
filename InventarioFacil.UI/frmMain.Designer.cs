namespace InventarioFacil
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ultraTabbedMdiManager1 = new Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager(this.components);
            this.imgListMenu = new System.Windows.Forms.ImageList(this.components);
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnItems = new System.Windows.Forms.ToolStripMenuItem();
            this.btnWarehouse = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDocTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMovs = new System.Windows.Forms.ToolStripButton();
            this.btnFisicInventory = new System.Windows.Forms.ToolStripButton();
            this.btnReports = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnUsers = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.btnMovs,
            this.toolStripSeparator2,
            this.btnFisicInventory,
            this.toolStripSeparator3,
            this.btnReports,
            this.toolStripSeparator4,
            this.btnUsers,
            this.toolStripSeparator5,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // ultraTabbedMdiManager1
            // 
            this.ultraTabbedMdiManager1.MdiParent = this;
            this.ultraTabbedMdiManager1.ViewStyle = Infragistics.Win.UltraWinTabbedMdi.ViewStyle.VisualStudio2005;
            // 
            // imgListMenu
            // 
            this.imgListMenu.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListMenu.ImageSize = new System.Drawing.Size(16, 16);
            this.imgListMenu.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnItems,
            this.btnWarehouse,
            this.btnCategories,
            this.btnDocTypes,
            this.clientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::InventarioFacil.Properties.Resources.catalog;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(45, 36);
            this.toolStripDropDownButton1.Text = "Catálogos";
            this.toolStripDropDownButton1.ToolTipText = "Catálogos del Sistema";
            // 
            // btnItems
            // 
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(189, 22);
            this.btnItems.Text = "Articulos";
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(189, 22);
            this.btnWarehouse.Text = "Almacenes";
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(189, 22);
            this.btnCategories.Text = "Categorias";
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnDocTypes
            // 
            this.btnDocTypes.Name = "btnDocTypes";
            this.btnDocTypes.Size = new System.Drawing.Size(189, 22);
            this.btnDocTypes.Text = "Tipos de Documentos";
            this.btnDocTypes.Click += new System.EventHandler(this.btnDocTypes_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // btnMovs
            // 
            this.btnMovs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMovs.Image = global::InventarioFacil.Properties.Resources.login_img;
            this.btnMovs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMovs.Name = "btnMovs";
            this.btnMovs.Size = new System.Drawing.Size(36, 36);
            this.btnMovs.ToolTipText = "Movimientos al Inventario";
            this.btnMovs.Click += new System.EventHandler(this.btnMovs_Click);
            // 
            // btnFisicInventory
            // 
            this.btnFisicInventory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFisicInventory.Image = global::InventarioFacil.Properties.Resources.fisico32;
            this.btnFisicInventory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFisicInventory.Name = "btnFisicInventory";
            this.btnFisicInventory.Size = new System.Drawing.Size(36, 36);
            this.btnFisicInventory.ToolTipText = "Inventario Físico";
            this.btnFisicInventory.Click += new System.EventHandler(this.btnFisicInventory_Click);
            // 
            // btnReports
            // 
            this.btnReports.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReports.Image = global::InventarioFacil.Properties.Resources.Reports_4;
            this.btnReports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(36, 36);
            this.btnReports.ToolTipText = "Reportes";
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = global::InventarioFacil.Properties.Resources.exit_icon;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 36);
            this.btnExit.Text = "toolStripButton3";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUsers.Image = global::InventarioFacil.Properties.Resources.users32;
            this.btnUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(36, 36);
            this.btnUsers.ToolTipText = "Usuarios";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Inventario Fácil v1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager ultraTabbedMdiManager1;
        private System.Windows.Forms.ToolStripButton btnMovs;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ImageList imgListMenu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnItems;
        private System.Windows.Forms.ToolStripMenuItem btnWarehouse;
        private System.Windows.Forms.ToolStripMenuItem btnCategories;
        private System.Windows.Forms.ToolStripMenuItem btnDocTypes;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnFisicInventory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnReports;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnUsers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}