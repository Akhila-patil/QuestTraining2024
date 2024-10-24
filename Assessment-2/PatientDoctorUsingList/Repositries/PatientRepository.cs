using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientDoctorUsingList.Models;

namespace PatientDoctorUsingList.Repositries
{
    internal class PatientRepository
    {

        private List<Patient> patients = new List<Patient>();

        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
            Console.WriteLine("Patient added successfully.");
        }

        public List<Patient> GetAllPatients()
        {
            return patients;
        }

        public void UpdatePatient(int id, string newCondition)
        {
            var patient = patients.FirstOrDefault(p => p.Id == id);
            if (patient != null)
            {
                patient.MedicalCondition = newCondition;
                Console.WriteLine("Patient updated successfully.");
            }
            else
            {
                Console.WriteLine("Patient not found.");
            }

        }

        public void DeletePatient(int id)
        {
            var patient = patients.FirstOrDefault(p => p.Id == id);
            if (patient != null)
            {
                patients.Remove(patient);
                Console.WriteLine("Patient deleted successfully.");
            }


            else
            {
                Console.WriteLine("Patient not found.");
            }
        }

    }
}
