namespace InventarioFacil.UI
{
    partial class frmCategories
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
            this.rubbonItems = new System.Windows.Forms.Ribbon();
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
            this.rubbonItems.Size = new System.Drawing.Size(800, 129);
            this.rubbonItems.TabIndex = 2;
            this.rubbonItems.Text = "ribbon1";
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.rubbonItems);
            this.KeyPreview = true;
            this.Name = "frmCategories";
            this.Text = "frmCategories";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon rubbonItems;
    }
}