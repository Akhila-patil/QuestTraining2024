using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientDoctorUsingList.Models;

namespace PatientDoctorUsingList.Repositries
{
    internal class DoctorRepository
    {
        private List<Doctor> doctors = new List<Doctor>();

        public void AddDoctor(Doctor doctor)
        {
            doctors.Add(doctor);
            Console.WriteLine("Doctor added successfully.");
        }

        public List<Doctor> GetAllDoctors()
        {
            return doctors;
        }

        public void UpdateDoctorSpecialization(int id, string newSpecialization)
        {
            var doctor = doctors.FirstOrDefault(d => d.Id == id);
            if (doctor != null)

            {
                doctor.Specialization = newSpecialization;
                Console.WriteLine("Doctor updated successfully.");
            }
            else
            {
                Console.WriteLine("Doctor not found.");
            }
        }

        public void DeleteDoctor(int id)
        {

            var doctor = doctors.FirstOrDefault(d => d.Id == id);
            if (doctor != null)
            {
                doctors.Remove(doctor);
                Console.WriteLine("Doctor deleted successfully.");
            }
            else
            {
                Console.WriteLine("Doctor not found.");
            }

        }
    }
}
