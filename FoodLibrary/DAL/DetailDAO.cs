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
    public class DetailDAO:DBContext
    {
        public IEnumerable<OrderDetails> GetDetailsById(int id)
        {
            string queryString = "select *from[orderdetail] where idorder=@id";
            var accounts = new List<OrderDetails>();
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
                        OrderDetails employee = new OrderDetails
                        ((int)reader[0], (int)reader[1], (int)reader[2], (int)reader[3]);

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
        public IEnumerable<Bill> GetBillByTable(int id)
        {
                string queryString = "select m.[name],od.counts,m.price,od.counts*m.price " +
                    "from orderdetail od, [order] o, menu m" +
                    "\nwhere od.idOrder= o.id and od.idfood= m.id and o.statusID=4 and o.id=@id";
            var accounts = new List<Bill>();
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
                        Bill employee = new Bill
                        ((string)reader[0], (int)reader[1], (double)reader[2], (double  )reader[3]);

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
        public void InsertOrderDetail(int id,int idorder, int food,int count)
        {
            string sql = "exec pro_InsertBillInfo @id=@id, @idOrder =@id1 ,@idFood =@id2,@count=@id3";
            using (SqlConnection connection =
                new SqlConnection(getConnectionString()))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@id1", idorder);
                command.Parameters.AddWithValue("@id2", food);
                command.Parameters.AddWithValue("@id3", count);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
