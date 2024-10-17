using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class Program
    {
        class Employee
        {
            public string Name { get; set; }

            public static string CompanyName { get; set; }

            public Employee()
            {
                CompanyName = "Microsoft";
            }
            public override string ToString() => Name + " "+ CompanyName;
        }

         static void Main(string[] args)
        {
            Console.WriteLine("Company Name" + Employee.CompanyName);
            var e1 = new Employee() { Name = "akhila" };
            Console.WriteLine(e1);    
        }
    }
}
