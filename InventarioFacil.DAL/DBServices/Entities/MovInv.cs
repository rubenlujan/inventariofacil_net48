using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioFacil.DAL.DBServices.Entities
{
    public class MovInv
    {
        public string Almacen { get; set; }
        public string Concepto { get; set; }
        public string DocNum { get; set; }
        public string Fecha { get; set; }
        public string Cantidad { get; set; }   
        public string Precio_U { get; set; }
        public string Costo_U { get; set; }
    }
}
