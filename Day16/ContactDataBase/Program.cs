using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactDataBase
{
    
        public class Contact
        {
            public int id { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
        }
        public class ContactRepository
        {
            private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pk\Documents\QuestDB.mdf;Integrated Security=True;Connect Timeout=30";

            public ContactRepository()
            {
                CreateContactTable();
            }

            private void CreateContactTable()
            {
                string createTableQuery = @"CREATE TABLE CONTACTS
                                            ( 
                                            ID INT PRIMARY KEY IDENTITY,
                                            Name VARCHAR(50) NOT NULL,
                                            Phone VARCHAR(50) NOT NULL,
                                            Email VARCHAR(50)
                                            )";
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand command = new SqlCommand(createTableQuery, conn);
                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
            public void AddContact(Contact contact)
            {
                string query = "INSERT INTO CONTACTS(Name,Phone,Email) VALUES(@Name,@Phone,@Email)";
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Name", contact.Name);
                    command.Parameters.AddWithValue("@Phone", contact.Phone);
                    command.Parameters.AddWithValue("@Email", contact.Email);
                    conn.Open();
                    command.ExecuteNonQuery();


                }
            }

            public Contact SearchByNameOrPhone(string input)
            {
                string query = "SELECT * FROM CONTACTS WHERE Name=@Input OR Phone=@Input";
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Input", input);

                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Contact
                            {
                                id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Phone = reader.GetString(2),
                                Email = reader.IsDBNull(3) ? null : reader.GetString(3)
                            };

                        }
                    
                    }

                }
                return null;
            }

            public void UpdateContact(Contact contact)
            {

                string query = "UPDATE CONTACT SET Name=@Name,Phone=@Phone, Email=@Email WHERE ID=@ID";
                using(SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand command= new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Name", contact.Name);
                    command.Parameters.AddWithValue("@Phone", contact.Phone);
                    command.Parameters.AddWithValue("@Email", contact.Email ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ID", contact.id);

                    conn.Open();
                    command.ExecuteNonQuery();

                }
            }

            public void DeleteContact(Contact contact)
            {
                string query = "DELETE FROM CONTACT WHERE ID=@ID";
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@ID", contact.id);

                }
            }
        }

    internal class Program
    {
        static void Main(string[] args)
        {
            ContactRepository repository = new ContactRepository();

            repository.AddContact(new Contact { Name = "Akhila Patil", Phone = "123456789", Email = "ap@gmail.com" });

            var contact = repository.SearchByNameOrPhone("Akhila Patil");
            if (contact != null)
            {

            }

        }


    }
}

                


            
        
    

