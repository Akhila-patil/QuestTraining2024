using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            var s1 = new Student
            {
                Name = "Studen_1",
                mark1 = 50,
                mark2=85
            };

            var s2 = new Student
            {
                Name = "Studen_2",
                mark1 = 56,
                mark2 = 85
            };
            var s3 = new Student
            {
                Name = "Studen_3",
                mark1 = 96,
                mark2 = 84
            };

            Student[] students = new Student[5];
            students[0] = s1;
            students[1] = s2;
            students[2] = s3;

            foreach (var item in students)
            {
                if (item != null)
                {
                    sum = sum + item.mark1 + item.mark2;
                }
                Console.WriteLine(item.Name);
                Console.WriteLine($"Sum is: {sum}");
               

            }

        }
    }
}
