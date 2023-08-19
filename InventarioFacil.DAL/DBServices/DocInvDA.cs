using InventarioFacil.Common;
using InventarioFacil.DAL.DBServices.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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
                        lst.AlmacenId = int.Parse(reader.GetString("warehouseid"));
                        lst.ConceptoId = reader.GetString("doctypeid");
                        lst.Almacen = reader.GetString("warehouse");
                        lst.Concepto = reader.GetString("doctype");
                        lst.NumDoc = reader.GetString("docnum");
                        lst.Fecha = reader.GetString("datemov");
                        lst.Status = reader.GetString("status");
                        lst.Cliente = reader.GetString("client");
                        lst.Proveedor = reader.GetString("supplier");
                        lst.Notas = reader.GetString("notes");

                        lstMovs.Add(lst);
                    }
                }
                connection.Close();
            }

            return lstMovs;
        }

        public List<DocMov> GetDocMovDetail(DocInv diObject)
        {
            List<DocMov> lstMovs = new List<DocMov>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "usp_GetDocMovItems";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_warehouse", diObject.warehouse);
                    command.Parameters.AddWithValue("@_doctype", diObject.doctype);
                    command.Parameters.AddWithValue("@_docnum", diObject.docnum);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        DocMov lst = new DocMov();
                        lst.item_id = int.Parse(reader.GetString("item_id"));
                        lst.quantity = decimal.Parse(reader.GetString("quantity"));
                        lst.part = int.Parse(reader.GetString("part"));
                        lst.item_dsc = reader.GetString("item_dsc");
                        lst.price_u = decimal.Parse(reader.GetString("price_u"));
                        lst.cost_u = decimal.Parse(reader.GetString("cost_u"));

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

        public OperationResult DeleteDocMov(DocInv diObject)
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
                        command.CommandText = "usp_DeleteDocMov";
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

        public OperationResult AddDocmov(DocMov diObject)
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
                        command.CommandText = "usp_AddDocmov";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@_warehouse", diObject.warehouse);
                        command.Parameters.AddWithValue("@_doctype", diObject.doctype);
                        command.Parameters.AddWithValue("@_docnum", diObject.docnum);
                        command.Parameters.AddWithValue("@_part", diObject.part);
                        command.Parameters.AddWithValue("@_itemid", diObject.item_id);
                        command.Parameters.AddWithValue("@_quantity", diObject.quantity);
                        command.Parameters.AddWithValue("@_price_u", diObject.price_u);
                        command.Parameters.AddWithValue("@_cost_u", diObject.cost_u);

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

        public OperationResult DocInvAfe(DocInv diObject)
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
                        command.CommandText = "usp_DocInvAfe";
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

        public OperationResult DocInvRes(DocInv diObject)
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
                        command.CommandText = "usp_DocInvRes";
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
