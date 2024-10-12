using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class Program
    {
        static List<Dictionary<string,string>> patients= new List<Dictionary<string,string>>();

        static void AddPatient()
        {
            var patient=new Dictionary<string,string>();
            Console.WriteLine("Enter patient name:");
            patient.Add("name",Console.ReadLine());

            Console.WriteLine("Enter patient Age:");
            patient.Add("age", Console.ReadLine());

            Console.WriteLine("Enter the symptoms as comma seperated values:");
            patient.Add("symptoms",Console.ReadLine());

            patient.Add("id", Guid.NewGuid().ToString());
            patients.Add(patient);

        }
        static void GetPatientById()
        {
            Console.WriteLine("Enter patient id:");
            var id=Console.ReadLine();

            foreach (var patient in patients) {
                if (patient["id"] == id)
                {
                    Console.WriteLine("Name:" + patient["name"]);
                    Console.WriteLine("Age:" + patient["age"]);
                    Console.WriteLine("Symptoms:" + patient["symptoms"]);
                    break;
                }
            }
         }
        static void GetPatientBySymptoms()
        {
            Console.WriteLine("Enter the symptoms to search to get the patient");
            var symptom=Console.ReadLine();
            bool found = true;

            foreach (patient["symptoms"].Contains(symptom)) 
            {
                Console.WriteLine($" patient found-- Id : {patients["id"]},Name {patients["name"]},Age{patients["age"]},Symptoms{patients["symptoms"]}");
                found = true;
            }
            if (!found)
            {
                Console.WriteLine("No patient found with symptom"+symptom);
            }
        }
       
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.Add patient");
                Console.WriteLine("2.search patient");
                var option = Console.ReadLine();

                switch (option)
                {
                    case  "1":
                        AddPatient();
                        break;
                    case "2":
                        GetPatientById();
                        break;

                    default: 

                        Console.WriteLine("Invalid ");
                        break;

                }
            }
        }
    }
}
