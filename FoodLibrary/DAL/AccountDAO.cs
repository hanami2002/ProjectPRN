﻿using FoodLibrary.DataAccess;
using FoodLibrary.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace FoodLibrary.DAL
{
    public class AccountDAO : DBContext
    {
        public IEnumerable<Account> GetListAcc()
        {
            string queryString = "select * from Account";
            var accounts = new List<Account>();
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
                        Account employee = new Account
                        ((string)reader[0], (string)reader[1], (string)reader[2], (int)reader[3]);

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
        public Account Login(string username, string password)
        {
            string sql = "select*from Account where userName=@user and [password]=@pass";
            using (SqlConnection connection =
                new SqlConnection(getConnectionString()))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@user", username);
                command.Parameters.AddWithValue("@pass", password);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Account acc = new Account
                        ((string)reader[0], (string)reader[1], (string)reader[2], (int)reader[3]);
                        connection.Close();
                        return acc;
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return null;
            }
        }
        public Account GetAccountByUserName(string username)
        {
            string sql = "select*from Account where userName=@user";
            using (SqlConnection connection =
                new SqlConnection(getConnectionString()))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@user", username);
                //    command.Parameters.AddWithValue("@pass", password);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Account acc = new Account
                        ((string)reader[0], (string)reader[1], (string)reader[2], (int)reader[3]);
                        connection.Close();
                        return acc;

                    }

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return null;
            }
        }
        public void UpdateInfoAccount(string username, string display, string passsO, string passN)
        {
            string sql = "update account set displayName=@display,[password]=@newpass where username= @username and [password]=@passO";
            using (SqlConnection connection =
               new SqlConnection(getConnectionString()))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@passO", passsO);
                command.Parameters.AddWithValue("@newpass", passN);
                command.Parameters.AddWithValue("@display", display);

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
