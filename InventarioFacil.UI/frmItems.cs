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
    public partial class frmItems : Form
    {
        BindingSource bs = new BindingSource();

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
            CargaDatos();
        }

        #region "Methods"
        private void CargaDatos()
        {
            try
            {
                var data = new ItemModel().GetItemList();
                bs.DataSource = null;
                bs.DataSource = data;
                dgvItems.DataSource = bs;
                    
                dgvItems.Columns[3].Width = 300;
                dgvItems.Columns[5].Width = 150;
                dgvItems.Columns[9].Visible = false;
                dgvItems.Columns[10].Visible = false;
                dgvItems.Columns[6].DefaultCellStyle.Format = "c2";
                dgvItems.Columns[7].DefaultCellStyle.Format = "c2";
                dgvItems.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvItems.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvItems.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        #endregion

        private void dgvItems_DoubleClick(object sender, EventArgs e)
        {
            frmItemsDetail frmItemsDetail = new frmItemsDetail();
            frmItemsDetail.itemId = Convert.ToInt16(dgvItems.SelectedCells[0].Value.ToString());
            frmItemsDetail.ShowDialog();    
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmItemsDetail frmItemsDetail = new frmItemsDetail();
            frmItemsDetail.itemId = 0;
            frmItemsDetail.ShowDialog();
        }
    }
}
