using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioFacil.Common
{
    public static class GlobalData
    {
        public static bool ReloadGrid { get; set; }
        public static TipoAccion TipoEdicion { get; set; }  
    }

    public enum TipoAccion
    {
        Alta = 1,
        Cambio = 2,
        Baja = 3
    }
}
