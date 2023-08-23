using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioFacil
{
    public static class Utilerias
    {
        public static void OpenWindow(string cadena, TextBox txtControl, string titulo)
        {
            frmVentana frmExpl = new frmVentana();
            frmExpl.strQuery = cadena;
            frmExpl.Text = titulo;
            if (frmExpl.ShowDialog() == DialogResult.OK)
            {
                txtControl.Text = frmExpl.RegresaDato();
            }
        }

        public static void ExportDataGridViewToCSV(string fileName, DataGridView dgvData)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Guardar archivo CSV";
            saveFileDialog.FileName = fileName;

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
    }
}
