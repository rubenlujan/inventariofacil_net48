using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioFacil.DAL.DBServices.Entities
{
    public class DocInv
    {
        public int warehouse { get; set; }
        public string doctype { get; set; }  
        public string docnum { get; set; }  
        public DateTime datemov { get ; set; }  
        public string notes { get; set; }   
        public string status { get; set; }  
    }
}
