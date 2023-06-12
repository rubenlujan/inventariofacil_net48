namespace InventarioFacil.UI
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.ribbonMenuUsuarios = new System.Windows.Forms.Ribbon();
            this.tabAcciones = new System.Windows.Forms.RibbonTab();
            this.rbpNuevo = new System.Windows.Forms.RibbonPanel();
            this.rbpSalir = new System.Windows.Forms.RibbonPanel();
            this.btnNew = new System.Windows.Forms.RibbonButton();
            this.btnExit = new System.Windows.Forms.RibbonButton();
            this.gvDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonMenuUsuarios
            // 
            this.ribbonMenuUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbonMenuUsuarios.Location = new System.Drawing.Point(0, 0);
            this.ribbonMenuUsuarios.Minimized = false;
            this.ribbonMenuUsuarios.Name = "ribbonMenuUsuarios";
            // 
            // 
            // 
            this.ribbonMenuUsuarios.OrbDropDown.AutoSizeContentButtons = false;
            this.ribbonMenuUsuarios.OrbDropDown.BorderRoundness = 8;
            this.ribbonMenuUsuarios.OrbDropDown.ContentButtonsMinWidth = 0;
            this.ribbonMenuUsuarios.OrbDropDown.ContentRecentItemsMinWidth = 0;
            this.ribbonMenuUsuarios.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbonMenuUsuarios.OrbDropDown.Name = "";
            this.ribbonMenuUsuarios.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbonMenuUsuarios.OrbDropDown.TabIndex = 0;
            this.ribbonMenuUsuarios.OrbDropDown.Visible = false;
            this.ribbonMenuUsuarios.OrbVisible = false;
            // 
            // 
            // 
            this.ribbonMenuUsuarios.QuickAccessToolbar.Visible = false;
            this.ribbonMenuUsuarios.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbonMenuUsuarios.Size = new System.Drawing.Size(800, 167);
            this.ribbonMenuUsuarios.TabIndex = 0;
            this.ribbonMenuUsuarios.Tabs.Add(this.tabAcciones);
            this.ribbonMenuUsuarios.Text = "ribbon1";
            // 
            // tabAcciones
            // 
            this.tabAcciones.Name = "tabAcciones";
            this.tabAcciones.Panels.Add(this.rbpNuevo);
            this.tabAcciones.Panels.Add(this.rbpSalir);
            this.tabAcciones.Text = "Acciones";
            // 
            // rbpNuevo
            // 
            this.rbpNuevo.ButtonMoreVisible = false;
            this.rbpNuevo.Items.Add(this.btnNew);
            this.rbpNuevo.Name = "rbpNuevo";
            this.rbpNuevo.Text = "Nuevo";
            // 
            // rbpSalir
            // 
            this.rbpSalir.ButtonMoreVisible = false;
            this.rbpSalir.Items.Add(this.btnExit);
            this.rbpSalir.Name = "rbpSalir";
            this.rbpSalir.Text = "Salir";
            // 
            // btnNew
            // 
            this.btnNew.Image = global::InventarioFacil.UI.Properties.Resources.add_48;
            this.btnNew.LargeImage = global::InventarioFacil.UI.Properties.Resources.add_48;
            this.btnNew.Name = "btnNew";
            this.btnNew.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnNew.SmallImage")));
            // 
            // btnExit
            // 
            this.btnExit.Image = global::InventarioFacil.UI.Properties.Resources.log_out48;
            this.btnExit.LargeImage = global::InventarioFacil.UI.Properties.Resources.log_out48;
            this.btnExit.Name = "btnExit";
            this.btnExit.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnExit.SmallImage")));
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gvDatos
            // 
            this.gvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDatos.Location = new System.Drawing.Point(0, 167);
            this.gvDatos.Name = "gvDatos";
            this.gvDatos.RowHeadersWidth = 51;
            this.gvDatos.RowTemplate.Height = 24;
            this.gvDatos.Size = new System.Drawing.Size(800, 283);
            this.gvDatos.TabIndex = 1;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.gvDatos);
            this.Controls.Add(this.ribbonMenuUsuarios);
            this.KeyPreview = true;
            this.Name = "frmUsers";
            this.Text = "frmUsers";
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbonMenuUsuarios;
        private System.Windows.Forms.RibbonTab tabAcciones;
        private System.Windows.Forms.RibbonPanel rbpNuevo;
        private System.Windows.Forms.RibbonButton btnNew;
        private System.Windows.Forms.RibbonPanel rbpSalir;
        private System.Windows.Forms.RibbonButton btnExit;
        private System.Windows.Forms.DataGridView gvDatos;
    }
}