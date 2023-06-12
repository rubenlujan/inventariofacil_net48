using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioFacil.DAL.DBServices.Entities
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int UserId { get; set; }
        public string CompleteName { get; set; }
        public int UserRol_Id { get; set; } 
        public string UserRol_Name { get;set; }
        public int IsActive { get; set; }
    }
}
