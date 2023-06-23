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

namespace InventarioFacil.DAL.DBServices
{
    public class ItemsDA : ConnectionToMySql
    {
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
    }
}
