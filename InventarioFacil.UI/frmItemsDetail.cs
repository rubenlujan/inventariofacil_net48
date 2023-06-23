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

namespace InventarioFacil.UI
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
        public int tipoMovimiento = 0;

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
            if(itemId != 0)
            {
                GetDataItem();
                return;
            }
            EnabledButtons(false);
            ClearFields();
            NewItem();  
        }


        private void btnUploadPic_Click(object sender, EventArgs e)
        {
            fileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string rutaImagen = fileDialog.FileName;
                    byte[] imagenBytes = File.ReadAllBytes(rutaImagen);
                    Image itemPic;

                    using (MemoryStream memoryStream = new MemoryStream(imagenBytes))
                    {
                        itemPic = System.Drawing.Image.FromStream(memoryStream);
                    }
                    itemPhoto.Image = itemPic;

                    OperationResult result = new ItemModel().SetItemImage(int.Parse(txtItem.Text), imagenBytes);
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
            codAnterior = int.Parse(txtItem.Text);
            EnabledFields(true);
            EnabledButtons(false);
        }

        #region Methods
        private void GetDataItem()
        {
            Item item = new ItemModel().GetItem(itemId);
            SetDataInfo(item);
            if (item.Imagen.Length > 0)
                SetItemImage(item.Imagen);
            EnabledFields(false);
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
            itemId = new MetodosGenerales().RegresaCampoNumerico("SELECT MAX(ItemId) FROM Items", ref message);
            if (message.Length > 0)
            {
                MessageBox.Show("Ha ocurrido el siguiente error:" + message);
                if(itemId > 0)
                    return;
                else
                    this.Close();
            }
            itemId += 1;
            txtItem.Text = itemId.ToString();
        }

        #endregion

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NewItem();  
        }
    }
}
