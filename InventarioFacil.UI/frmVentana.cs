using InventarioFacil.DAL.DBServices;
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

namespace InventarioFacil
{
    public partial class frmVentana : Form
    {
        string regresaDato;
        internal string strQuery;
        BindingSource bs = new BindingSource();
        int x;
        DataView dv;

        public frmVentana()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVentana_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (this.Text.ToUpper() == "ARTICULOS")
                this.WindowState = FormWindowState.Maximized;

            LoadData();

            Cursor.Current = Cursors.Default;
        }

        #region Methods
        internal string RegresaDato()
        {
            return regresaDato;
        }

        void LoadData()
        {
            try
            {
                DataTable dt;
                string message = string.Empty;
                dt = new MetodosGenerales().ReturnDataTable(strQuery, ref message);
                dv = new DataView(dt);

                bs.DataSource = dv;
                FillGrid();

                x = 0;
                while (x <= dt.Columns.Count - 1)
                {
                    cboSearchFields.Items.Add(dt.Columns[x].Caption);
                    x += 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillGrid() {
            gvVentana.DataSource = bs;

            foreach (DataGridViewColumn column in gvVentana.Columns)
            {
                gvVentana.Columns[column.Name].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        #endregion

        private void gvVentana_DoubleClick(object sender, EventArgs e)
        {
            regresaDato = gvVentana.CurrentRow.Cells[0].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchText.Text) || string.IsNullOrEmpty(cboSearchFields.Text))
            {
                MessageBox.Show("Debe llenar los campos de búsqueda.");
                return;
            }

            dv.RowFilter = cboSearchFields.Text+ " LIKE '%" + txtSearchText.Text + "%'";
            gvVentana.Refresh();
        }
    }
}
