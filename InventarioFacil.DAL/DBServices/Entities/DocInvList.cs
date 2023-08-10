using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioFacil.DAL.DBServices.Entities
{
    public class DocInvList
    {
        public string Almacen { get; set; } 
        public string Concepto { get; set; }    
        public string NumDoc { get; set; }  
        public string Fecha { get; set; }   
        public string Status { get; set; }
        public string Cliente { get; set; }
        public string Proveedor { get; set; }
        public string Notas { get; set; }
    }
}
