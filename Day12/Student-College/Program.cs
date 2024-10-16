using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_College
{
    internal class Program
    {

        class Student
        {
            public string Name { get; set; }
            public string Email { get; set; }
        }

        class College : Student
        {
            public string CollegeName { get; set; }

            public override string ToString()
            {
                return $"Name:{Name},Email:{Email} ,CollegeName: {CollegeName}";
            }
        }
        class School : Student
        {
            public string SchoolName { get; set; }

            public override string ToString()
            {
                return $"Name:{Name},Email:{Email} ,CollegeName: {SchoolName}";
            }
        }

        static void Main(string[] args)
        {
            var c = new College
            {
                Name="Akhila",
                Email="ak@gmail.com",
                CollegeName="PDA"
            };
            Console.WriteLine(c);

            var s  = new School
            {
                Name = "Akhila",
                Email = "ak@gmail.com",
                SchoolName = "PDA"
            };
            Console.WriteLine(s);

        }
    }
}
