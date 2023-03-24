using FoodLibrary.DataAccess;
using FoodLibrary.Object;
using System;
using System.Collections;
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
                        //int? id =(int) reader[0]; 
                        //if (id == null)
                        //{
                        //    return 0 ;
                        //}
                        //else {
                        //    return (int)reader[0];
                        //}
                        return (int)reader[0];
                    }
                }
                catch (Exception ex)
                {
                    return 0;
                    //throw new Exception(ex.Message);
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
        public void CheckOut(int idTable,double price)
        {
            string sql = "update [Order] set StatusID=3 ,dateCheckout=getdate(),total="+price+" where idTable=@id";
            using (SqlConnection connection =
                new SqlConnection(getConnectionString()))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", idTable);               
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
        public void MoveTable(int id1,int id2)
        {
            
            string sql = "exec pro_Switch_table @idTable1=@id1,@idTable2=@id2,@id1=@id3,@id2=@id4";
            using (SqlConnection connection =
                new SqlConnection(getConnectionString()))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id1", id1);
                command.Parameters.AddWithValue("@id2", id2);
                command.Parameters.AddWithValue("@id4", GetMaxID("[order]"));
                command.Parameters.AddWithValue("@id3", GetMaxID("[order]"));
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
        public ArrayList GetListByDate(DateTime date1,DateTime date2)
        {
            string sql = "exec pro_GetListBillbyDate @checkin=@d1 ,@checkout= @d2";
            using (SqlConnection connection =
                new SqlConnection(getConnectionString()))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@d1", date1);
                command.Parameters.AddWithValue("@d2", date2);
                var list = new ArrayList();
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        var new1 = new { 
                            TableName = (string)reader[0],
                            Total = (double)reader[1],
                            CheckIn= (DateTime)reader[2],
                            CheckOut= (DateTime)reader[3]
                        };
                        list.Add(new1);
                    }
                    return list;
                    
                    connection.Close();
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
