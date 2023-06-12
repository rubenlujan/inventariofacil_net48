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
    public class UserDA : ConnectionToMySql
    {
        public User Login(string username, string password)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from users_list where userName=@username and password=@pass";
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@pass", password);
                    command.CommandType = CommandType.Text;

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        var userObj = new User
                        {
                            UserId = (int)reader["User_Id"], 
                            Password = reader["Password"].ToString(),
                            Username = reader["UserName"].ToString(),
                            CompleteName = reader["CompleteName"].ToString(),
                            Email = reader["Email"].ToString(),
                            UserRol_Name = reader["Rol_Dsc"].ToString(),
                            UserRol_Id = int.Parse(reader["Rol_Id"].ToString())
                            
                        };

                        ActiveUser.UserId = userObj.UserId;
                        ActiveUser.Username = username;
                        ActiveUser.UserCompleteName = userObj.CompleteName;
                        ActiveUser.UserRolName = userObj.UserRol_Name;
                        ActiveUser.UserRolId = userObj.UserRol_Id;  

                        return userObj;
                    }
                    else
                        return null;
                }
            }
        }
    }
}
