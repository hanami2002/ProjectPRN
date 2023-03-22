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
    public class CategoryDAO:DBContext
    {
        public IEnumerable<Category> GetListCategory()
        {
            string queryString = "select * from Category";
            var categories = new List<Category>();
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
                        Category tb = new Category
                        ((int)reader[0], (string)reader[1]);

                        categories.Add(tb);
                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return categories;
            }
        }
    }
}
