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

namespace InventarioFacil
{
    public partial class frmDocTypeDetail : Form
    {
        public frmDocTypeDetail()
        {
            InitializeComponent();
        }
        #region Methods
        public void SetCombo(string doctype)
        {
            if (doctype == "E")
                cboType.Text = "Entrada";
            else
                cboType.Text = "Salida";
        }

        private void SetNewId()
        {
            var strQuery = "select COALESCE(MAX(convert(id, SIGNED)), 0) + 1   from doctypes";
            string message = string.Empty;
            var maxId = new MetodosGenerales().RegresaCampoNumerico(strQuery, ref message);
            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Ocurrió un error: " + message);
                return;
            }
            txtConcepto.Text = maxId.ToString("00");
            cboType.Enabled = true;
            txtConcepto.Focus();
        }

        private OperationResult AddNewDocType()
        {
            var type = cboType.Text.Substring(0, 1);
            return new DocTypesDA().AddNewDocType(txtConcepto.Text, txtDescripcion.Text, type);
        }

        private OperationResult UpdateDocType()
        {
            return new DocTypesDA().UpdateDocType(txtConcepto.Text, txtDescripcion.Text);
        }
        #endregion
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtDescripcion.Text) || cboType.Text == "") 
            {
                MessageBox.Show("Debe llenar todos los datos.");
                return;
            }
            this.Cursor = Cursors.WaitCursor;
            OperationResult result;
            if(GlobalData.TipoEdicion == TipoAccion.Alta)
                result = AddNewDocType();
            else
                result = UpdateDocType();

            this.Cursor = Cursors.Default;
            if (result.ResultId == 200)
            {
                MessageBox.Show("Registro guardado.");
                GlobalData.ReloadGrid = true;
                this.Close();
            }
            else
                MessageBox.Show("Ocurrió un error:" + result.Message);
        }

        private void frmDocTypeDetail_Load(object sender, EventArgs e)
        {
            if(GlobalData.TipoEdicion == TipoAccion.Alta)
                SetNewId(); 
        }
    }
}
