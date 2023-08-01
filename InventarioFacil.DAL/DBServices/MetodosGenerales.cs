using InventarioFacil.Common;
using InventarioFacil.DAL.DBServices.Entities;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Asn1.X500;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace InventarioFacil.DAL.DBServices
{
    public class MetodosGenerales : ConnectionToMySql
    {
        public Int16 RegresaCampoNumerico(string strQuery, ref string message)
        {
            Int16 result = -1;
            try
            {
                var reader = ExecuteDataReader(strQuery, ref message);
                if (message.Length > 0)
                {
                    return -1;
                }

                if (reader.HasRows)
                {
                    reader.Read();
                    if (reader[0] != DBNull.Value)
                        result = Convert.ToInt16(reader[0]);

                }
            } 
            catch(Exception ex)
            {
                result = -1;
                message = ex.Message;
            }
            finally 
            {
                CloseConnection();
            }
            return result;
        }

        public List<ComboEntity> RegresaCatalogoCombo(string strQuery, ref string message)
        {
            List<ComboEntity> list = new List<ComboEntity>();
            try
            {
                var reader = ExecuteDataReader(strQuery, ref message);
                if (message.Length > 0)
                {
                    throw new Exception(message);
                }
                while(reader.Read())
                {
                    var value = int.Parse(reader[0].ToString());
                    var descrip = reader[1].ToString(); 
                    list.Add(new ComboEntity { Description = descrip, Value = value });
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            finally
            {
                CloseConnection();
            }
            return list;
        }

        public OperationResult DeleteGeneric(int id, string spName)
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
                        command.CommandText = spName;
                        command.Parameters.AddWithValue("@_id", id);
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
