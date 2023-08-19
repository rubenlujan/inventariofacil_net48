using InventarioFacil.Common;
using InventarioFacil.DAL.DBServices.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace InventarioFacil.DAL.DBServices
{
    public class ItemsDA : ConnectionToMySql
    {
        public int ValidateItemMovs(int id)
        {
            int regs = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "usp_ValidateItem";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_id", id);
                    MySqlDataReader reader = command.ExecuteReader();
                   
                    while (reader.Read())
                    {
                        regs = reader.GetInt32(0);
                    
                    }
                }
            }

            return regs;    
        }

        public List<Item> GetItemList()
        {
            List<Item> list = new List<Item>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from items_data";
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var item = SetItemData(reader); 
                        list.Add(item);
                    }
                }
            }
            return list;
        }

        public Item GetItem(int id)
        {
            Item item = new Item();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from items_data Where Id = " + id;
                    command.CommandType = CommandType.Text;

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        item = SetItemData(reader);
                        int index = reader.GetOrdinal("Photo");
                        item.Imagen = !reader.IsDBNull(index) ? (byte[])reader["Photo"] : new byte[0];
                        item.Notas = reader["Notas"].ToString();
                    }
                }
            }
            return item;
        }

        private Item SetItemData(MySqlDataReader reader) 
        {
            Item item = new Item();
            item.Id = int.Parse(reader["Id"].ToString());
            item.SKU = reader["SKU"].ToString();
            item.Descripcion = reader["Descripcion"].ToString();
            item.CodBar = reader["CodigoBarras"].ToString();
            item.Categoria = reader["Categoria"].ToString();
            item.UMed = reader["UMed"].ToString();
            item.Costo_U = decimal.Parse(reader["Costo_U"].ToString());
            item.Precio_U = decimal.Parse(reader["Precio_U"].ToString());
            item.Existencia = double.Parse(reader["Stock"].ToString());
            item.Status = reader["status"].ToString();  
            return item;
        }

        public OperationResult SetItemImage(int itemId, byte[] image)
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
                        command.CommandText = "usp_SetItemImage";
                        command.Parameters.AddWithValue("@Id", itemId);
                        command.Parameters.AddWithValue("@itemImage", image);

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

        public OperationResult AddNewItem(Item item, int categoryId, int umedId)
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
                        command.CommandText = "usp_AddNewItem";
                        command.Parameters.AddWithValue("@ItemId", item.Id);
                        command.Parameters.AddWithValue("@SKU", item.SKU);
                        command.Parameters.AddWithValue("@Barcode", item.CodBar);
                        command.Parameters.AddWithValue("@Description", item.Descripcion);
                        command.Parameters.AddWithValue("@UMed_Id", umedId);
                        command.Parameters.AddWithValue("@UPrice", item.Precio_U);
                        command.Parameters.AddWithValue("@UCost", item.Costo_U);
                        command.Parameters.AddWithValue("@Category_Id", categoryId); 
                        command.Parameters.AddWithValue("@Notes", item.Notas);
                        command.Parameters.AddWithValue("@Status", item.Status);
                        command.Parameters.AddWithValue("@itemImage", item.Imagen);

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

        public OperationResult UpdateItem(Item item, int categoryId, int umedId)
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
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "usp_UpdateItem";
                        command.Parameters.AddWithValue("@_ItemId", item.Id);
                        command.Parameters.AddWithValue("@_SKU", item.SKU);
                        command.Parameters.AddWithValue("@_Barcode", item.CodBar);
                        command.Parameters.AddWithValue("@_Description", item.Descripcion);
                        command.Parameters.AddWithValue("@_UMed_Id", umedId);
                        command.Parameters.AddWithValue("@_UPrice", item.Precio_U);
                        command.Parameters.AddWithValue("@_UCost", item.Costo_U);
                        command.Parameters.AddWithValue("@_Category_Id", categoryId);
                        command.Parameters.AddWithValue("@_Notes", item.Notas);
                        command.Parameters.AddWithValue("@_Status", item.Status);
                        command.Parameters.AddWithValue("@_itemImage", item.Imagen);

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

        public OperationResult DeleteItem(int itemId)
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
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "usp_DeleteItem";
                        command.Parameters.AddWithValue("@Id", itemId);
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

        public List<MovInv> GetKardex(int itemId)
        {
            List<MovInv> list = new List<MovInv>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "usp_GetKardexByItem";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_itemId", itemId);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var item = new MovInv();
                        item.Almacen = reader.GetString("warehouse");
                        item.Concepto = reader.GetString("concept");
                        item.DocNum = reader.GetString("docnum");
                        item.Fecha = reader.GetString("docdate");
                        item.Cantidad = reader.GetString("quantity");
                        item.Precio_U = reader.GetString("price_u");
                        item.Costo_U = reader.GetString("cost_u");
                        list.Add(item);
                    }
                }
            }
            return list;
        }
    }
}
