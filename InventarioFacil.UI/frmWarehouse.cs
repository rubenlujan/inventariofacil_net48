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

namespace InventarioFacil
{
    public partial class frmWarehouse : Form
    {
        private string strQuery;
        BindingSource bs = new BindingSource();
        DataView dv = new DataView();
        int actualPos = 0;
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
                bs.Position = actualPos;
                this.Cursor = Cursors.Default;
            }
            catch(Exception ex) 
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Ha ocurrido el siguiente error: " + ex.Message);
            }
            
        }

        private void DeleteRecord()
        {
            OperationResult result = new OperationResult();
            var rowIndex = dgvData.SelectedRows[0];
            var description = rowIndex.Cells[1].Value.ToString();
            actualPos = rowIndex.Index;
            if (MessageBox.Show(String.Format("¿Desea borrar el almacen {0} ?", description), "Borrar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Cursor = Cursors.WaitCursor;
                var id = int.Parse(rowIndex.Cells[0].Value.ToString());
                result = new CatalogsDA().DeleteWarehouse(id);
                this.Cursor = Cursors.Default;
                var message = result.ResultId == 200 ? "Registro borrado" : "Error al borrar el registro: " + result.Message;
                MessageBox.Show(message);
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
            DeleteRecord();
            LoadData();
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
