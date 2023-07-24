using InventarioFacil.Common;
using InventarioFacil.DAL.DBServices.Entities;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace InventarioFacil.DAL.DBServices
{
    public class CatalogsDA : ConnectionToMySql
    {
        public List<Catalog> GetCatalogList(string strQuery)
        {
            List<Catalog> list = new List<Catalog>();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = System.Data.CommandType.Text;
                        command.CommandText = strQuery;
                        MySqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Catalog catalog = new Catalog() { 
                                Id = int.Parse(reader["Id"].ToString()),
                                Description = reader["Description"].ToString()
                            };    
                            list.Add(catalog);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return list;
        }

        public OperationResult AddNewWarehouse(int id, string description)
        {
            OperationResult result = new OperationResult();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandText = "usp_AddNewWarehouse";
                        command.Parameters.AddWithValue("@_id", id);
                        command.Parameters.AddWithValue("@_description", description);
                        command.ExecuteNonQuery();

                        result.ResultId = 200;
                        result.Message = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                result.ResultId = 400;
                result.Message = ex.Message;
            }
            return result;
        }

        public OperationResult UpdateWarehouse(int id, string description)
        {
            OperationResult result = new OperationResult();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandText = "usp_UpdateWarehouse";
                        command.Parameters.AddWithValue("@_id", id);
                        command.Parameters.AddWithValue("@_description", description);
                        command.ExecuteNonQuery();

                        result.ResultId = 200;
                        result.Message = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                result.ResultId = 400;
                result.Message = ex.Message;
            }
            return result;
        }
    }
}
