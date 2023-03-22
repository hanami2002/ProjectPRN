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
    public class TableDAO:DBContext
    {
        public IEnumerable<Table> GetListTables()
        {
            string queryString = "select*from [Table]";
            var tables = new List<Table>();
            using (SqlConnection connection =
                new SqlConnection(getConnectionString()))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                //command.Parameters.AddWithValue("@pricePoint", paramValue);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Table tb = new Table
                        ((int)reader[0], (string)reader[1], (int)reader[2]);

                        tables.Add(tb);
                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return tables;
            }
        }
    }
}
