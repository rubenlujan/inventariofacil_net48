namespace InventarioFacil
{
    partial class frmVentana
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
            this.c1Ribbon1 = new C1.Win.C1Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.C1Ribbon.RibbonApplicationMenu();
            this.bottomBar = new C1.Win.C1Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.C1Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.C1Ribbon.RibbonQat();
            this.ribbonTab1 = new C1.Win.C1Ribbon.RibbonTab();
            this.rgActions = new C1.Win.C1Ribbon.RibbonGroup();
            this.btnNew = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonSeparator1 = new C1.Win.C1Ribbon.RibbonSeparator();
            this.rgSearch = new C1.Win.C1Ribbon.RibbonGroup();
            this.tbSearch = new C1.Win.C1Ribbon.RibbonToolBar();
            this.ribbonLabel1 = new C1.Win.C1Ribbon.RibbonLabel();
            this.cboSearchFields = new C1.Win.C1Ribbon.RibbonComboBox();
            this.ribbonLabel2 = new C1.Win.C1Ribbon.RibbonLabel();
            this.txtSearchText = new C1.Win.C1Ribbon.RibbonTextBox();
            this.ribbonButton2 = new C1.Win.C1Ribbon.RibbonButton();
            this.rgExit = new C1.Win.C1Ribbon.RibbonGroup();
            this.btnExit = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonTopToolBar1 = new C1.Win.C1Ribbon.RibbonTopToolBar();
            this.gvVentana = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentana)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.BottomToolBarHolder = this.bottomBar;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(800, 132);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
            this.c1Ribbon1.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2010Blue;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Appearance = C1.Win.C1Ribbon.AppMenuAppearance.Compact;
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            this.ribbonApplicationMenu1.Visible = false;
            // 
            // bottomBar
            // 
            this.bottomBar.Name = "bottomBar";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            this.ribbonQat1.Visible = false;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Groups.Add(this.rgActions);
            this.ribbonTab1.Groups.Add(this.rgSearch);
            this.ribbonTab1.Groups.Add(this.rgExit);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Acciones";
            // 
            // rgActions
            // 
            this.rgActions.CanBeAddedToQat = false;
            this.rgActions.Items.Add(this.btnNew);
            this.rgActions.Items.Add(this.ribbonSeparator1);
            this.rgActions.Name = "rgActions";
            this.rgActions.Text = "Nuevo";
            // 
            // btnNew
            // 
            this.btnNew.CanBeAddedToQat = false;
            this.btnNew.LargeImage = global::InventarioFacil.Properties.Resources.anadir_48;
            this.btnNew.Name = "btnNew";
            this.btnNew.SupportedGroupSizing = C1.Win.C1Ribbon.SupportedGroupSizing.LargeImageOnly;
            this.btnNew.TextImageRelation = C1.Win.C1Ribbon.TextImageRelation.ImageBeforeText;
            // 
            // ribbonSeparator1
            // 
            this.ribbonSeparator1.Name = "ribbonSeparator1";
            // 
            // rgSearch
            // 
            this.rgSearch.Items.Add(this.tbSearch);
            this.rgSearch.Name = "rgSearch";
            this.rgSearch.Text = "Búsqueda";
            // 
            // tbSearch
            // 
            this.tbSearch.Items.Add(this.ribbonLabel1);
            this.tbSearch.Items.Add(this.cboSearchFields);
            this.tbSearch.Items.Add(this.ribbonLabel2);
            this.tbSearch.Items.Add(this.txtSearchText);
            this.tbSearch.Items.Add(this.ribbonButton2);
            this.tbSearch.Name = "tbSearch";
            // 
            // ribbonLabel1
            // 
            this.ribbonLabel1.Name = "ribbonLabel1";
            this.ribbonLabel1.Text = "Buscar en";
            // 
            // cboSearchFields
            // 
            this.cboSearchFields.Name = "cboSearchFields";
            // 
            // ribbonLabel2
            // 
            this.ribbonLabel2.Name = "ribbonLabel2";
            this.ribbonLabel2.Text = "el texto:";
            // 
            // txtSearchText
            // 
            this.txtSearchText.Name = "txtSearchText";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.SmallImage = global::InventarioFacil.Properties.Resources.search;
            this.ribbonButton2.Click += new System.EventHandler(this.ribbonButton2_Click);
            // 
            // rgExit
            // 
            this.rgExit.Items.Add(this.btnExit);
            this.rgExit.Name = "rgExit";
            this.rgExit.Text = "Salir";
            // 
            // btnExit
            // 
            this.btnExit.LargeImage = global::InventarioFacil.Properties.Resources.log_out48;
            this.btnExit.Name = "btnExit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // gvVentana
            // 
            this.gvVentana.AllowUserToAddRows = false;
            this.gvVentana.AllowUserToDeleteRows = false;
            this.gvVentana.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gvVentana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVentana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvVentana.Location = new System.Drawing.Point(0, 132);
            this.gvVentana.Name = "gvVentana";
            this.gvVentana.ReadOnly = true;
            this.gvVentana.Size = new System.Drawing.Size(800, 318);
            this.gvVentana.TabIndex = 9;
            this.gvVentana.DoubleClick += new System.EventHandler(this.gvVentana_DoubleClick);
            // 
            // frmVentana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.gvVentana);
            this.Controls.Add(this.c1Ribbon1);
            this.Name = "frmVentana";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Ventana";
            this.Load += new System.EventHandler(this.frmVentana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.C1Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.C1Ribbon.RibbonBottomToolBar bottomBar;
        private C1.Win.C1Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.C1Ribbon.RibbonQat ribbonQat1;
        private C1.Win.C1Ribbon.RibbonTab ribbonTab1;
        private C1.Win.C1Ribbon.RibbonGroup rgActions;
        private C1.Win.C1Ribbon.RibbonButton btnNew;
        private C1.Win.C1Ribbon.RibbonSeparator ribbonSeparator1;
        private C1.Win.C1Ribbon.RibbonGroup rgSearch;
        private C1.Win.C1Ribbon.RibbonToolBar tbSearch;
        private C1.Win.C1Ribbon.RibbonLabel ribbonLabel1;
        private C1.Win.C1Ribbon.RibbonComboBox cboSearchFields;
        private C1.Win.C1Ribbon.RibbonLabel ribbonLabel2;
        private C1.Win.C1Ribbon.RibbonTextBox txtSearchText;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton2;
        private C1.Win.C1Ribbon.RibbonGroup rgExit;
        private C1.Win.C1Ribbon.RibbonButton btnExit;
        private C1.Win.C1Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private System.Windows.Forms.DataGridView gvVentana;
    }
}