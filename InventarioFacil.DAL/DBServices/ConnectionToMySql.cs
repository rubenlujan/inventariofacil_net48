using MySql.Data.MySqlClient;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioFacil.DAL.DBServices
{
    public abstract class ConnectionToMySql
    {
        private readonly string connectionString;//Obtiene o establece la cadena de conexión.
        MySqlConnection connection;
        public ConnectionToMySql()
        {
            //Establecer la cadena de conexión.
            connectionString = ConfigurationManager.ConnectionStrings["mySql"].ToString();
            var uidBytes = Convert.FromBase64String(ConfigurationManager.AppSettings["uid"].ToString());
            var uid = "uid = " + Encoding.UTF8.GetString(uidBytes);
            var pidBytes = Convert.FromBase64String(ConfigurationManager.AppSettings["pid"].ToString());
            var pid = "pwd = " + Encoding.UTF8.GetString(pidBytes);
            connectionString += uid + ";" + pid + ";";
        }
        protected MySqlConnection GetConnection()
        {
            //Este métedo se encarga de establecer y devolver el objeto de conexión a SQL Server.
            if (connection == null || connection.State != ConnectionState.Open) 
                connection = new MySqlConnection(connectionString);
            return connection;
        }

        protected MySqlDataReader ExecuteDataReader(string strQuery, ref string message)
        {
            try
            {
                var connection = GetConnection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(strQuery, connection);
                cmd.CommandType = System.Data.CommandType.Text;

                MySqlDataReader reader = cmd.ExecuteReader();
                return reader;
                /*
                using (var connection = GetConnection())
                {
                  
                }*/
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return null;
            }
        }

        protected void CloseConnection()
        {
            if(connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }        
    }
}
