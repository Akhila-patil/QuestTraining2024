using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    class Employee
    {
        public string firstname;
        public string lastname;
        public int salary;

        public void TotalSalary()
        {
            Console.WriteLine(salary * 12);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.firstname = "Akhila";

        }
    }
}
