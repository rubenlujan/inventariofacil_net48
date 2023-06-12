using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioFacil.DAL.DBServices
{
    public abstract class ConnectionToMySql
    {
        private readonly string connectionString;//Obtiene o establece la cadena de conexión.

        public ConnectionToMySql()
        {
            //Establecer la cadena de conexión.
            connectionString = ConfigurationManager.ConnectionStrings["mySql"].ToString();
        }
        protected MySqlConnection GetConnection()
        {
            //Este métedo se encarga de establecer y devolver el objeto de conexión a SQL Server.
            return new MySqlConnection(connectionString);
        }
    }
}
