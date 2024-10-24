using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientAndDoctorManagementSystem.Models;

namespace PatientAndDoctorManagementSystem.Repositries
{
    internal class Doctorrepository
    {
        private readonly string _connectionString;
        public Doctorrepository(string ConnectionString)
        {
            _connectionString = ConnectionString;

        }
        public Doctorrepository()
        {
            createDoctorTable();
        }
        private void createDoctorTable()
        {
            var connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pk\Documents\QuestDB.mdf;Integrated Security=True;Connect Timeout=30";
            var createTableQuery1 = @"CREATE TABLE DOCTORS
                                  (
                                    id INT PRIMARY KEY IDENTITY,
                                    Name VARCHAR(50) NOT NULL,
                                    Specialization VARCHAR(50),
                                    patientId int ,
                                    CONSTRAINT fk_id FOREIGN KEY(PatientId) REFERENCES PATIENTS(id);
                                    )";
            var conn  = new SqlConnection(connStr);
            conn.Open();
            var command = new SqlCommand(createTableQuery1, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
        public void AddDoctor(Doctor doctor)
        {
            List<Doctor> doctors = new List<Doctor>();
            using(SqlConnection conn=new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO DOCTORS (Name,Specialization,PatientId) VALUES(@Names,@Specialization,@PatientId)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", doctor.Name);
                cmd.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                cmd.Parameters.AddWithValue("@PatientId", (object)doctor.PatientId ?? DBNull.Value);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        


        }
        public List<Doctor> GetAllDoctor()
        {
            List<Doctor> doctors = new List<Doctor>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Doctor";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    doctors.Add(new Doctor
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString(),
                        Specialization = reader["Specialization"].ToString(),
                        PatientId = reader["PatientId"] as int?
                    });
                }
            }
            return doctors;
        }

        public void UpdateDoctor(Doctor doctor)
        {

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Doctor SET Name = @Name, Specialization = @Specialization WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", doctor.Id);
                cmd.Parameters.AddWithValue("@Name", doctor.Name);
                cmd.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

        }

        public void DeleteDoctor(int doctorId)
        {

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Doctor WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", doctorId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


    }
}
