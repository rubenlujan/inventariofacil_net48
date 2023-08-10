using InventarioFacil.Common;
using InventarioFacil.DAL.DBServices;
using InventarioFacil.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventarioFacil.DAL.DBServices.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Security.Cryptography;
using System.Windows.Forms.VisualStyles;

namespace InventarioFacil
{
    public partial class frmItemsDetail : Form
    {
        public frmItemsDetail()
        {
            InitializeComponent();
        }

        private bool editing = false;
        public int itemId;
        private int codAnterior;
        string strQuery = string.Empty;
        string message = string.Empty;
        string rutaImagen;
        public TipoAccion tipoMovimiento;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(codAnterior == 0) 
            {
                this.Close();
            } 
            else
            {
                itemId = codAnterior;
                EnabledButtons(true);
                EnabledFields(false);
                GetDataItem();
            }
        }

        private void frmItemsDetail_Load(object sender, EventArgs e)
        {
            
            LoadCombos();
            if(itemId != 0)
            {
                GetDataItem();
                return;
            }
            EnabledButtons(false);
            ClearFields();
            NewItem();  
        }

        #region "LoadSave Data"
        private void SetDataInfo(Item item)
        {
            txtItem.Text = item.Id.ToString();
            txtCodigo.Text = item.SKU;
            cboUMed.Text = item.UMed;
            txtDescripcion.Text = item.Descripcion;
            cboCategoria.Text = item.Categoria;
            txtCodBar.Text = item.CodBar;
            txtPrecioU.Text = item.Precio_U.ToString("N2");
            txtCostoU.Text = item.Costo_U.ToString("N2");
            txtNotas.Text = item.Notas;
            txtExistencia.Text = item.Existencia.ToString("N");
            cboStatus.Text = item.Status;
        }

        private void LoadCombos()
        {
            message = string.Empty;
            strQuery = "Select Id, Description FROM categories";
            var categories = new MetodosGenerales().RegresaCatalogoCombo(strQuery, ref message);
            SetComboData(cboCategoria, categories);
            
            strQuery = "Select Id, Description FROM umeasurements";
            var umeds = new MetodosGenerales().RegresaCatalogoCombo(strQuery, ref message);
            SetComboData(cboUMed, umeds);

        }

        private void SetComboData<T>(ComboBox comboControl, List<T> listData)
        {
            comboControl.ValueMember = "Value";
            comboControl.DisplayMember = "Description";
            comboControl.DataSource = listData;
        }

        private bool ValidateEmptyFields()
        {
            bool result = true;    
            foreach (Control control in this.gpDatos.Controls)
            {
                if (control.Tag != null && control.Tag.ToString().Contains("input"))
                {
                    if(control.GetType() == typeof(ComboBox) && control.Text == "")
                    {
                        result = false;
                        break;
                    }
                }
            }
            return result;  
        }
        #endregion

        #region BDActions
        private OperationResult DeleteItem()
        {
            OperationResult result = new OperationResult();
            int regs = new ItemsDA().ValidateItemMovs(int.Parse(txtItem.Text));
            if (regs > 0)
            {
                MessageBox.Show("El articulo tiene movimientos, no se puede borrar.");
                result.ResultId = 400;
                return result;
            }

            result = new ItemsDA().DeleteItem(int.Parse(txtItem.Text));
            if(result.ResultId != 200)
                MessageBox.Show("Ocurrió un error al borrar el registro: " + result.Message);

            return result;
        }
        #endregion

        private void btnUploadPic_Click(object sender, EventArgs e)
        {
            fileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rutaImagen = fileDialog.FileName;
                    byte[] imagenBytes = File.ReadAllBytes(rutaImagen);

                    Image itemPic;
                    using (MemoryStream memoryStream = new MemoryStream(imagenBytes))
                    {
                        itemPic = Image.FromStream(memoryStream);
                    }

                    itemPhoto.Image = itemPic;
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Ocurrió el siguiente error:" + ex.Message);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(!editing) 
                this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tipoMovimiento = TipoAccion.Cambio;
            codAnterior = int.Parse(txtItem.Text);
            EnabledFields(true);
            EnabledButtons(false);
        }

        #region Methods
        private void GetDataItem()
        {
            this.Cursor = Cursors.WaitCursor;
            Item item = new ItemModel().GetItem(itemId);
            SetDataInfo(item);
            if (item.Imagen.Length > 0)
                SetItemImage(item.Imagen);
            EnabledFields(false);
            this.Cursor= Cursors.Default;
        }

        private void SetItemImage(byte[] image)
        {
            Image itemPic;
            using (MemoryStream memoryStream = new MemoryStream(image))
            {
                itemPic = Image.FromStream(memoryStream);
            }
            itemPhoto.Image = itemPic;
        }

       

        private void EnabledFields(bool enabled)
        {
            foreach (Control control in this.gpDatos.Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == "input")
                    control.Enabled = enabled;
            }
        }

        private void ClearFields()
        {
            foreach (Control control in this.gpDatos.Controls)
            {
                if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(ComboBox))
                    control.Text = string.Empty;    
            }
            txtCostoU.Text = "0";
            txtPrecioU.Text = "0";
            cboStatus.Text = "Activo";
        }

        private void EnabledButtons(bool bEnable)
        {
            btnNuevo.Enabled = bEnable;
            btnEditar.Enabled = bEnable;

            //Los usuarios de captura no tienen acceso a borrar registros
            btnBorrar.Enabled = bEnable;
            /* if (clsGlobalData.TipoUsuario == 1)
             {
                 btnBorrar.Enabled = false;
             }*/
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

        private void NewItem()
        {
            codAnterior = itemId;
            ClearFields();
            EnabledButtons(false);
            EnabledFields(true);
            itemPhoto.Image = null;
            itemId = new MetodosGenerales().RegresaCampoNumerico("SELECT COALESCE(MAX(itemid), 0) + 1 FROM items", ref message);
            if (message.Length > 0)
            {
                MessageBox.Show("Ha ocurrido el siguiente error:" + message);
                if(itemId > 0)
                    return;
                else
                    this.Close();
            }
            txtItem.Text = itemId.ToString();
            tipoMovimiento = TipoAccion.Alta;
        }

        #endregion

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NewItem();
            tipoMovimiento = TipoAccion.Alta;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                OperationResult result = new OperationResult();
                GlobalData.ReloadGrid = true;
                this.Cursor = Cursors.WaitCursor;

                switch (tipoMovimiento)
                {
                    case TipoAccion.Alta:
                        result = AddNewItem();
                        break;
                    case TipoAccion.Cambio:
                        result = UpdateItem();
                        break;
                    case TipoAccion.Baja:
                        result = new ItemsDA().DeleteItem(int.Parse(txtItem.Text));
                        this.Close();
                        break;
                }
                this.Cursor = Cursors.Default;

                if (result.ResultId != 200)
                    throw new Exception(result.Message);


                EnabledFields(false);
                EnabledButtons(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el siguiente error:" + ex.Message);
            }
        }

        private OperationResult AddNewItem()
        {
            if(!ValidateEmptyFields())
            {
                MessageBox.Show("Debe llenar todos los combos.");
                return null;
            }

            var item = SetItemData();
            var categoryId = (int)cboCategoria.SelectedValue;
            var umed = (int)cboUMed.SelectedValue;
            return new ItemModel().AddNewItem(item, categoryId, umed);
        }

        private OperationResult UpdateItem()
        {
            OperationResult result = new OperationResult();
            var item = SetItemData();
            var categoryId = (int)cboCategoria.SelectedValue;
            var umed = (int)cboUMed.SelectedValue;
            return new ItemModel().UpdateItem(item, categoryId, umed);  
        }

        private Item SetItemData()
        {
            Item item = new Item();
            item.Id = int.Parse(txtItem.Text);
            item.SKU = txtCodigo.Text;
            item.Descripcion = txtDescripcion.Text;
            item.CodBar = txtCodBar.Text;
            item.Precio_U = decimal.Parse(txtPrecioU.Text);
            item.Costo_U = decimal.Parse(txtCostoU.Text);
            item.Notas = txtNotas.Text;
            item.Status = cboStatus.Text;

            if (!string.IsNullOrEmpty(rutaImagen))
                item.Imagen = File.ReadAllBytes(rutaImagen);

            return item;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            var result = DeleteItem();
            if (result.ResultId == 200)
            {
                GlobalData.ReloadGrid = true;
                MessageBox.Show("Articulo borrado.");
                this.Close();   
            }
            EnabledButtons(false);
        }
    }
}
