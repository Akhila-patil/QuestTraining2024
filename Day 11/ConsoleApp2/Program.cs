using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {

        /*class StudentManagement
        {
            private List<Student> students=new List<Student>();


            private Student GetStudentByRegisterNumber(string registerNumber)
            {
                foreach (var student in students)
                {

                    if (student.RegisterNumber == registerNumber)
                    {
                        return student;
                    }
                    return null;
                }
            }
            public void Add(Student s)
            {
                if (GetStudentByRegisterNumber(s.RegisterNumber != null))
                {
                    Console.WriteLine("Student already Exist");
                    return;
                }
                students.Add(s);
                Console.WriteLine("Student added successfully");

            }
            public void search(string registerNumber)
            {
                var student=GetStudentByRegisterNumber(registerNumber);
                if (student.RegisterNumber == registerNumber)
                {
                    Console.WriteLine($"Student found with {registerNumber}");
                }
                else
                {
                    Console.WriteLine("Student not found");

                }
            }

            public void update(string registerNumber, string name,int studentclass)
            {
                var student=GetStudentByRegisterNumber(registerNumber);
                if (student == null)
                {
                    Console.WriteLine("Student not found");
                    return;
                }
                student.Name = name;
                student.RegisterNumber = registerNumber;
                student.StudentClass = studentclass;

                Console.WriteLine("Student details updated successfully");

            }

            public void delete(string registerNumber)
            {
                var student=GetStudentByRegisterNumber(registerNumber);
                if(student == null)
                {
                    Console.WriteLine("Student not found");
                    return;
                }
                students.Remove(student);
                Console.WriteLine("Student deleted successfully");

            }
        }*/
        static void Main(string[] args)
        {
            /*
            var student=new Student();
            while (true) {
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Search");
                Console.WriteLine("3.Update");
                Console.WriteLine("4.Delete");
                Console.WriteLine("5.Exit");

                var option=Console.ReadLine();
                switch (option)
                {
                    case "1":
                        var stu = Getdata();
                        student.Add(stu);
                        break;
                        
            }
            
            }*/
        }
   
       /*private static Student Getdata()
       {
        Student s = new Student();
        Console.WriteLine("Enter the name of student");
        s.Name = Console.ReadLine();
        Console.WriteLine("Enter student registration number");
        s.RegisterNumber = Console.ReadLine();
        Console.WriteLine("Enter student class from 1 to 10");
        s.StudentClass = Console.ReadLine();
       }*/
    }
}
