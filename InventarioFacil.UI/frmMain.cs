using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioFacil
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ShowForm("InventarioFacil.frmItems",1);
        }

        private void ShowForm(string forma, int source)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType().ToString() == forma)
                {
                    f.Show();
                    f.Focus();
                    return;
                }
            }
            Type t = Type.GetType(forma, true);
            Form newForm = (Form)Activator.CreateInstance(t, true);
            newForm.MdiParent = this;
            newForm.Show();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar la aplicación?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();//Cierra toda la aplicación finalizando todos los procesos.
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            ShowForm("InventarioFacil.frmItems", 1  );
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            ShowForm("InventarioFacil.frmWarehouse", 1);
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            ShowForm("InventarioFacil.frmCategories", 1);
        }

        private void btnDocTypes_Click(object sender, EventArgs e)
        {
            ShowForm("InventarioFacil.frmDocTypes", 1);
        }

        private void btnMovs_Click(object sender, EventArgs e)
        {
            ShowForm("InventarioFacil.frmDocInv", 1);
        }

        private void btnFisicInventory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opción en desarrollo");
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opción en desarrollo");
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opción en desarrollo");
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opción en desarrollo");
        }
    }
}
