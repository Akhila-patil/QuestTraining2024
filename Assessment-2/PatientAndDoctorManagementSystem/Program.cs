/*Patient and Doctor Management System Using MSSQL
Task:

Create a C# console application that interacts with an MSSQL database to manage records of patients and doctors. Focus on basic CRUD operations for two separate tables: Patient and Doctor.
1. Database Schema
Patient Table

Fields:
Id (INT, Primary Key) – Unique identifier of the patient.
Name (NVARCHAR(100)) – Name of the patient.
Age (INT) – Age of the patient.
Gender (NVARCHAR(10)) – Gender of the patient.
MedicalCondition (NVARCHAR(200)) – Medical condition of the patient.
Doctor Table

Fields:
Id (INT, Primary Key) – Unique identifier of the doctor.
Name (NVARCHAR(100)) – Name of the doctor.
Specialization (NVARCHAR(100)) – Specialization of the doctor (e.g., Cardiologist, Neurologist).
PatientId (INT, Optional) – A nullable field to assign a patient to the doctor if needed (foreign key to Patient.Id).
2. Application Requirements
Perform CRUD Operations for Patients and DoctorsImplement the following operations using ADO.NET, keeping the operations simple for each table:
Create:
Add a new patient to the Patient table.
Add a new doctor to the Doctor table.
Read:
Retrieve and display a list of all patients with their details (name, age, medical condition).
Retrieve and display a list of all doctors with their specializations.
Update:
Update a patient’s details (e.g., medical condition).
Update a doctor’s specialization.
Delete:
Delete a patient record from the Patient table.
Delete a doctor record from the Doctor table.
 */



using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientAndDoctorManagementSystem.Models;
using PatientAndDoctorManagementSystem.Repositries;

namespace PatientAndDoctorManagementSystem
{
    internal class Program
    {
        public const string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pk\Documents\QuestDB.mdf;Integrated Security=True;Connect Timeout=30";
        static void Main(string[] args)
        {
             

            PatientRepository patientRepo =new PatientRepository(connStr);
            Doctorrepository doctorRepo = new Doctorrepository(connStr);
            HospitalManager manager = new HospitalManager();

            while (true)
            {
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. Get all Patients");
                Console.WriteLine("3. Update Patient");
                Console.WriteLine("4. Delete Patient");
                Console.WriteLine("5. Add Doctor");
                Console.WriteLine("6. Get all Doctors");
                Console.WriteLine("7. Update Doctor");
                Console.WriteLine("8. Delete Doctor");
                Console.WriteLine("9. Exit");

                Console.Write("Select an option: ");
                var Option = Console.ReadLine();

                switch (Option)
                {
                    case "1":

                        manager.AddPatient();
                        break;

                    case "2":
                        manager.GetAllPatients();
                        break;
                    case "3":
                        manager.UpdatePatient();
                       break;
                    case "4":
                        manager.DeletePatient();
                        break;
                    case "5":
                        manager.AddDoctor();
                        break;

                    case "6":
                        manager.GetAllDoctor();
                        break;
                    case "7":
                        manager.UpdateDoctor();
                        break;
                    case "8":
                        manager.DeleteDoctor();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;

                }


            }
            

        }
    }
   


}
