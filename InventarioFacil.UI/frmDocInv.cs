using InventarioFacil.Common;
using InventarioFacil.DAL.DBServices;
using InventarioFacil.DAL.DBServices.Entities;
using InventarioFacil.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InventarioFacil
{
    public partial class frmDocInv : Form
    {
        BindingSource bs = new BindingSource();
        int position = 0;
        DataTable dt = new DataTable();
        DataView dv = new DataView();

        public frmDocInv()
        {
            InitializeComponent();
        }
        #region Methods
        private void LoadData()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (!GlobalData.ReloadGrid)
                    return;

                this.Cursor = Cursors.WaitCursor;
                var data = new DocInvDA().GetDocInvList();
                dv = CreateDataView(data);
                bs.DataSource = null;
                bs.DataSource = dv;
                FillDataGrid();
                bs.Position = position <= bs.Count ? position : bs.Position;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
            GlobalData.ReloadGrid = false;
        }

        private DataView CreateDataView(List<DocInvList> data)
        {
            DocInvList docinvCols = new DocInvList();
            PropertyInfo[] propiedades = docinvCols.GetType().GetProperties();
            dt = new DataTable();
            foreach (PropertyInfo propiedad in propiedades)
            {
                dt.Columns.Add(propiedad.Name);
            }
           

            foreach (DocInvList item in data)
            {
                dt.Rows.Add(item.Almacen, item.Concepto, item.NumDoc, item.Fecha, item.Status, item.Cliente, item.Proveedor, item.Notas);
            }
            return new DataView(dt);
        }

        private void FillDataGrid()
        {
            dgvData.DataSource = bs;

            foreach (DataGridViewColumn column in dgvData.Columns)
            {
                dgvData.Columns[column.Name].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            this.Cursor = Cursors.Default;

        }

        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDocInv_Load(object sender, EventArgs e)
        {
            GlobalData.ReloadGrid = true;
            dv.AllowEdit = false;
            dv.AllowNew = false;
            dv.AllowDelete = false;
            LoadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmDocMov frmDMov = new frmDocMov();
            GlobalData.TipoEdicion = TipoAccion.Alta;
            //actRecord = bs.Count;
            if (frmDMov.ShowDialog() == DialogResult.OK)
                return;
            //    CargaDatos(true);
        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
