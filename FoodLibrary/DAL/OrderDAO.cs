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
    public class OrderDAO : DBContext
    {
        public int GetIdByTableId(int tableId)
        {
            string sql = "select *from [order] where idTable=@id and statusId=4";
            using (SqlConnection connection =
                new SqlConnection(getConnectionString()))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", tableId);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {


                        return (int)reader[0];
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return -1;
        }
        public int GetMaxID(string tables)
        {
            string sql = "select max(id) from "+tables;           
            using (SqlConnection connection =
                new SqlConnection(getConnectionString()))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader[0]==null)
                        {
                            return 0;
                        }
                        else {
                            return (int)reader[0];
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return -1;
        }
        public void InsertOrder(int idorder,int idtable)
        {
            string sql = "exec pro_InserOrder @idOrder =@id1 ,@idTable =@id2";
            using (SqlConnection connection =
                new SqlConnection(getConnectionString()))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id1", idorder);
                command.Parameters.AddWithValue("@id2", idtable);

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
