using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pk\Documents\QuestDB.mdf;Integrated Security=True;Connect Timeout=30";
            //var createTableQuery = @"CREATE TABLE Books
            //    (
            //      id INT PRIMARY KEY IDENTITY,
            //      name VARCHAR(50),
            //      author  VARCHAR(50),
            //      price int default 0
            //    )";

            //var conn = new SqlConnection(connStr);
            //conn.Open();
            //var command = new SqlCommand(createTableQuery, conn);
            //command.ExecuteNonQuery();
            //conn.Close();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();


                Console.WriteLine("Enter the id:");
                var id = Console.ReadLine();

                Console.WriteLine("Author:");
                var author = Console.ReadLine();

                Console.WriteLine("Enter the price of book:");
                int price = int.Parse(Console.ReadLine());


                var insertQuery = @"INSERT INTO Books (name, author, price) 
                                VALUES (@name, @author, @price)";


            }





        }
    }
}
