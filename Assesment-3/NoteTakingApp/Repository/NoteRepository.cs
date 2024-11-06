using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteTakingApp.Models;

namespace NoteTakingApp.Repository
{
    public class NoteRepository 
    {
        private readonly string _connectionString;
        public NoteRepository(string ConnectionString)
        {
            _connectionString = ConnectionString;

        }
        public NoteRepository()
        {
            createDoctorTable();
        }
        public void createDoctorTable()
        {
            var createTableQuery = @"CREATE TABLE Notes
                                   (
                                   Id INT IDENTITY PRIMARY KEY,
                                   Title  VARCHAR(100) NOT NULL,
                                   Content VARCHAR(1000) NOT NULL,
                                   CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
                                   UpdatedAt DATETIME NULL
                                   )";
            var conn = new SqlConnection(_connectionString);
            conn.Open();
            var command = new SqlCommand(createTableQuery, conn);
            command.ExecuteNonQuery();
            
        }
        public List<Note> GetAllNotes()
        {
            var notes = new List<Note>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var query = "select * from Notes";
                using(var cmd=new SqlCommand(query, connection))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        notes.Add(new Note
                        {
                            Id = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Content = reader.GetString(2),
                            CreatedAt = reader.GetDateTime(3),
                            UpdatedAt = reader.GetDateTime(4)
                        });
                    }
                    cmd.ExecuteNonQuery();
                }
            }
            return notes;
        }
        public void AddNote(Note note)
        {
            using(var connection=new SqlConnection(_connectionString))
            {
                connection.Open();
                var query = "INSERT INTO NOTE(Title,Content) VALUES(@Title,@Content)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Title", note.Title);
                    command.Parameters.AddWithValue("@Content", note.Content);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public void UpdateNote( int id,Note note)
        {
            using(var connection=new SqlConnection(_connectionString))
            {
                connection.Open();
                var query = "UPDATE Notes SET Title=@Title,Content=@Content,UpdatedAt=GETDATE() WHERE id=@Id";
                using(var cmd=new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Title", note.Title);
                    cmd.Parameters.AddWithValue("@Content", note.Content);
                    cmd.Parameters.AddWithValue("@Id", note.Id) ;
                    cmd.ExecuteNonQuery();
                    


                }
            }
        }
        public void DeleteNote(int id)
        {
            using(var connection=new SqlConnection(_connectionString))
            {
                connection.Open();
                var query = "DELETE FROM Notes WHERE Id=@Id";
                using(var cmd=new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id",id);
                    cmd.ExecuteNonQuery();
                }
                
            }
        }

       
    }
}
