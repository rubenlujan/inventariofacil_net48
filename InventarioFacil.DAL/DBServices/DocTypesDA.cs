using InventarioFacil.Common;
using InventarioFacil.DAL.DBServices.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioFacil.DAL.DBServices
{
    public class DocTypesDA : ConnectionToMySql
    {
        public List<DocType> GetDocTypes()
        {
            List<DocType> docTypes = new List<DocType>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from doctypes_list";
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        DocType docType = new DocType();
                        docType.Concepto = reader.GetString(0);
                        docType.Descripcion = reader.GetString(1);
                        docType.Tipo = reader.GetString(2);
                        docTypes.Add(docType);  
                    }
                }
                connection.Close(); 
            }
            return docTypes;    
        }

        public OperationResult AddNewDocType(string doc, string descrip, string type)
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
                        command.CommandText = "usp_AddNewDocType";
                        command.Parameters.AddWithValue("@_Id", doc);
                        command.Parameters.AddWithValue("@_description", descrip);
                        command.Parameters.AddWithValue("@_type", type);

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

        public OperationResult UpdateDocType(string doc, string descrip)
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
                        command.CommandText = "usp_UpdateDocType";
                        command.Parameters.AddWithValue("@_Id", doc);
                        command.Parameters.AddWithValue("@_description", descrip);

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
