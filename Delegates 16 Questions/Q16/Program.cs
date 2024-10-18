using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q16
{
    internal class Program
    {
        public class Employee
        {
           
            public virtual decimal CalculateBonus(decimal salary)
            {
                return (salary * 0.10m);
            }
        }
        public class Manager : Employee
        {
            public override decimal CalculateBonus(decimal salary)
            {
                return salary * 0.20m;
            }
        }
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            decimal employeesalary = 5000m;
            decimal employeeBonus = employee.CalculateBonus(employeesalary);
            Console.WriteLine("Employee Bonus is:" + employeeBonus);

            Manager manager = new Manager();
            decimal managersalary = 55000m;
            decimal managerBonus = manager.CalculateBonus(managersalary);
            Console.WriteLine("Manager Bonus is:" + managerBonus);
        }
    }
}
