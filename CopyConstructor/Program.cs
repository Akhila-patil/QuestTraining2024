using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    internal class Program
    {
        /*class Employee
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Employee(string name, int age) => (Name, Age) = (name, age);
            public Employee(Employee emp) => (Name, Age) = (emp.Name, emp.Age);
            public void Display() => Console.Write($"The age of {Name} is {Age}\n");
            
        }*/
        class MyClass
        {
            private int[] numbers = new int[10];
            public int this[int index]
            {
                get
                {
                    return numbers[index];
                }
                set
                {
                    numbers[index] = value;
                }
            }
        }
        static void Main(string[] args)
        {
            var insert = new MyClass();
            insert[0] = 10;
            insert[1] = 20;
            
            Console.WriteLine(insert[0]);
            Console.WriteLine(insert[1]);
            //Employee employee1 = new Employee("Akhila", 25);
            //Employee employee2 = new Employee(employee1);
            //employee2.Display();
        }
    }
}
