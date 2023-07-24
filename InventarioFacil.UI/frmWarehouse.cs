using InventarioFacil.Common;
using InventarioFacil.DAL.DBServices;
using InventarioFacil.Domain;
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
    public partial class frmWarehouse : Form
    {
        private string strQuery;
        BindingSource bs = new BindingSource();
        DataView dv = new DataView();
        public frmWarehouse()
        {
            InitializeComponent();
        }

        #region Methods
        private void LoadData()
        {
            try
            {
                if (!GlobalData.ReloadGrid)
                    return;

                this.Cursor = Cursors.WaitCursor;
                strQuery = "Select * from warehouse";
                var data = new CatalogsDA().GetCatalogList(strQuery);
                bs.DataSource = null;
                bs.DataSource = data;
                dgvData.DataSource = bs;
                this.Cursor = Cursors.Default;
            }
            catch(Exception ex) 
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Ha ocurrido el siguiente error: " + ex.Message);
            }
            
        }
        #endregion

        private void frmWarehouse_Load(object sender, EventArgs e)
        {
            GlobalData.ReloadGrid = true;
            LoadData();
        }

        private void rbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbAdd_Click(object sender, EventArgs e)
        {
            GlobalData.TipoEdicion = TipoAccion.Alta;
            var frmChild = new frmWarehouseDetail();    
            frmChild.ShowDialog();
            LoadData();
        }

        private void rbDelete_Click(object sender, EventArgs e)
        {
            if(dgvData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro.");
                return;
            }
        }

        private void dgvData_DoubleClick(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                GlobalData.TipoEdicion = TipoAccion.Cambio;
                var rowIndex = dgvData.SelectedRows[0];

                var id = rowIndex.Cells[0].Value.ToString();
                var description = rowIndex.Cells[1].Value.ToString();
                var frmChild = new frmWarehouseDetail();
                frmChild.txtAlmacen.Text = id;
                frmChild.txtDescripcion.Text = description;
                frmChild.ShowDialog();
                LoadData();
            }
        }
    }
}
