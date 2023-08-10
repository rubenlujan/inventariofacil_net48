using System;
using System.Collections.Generic;
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
    }
}
