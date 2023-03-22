using FoodLibrary.DataAccess;
using FoodLibrary.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLibrary.DAL
{
    public class MenuDAO:DBContext
    {
        public IEnumerable<Menu> GetMenuByIdCate(int id)
        {
            string queryString = "select * from Menu where idCategory=@id";
            var accounts = new List<Menu>();
            using (SqlConnection connection =
                new SqlConnection(getConnectionString()))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@id", id);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Menu employee = new Menu
                        ((int)reader[0], (string)reader[1], (double)reader[2], (int)reader[3]);

                        accounts.Add(employee);
                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return accounts;
            }
        }
        public IEnumerable<Menu> GetMenu()
        {
            string queryString = "select * from Menu ";
            var accounts = new List<Menu>();
            using (SqlConnection connection =
                new SqlConnection(getConnectionString()))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
               // command.Parameters.AddWithValue("@id", id);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Menu employee = new Menu
                        ((int)reader[0], (string)reader[1], (double)reader[2], (int)reader[3]);

                        accounts.Add(employee);
                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return accounts;
            }
        }
    }
}
