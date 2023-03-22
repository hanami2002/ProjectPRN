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
    public class StatusDAO:DBContext
    {
        public string GetNameByID(int id)
        {
            string sql = "select*from [Status] where id=@id";
            using (SqlConnection connection =
                new SqlConnection(getConnectionString()))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Status stt= new Status
                        ((int)reader[0], (string)reader[1]);

                        return stt.sttName;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return null;
            }
        }
    }
}
