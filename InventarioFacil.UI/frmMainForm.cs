using InventarioFacil.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioFacil.UI
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            lblName.Text = ActiveUser.UserCompleteName;
            lblRolName.Text = ActiveUser.UserRolName;

            if(ActiveUser.UserRolId != 1)
                btnUsers.Visible = false;   

            ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnCatalogos, "Catálogos");
            ToolTip1.SetToolTip(this.btnMovimientos, "Movimientos al inventario");
            ToolTip1.SetToolTip(this.btnInvFisico, "Inventario Físico");
            ToolTip1.SetToolTip(this.btnLogout, "Salir del sistema");
            ToolTip1.SetToolTip(this.btnReportes, "Reportes");
            ToolTip1.SetToolTip(this.btnUsers, "Usuarios");
        }

        #region "Clicks"
        private void btnLogout_Click(object sender, EventArgs e)
        {
            CloseApp();
        }

        private void btnSideMenu_Click(object sender, EventArgs e)
        {
            SlideMenu();
        }

        private void btnCatalogos_Click(object sender, EventArgs e)
        {
            if (panelCatalogosSubMenu.Visible)
                panelCatalogosSubMenu.Visible = false;
            else
            {
                panelCatalogosSubMenu.Visible = true;
                if (btnCatalogos.Text == string.Empty)
                    SlideMenu();
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmUsers());
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmItems());
        }
        #endregion

        #region "Metodos"
        protected void CloseApp()
        {
            if (MessageBox.Show("¿Está seguro de cerrar la aplicación?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();//Cierra toda la aplicación finalizando todos los procesos.
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelClientArea.Controls.Add(childForm);
            PanelClientArea.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        #region "SlideMenu"
        private void SlideMenu()
        {
            if (panelSideMenu.Width > 100)
            {
                HideSubmenus();
                panelSideMenu.Width = 70; // 52;
                foreach (Control control in panelMenuHeader.Controls)
                {
                    if (control != btnSideMenu)
                        control.Visible = false;
                }
            }
            else
            {
                panelSideMenu.Width = 230;
                foreach (Control control in panelMenuHeader.Controls)
                {
                    control.Visible = true;
                }
                ShowMenu();
            }
        }

        private void HideSubmenus()
        {
            foreach (Control control in panelSideMenu.Controls)
            {
                if (control.Tag != null && control.Tag.ToString().Contains("sub"))
                    control.Visible = false;
                else if (control.Tag != null && control.Tag.ToString().Contains("bmenu"))
                    control.Text = string.Empty;
            }
        }

        private void ShowMenu()
        {
            btnCatalogos.Text = "  Catálogos";
            btnMovimientos.Text = "  Movimientos";
            btnInvFisico.Text = " Inventario Físico";
            btnUsers.Text = "  Usuarios";
            btnReportes.Text = "  Reportes";
            btnLogout.Text = " Cerrar sesión";
        }



        #endregion|

       
    }
}
