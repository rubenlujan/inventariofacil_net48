using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioFacil.DAL.DBServices.Entities
{
    public class Item
    {
        public int Id { get; set; }  // 0
        public string SKU { get; set; } // 1
        public string CodBar { get; set; } // 2
        public string Descripcion { get; set; } // 3
        public string UMed { get; set; } // 4
        public string Categoria { get; set; } // 5
        public decimal Precio_U { get; set; } // 6
        public decimal Costo_U { get; set; } // 7
        public double Existencia { get; set; }  //8
        public byte[] Imagen { get; set; }  // 9 
        public string Notas { get; set; }   // 10
        public string Status { get; set; }   // 11
    }
}
