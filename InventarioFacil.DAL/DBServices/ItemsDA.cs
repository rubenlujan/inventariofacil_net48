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
                        list.Add(item);
                    }
                }
            }
            return list;
        }
    }
}
