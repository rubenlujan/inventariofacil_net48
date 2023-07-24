namespace InventarioFacil.UI
{
    partial class frmWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWarehouse));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rubbonItems = new System.Windows.Forms.Ribbon();
            this.tbAcciones = new System.Windows.Forms.RibbonTab();
            this.pnlAdd = new System.Windows.Forms.RibbonPanel();
            this.rbAdd = new System.Windows.Forms.RibbonButton();
            this.pnlDelete = new System.Windows.Forms.RibbonPanel();
            this.rbDelete = new System.Windows.Forms.RibbonButton();
            this.pnlExit = new System.Windows.Forms.RibbonPanel();
            this.rbExit = new System.Windows.Forms.RibbonButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // rubbonItems
            // 
            this.rubbonItems.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rubbonItems.Location = new System.Drawing.Point(0, 0);
            this.rubbonItems.Margin = new System.Windows.Forms.Padding(2);
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
            this.rubbonItems.Size = new System.Drawing.Size(971, 129);
            this.rubbonItems.TabIndex = 1;
            this.rubbonItems.Tabs.Add(this.tbAcciones);
            this.rubbonItems.Text = "ribbon1";
            // 
            // tbAcciones
            // 
            this.tbAcciones.Name = "tbAcciones";
            this.tbAcciones.Panels.Add(this.pnlAdd);
            this.tbAcciones.Panels.Add(this.pnlDelete);
            this.tbAcciones.Panels.Add(this.pnlExit);
            this.tbAcciones.Text = "Acciones";
            // 
            // pnlAdd
            // 
            this.pnlAdd.ButtonMoreEnabled = false;
            this.pnlAdd.ButtonMoreVisible = false;
            this.pnlAdd.Items.Add(this.rbAdd);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Text = "Nuevo";
            // 
            // rbAdd
            // 
            this.rbAdd.Image = global::InventarioFacil.UI.Properties.Resources.add_48;
            this.rbAdd.LargeImage = global::InventarioFacil.UI.Properties.Resources.add_48;
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbAdd.SmallImage")));
            this.rbAdd.Click += new System.EventHandler(this.rbAdd_Click);
            // 
            // pnlDelete
            // 
            this.pnlDelete.ButtonMoreEnabled = false;
            this.pnlDelete.ButtonMoreVisible = false;
            this.pnlDelete.Items.Add(this.rbDelete);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Text = "Borrar";
            // 
            // rbDelete
            // 
            this.rbDelete.Image = global::InventarioFacil.UI.Properties.Resources.delete48;
            this.rbDelete.LargeImage = global::InventarioFacil.UI.Properties.Resources.delete48;
            this.rbDelete.Name = "rbDelete";
            this.rbDelete.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbDelete.SmallImage")));
            this.rbDelete.Click += new System.EventHandler(this.rbDelete_Click);
            // 
            // pnlExit
            // 
            this.pnlExit.ButtonMoreEnabled = false;
            this.pnlExit.ButtonMoreVisible = false;
            this.pnlExit.Items.Add(this.rbExit);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Text = "Salir";
            // 
            // rbExit
            // 
            this.rbExit.Image = global::InventarioFacil.UI.Properties.Resources.log_out48;
            this.rbExit.LargeImage = global::InventarioFacil.UI.Properties.Resources.log_out48;
            this.rbExit.Name = "rbExit";
            this.rbExit.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbExit.SmallImage")));
            this.rbExit.Click += new System.EventHandler(this.rbExit_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 129);
            this.dgvData.Margin = new System.Windows.Forms.Padding(2);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(971, 324);
            this.dgvData.TabIndex = 2;
            this.dgvData.DoubleClick += new System.EventHandler(this.dgvData_DoubleClick);
            // 
            // frmWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 453);
            this.ControlBox = false;
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.rubbonItems);
            this.KeyPreview = true;
            this.Name = "frmWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Almacenes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon rubbonItems;
        private System.Windows.Forms.RibbonTab tbAcciones;
        private System.Windows.Forms.RibbonPanel pnlAdd;
        private System.Windows.Forms.RibbonButton rbAdd;
        private System.Windows.Forms.RibbonPanel pnlDelete;
        private System.Windows.Forms.RibbonButton rbDelete;
        private System.Windows.Forms.RibbonPanel pnlExit;
        private System.Windows.Forms.RibbonButton rbExit;
        private System.Windows.Forms.DataGridView dgvData;
    }
}