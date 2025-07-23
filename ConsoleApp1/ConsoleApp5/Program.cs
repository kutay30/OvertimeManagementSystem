// See https://aka.ms/new-console-template for more information

using System;
using System.Data;
using System.Data.SqlClient;
using Npgsql;

namespace ConsoleApp5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=123;Database=kutay");
            connection.Open();
            NpgsqlCommand command=new NpgsqlCommand("SELECT * FROM category", connection);
            var adapter=new NpgsqlDataAdapter(command);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            
            
            
            
            
            
            
            
            
            
            
            
            connection.Close();


            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item);
                    
                }
                Console.WriteLine();
            }
            {
                
            }
            

        }
    }
}

