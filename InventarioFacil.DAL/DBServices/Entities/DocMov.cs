using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioFacil.DAL.DBServices.Entities
{
    public class DocMov
    {
        public int warehouse { get; set; }
        public string doctype { get; set; }
        public string docnum { get; set; }
        public int part { get; set; }   
        public int item_id { get; set; }
        public string item_dsc { get; set; }    
        public decimal quantity { get; set; }
        public decimal price_u { get; set; }
        public decimal cost_u { get; set; }
    }
}
