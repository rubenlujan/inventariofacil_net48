namespace InventarioFacil
{
    partial class frmDocInv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocInv));
            this.c1Ribbon1 = new C1.Win.C1Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.C1Ribbon.RibbonApplicationMenu();
            this.bottomBar = new C1.Win.C1Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.C1Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.C1Ribbon.RibbonQat();
            this.ribbonTab1 = new C1.Win.C1Ribbon.RibbonTab();
            this.rgActions = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonTopToolBar1 = new C1.Win.C1Ribbon.RibbonTopToolBar();
            this.btnNew = new C1.Win.C1Ribbon.RibbonButton();
            this.btnPrint = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonSeparator1 = new C1.Win.C1Ribbon.RibbonSeparator();
            this.rgReports = new C1.Win.C1Ribbon.RibbonGroup();
            this.btnHMovs = new C1.Win.C1Ribbon.RibbonButton();
            this.btnInvCost = new C1.Win.C1Ribbon.RibbonButton();
            this.btnInvAlm = new C1.Win.C1Ribbon.RibbonButton();
            this.rgSearch = new C1.Win.C1Ribbon.RibbonGroup();
            this.tbSearch = new C1.Win.C1Ribbon.RibbonToolBar();
            this.ribbonLabel1 = new C1.Win.C1Ribbon.RibbonLabel();
            this.cboFields = new C1.Win.C1Ribbon.RibbonComboBox();
            this.ribbonLabel2 = new C1.Win.C1Ribbon.RibbonLabel();
            this.txtSearchText = new C1.Win.C1Ribbon.RibbonTextBox();
            this.ribbonButton2 = new C1.Win.C1Ribbon.RibbonButton();
            this.rgExit = new C1.Win.C1Ribbon.RibbonGroup();
            this.btnExit = new C1.Win.C1Ribbon.RibbonButton();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
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
            this.c1Ribbon1.Size = new System.Drawing.Size(1069, 132);
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
            this.ribbonTab1.Groups.Add(this.rgReports);
            this.ribbonTab1.Groups.Add(this.rgExit);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Acciones";
            // 
            // rgActions
            // 
            this.rgActions.CanBeAddedToQat = false;
            this.rgActions.Items.Add(this.btnNew);
            this.rgActions.Items.Add(this.ribbonSeparator1);
            this.rgActions.Items.Add(this.btnPrint);
            this.rgActions.Name = "rgActions";
            this.rgActions.Text = "Procesos";
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // btnNew
            // 
            this.btnNew.CanBeAddedToQat = false;
            this.btnNew.LargeImage = global::InventarioFacil.Properties.Resources.anadir_48;
            this.btnNew.Name = "btnNew";
            this.btnNew.SupportedGroupSizing = C1.Win.C1Ribbon.SupportedGroupSizing.LargeImageOnly;
            this.btnNew.Text = "Nuevo";
            // 
            // btnPrint
            // 
            this.btnPrint.LargeImage = global::InventarioFacil.Properties.Resources.impresora;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.SmallImage")));
            this.btnPrint.Text = "Imprimir";
            // 
            // ribbonSeparator1
            // 
            this.ribbonSeparator1.Name = "ribbonSeparator1";
            // 
            // rgReports
            // 
            this.rgReports.Items.Add(this.btnHMovs);
            this.rgReports.Items.Add(this.btnInvCost);
            this.rgReports.Items.Add(this.btnInvAlm);
            this.rgReports.Name = "rgReports";
            this.rgReports.Text = "Reportes";
            // 
            // btnHMovs
            // 
            this.btnHMovs.Name = "btnHMovs";
            this.btnHMovs.SmallImage = global::InventarioFacil.Properties.Resources.reports32;
            this.btnHMovs.Text = "Historial de Movimientos";
            // 
            // btnInvCost
            // 
            this.btnInvCost.Name = "btnInvCost";
            this.btnInvCost.SmallImage = global::InventarioFacil.Properties.Resources.reports32;
            this.btnInvCost.Text = "Inventario Costeado";
            // 
            // btnInvAlm
            // 
            this.btnInvAlm.Name = "btnInvAlm";
            this.btnInvAlm.SmallImage = global::InventarioFacil.Properties.Resources.reports32;
            this.btnInvAlm.Text = "Inventario por Almacén";
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
            this.tbSearch.Items.Add(this.cboFields);
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
            // cboFields
            // 
            this.cboFields.Name = "cboFields";
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
            // frmDocInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 572);
            this.ControlBox = false;
            this.Controls.Add(this.c1Ribbon1);
            this.Name = "frmDocInv";
            this.Text = "Movimientos al inventario";
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
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
        private C1.Win.C1Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.C1Ribbon.RibbonButton btnNew;
        private C1.Win.C1Ribbon.RibbonButton btnPrint;
        private C1.Win.C1Ribbon.RibbonSeparator ribbonSeparator1;
        private C1.Win.C1Ribbon.RibbonGroup rgReports;
        private C1.Win.C1Ribbon.RibbonButton btnHMovs;
        private C1.Win.C1Ribbon.RibbonButton btnInvCost;
        private C1.Win.C1Ribbon.RibbonButton btnInvAlm;
        private C1.Win.C1Ribbon.RibbonGroup rgSearch;
        private C1.Win.C1Ribbon.RibbonToolBar tbSearch;
        private C1.Win.C1Ribbon.RibbonLabel ribbonLabel1;
        private C1.Win.C1Ribbon.RibbonComboBox cboFields;
        private C1.Win.C1Ribbon.RibbonLabel ribbonLabel2;
        private C1.Win.C1Ribbon.RibbonTextBox txtSearchText;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton2;
        private C1.Win.C1Ribbon.RibbonGroup rgExit;
        private C1.Win.C1Ribbon.RibbonButton btnExit;
    }
}