using InventarioFacil.DAL.DBServices.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InventarioFacil.DAL.DBServices
{
    public class ReportsDA : ConnectionToMySql
    {
        public DataSet GetReportData(string storedProc, Dictionary<string,  object> parameters)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = storedProc;
                    command.CommandType = CommandType.StoredProcedure;
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }
                    DataSet ds = new DataSet();
                    MySqlDataAdapter da = new MySqlDataAdapter(command);
                    da.Fill(ds);
                    connection.Close();
                    return ds;
                }
            }
        }
    }
}
