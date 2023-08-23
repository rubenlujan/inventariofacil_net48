using InventarioFacil.Common;
using InventarioFacil.DAL.DBServices;
using InventarioFacil.DAL.DBServices.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Drawing;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Font = iTextSharp.text.Font;

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
                dt.Rows.Add(item.AlmacenId, item.Almacen, item.ConceptoId, item.Concepto, item.NumDoc, item.Fecha, item.Status, item.Cliente, item.Proveedor, item.Notas);
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
            dgvData.Columns[0].Visible = false;
            dgvData.Columns[2].Visible = false;

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
            position = bs.Count;
            frmDMov.ShowDialog();
            LoadData();
        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {

        }

        private void dgvData_DoubleClick(object sender, EventArgs e)
        {
            frmDocMov frmChild = new frmDocMov();
            var rowIndex = dgvData.SelectedRows[0];
            position = rowIndex.Index;
            frmChild.docinvEntity = new DocInv();
            frmChild.docinvEntity.warehouse = int.Parse(rowIndex.Cells[0].Value.ToString());
            frmChild.docinvEntity.warehouse_dsc = rowIndex.Cells[1].Value.ToString();
            frmChild.docinvEntity.doctype = rowIndex.Cells[2].Value.ToString();
            frmChild.docinvEntity.docnum = rowIndex.Cells[4].Value.ToString();
            frmChild.docinvEntity.datemov = DateTime.Parse(rowIndex.Cells[5].Value.ToString());
            frmChild.docinvEntity.status = rowIndex.Cells[6].Value.ToString();
            frmChild.docinvEntity.notes = rowIndex.Cells[9].Value.ToString();
            frmChild.lblConcepto.Text = rowIndex.Cells[3].Value.ToString();
            GlobalData.TipoEdicion = TipoAccion.Cambio;
            frmChild.ShowDialog();
            LoadData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "GridViewExport.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document pdfDoc = new Document(PageSize.LETTER.Rotate(), 10f, 10f, 10f, 0f);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));

                    pdfDoc.Open();

                    // Agregar encabezado
                    pdfDoc.Add(new Paragraph("Reporte de Inventarios"));

                    // Agregar números de página
                    pdfDoc.Add(new Chunk("Página: "));
                    pdfDoc.Add(new Chunk(writer.PageNumber.ToString()));

                    PdfPTable pdfTable = new PdfPTable(dgvData.Columns.Count);
                    pdfTable.DefaultCell.Padding = 3;
                    pdfTable.WidthPercentage = 100;
                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                    // Agregar encabezados de columna
                    foreach (DataGridViewColumn column in dgvData.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        pdfTable.AddCell(cell);
                    }

                    // Agregar filas y celdas al PDF
                    foreach (DataGridViewRow row in dgvData.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(cell.Value.ToString());
                        }
                    }

                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    writer.Close();

                    MessageBox.Show("PDF exportado exitosamente.", "Exportar a PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnInvCost_Click(object sender, EventArgs e)
        {
            frmStockReports frmChild = new frmStockReports();
            frmChild.ReportData = new Reports();
            frmChild.ReportData.ShowDate = false;
            frmChild.ReportData.StoredProc = "usp_Costed_Inventory";
            frmChild.ReportData.ReportName = "Inventario Costeado";
            frmChild.ReportData.IsTotalized = true;
            frmChild.ShowDialog();
        }
    }
}
