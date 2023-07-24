using InventarioFacil.Common;
using InventarioFacil.DAL.DBServices;
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
    public partial class frmWarehouseDetail : Form
    {
        public frmWarehouseDetail()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe introducir una descripción");
                return;
            }

            OperationResult result;
            if (GlobalData.TipoEdicion == TipoAccion.Alta)
                result = new CatalogsDA().AddNewWarehouse(int.Parse(txtAlmacen.Text), txtDescripcion.Text);
            else
                result = new CatalogsDA().UpdateWarehouse(int.Parse(txtAlmacen.Text), txtDescripcion.Text);

            if (result.ResultId != 200)
            {
                MessageBox.Show("Error al guardar el registro: " + result.Message);
                return;
            }

            MessageBox.Show("Registro guardado correctamente.");
            GlobalData.ReloadGrid = true;

            this.Close();
        }

        public void SetNewId()
        {
            var strQuery = "select COALESCE(MAX(id), 0) + 1   from warehouse";
            string message = string.Empty;
            var maxId = new MetodosGenerales().RegresaCampoNumerico(strQuery, ref message);
            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Ocurrió un error: " + message);
                return;
            }
            txtAlmacen.Text = maxId.ToString(); 
        }

        private void frmWarehouseDetail_Load(object sender, EventArgs e)
        {
            if(GlobalData.TipoEdicion == TipoAccion.Alta)
                SetNewId();
        }
    }
}
