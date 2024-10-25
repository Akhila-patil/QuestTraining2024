using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientAndDoctorManagementSystem.Models;

namespace PatientAndDoctorManagementSystem.Repositries
{
    internal class PatientRepository
    {
        private readonly string _connectionString;
        public  PatientRepository(string ConnectionString)
        {
             _connectionString = ConnectionString;
        }
        public  PatientRepository()
        {
            CreatePatientTable();
        }
        public void CreatePatientTable()
        {
            

            var createTableQuery = @"CREATE TABLE PATIENTS
                                  (
                                    id INT PRIMARY KEY IDENTITY,
                                    Name VARCHAR(50) NOT NULL,
                                    Age INT NOT NULL,
                                    Gender VARCHAR(20) NOT NULL,
                                    MedicalCondition VARCHAR(200) NOT NULL
                                    )";
            var conn = new SqlConnection(_connectionString);
            conn.Open();
            var command = new SqlCommand(createTableQuery, conn);
            command.ExecuteNonQuery();
            conn.Close();

        }

        public void AddPatient(Patient patient)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString)) 
            {
                string insertQuery = "INSERT INTO Patients (Name, Age, Gender, MedicalCondition) VALUES (@Name, @Age, @Gender, @MedicalCondition)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@Name", patient.Name);
                cmd.Parameters.AddWithValue("@Age", patient.Age);
                cmd.Parameters.AddWithValue("@Gender", patient.Gender.ToString());
                cmd.Parameters.AddWithValue("@MedicalCondition", patient.MedicalCondition);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

        }
        public List<Patient> GetAllPatients()
        {
            var patients = new List<Patient>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Patients";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        patients.Add(new Patient
                        {
                            id = (int)reader["Id"],
                            Name = reader["Name"].ToString(),
                            Age = (int)reader["Age"],
                            Gender = Enum.TryParse(reader["Gender"].ToString(), out Gender g) ? g : Gender.other,
                            MedicalCondition = reader["MedicalCondition"].ToString()
                        });
                    }
                }
            }
            return patients;
        }

        public void UpdatePatient(Patient patient)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string updateQuery = "UPDATE Patient SET Name = @Name, Age = @Age, Gender = @Gender, MedicalCondition = @MedicalCondition WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@Id", patient.id);
                cmd.Parameters.AddWithValue("@Name", patient.Name);
                cmd.Parameters.AddWithValue("@Age", patient.Age);
                cmd.Parameters.AddWithValue("@Gender", patient.Gender);
                cmd.Parameters.AddWithValue("@MedicalCondition", patient.MedicalCondition);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

        }
        public void DeletePatient(int patientId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string deleteQuery = "DELETE FROM Patient WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                cmd.Parameters.AddWithValue("@Id", patientId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }



    }
}
