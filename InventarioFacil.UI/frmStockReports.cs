using InventarioFacil.Common;
using InventarioFacil.DAL.DBServices;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System;
using System.Drawing.Text;
using System.Text.RegularExpressions;
using System.Data;
using System.Text;
using Infragistics.Win;

namespace InventarioFacil
{
    public partial class frmStockReports : Form
    {
        public Reports ReportData;
        string dateRange = string.Empty;
        DataSet ds;
        public frmStockReports()
        {
            InitializeComponent();
        }

        private void btnPantalla_Click(object sender, System.EventArgs e)
        {
            if (!ReportData.ShowDate)
                dateRange = " al " + DateTime.Now.ToString("dd-MM-yyyy");

            ReportData.ReportName += dateRange;
            Dictionary<string, object> map = new Dictionary<string, object>();
            map.Add("@_iniId", txtCDel.Text);
            map.Add("@_endId", txtCAl.Text);
            ReportData.Params = map;
            ds = new ReportsDA().GetReportData(ReportData.StoredProc, ReportData.Params);
            dgvData.DataSource = ds.Tables[0];

            if(ReportData.IsTotalized && dgvData.Rows.Count > 0)
            {
                dgvData.Rows[0].DefaultCellStyle.Font = new System.Drawing.Font(System.Drawing.FontFamily.GenericSerif, 10, System.Drawing.FontStyle.Bold);
                dgvData.Rows[0].DefaultCellStyle.BackColor = System.Drawing.Color.Green;
                dgvData.Rows[0].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            }

            dgvData.Rows[0].Selected = false;
            dgvData.Rows[1].Selected = false;

            int totalSize = 0;  
            foreach(DataGridViewColumn col in dgvData.Columns) 
            { 
                totalSize += col.Width;
            }
            this.Width = totalSize + 100;
            //this.Height = totalSize + 100;
            //MessageBox.Show(totalSize.ToString());

            EnabledButtons(true);
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void frmStockReports_Load(object sender, System.EventArgs e)
        {
            if (ReportData == null)
                this.Close();

            gbFechas.Visible = ReportData.ShowDate;
            EnabledButtons(false);

        }

        private void EnabledButtons(bool enabled)
        {
            btnExcel.Enabled = enabled;
            btnPDF.Enabled = enabled;
        }

        private void btnPDF_Click(object sender, System.EventArgs e)
        {
           try
            {
                ExportToPDF();
            }
            catch(Exception ex) {
                MessageBox.Show("Error al exportar:" + ex.Message);
            }
        }

        private void ExportToPDF()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = ReportData.ReportName;
            saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document document = new Document(PageSize.LETTER.Rotate(), 10f, 10f, 10f, 10f);
                    PdfWriter writer = PdfWriter.GetInstance(document, fs);

                    document.Open();

                    // Agregar encabezado
                    PdfPTable headerTable = new PdfPTable(1);
                    headerTable.DefaultCell.Border = Rectangle.NO_BORDER;
                    headerTable.WidthPercentage = 100;
                    Font companyFont = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.BOLDITALIC);
                    companyFont.Color = BaseColor.BLUE;
                    headerTable.AddCell(new Phrase(GlobalData.CompanyName, companyFont));
                    document.Add(headerTable);

                    document.Add(new Paragraph(Chunk.NEWLINE));

                    headerTable = new PdfPTable(1);
                    headerTable.DefaultCell.Border = Rectangle.NO_BORDER;
                    headerTable.WidthPercentage = 100;
                    Font headerFont = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD);
                    headerTable.AddCell(new Phrase(ReportData.ReportName, headerFont));
                    document.Add(headerTable);

                    document.Add(new Paragraph(Chunk.NEWLINE));


                    // Agregar números de página
                    PageNumberEvent pageNumberEvent = new PageNumberEvent();
                    writer.PageEvent = pageNumberEvent;
                    

                    // Crear la tabla para el DataGridView
                    PdfPTable pdfTable = new PdfPTable(dgvData.Columns.Count);
                    pdfTable.WidthPercentage = 100;
                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                    Font boldFont = new Font(iTextSharp.text.Font.FontFamily.COURIER, 10, iTextSharp.text.Font.BOLD);
                    // Agregar encabezados de columna
                    foreach (DataGridViewColumn column in dgvData.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, boldFont));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable.AddCell(cell);
                    }

                    // Agregar filas y celdas al PDF
                    int totalRows = 1;

                    foreach (DataGridViewRow row in dgvData.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            PdfPCell newCell = new PdfPCell(new Phrase(cell.Value.ToString()));

                            if (ReportData.IsTotalized && totalRows == 1)
                                newCell.BackgroundColor = BaseColor.GREEN;

                            if (cell.Value.ToString().Contains("$") || IsNumeric(cell.Value.ToString()))
                                newCell.HorizontalAlignment = Element.ALIGN_RIGHT
                                    ;
                            pdfTable.AddCell(newCell);
                        }
                        totalRows++;
                    }

                    document.Add(pdfTable);
                    document.Close();

                    MessageBox.Show("PDF exportado exitosamente.", "Exportar a PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool IsNumeric(string text)
        {
            return Regex.IsMatch(text, @"^\d+(\.\d+)?$");
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
           try
            {
                ExportToCSV();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al exportar: " + ex.Message);
            }
        }

        private void ExportToCSV()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Guardar archivo CSV";
            saveFileDialog.FileName = ReportData.ReportName;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder csvContent = new StringBuilder();

                // Encabezados de columna
                foreach (DataGridViewColumn column in dgvData.Columns)
                {
                    csvContent.Append(column.HeaderText);
                    csvContent.Append(",");
                }
                csvContent.AppendLine();

                // Contenido de las filas
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        csvContent.Append(cell.Value);
                        csvContent.Append(",");
                    }
                    csvContent.AppendLine();
                }

                // Escribir el contenido en el archivo
                File.WriteAllText(saveFileDialog.FileName, csvContent.ToString());

                MessageBox.Show("CSV exportado exitosamente.", "Exportar a CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            var strQuery = "SELECT Id,SKU, Descripcion,Categoria, Stock as Existencia FROM items_data WHERE Status='Activo' ORDER BY Id";
            Utilerias.OpenWindow(strQuery, txtCDel, "Articulos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var strQuery = "SELECT Id,SKU, Descripcion,Categoria, Stock as Existencia FROM items_data WHERE Status='Activo' ORDER BY Id";
            Utilerias.OpenWindow(strQuery, txtCAl, "Articulos");
        }
    }

    class PageNumberEvent : PdfPageEventHelper
    {
        public override void OnEndPage(PdfWriter writer, Document document)
        {
            base.OnEndPage(writer, document);

            int pageNumber = writer.PageNumber;
            Rectangle pageSize = document.PageSize;

            PdfContentByte cb = writer.DirectContent;
            cb.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 10);
            cb.SetRGBColorFill(100, 100, 100);

            cb.BeginText();
            cb.SetTextMatrix(pageSize.GetRight(70), pageSize.GetBottom(30));
            cb.ShowText($"Página {pageNumber}");
            cb.EndText();
        }
    }
}
