/* You are building a healthcare management system. You have two entities: Patient and Appointment.
Patient: Stores information about patients.
Id: Unique identifier of the patient.
Name: Name of the patient.
Age: Age of the patient.
Gender: Gender of the patient.
MedicalCondition: Primary medical condition of the patient.
Appointment: Stores information about the appointments made by patients.
Id: Unique identifier of the appointment.
PatientId: The ID of the patient who has the appointment.
DoctorName: The name of the doctor for the appointment.
AppointmentDate: Date and time of the appointment.
AppointmentType: Type of appointment (e.g., "Consultation", "Surgery", "Follow-up").
Task:
Using LINQ, write a query to find the following information:
List all the patients (name, age, medical condition) who have an upcoming appointment within the next 7 days.
Group the patients by their MedicalCondition and return the total number of patients in each condition category who have upcoming appointments.
Find the patient(s) with the most appointments in the last 30 days. If there are multiple patients with the same number of appointments, return all of them.
For patients over the age of 60, list the patient names along with their most recent appointment (doctor's name, date, and type of appointment).
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagementSystem
{
    internal class Program
    {

        public class Patient
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }
            public string MedicalCondition { get; set; }
        }

        
        public class Appointment
        {
            public int Id { get; set; }
            public int PatientId { get; set; }
            public string DoctorName { get; set; }
            public DateTime AppointmentDate { get; set; }
            public string AppointmentType { get; set; }
        }
        static void Main(string[] args)
        {

            var patients = new List<Patient>
        {
            new Patient { Id = 1, Name = "John Doe", Age = 65, Gender = "Male", MedicalCondition = "Diabetes" },
            new Patient { Id = 2, Name = "Jane Smith", Age = 45, Gender = "Female", MedicalCondition = "Hypertension" },
            new Patient { Id = 3, Name = "Michael Brown", Age = 70, Gender = "Male", MedicalCondition = "Heart Disease" },
            new Patient { Id = 4, Name = "Emily White", Age = 50, Gender = "Female", MedicalCondition = "Diabetes" },
        };

           
            var appointments = new List<Appointment>
        {
            new Appointment { Id = 1, PatientId = 1, DoctorName = "Dr. Adams", AppointmentDate = DateTime.Now.AddDays(3), AppointmentType = "Consultation" },
            new Appointment { Id = 2, PatientId = 1, DoctorName = "Dr. Adams", AppointmentDate = DateTime.Now.AddDays(-5), AppointmentType = "Follow-up" },
            new Appointment { Id = 3, PatientId = 2, DoctorName = "Dr. Blake", AppointmentDate = DateTime.Now.AddDays(1), AppointmentType = "Consultation" },
            new Appointment { Id = 4, PatientId = 3, DoctorName = "Dr. Clark", AppointmentDate = DateTime.Now.AddDays(4), AppointmentType = "Surgery" },
            new Appointment { Id = 5, PatientId = 4, DoctorName = "Dr. Evans", AppointmentDate = DateTime.Now.AddDays(8), AppointmentType = "Consultation" },
            new Appointment { Id = 6, PatientId = 1, DoctorName = "Dr. Adams", AppointmentDate = DateTime.Now.AddDays(-10), AppointmentType = "Consultation" }
        };


            //Patient who have appointment in the next 7 days:
            var upcomingAppointments = from appointment in appointments
                                       where appointment.AppointmentDate > DateTime.Now && appointment.AppointmentDate <= DateTime.Now.AddDays(7)
                                       join patient in patients on appointment.PatientId equals patient.Id
                                       select new { patient.Name,patient.Age, patient.MedicalCondition, appointment.AppointmentDate, appointment.AppointmentType };

            Console.WriteLine("Patients with upcoming appointments in the next 7 days:");
            foreach (var item in upcomingAppointments)
            {
                Console.WriteLine($"\n{item.Name},\nAge: {item.Age},\nCondition: {item.MedicalCondition},\nAppointment: {item.AppointmentType} on {item.AppointmentDate}");
            }

            //Group the patients by their MedicalCondition and return the total number of patients in each condition category who have upcoming appointments.
            var groupedByCondition = from appointment in appointments
                                       where appointment.AppointmentDate > DateTime.Now && appointment.AppointmentDate <= DateTime.Now.AddDays(7)
                                        join patient in patients on appointment.PatientId equals patient.Id
                                        group patient by patient.MedicalCondition into patientGroup
                                        select new { MedicalCondition = patientGroup.Key, PatientCount = patientGroup.Count() };

        }





    }
}
