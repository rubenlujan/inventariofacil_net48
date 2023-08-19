using InventarioFacil.Common;
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
using InventarioFacil.DAL.DBServices.Entities;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace InventarioFacil
{
    public partial class frmItems : Form
    {
        BindingSource bs = new BindingSource();
        int position = 0;
        Dictionary<string, string> fieldNames = new Dictionary<string, string>();
        DataTable dt = new DataTable();
        DataView dv = new DataView();
        public frmItems()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            GlobalData.ReloadGrid = true;
            dv.AllowEdit = false;
            dv.AllowNew = false;
            dv.AllowDelete = false;
            LoadData();
        }

        #region "Methods"
        private void LoadData()
        {
            try
            {
                if (!GlobalData.ReloadGrid)
                    return;

                this.Cursor = Cursors.WaitCursor;
                var data = new ItemModel().GetItemList();
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
            GlobalData.ReloadGrid = false;
        }

        private DataView CreateDataView(List<Item> data)
        {
            dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("SKU");
            dt.Columns.Add("CodBar");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("UMed");
            dt.Columns.Add("Categoria");
            dt.Columns.Add("Precio_U", typeof(decimal));
            dt.Columns.Add("Costo_U", typeof(decimal));
            dt.Columns.Add("Existencia");
            dt.Columns.Add("Imagen");
            dt.Columns.Add("Notas");
            dt.Columns.Add("Status");

            foreach (Item item in data)
            {
                dt.Rows.Add(item.Id, item.SKU, item.CodBar, item.Descripcion, item.UMed, item.Categoria, item.Precio_U, item.Costo_U, item.Existencia, "", item.Notas, item.Status);
            }
            return new DataView(dt);
        }

        private void FillDataGrid()
        {
            dgvItems.DataSource = bs;

            foreach (DataGridViewColumn column in dgvItems.Columns)
            {
                dgvItems.Columns[column.Name].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dgvItems.Columns[3].Width = 300;
            dgvItems.Columns[5].Width = 150;
            dgvItems.Columns[9].Visible = false;
            dgvItems.Columns[10].Visible = false;
            dgvItems.Columns[6].DefaultCellStyle.Format = "c2";
            dgvItems.Columns[7].DefaultCellStyle.Format = "c2";
            dgvItems.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvItems.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvItems.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Cursor = Cursors.Default;

        }

        #endregion

        private void dgvItems_DoubleClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmItemsDetail frmItemsDetail = new frmItemsDetail();
            frmItemsDetail.itemId = Convert.ToInt16(dgvItems.SelectedCells[0].Value.ToString());
            position = bs.Position;
            frmItemsDetail.ShowDialog();
            LoadData();
            this.Cursor = Cursors.Default;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmItemsDetail frmItemsDetail = new frmItemsDetail();
            frmItemsDetail.itemId = 0;
            frmItemsDetail.tipoMovimiento = TipoAccion.Alta;
            frmItemsDetail.ShowDialog();
            LoadData(); 
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GlobalData.ReloadGrid = true;
            LoadData(); 
        }

        private void dgvItems_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtColumna.TextBoxText = dgvItems.Columns[e.ColumnIndex].Name;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dv.RowFilter = txtColumna.TextBoxText + " LIKE '%" + txtSearch.TextBoxText + "%'";
            dgvItems.Refresh();
            /*
            bsFilter.Filter = txtColumna.TextBoxText + " LIKE '%" + txtSearch.TextBoxText + "%'";
            bs.Filter = "SKU = '4'";
            var test = bs.SupportsFiltering;
            FillDataGrid();
            dgvItems.Refresh(); */
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Guardar archivo CSV";
            saveFileDialog.FileName = "articulos.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string nombreArchivo = saveFileDialog.FileName;
                string directorio = Path.GetDirectoryName(nombreArchivo);
                try
                {
                    // Crear el archivo CSV y escribir los datos del DataTable
                    using (StreamWriter sw = new StreamWriter(nombreArchivo, false, Encoding.UTF8))
                    {
                        // Escribir los encabezados de las columnas
                        foreach (DataColumn columna in dv.Table.Columns)
                        {
                            sw.Write(columna.ColumnName);
                            sw.Write(",");
                        }
                        sw.WriteLine();

                        // Escribir los datos de las filas
                        foreach (DataRowView fila in dv)
                        {
                            foreach (object valor in fila.Row.ItemArray)
                            {
                                sw.Write(valor.ToString());
                                sw.Write(",");
                            }
                            sw.WriteLine();
                        }
                    }

                    MessageBox.Show("Archivo CSV creado exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear el archivo CSV: " + ex.Message);
                }
            }
        }
    }
}
