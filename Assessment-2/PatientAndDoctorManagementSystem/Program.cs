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
        static void Main(string[] args)
        {
            var connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pk\Documents\QuestDB.mdf;Integrated Security=True;Connect Timeout=30";
           
            //var createTableQuery = @"CREATE TABLE PATIENTS
            //                      (
            //                        id INT PRIMARY KEY IDENTITY,
            //                        Name VARCHAR(50) NOT NULL,
            //                        Age INT NOT NULL,
            //                        Gender VARCHAR(20) NOT NULL,
            //                        MedicalCondition VARCHAR(200) NOT NULL
            //                        )";
            //var conn=new SqlConnection(connStr);
            //conn.Open();
            //var command=new SqlCommand(createTableQuery,conn);
            //command.ExecuteNonQuery();
            //conn.Close();

            //var createTableQuery1 = @"CREATE TABLE DOCTORS
            //                      (
            //                        id INT PRIMARY KEY IDENTITY,
            //                        Name VARCHAR(50) NOT NULL,
            //                        Specialization VARCHAR(50),
            //                        patientId int ,
            //                        CONSTRAINT fk_id FOREIGN KEY(PatientId) REFERENCES PATIENTS(id);
            //                        )";
            //var conn1 = new SqlConnection(connStr);
            //conn.Open();
            //var command1 = new SqlCommand(createTableQuery1, conn);
            //command.ExecuteNonQuery();
            //conn.Close();


             PatientRepository patientRepo=new PatientRepository(connStr);
            Doctorrepository doctorrepository = new Doctorrepository(connStr);

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
                        AddPatient();
                        break;

                    case "2":
                        GetAllPatients();
                        break;
                    case "3":
                       UpdatePatient();
                       break;
                    case "4":
                        DeletePatient();
                        break;
                    case "5":
                        AddDoctor();
                        break;

                    case "6":
                        GetAllDoctor();
                        break;
                    case "7":
                        UpdateDoctor();
                        break;
                    case "8":
                        DeleteDoctor();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;

                }


            }
            

        }
    }
    private static void AddPatient()
    {
        Console.Write("Enter patient name: ");
        var name = Console.ReadLine();
        Console.Write("Enter age: ");
        var age = int.Parse(Console.ReadLine());
        Console.Write("Enter gender: ");
        var gender = Console.ReadLine();
        Console.Write("Enter medical condition: ");
        var medicalCondition = Console.ReadLine();

        var patientRepo = new PatientRepository(connStr);
        patientRepo.AddPatient(new Patient { Name = name, Age = age, Gender = gender, MedicalCondition = medicalCondition });
        Console.WriteLine("Patient added successfully.");
    }

    private static void GetAllPatients()
    {
        var patientRepo = new PatientRepository(connStr);
        var patients = patientRepo.GetAllPatients();
        foreach (var patient in patients)
        {
            Console.WriteLine($"Id: {patient.id}, Name: {patient.Name}, Age: {patient.Age}, Gender: {patient.Gender}, Condition: {patient.MedicalCondition}");
        }
    }

    private static void UpdatePatient()
    {
        Console.Write("Enter patient ID to update: ");

        var id = int.Parse(Console.ReadLine());

        Console.Write("Enter new patient name: ");
        var name = Console.ReadLine();
        Console.Write("Enter new age: ");
        var age = int.Parse(Console.ReadLine());
        Console.Write("Enter new gender: ");
        var gender = Console.ReadLine();
        Console.Write("Enter new medical condition: ");
        var medicalCondition = Console.ReadLine();

        var patientRepo = new PatientRepository(connStr);
        patientRepo.UpdatePatient(new Patient { id = id, Name = name, Age = age, Gender = gender, MedicalCondition = medicalCondition });
        Console.WriteLine("Patient updated successfully.");
    }

    private static void DeletePatient()
    {
        Console.WriteLine("Enter patient ID to delete:");
        var id = int.Parse(Console.ReadLine());

        var patientRepo = new PatientRepository(connStr);
        patientRepo.DeletePatient(id);
        Console.WriteLine("Patient deleted successfully.");

    }


    private static void AddDoctor()
    {
        Console.Write("Enter doctor name: ");
        var name = Console.ReadLine();
        Console.Write("Enter specialization: ");
        var specialization = Console.ReadLine();
        Console.Write("Enter patient Id (if any, or leave blank): ");
        var patientIdInput = Console.ReadLine();
        int? patientId = string.IsNullOrEmpty(patientIdInput) ? (int?)null : int.Parse(patientIdInput);

        var doctorRepo = new Doctorrepository(connStr);
        doctorRepo.AddDoctor(new Doctor { Name = name, Specialization = specialization, PatientId = patientId });
        Console.WriteLine("Doctor added successfully.");
    }

    private static void GetAllDoctor()
    {
        var doctorRepo = new Doctorrepository(connStr);
        var doctors = doctorRepo.GetAllDoctors();
        foreach (var doctor in doctors)
        {
            Console.WriteLine($"Id: {doctor.Id}, Name: {doctor.Name}, Specialization: {doctor.Specialization}, PatientId: {doctor.PatientId}");
        }
    }

    private static void UpdateDoctor()
    {
        Console.Write("Enter doctor ID to update: ");
        var id = int.Parse(Console.ReadLine());

        Console.Write("Enter new doctor name: ");
        var name = Console.ReadLine();

        Console.Write("Enter new specialization: ");
        var specialization = Console.ReadLine();

        Console.Write("Enter new patient Id : ");
        var patientIdInput = Console.ReadLine();
        int? patientId = string.IsNullOrEmpty(patientIdInput) ? (int?)null : int.Parse(patientIdInput);

        var doctorRepo = new Doctorrepository(connStr);
        doctorRepo.UpdateDoctor(new Doctor { Id = id, Name = name, Specialization = specialization, PatientId = patientId });
        Console.WriteLine("Doctor updated successfully.");
    }

    private static void DeleteDoctor()
    {
        Console.Write("Enter doctor ID to delete: ");
        var id = int.Parse(Console.ReadLine());

        var doctorRepo = new Doctorrepository(connStr);
        doctorRepo.DeleteDoctor(id);
        Console.WriteLine("Doctor deleted successfully.");
    }




}
