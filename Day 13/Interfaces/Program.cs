using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{

    
        class SchoolStudent : Istudent
        {  
            public string Name { get; set; }
            public const string SchoolName = "Pda";

           public  void Display()
            {
                Console.WriteLine($" Student Name:{Name} | School Name: {SchoolName}");

            }

        }
    class CollegeStudent : Istudent
    {
        public string Name { get; set; }
        public const string CollegeName = "Appa";

        public void Display()
        {
            Console.WriteLine($" Student Name:{Name} | College Name: {CollegeName}");

        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Istudent>
            {
                new SchoolStudent {Name="jony"},
                new SchoolStudent {Name="Pony"},
                new CollegeStudent{Name="Tony"},
                new CollegeStudent{Name="sony"}
                
            };
            foreach (var student in students)
            {
                student.Display();
            }
        }
    }
}
