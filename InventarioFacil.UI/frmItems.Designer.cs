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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rubbonItems = new System.Windows.Forms.Ribbon();
            this.tabAcciones = new System.Windows.Forms.RibbonTab();
            this.pnlAlta = new System.Windows.Forms.RibbonPanel();
            this.pnlSearch = new System.Windows.Forms.RibbonPanel();
            this.pnlRefresh = new System.Windows.Forms.RibbonPanel();
            this.pnlProcess = new System.Windows.Forms.RibbonPanel();
            this.pnlExit = new System.Windows.Forms.RibbonPanel();
            this.tabReportes = new System.Windows.Forms.RibbonTab();
            this.grpSearch = new System.Windows.Forms.RibbonItemGroup();
            this.lblSearchIn = new System.Windows.Forms.RibbonLabel();
            this.cboColumns = new System.Windows.Forms.RibbonComboBox();
            this.lblText = new System.Windows.Forms.RibbonLabel();
            this.txtSearch = new System.Windows.Forms.RibbonTextBox();
            this.btnNew = new System.Windows.Forms.RibbonButton();
            this.btnSearch = new System.Windows.Forms.RibbonButton();
            this.btnRefresh = new System.Windows.Forms.RibbonButton();
            this.btnExportar = new System.Windows.Forms.RibbonButton();
            this.btnExit = new System.Windows.Forms.RibbonButton();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
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
            this.rubbonItems.Size = new System.Drawing.Size(1068, 159);
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
            // pnlSearch
            // 
            this.pnlSearch.ButtonMoreEnabled = false;
            this.pnlSearch.ButtonMoreVisible = false;
            this.pnlSearch.FlowsTo = System.Windows.Forms.RibbonPanelFlowDirection.Right;
            this.pnlSearch.Items.Add(this.grpSearch);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Text = "Búsqueda";
            // 
            // pnlRefresh
            // 
            this.pnlRefresh.ButtonMoreEnabled = false;
            this.pnlRefresh.ButtonMoreVisible = false;
            this.pnlRefresh.Items.Add(this.btnRefresh);
            this.pnlRefresh.Name = "pnlRefresh";
            this.pnlRefresh.Text = "Refrescar";
            // 
            // pnlProcess
            // 
            this.pnlProcess.ButtonMoreEnabled = false;
            this.pnlProcess.ButtonMoreVisible = false;
            this.pnlProcess.FlowsTo = System.Windows.Forms.RibbonPanelFlowDirection.Right;
            this.pnlProcess.Items.Add(this.btnExportar);
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
            // tabReportes
            // 
            this.tabReportes.Name = "tabReportes";
            this.tabReportes.Text = "Reportes";
            // 
            // grpSearch
            // 
            this.grpSearch.DrawBackground = false;
            this.grpSearch.Items.Add(this.lblSearchIn);
            this.grpSearch.Items.Add(this.cboColumns);
            this.grpSearch.Items.Add(this.lblText);
            this.grpSearch.Items.Add(this.txtSearch);
            this.grpSearch.Items.Add(this.btnSearch);
            this.grpSearch.Name = "grpSearch";
            // 
            // lblSearchIn
            // 
            this.lblSearchIn.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.lblSearchIn.Name = "lblSearchIn";
            this.lblSearchIn.Text = "Buscar en";
            // 
            // cboColumns
            // 
            this.cboColumns.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.cboColumns.Name = "cboColumns";
            this.cboColumns.SelectedIndex = -1;
            this.cboColumns.TextBoxText = "";
            // 
            // lblText
            // 
            this.lblText.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.lblText.Name = "lblText";
            this.lblText.Text = " el texto ";
            // 
            // txtSearch
            // 
            this.txtSearch.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.TextBoxText = "";
            // 
            // btnNew
            // 
            this.btnNew.Image = global::InventarioFacil.UI.Properties.Resources.add_48;
            this.btnNew.LargeImage = global::InventarioFacil.UI.Properties.Resources.add_48;
            this.btnNew.Name = "btnNew";
            this.btnNew.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnNew.SmallImage")));
            // 
            // btnSearch
            // 
            this.btnSearch.DrawDropDownIconsBar = false;
            this.btnSearch.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Up;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.LargeImage")));
            this.btnSearch.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.SmallImage = global::InventarioFacil.UI.Properties.Resources.search24;
            this.btnSearch.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.btnSearch.ToolTipTitle = "Buscar";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::InventarioFacil.UI.Properties.Resources.refresh_32;
            this.btnRefresh.LargeImage = global::InventarioFacil.UI.Properties.Resources.refresh_32;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.SmallImage")));
            this.btnRefresh.ToolTip = "Refrescar datos";
            // 
            // btnExportar
            // 
            this.btnExportar.DrawDropDownIconsBar = false;
            this.btnExportar.DropDownResizable = true;
            this.btnExportar.Image = global::InventarioFacil.UI.Properties.Resources.Excel_icon;
            this.btnExportar.LargeImage = global::InventarioFacil.UI.Properties.Resources.Excel_icon;
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.SmallImage = global::InventarioFacil.UI.Properties.Resources.Excel_icon;
            this.btnExportar.Text = "Exportar a Excel";
            // 
            // btnExit
            // 
            this.btnExit.Image = global::InventarioFacil.UI.Properties.Resources.log_out48;
            this.btnExit.LargeImage = global::InventarioFacil.UI.Properties.Resources.log_out48;
            this.btnExit.Name = "btnExit";
            this.btnExit.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnExit.SmallImage")));
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeColumns = false;
            this.dgvItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.Location = new System.Drawing.Point(0, 159);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(1068, 369);
            this.dgvItems.TabIndex = 1;
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 528);
            this.ControlBox = false;
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.rubbonItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmItems";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Articulos";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
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
        private System.Windows.Forms.RibbonItemGroup grpSearch;
        private System.Windows.Forms.RibbonLabel lblSearchIn;
        private System.Windows.Forms.RibbonComboBox cboColumns;
        private System.Windows.Forms.RibbonLabel lblText;
        private System.Windows.Forms.RibbonTextBox txtSearch;
        private System.Windows.Forms.RibbonButton btnSearch;
        private System.Windows.Forms.RibbonButton btnRefresh;
        private System.Windows.Forms.RibbonButton btnExportar;
        private System.Windows.Forms.DataGridView dgvItems;
    }
}