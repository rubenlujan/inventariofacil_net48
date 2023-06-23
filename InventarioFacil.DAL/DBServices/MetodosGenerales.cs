using InventarioFacil.Common;
using InventarioFacil.DAL.DBServices.Entities;
using MySql.Data.MySqlClient;
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
    }
}
