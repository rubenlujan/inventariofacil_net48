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
        DocInv docinvEntity;

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
        private void NewRecord()
        {
            docinvEntity = new DocInv();    
            ClearFields();
            EnabledButtons(false);
            EnabledFields(true);
            txtAlmacen.Focus();
            GlobalData.TipoEdicion = TipoAccion.Alta;

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
            txtStatus.Text = "Pendiente";
            lblAlmacen.Text = "";
            lblConcepto.Text = "";
        }

        private void EnabledFields(bool enabled)
        {
            foreach (Control control in this.gpMain.Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == "input")
                    control.Enabled = enabled;
            }
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

        }

        private void FillDocInvEntity()
        {
            docinvEntity.warehouse = int.Parse(txtAlmacen.Text);
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
            int tipo;
            message = string.Empty;

            strQuery = "SELECT Actual_Stock FROM itemsstock WHERE Item_Id=" + codigo + " and warehouse_id = " + txtAlmacen.Text;
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

        #endregion

        private void txtConcepto_Leave(object sender, EventArgs e)
        {
            if (txtConcepto.Text != "" && txtConcepto.Enabled)
            {
                if (txtAlmacen.Text == "")
                {
                    MessageBox.Show("Debe capturar un almacen");
                    txtAlmacen.Focus();
                    txtConcepto.Text = "";
                    return;
                }
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
                    strQuery = "SELECT COALESCE(MAX(docnum), 0) + 1 FROM docinv WHERE warehouse='" + txtAlmacen.Text + "' AND doctype='" + txtConcepto.Text + "'";
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
                        txtAlmacen.Enabled = false;
                    }
                }
            }
        }

        private void frmDocMov_Load(object sender, EventArgs e)
        {
            if(GlobalData.TipoEdicion == TipoAccion.Alta)
                NewRecord();
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

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            if (txtAlmacen.Enabled == false)
                return;

            strQuery = "SELECT id, description as Descripcion FROM warehouse order by id";
            Utilerias.OpenWindow(strQuery, txtAlmacen, "Almacenes");
            txtAlmacen_Leave(sender, e);
            //this.ProcessTabKey(true);
        }

        private void txtAlmacen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                this.ProcessTabKey(true);
            }
        }

        private void txtAlmacen_Leave(object sender, EventArgs e)
        {
            if (txtAlmacen.Text != "" && txtAlmacen.Enabled)
            {
                message = string.Empty;
                strQuery = "SELECT description FROM warehouse WHERE id=" + txtAlmacen.Text;
                lblAlmacen.Text = new MetodosGenerales().RegresaCampoAlfanumerico(strQuery, ref message);
                
                if (lblAlmacen.Text != "")
                {
                    txtConcepto.Focus();
                    return;
                }
                MessageBox.Show("No existe esta clave");
                txtAlmacen.Text = "";
                txtAlmacen.Focus();
                return;
                
            }
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
            if (txtArticulo.Text != "")
            {
                message = String.Empty;
                strQuery = "SELECT Descripcion, Precio_U, Costo_U FROM items_data WHERE Id=" + txtArticulo.Text;
                var rdr = new MetodosGenerales().ReturnDataReader(strQuery, ref message);

                if (rdr.Read())
                {
                    lblArticulo.Text = rdr[0].ToString();
                    txtPrecioU.Text = decimal.Parse(rdr[1].ToString()).ToString("N2");
                    txtCostoU.Text = decimal.Parse(rdr[2].ToString()).ToString("N2");
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
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string tipo;
            int cant;
            message = String.Empty;

            if (Convert.ToInt32(txtCantidad.Text) == 0 || lblArticulo.Text.Length == 0)
            {
                MessageBox.Show("Complete todos los campos.");
                if (lblArticulo.Text.Length == 0 ? txtArticulo.Focus() : txtCantidad.Focus()) ;

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

            double importe;
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
    }
}
