using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class Student
    {
        public string Name;
        public int mark1;
        public int mark2;
        public int mark3;

        public void TotalMarks()
        {
            int total = mark1 + mark2 + mark3;
            Console.WriteLine($"The total mark of student is: {total}");
        }
        public void Average()
        {
            double average = (mark1 + mark2 + mark3) / 3;
            Console.WriteLine($"Average of marks scored:{average}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Akhila";
            s1.mark1 = 60;
            s1.mark2 = 50;
            s1.mark3 = 80;

            Student s2 = new Student();
            s2.Name = "John";
            s2.mark1 = 40;
            s2.mark2 = 60;
            s2.mark3 = 70;

            s1.TotalMarks();
            s1.Average();

            s2.TotalMarks();
            s2.Average();


        }
    }
}
