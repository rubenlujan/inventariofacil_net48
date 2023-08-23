using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioFacil.Common
{
    public class Reports
    {
        public string ReportName { get; set; }  
        public bool ShowDate { get; set; }
        public string StoredProc { get; set; }  
        public bool IsTotalized { get; set; }   
        public Dictionary<string, Object> Params { get; set; }

        public Reports() { 
            Params = new Dictionary<string, Object>();  
        }
    }
}
