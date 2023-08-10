using InventarioFacil.Common;
using InventarioFacil.DAL.DBServices.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace InventarioFacil.DAL.DBServices
{
    public class DocInvDA : ConnectionToMySql
    {
        public List<DocInvList> GetDocInvList()
        {
            List<DocInvList> lstMovs = new List<DocInvList>();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from docinv_list";
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        DocInvList lst = new DocInvList();
                        lst.Almacen = reader.GetString("warehouse");
                        lst.Concepto = reader.GetString("doctype");
                        lst.NumDoc = reader.GetString("docnum");
                        lst.Fecha = reader.GetString("datemov");
                        lst.Status = reader.GetString("status");
                        lst.Cliente = reader.GetString("client");
                        lst.Cliente = reader.GetString("supplier");
                        lst.Cliente = reader.GetString("notes");

                        lstMovs.Add(lst);
                    }
                }
                connection.Close();
            }

            return lstMovs;
        }

        public OperationResult AddUpdateDocInv(DocInv diObject)
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
                        command.CommandText = "usp_AddUpdateDocInv";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@_warehouse", diObject.warehouse);
                        command.Parameters.AddWithValue("@_doctype", diObject.doctype);
                        command.Parameters.AddWithValue("@_docnum", diObject.docnum);
                        command.Parameters.AddWithValue("@_docdate", diObject.datemov.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@_notes", diObject.notes);
                        command.Parameters.AddWithValue("@_status", diObject.status);

                        command.ExecuteNonQuery();

                        result.ResultId = 200;
                        result.Message = string.Empty;
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                result.ResultId = 400;
                result.Message = ex.Message;
            }

            return result;
        }

        public OperationResult DeleteDocInv(DocInv diObject)
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
                        command.CommandText = "usp_DeleteDocInv";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@_warehouse", diObject.warehouse);
                        command.Parameters.AddWithValue("@_doctype", diObject.doctype);
                        command.Parameters.AddWithValue("@_docnum", diObject.docnum);

                        command.ExecuteNonQuery();

                        result.ResultId = 200;
                        result.Message = string.Empty;
                    }
                    connection.Close();
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
