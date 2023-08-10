using InventarioFacil.Common;
using InventarioFacil.DAL.DBServices.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using InventarioFacil;

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
            catch (Exception ex)
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

        public string RegresaCampoAlfanumerico(string strQuery, ref string message)
        {
            string result = string.Empty;
            try
            {
                var reader = ExecuteDataReader(strQuery, ref message);
                if (message.Length > 0)
                {
                    return string.Empty;
                }

                if (reader.HasRows)
                {
                    reader.Read();
                    if (reader[0] != DBNull.Value)
                        result = reader[0].ToString();

                }
            }
            catch (Exception ex)
            {
                result = string.Empty;
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
                while (reader.Read())
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

        public DataTable ReturnDataTable(string strQuery, ref string message)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = ExecuteDataTable(strQuery, ref message);
            }
            catch (Exception ex)
            {
                message += ex.Message;
            }
            finally {
                CloseConnection();
            }
            return dt;
        }

        public IDataReader ReturnDataReader(string strQuery, ref string message)
        {
            IDataReader dr = null;
            try
            {
                dr = ExecuteDataReader(strQuery, ref message);
            }
            catch (Exception ex)
            {
                message += ex.Message;
            }
            return dr;
        }
    }
}
