using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDatabase
{
    internal class Program
    {
        static Dictionary<string, Dictionary<string, object>> patients = new Dictionary<string, Dictionary<string, object>>();

        static void AddPatient()
        {
            Console.WriteLine("Enter the patient Id:");
            string patientId = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter the patient name:");
            string name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter the patient age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter the type of diagnosis");
            string diagnosis = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter the status of Admission [Admitted or Discharged]:");
            string status = Console.ReadLine();
            Console.WriteLine();



            if (!patients.ContainsKey(patientId))
            {
                var patientDetails = new Dictionary<string, object>
                {
                    {"Name",name },
                    {"Age",age },
                    {"Diagnosis",diagnosis},
                    {"AdmissionStatus",status }
                };
                patients.Add(patientId, patientDetails);

                Console.WriteLine("Patient details added successfully");
                Console.WriteLine();
            }
            
            else
            {
                Console.WriteLine("patient id  already exist");
            }


        }

        static void SearchAndUpdateOfPatient()
        {
            Console.WriteLine("Enter the id of patient:");
            string patientId = Console.ReadLine();
            if (patients.ContainsKey(patientId))
            {
                var patientDeatails = patients[patientId];
                Console.WriteLine($"1.Ppatient Id:{patientId},\n2.PatientName:{patientDeatails["Name"]},\n3.PatientAge:{patientDeatails["Age"]},\n 4.Diagnosis:{patientDeatails["Diagnosis"]},\n5.Status:{patientDeatails["AdmissionStatus"]}");

                Console.WriteLine("If you want to change the diagnosis or change the Admission status in (y/n)");
                string update = Console.ReadLine().ToLower().Trim();
                if (update == "y")
                {
                    Console.WriteLine("Enter the new diagnosis:");
                    patientDeatails["Diagnosis"] = Console.ReadLine();

                    Console.WriteLine("Enter the new status:[Available / Discharged] )");
                    patientDeatails["AdmittedStatus"] = Console.ReadLine();

                    Console.WriteLine("Patient details updated successfully");
                    Console.WriteLine() ;
                }
                else
                {
                    Console.WriteLine("No updation required");
                }
            }
            else
            {
                Console.WriteLine("Patient id does not exisst");
            }

        }

        static void GetListOfAdmittedPatients()
        {

            Console.WriteLine("List of admitted patients:");

            foreach (var patient in patients)
            {

                if ((string)patient.Value["AdmissionStatus"] == "Admitted")
                {
                    Console.WriteLine($"Patient ID:{patient.Key},\nName:{patient.Value["Name"]} \nAge:{patient.Value["Age"]},\nDiagnosis:{patient.Value["Diagnosis"]}");

                }


            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\t");
                Console.WriteLine("1.Add Patient\t ");
                Console.WriteLine("2.Search and update patient details\t");
                Console.WriteLine("3.List of Admitted patients\t");
                Console.WriteLine("4.Exit");

                Console.WriteLine();

                string option = Console.ReadLine();

                switch (option)
                {

                    case "1":
                        AddPatient();
                        break;
                    case "2":
                        SearchAndUpdateOfPatient();
                        break;
                    case "3":
                        GetListOfAdmittedPatients();
                        break;
                    default:
                        Console.WriteLine("Invalid option no data exist");
                        break;


                }

            }
        }
    }
}

