using Infragistics.Win.Layout;
using InventarioFacil.Common;
using InventarioFacil.DAL.DBServices;
using InventarioFacil.DAL.DBServices.Entities;
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
    public partial class frmDocMov : Form
    {
        string strQuery;
        string message;
        public DocInv docinvEntity;

        public frmDocMov()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NewRecord();
        }

        #region Methods

        private void FillCombo()
        {
            message = string.Empty;
            strQuery = "Select Id, Description FROM warehouse";
            var warehouses = new MetodosGenerales().RegresaCatalogoCombo(strQuery, ref message);
            SetComboData(cboAlmacen, warehouses);
        }

        private void SetComboData<T>(ComboBox comboControl, List<T> listData)
        {
            comboControl.ValueMember = "Value";
            comboControl.DisplayMember = "Description";
            comboControl.DataSource = listData;
        }

        private void NewRecord()
        {
            GlobalData.TipoEdicion = TipoAccion.Alta;
            docinvEntity = new DocInv(); 
            gvArticulos.Rows.Clear();
            ClearFields();
            EnabledButtons(false);
            EnabledFields(true);
            txtConcepto.Focus();
        }

        private void ClearFields()
        {
            foreach (Control control in this.gpMain.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                    control.Text = string.Empty;
            }
            txtCostoU.Text = "0";
            txtPrecioU.Text = "0";
            txtStatus.Text = "PENDIENTE";
            lblConcepto.Text = "";
        }

        private void EnabledFields(bool enabled)
        {
            foreach (Control control in this.gpMain.Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == "input")
                    control.Enabled = enabled;
            }
            dtFecha.Enabled = enabled;
            cboAlmacen.Enabled = GlobalData.TipoEdicion == TipoAccion.Alta;
            txtConcepto.Enabled = string.IsNullOrEmpty(txtConcepto.Text);
        }

        private void EnabledButtons(bool bEnable)
        {
            btnNuevo.Enabled = bEnable;
            btnEditar.Enabled = bEnable;
            btnBorrar.Enabled = bEnable;
            btnSalir.Enabled = bEnable;

            if (!bEnable)
            {
                btnGrabar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
                btnCancelar.Enabled = false;
            }
            if(txtStatus.Text == "ACTUALIZA" || txtStatus.Text == "CANCELADO")
            {
                btnCancel.Enabled = txtStatus.Text == "ACTUALIZA" ? true : false;   
                btnBorrar.Enabled = false;
                btnEditar.Enabled = false;
            } 
            else
            {
                btnCancel.Enabled = false;  
            }
        }

        private void FillDocInvEntity()
        {
            docinvEntity.warehouse = (int)cboAlmacen.SelectedValue;
            docinvEntity.doctype = txtConcepto.Text;
            docinvEntity.docnum = txtNumero.Text;
            docinvEntity.datemov = dtFecha.Value;
            docinvEntity.notes = "";
            docinvEntity.status = txtStatus.Text;
        }

        private OperationResult AddUpdateDocInv(DocInv diObject)
        {
            var result = new DocInvDA().AddUpdateDocInv(diObject);
            if(result.ResultId != 200)
            {
                MessageBox.Show("Ocurrió un error:" + result.Message);
            }
            return result;
        }

        private int ChecaExistencia(int cantidad, string codigo)
        {
            int regresa = cantidad;
            int existencia;
            message = string.Empty;

            strQuery = "SELECT Actual_Stock FROM itemsstock WHERE Item_Id=" + codigo + " and warehouse_id = " + cboAlmacen.SelectedValue;
            existencia = new MetodosGenerales().RegresaCampoNumerico(strQuery, ref message);
            if (cantidad > existencia)
            {
                MessageBox.Show("No hay existencia suficiente para cubrir la salida de este articulo.");
                regresa = 0;
            }
            return regresa;
        }

        private void ClearItems()
        {
            txtArticulo.Text = "";
            lblArticulo.Text = "";
            txtPrecioU.Text = "0";
            txtCostoU.Text = "0";   
            txtCantidad.Text = "";
        }

        private OperationResult CancelDocument()
        {
            DialogResult resp = MessageBox.Show("¿Desea cancelar el documento?", "?", MessageBoxButtons.YesNo);
            OperationResult result = new OperationResult();
            if (resp == DialogResult.Yes)
            {
                result = new DocInvDA().DocInvRes(docinvEntity);
                if (result.ResultId == 200)
                    txtStatus.Text = "CANCELADO";
                else
                    MessageBox.Show("Error:" + result.Message);

                return result;
            }
            return null; 

        }

        private void SaveData()
        {
            message = string.Empty;
            try
            {
                if (GlobalData.TipoEdicion != TipoAccion.Baja)
                {
                    var docinvDA = new DocInvDA();

                    docinvEntity.datemov = dtFecha.Value;
                    docinvEntity.notes = txtComentarios.Text;
                    docinvEntity.status = txtStatus.Text;
                    var result = docinvDA.AddUpdateDocInv(docinvEntity);

                    if (result.ResultId != 200)
                    {
                        MessageBox.Show("Error:" + result.Message);
                        return;
                    }
                    if(gvArticulos.Rows.Count > 0)
                    {
                        InsertItems();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido el siguiente error: " + ex.Message + ". Comuniquese con sistemas");
            }
            EnabledFields(false);
            EnabledButtons(true);   
            GlobalData.ReloadGrid = true;
        }
       
        private void InsertItems()
        {
            var docinvDA = new DocInvDA();
            var result = docinvDA.DeleteDocMov(docinvEntity);
            int cont = 0;
            while (cont <= gvArticulos.Rows.Count - 1)
            {
                var docmovEntity = new DocMov();
                docmovEntity.warehouse = docinvEntity.warehouse;
                docmovEntity.doctype = docinvEntity.doctype;
                docmovEntity.docnum = docinvEntity.docnum;
                docmovEntity.part = int.Parse(gvArticulos.Rows[cont].Cells[0].Value.ToString());
                docmovEntity.item_id = int.Parse(gvArticulos.Rows[cont].Cells[1].Value.ToString());
                docmovEntity.quantity = decimal.Parse(gvArticulos.Rows[cont].Cells[3].Value.ToString());
                docmovEntity.price_u = decimal.Parse(gvArticulos.Rows[cont].Cells[4].Value.ToString());
                docmovEntity.cost_u = decimal.Parse(gvArticulos.Rows[cont].Cells[5].Value.ToString());

                result = docinvDA.AddDocmov(docmovEntity);

                if (result.ResultId != 200)
                    MessageBox.Show("Error:" + result.Message);

                cont++;
            }

            DialogResult resp = MessageBox.Show("¿Desea actualizar el inventario?", "?", MessageBoxButtons.YesNo);
            if (resp == DialogResult.Yes)
            {
                result = docinvDA.DocInvAfe(docinvEntity);

                if (result.ResultId != 200)
                {
                    MessageBox.Show("Error:" + result.Message, "Error");
                }
                else
                {
                    MessageBox.Show("Registro actualizado");
                    txtStatus.Text = "ACTUALIZA";
                }
            }
        }
        
        private void LoadData()
        {
            if(docinvEntity != null)
            {
                cboAlmacen.Text = docinvEntity.warehouse_dsc;
                txtConcepto.Text = docinvEntity.doctype.ToString();
                txtNumero.Text = docinvEntity.docnum.ToString();
                dtFecha.Value = docinvEntity.datemov;
                txtComentarios.Text = docinvEntity.notes.ToString();
                txtStatus.Text = docinvEntity.status.ToString();
                GetItems();
                EnabledFields(false);
            }
            EnabledButtons(true);
        }

        private void GetItems()
        {
            var lstItems = new DocInvDA().GetDocMovDetail(docinvEntity);
            object[] Param = new object[6];
            foreach(DocMov item in lstItems)
            {
                Param[0] = item.part;
                Param[1] = item.item_id.ToString();
                Param[2] = item.item_dsc;
                Param[3] = item.quantity.ToString();    
                Param[4] = item.price_u.ToString();
                Param[5] = item.cost_u.ToString();
                gvArticulos.Rows.Add(Param);
            }
        }
        #endregion

        private void txtConcepto_Leave(object sender, EventArgs e)
        {
            if (txtConcepto.Text != "" && txtConcepto.Enabled)
            {
                message = String.Empty;

                strQuery = "SELECT description FROM doctypes WHERE id='" + txtConcepto.Text + "'";
                lblConcepto.Text = new MetodosGenerales().RegresaCampoAlfanumerico(strQuery, ref message);
                if (lblConcepto.Text == "")
                {
                    MessageBox.Show("No existe esta clave");
                    txtConcepto.Text = "";
                    txtConcepto.Focus();
                }
                else
                {
                    Int16 cons;
                    strQuery = "SELECT COALESCE(MAX(docnum), 0) + 1 FROM docinv WHERE warehouse='" + cboAlmacen.SelectedValue + "' AND doctype='" + txtConcepto.Text + "'";
                    cons = new MetodosGenerales().RegresaCampoNumerico(strQuery, ref message);
                    txtNumero.Text = cons.ToString("000000");
                    txtNumero.Enabled = false;
                    FillDocInvEntity();
                    var result = AddUpdateDocInv(docinvEntity);
                    if (result != null && result.ResultId == 200)
                    {
                        dtFecha.Focus();
                        gbItems.Enabled = true;
                        txtConcepto.Enabled = false;
                        cboAlmacen.Enabled = false;
                    }
                }
            }
        }

        private void frmDocMov_Load(object sender, EventArgs e)
        {
            FillCombo();

            if (GlobalData.TipoEdicion == TipoAccion.Alta)
                NewRecord();
            else
                LoadData();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(GlobalData.TipoEdicion == TipoAccion.Alta)
            {
                if (MessageBox.Show("¿Está seguro de cancelar la captura actual?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var result = new DocInvDA().DeleteDocInv(docinvEntity);
                    this.Close();
                }
                    
                
                //borrar registro
            }
            else
            {
                EnabledButtons(true);
                EnabledFields(false);
            }

/*            if (codAnterior == 0)
            {
                this.Close();
            }
            else
            {
                itemId = codAnterior;
                EnabledButtons(true);
                EnabledFields(false);
                GetDataItem();
            }*/
        }

        private void txtConcepto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                this.ProcessTabKey(true);
            }
        }

        private void btnConcepto_Click(object sender, EventArgs e)
        {
            if (txtConcepto.Enabled == false)
                return;

            strQuery = "SELECT id as Concepto, description as Descripcion,doctype as Tipo FROM doctypes Order BY id";
            Utilerias.OpenWindow(strQuery, txtConcepto, "Conceptos");
            txtNumero.Enabled = false;
            txtConcepto_Leave(sender, e);
        }

        private void btnArticulo_Click(object sender, EventArgs e)
        {
            strQuery = "SELECT Id,SKU, Descripcion, Stock as Existencia FROM items_data WHERE Status='Activo' ORDER BY Id";
            Utilerias.OpenWindow(strQuery, txtArticulo, "Articulos");
            txtArticulo_Leave(sender, e);
        }

        private void txtArticulo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArticulo.Text))
            {
                message = String.Empty;
                var rdr = new MetodosGenerales().ReturnDataReader("SELECT Id,Descripcion, Precio_U, Costo_U FROM items_data WHERE Id=" + txtArticulo.Text + " or SKU = '" + txtArticulo.Text + "' or codigobarras = '" + txtArticulo + "'", ref message);
                if (rdr.Read())
                {
                    txtArticulo.Text = rdr[0].ToString();
                    lblArticulo.Text = rdr[1].ToString();
                    txtPrecioU.Text = decimal.Parse(rdr[2].ToString()).ToString("N2");
                    txtCostoU.Text = decimal.Parse(rdr[3].ToString()).ToString("N2");
                    txtCantidad.Focus();
                }
                else
                {
                    MessageBox.Show("No existe esta clave");
                    txtArticulo.Text = "";
                    txtArticulo.Focus();
                }
                rdr.Close();
            }
            else
            {
                MessageBox.Show("Debe introducir un código");
                txtArticulo.Focus();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string tipo;
            int cant;
            message = String.Empty;

            if (string.IsNullOrEmpty(txtCantidad.Text) || int.Parse(txtCantidad.Text) == 0 || lblArticulo.Text.Length == 0)
            {
                MessageBox.Show("Complete todos los campos.");
                if (lblArticulo.Text.Length == 0 ? txtArticulo.Focus() : txtCantidad.Focus());

                return;
            }

            strQuery = "SELECT doctype FROM doctypes where id='" + txtConcepto.Text + "'";
            tipo = new MetodosGenerales().RegresaCampoAlfanumerico(strQuery, ref message);
            if(string.IsNullOrEmpty(tipo) ) {
                MessageBox.Show("El tipo de concepto " + lblConcepto.Text + " no tiene tipo definido.");
                return;
            }
            if (tipo == "S")
            {
                cant = ChecaExistencia(Convert.ToInt16(txtCantidad.Text), txtArticulo.Text);
                if (cant <= 0)
                    return;
            }
            else
                cant = Convert.ToInt16(txtCantidad.Text);

            object[] Param = new object[6];
            Param[0] = gvArticulos.Rows.Count + 1;
            Param[1] = txtArticulo.Text;
            Param[2] = lblArticulo.Text;
            Param[3] = cant;
            Param[4] = txtPrecioU.Text;
            Param[5] = txtCostoU.Text;

            gvArticulos.Rows.Add(Param);

            ClearItems();
            txtArticulo.Focus();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                this.ProcessTabKey(true);
            }
        }

        private void txtPrecioU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                this.ProcessTabKey(true);
            }
        }

        private void txtCostoU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                this.ProcessTabKey(true);
            }
        }

        private void txtArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                this.ProcessTabKey(true);
            }
        }

        private void gvArticulos_DoubleClick(object sender, EventArgs e)
        {
            if (btnGrabar.Enabled)
            {
                DialogResult resp = MessageBox.Show("Desea borrar esta partida?", "?", MessageBoxButtons.YesNo);
                if (resp == DialogResult.Yes)
                    gvArticulos.Rows.Remove(gvArticulos.CurrentRow);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void dtFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                this.ProcessTabKey(true);
            }
        }

        private void dtFecha_Leave(object sender, EventArgs e)
        {
            txtArticulo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EnabledFields(true);
            EnabledButtons(false);
            gbItems.Enabled = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = CancelDocument();
            if(result != null && result.ResultId == 200)
            {
                MessageBox.Show("Documento cancelado");
                EnabledButtons(true);
                GlobalData.ReloadGrid = true;
            }
        }

        private void frmDocMov_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                btnGrabar_Click(sender, e);
            }
        }

        private void cboAlmacen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                this.ProcessTabKey(true);
            }
        }
    }
}
