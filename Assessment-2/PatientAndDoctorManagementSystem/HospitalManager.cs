using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientAndDoctorManagementSystem.Models;
using PatientAndDoctorManagementSystem.Repositries;

namespace PatientAndDoctorManagementSystem
{
    internal class HospitalManager
    {
        public void AddPatient()
        {
            Console.Write("Enter patient name: ");
            var name = Console.ReadLine();
           
            Console.Write("Enter age: ");
            var age = int.Parse(Console.ReadLine());

            Console.Write("Enter gender(Male/Female/Other): ");
            var genderinput = Console.ReadLine();
            Gender gender;
            if (!Enum.TryParse(genderinput, true, out gender))
            {
                Console.WriteLine("Invalid gender input");
                gender = Gender.other;
            }
            Console.Write("Enter medical condition: ");
            var medicalCondition = Console.ReadLine();

            var patientRepo = new PatientRepository();
            patientRepo.AddPatient(new Patient { Name = name, Age = age, Gender = gender, MedicalCondition = medicalCondition });
            Console.WriteLine("Patient added successfully.");
        }
        public void GetAllPatients()
        {
            var patientRepo = new PatientRepository();
            var patients = patientRepo.GetAllPatients();
            foreach (var patient in patients)
            {
                Console.WriteLine($"Id: {patient.id}, Name: {patient.Name}, Age: {patient.Age}, Gender: {patient.Gender}, Condition: {patient.MedicalCondition}");
            }
        }
        public void UpdatePatient()
        {
            Console.Write("Enter patient ID to update: ");

            var id = int.Parse(Console.ReadLine());

            Console.Write("Enter new patient name: ");
            var name = Console.ReadLine();

            Console.Write("Enter new age: ");
            var age = int.Parse(Console.ReadLine());

            Console.Write("Enter new gender(Male/Female/Other): ");
            var genderinput = Console.ReadLine();
            Gender gender;
            if(!Enum.TryParse(genderinput,true,out gender))
            {
                Console.WriteLine("Invalid gender input");
                gender = Gender.other;
            }
            Console.Write("Enter new medical condition: ");
            var medicalCondition = Console.ReadLine();

            var patientRepo = new PatientRepository();
            patientRepo.UpdatePatient(new Patient { id = id, Name = name, Age = age, Gender = gender, MedicalCondition = medicalCondition });
            Console.WriteLine("Patient updated successfully.");
        }
        public void DeletePatient()
        {
            Console.WriteLine("Enter patient ID to delete:");
            var id = int.Parse(Console.ReadLine());

            var patientRepo = new PatientRepository();
            patientRepo.DeletePatient(id);
            Console.WriteLine("Patient deleted successfully.");

        }
        public void AddDoctor()
        {
            Console.Write("Enter doctor name: ");
            var name = Console.ReadLine();
            Console.Write("Enter specialization: ");
            var specialization = Console.ReadLine();
            Console.Write("Enter patient Id ");
            var patientIdInput = Console.ReadLine();
            int? patientId = string.IsNullOrEmpty(patientIdInput) ? (int?)null : int.Parse(patientIdInput);

            var doctorRepo = new Doctorrepository();
            doctorRepo.AddDoctor(new Doctor { Name = name, Specialization = specialization, PatientId = patientId });
            Console.WriteLine("Doctor added successfully.");
        }
        public void GetAllDoctor()
        {
            var doctorRepo = new Doctorrepository();
            var doctors = doctorRepo.GetAllDoctor();
            foreach (var doctor in doctors)
            {
                Console.WriteLine($"Id: {doctor.Id}, Name: {doctor.Name}, Specialization: {doctor.Specialization}, PatientId: {doctor.PatientId}");
            }
        }
        public void UpdateDoctor()
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

            var doctorRepo = new Doctorrepository();
            doctorRepo.UpdateDoctor(new Doctor { Id = id, Name = name, Specialization = specialization, PatientId = patientId });
            Console.WriteLine("Doctor updated successfully.");
        }
        public void DeleteDoctor()
        {
            Console.Write("Enter doctor ID to delete: ");
            var id = int.Parse(Console.ReadLine());

            var doctorRepo = new Doctorrepository();
            doctorRepo.DeleteDoctor(id);
            Console.WriteLine("Doctor deleted successfully.");
        }
    }
}
