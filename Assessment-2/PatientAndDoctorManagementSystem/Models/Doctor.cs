//Fields:
//Id(INT, Primary Key) – Unique identifier of the doctor.
//Name (NVARCHAR(100)) – Name of the doctor.
//Specialization (NVARCHAR(100)) – Specialization of the doctor (e.g., Cardiologist, Neurologist).
//PatientId (INT, Optional) – A nullable field to assign a patient to the doctor if needed (foreign key to Patient.Id).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAndDoctorManagementSystem.Models
{
    internal class Doctor
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Specialization { get; set; }
        public int ? PatientId { get; set; }


    }
}
