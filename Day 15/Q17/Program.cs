/* Join Employees with Departments
Given two lists, one of employees and one of departments, return a list of employees with their corresponding department names based on department IDs.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q17
{
    internal class Program
    {
        class Employee
        {
            public string Name { get; set; }
            public int DepartmentId { get; set; }
        }
        class Department
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        static void Main(string[] args)
        {

            //var empId = new List<int>() { 100, 101, 102, 103 };
            //var dept = new List<string>() { "HR", "Finance", "CS", "IT" };
            //for (int i = 0; i < empId.Count; i++) { 
            //Console.WriteLine($"{empId[i]}-{dept[i]}");

            //}



            //    var Employee = new List<(int empId, string Name,int deptId)>
            //    {
            //        (1,"A",10),
            //        (2,"B",20),
            //        (3,"C",10),
            //        (4,"D",30)
            //    };
            //    var Department = new List<(int deptId,string deptName)>
            //    {
            //        (10,"HR"),
            //        (20,"Development"),
            //        (30,"Finance")
            //    };

            //    var result = from e in Employee
            //                 join d in Department on e.deptId equals d.deptId
            //                 select (e.Name, d.deptName);

            //    foreach (var item in result)
            //    {
            //        Console.WriteLine($"Employee Name: {item.Name}  Department:{item.deptName}");
            //    }


            var departments = new List<Department>()
            {
                new Department { Id = 1,Name="Dpt 1" },
                new Department{Id=2,Name="Dpt 2"}

            };
            var employees = new List<Employee>()
            {
                new Employee{Name="John",DepartmentId=1},
                 new Employee{Name="Mary",DepartmentId=1},
                  new Employee{Name="sonu",DepartmentId=2}
            };
            var empWithDepts = employees
                .Join(
                departments,
                e => e.DepartmentId,
                d => d.Id,
                (e, d) => new
                {
                    EmployeeName = e.Name,
                    DepartmnetName = d.Name
                }
                );
            foreach(var item in empWithDepts)
            {
                Console.WriteLine(item.EmployeeName + " - " + item.DepartmnetName);
            }


        }
    }
}
