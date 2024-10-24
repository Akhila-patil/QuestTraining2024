using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientDoctorUsingList.Models;
using PatientDoctorUsingList.Repositries;

namespace PatientDoctorUsingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var patientRepository = new PatientRepository();
            var doctorRepository = new DoctorRepository();

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
                        AddPatient(patientRepository);
                        break;
                    case "2":
                        AddDoctor(doctorRepository);
                        break;
                    case "3":
                        GetAllPatients(patientRepository);
                        break;
                    case "4":
                        GetAllDoctors(doctorRepository);
                        break;
                    case "5":
                        UpdatePatient(patientRepository);
                        break;
                    case "6":
                        UpdateDoctor(doctorRepository);
                        break;
                    case "7":
                        DeletePatient(patientRepository);
                        break;
                    case "8":
                        DeleteDoctor(doctorRepository);
                        break;
                    case "9":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            }
                    
        }



        static void AddPatient(PatientRepository patientRepository)
        {
            Console.WriteLine("Enter Patient Id:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Patient Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Patient Age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Patient Gender:");
            string gender = Console.ReadLine();

            Console.WriteLine("Enter Patient Medical Condition:");
            string condition = Console.ReadLine();

            patientRepository.AddPatient(new Patient { Id = id, Name = name, Age = age, Gender = gender, MedicalCondition = condition });
        }

        static void AddDoctor(DoctorRepository doctorRepository)
        {
            Console.WriteLine("Enter Doctor Id:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Doctor Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Doctor Specialization:");
            string specialization = Console.ReadLine();

            doctorRepository.AddDoctor(new Doctor { Id=id, Name=name, Specialization = specialization });
        }

        static void GetAllPatients(PatientRepository patientRepository)
        {
            var patients = patientRepository.GetAllPatients();
            foreach (var patient in patients)
            {
                Console.WriteLine($"Id: {patient.Id}, Name: {patient.Name}, Age: {patient.Age}, Gender: {patient.Gender}, Medical Condition: {patient.MedicalCondition}");
            }
        }

        static void GetAllDoctors(DoctorRepository doctorRepository)
        {
            var doctors = doctorRepository.GetAllDoctors();
            foreach (var doctor in doctors)
            {
                Console.WriteLine($"Id: {doctor.Id}, Name: {doctor.Name}, Specialization: {doctor.Specialization}");
            }
        }

        static void UpdatePatient(PatientRepository patientRepository)
        {
            Console.WriteLine("Enter Patient Id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter New Medical Condition:");
            string condition = Console.ReadLine();

            patientRepository.UpdatePatient(id, condition);
        }

        static void UpdateDoctor(DoctorRepository doctorRepository)
        {
            Console.WriteLine("Enter Doctor Id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter New Specialization:");
            string specialization = Console.ReadLine();

            doctorRepository.UpdateDoctorSpecialization(id, specialization);
        }

        static void DeletePatient(PatientRepository patientRepository)
        {
            Console.WriteLine("Enter Patient Id:");
            int id = int.Parse(Console.ReadLine());

            patientRepository.DeletePatient(id);
        }

        static void DeleteDoctor(DoctorRepository doctorRepository)
        {
            Console.WriteLine("Enter Doctor Id:");
            int id = int.Parse(Console.ReadLine());

            doctorRepository.DeleteDoctor(id);
        }
    }
}
