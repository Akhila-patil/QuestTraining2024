//{Fields:
//Id(INT, Primary Key) – Unique identifier of the patient.
//Name(NVARCHAR(100)) – Name of the patient.
//Age(INT) – Age of the patient.
//Gender(NVARCHAR(10)) – Gender of the patient.
//MedicalCondition(NVARCHAR(200)) – Medical condition of the patient.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAndDoctorManagementSystem.Models { 

    internal class Patient
    {
    public int id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public Gender Gender { get; set; }  
    public string MedicalCondition { get; set; }
    }
    public enum Gender{
        Male,
        Female,
        other
    }
}
