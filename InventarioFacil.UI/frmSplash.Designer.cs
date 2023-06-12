namespace InventarioFacil.UI
{
    partial class frmSplash
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
            this.lblInicio = new System.Windows.Forms.Label();
            this.cpBar = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.White;
            this.lblInicio.Location = new System.Drawing.Point(45, 79);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(253, 37);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Iniciando Sesión";
            // 
            // cpBar
            // 
            this.cpBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpBar.AnimationSpeed = 500;
            this.cpBar.BackColor = System.Drawing.Color.Transparent;
            this.cpBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.cpBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpBar.InnerMargin = 2;
            this.cpBar.InnerWidth = -1;
            this.cpBar.Location = new System.Drawing.Point(64, 187);
            this.cpBar.MarqueeAnimationSpeed = 2000;
            this.cpBar.Name = "cpBar";
            this.cpBar.OuterColor = System.Drawing.Color.Gray;
            this.cpBar.OuterMargin = -25;
            this.cpBar.OuterWidth = 26;
            this.cpBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpBar.ProgressWidth = 15;
            this.cpBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cpBar.Size = new System.Drawing.Size(200, 200);
            this.cpBar.StartAngle = 270;
            this.cpBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.cpBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpBar.SubscriptText = "";
            this.cpBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpBar.SuperscriptText = "%";
            this.cpBar.TabIndex = 1;
            this.cpBar.Text = "0";
            this.cpBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpBar.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(350, 567);
            this.ControlBox = false;
            this.Controls.Add(this.cpBar);
            this.Controls.Add(this.lblInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplash";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicio;
        private CircularProgressBar.CircularProgressBar cpBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}