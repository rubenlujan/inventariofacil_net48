namespace InventarioFacil.UI
{
    partial class frmItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItems));
            this.rubbonItems = new System.Windows.Forms.Ribbon();
            this.tabAcciones = new System.Windows.Forms.RibbonTab();
            this.pnlAlta = new System.Windows.Forms.RibbonPanel();
            this.btnNew = new System.Windows.Forms.RibbonButton();
            this.pnlSearch = new System.Windows.Forms.RibbonPanel();
            this.pnlRefresh = new System.Windows.Forms.RibbonPanel();
            this.pnlProcess = new System.Windows.Forms.RibbonPanel();
            this.pnlExit = new System.Windows.Forms.RibbonPanel();
            this.btnExit = new System.Windows.Forms.RibbonButton();
            this.tabReportes = new System.Windows.Forms.RibbonTab();
            this.SuspendLayout();
            // 
            // rubbonItems
            // 
            this.rubbonItems.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rubbonItems.Location = new System.Drawing.Point(0, 0);
            this.rubbonItems.Minimized = false;
            this.rubbonItems.Name = "rubbonItems";
            // 
            // 
            // 
            this.rubbonItems.OrbDropDown.BorderRoundness = 8;
            this.rubbonItems.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.rubbonItems.OrbDropDown.Name = "";
            this.rubbonItems.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.rubbonItems.OrbDropDown.TabIndex = 0;
            this.rubbonItems.OrbVisible = false;
            // 
            // 
            // 
            this.rubbonItems.QuickAccessToolbar.Visible = false;
            this.rubbonItems.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.rubbonItems.Size = new System.Drawing.Size(800, 159);
            this.rubbonItems.TabIndex = 0;
            this.rubbonItems.Tabs.Add(this.tabAcciones);
            this.rubbonItems.Tabs.Add(this.tabReportes);
            this.rubbonItems.Text = "ribbon1";
            // 
            // tabAcciones
            // 
            this.tabAcciones.Name = "tabAcciones";
            this.tabAcciones.Panels.Add(this.pnlAlta);
            this.tabAcciones.Panels.Add(this.pnlSearch);
            this.tabAcciones.Panels.Add(this.pnlRefresh);
            this.tabAcciones.Panels.Add(this.pnlProcess);
            this.tabAcciones.Panels.Add(this.pnlExit);
            this.tabAcciones.Text = "Acciones";
            // 
            // pnlAlta
            // 
            this.pnlAlta.ButtonMoreEnabled = false;
            this.pnlAlta.ButtonMoreVisible = false;
            this.pnlAlta.Items.Add(this.btnNew);
            this.pnlAlta.Name = "pnlAlta";
            this.pnlAlta.Text = "Nuevo";
            // 
            // btnNew
            // 
            this.btnNew.Image = global::InventarioFacil.UI.Properties.Resources.add_48;
            this.btnNew.LargeImage = global::InventarioFacil.UI.Properties.Resources.add_48;
            this.btnNew.Name = "btnNew";
            this.btnNew.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnNew.SmallImage")));
            // 
            // pnlSearch
            // 
            this.pnlSearch.ButtonMoreEnabled = false;
            this.pnlSearch.ButtonMoreVisible = false;
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Text = "Búsqueda";
            // 
            // pnlRefresh
            // 
            this.pnlRefresh.ButtonMoreEnabled = false;
            this.pnlRefresh.ButtonMoreVisible = false;
            this.pnlRefresh.Name = "pnlRefresh";
            this.pnlRefresh.Text = "Refrescar";
            // 
            // pnlProcess
            // 
            this.pnlProcess.ButtonMoreEnabled = false;
            this.pnlProcess.ButtonMoreVisible = false;
            this.pnlProcess.Name = "pnlProcess";
            this.pnlProcess.Text = "Procesos";
            // 
            // pnlExit
            // 
            this.pnlExit.ButtonMoreEnabled = false;
            this.pnlExit.ButtonMoreVisible = false;
            this.pnlExit.Items.Add(this.btnExit);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Text = "Salir";
            // 
            // btnExit
            // 
            this.btnExit.Image = global::InventarioFacil.UI.Properties.Resources.log_out48;
            this.btnExit.LargeImage = global::InventarioFacil.UI.Properties.Resources.log_out48;
            this.btnExit.Name = "btnExit";
            this.btnExit.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnExit.SmallImage")));
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tabReportes
            // 
            this.tabReportes.Name = "tabReportes";
            this.tabReportes.Text = "Reportes";
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.rubbonItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmItems";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Articulos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon rubbonItems;
        private System.Windows.Forms.RibbonTab tabAcciones;
        private System.Windows.Forms.RibbonTab tabReportes;
        private System.Windows.Forms.RibbonPanel pnlAlta;
        private System.Windows.Forms.RibbonButton btnNew;
        private System.Windows.Forms.RibbonPanel pnlSearch;
        private System.Windows.Forms.RibbonPanel pnlRefresh;
        private System.Windows.Forms.RibbonPanel pnlProcess;
        private System.Windows.Forms.RibbonPanel pnlExit;
        private System.Windows.Forms.RibbonButton btnExit;
    }
}