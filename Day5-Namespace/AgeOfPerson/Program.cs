using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfPerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the date  birth year:");
            int birthYear=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the date  birth month:");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the date  birth day:");
            int birthDay = int.Parse(Console.ReadLine());

            int currentYear=DateTime.Now.Year;
            int currentMonth=DateTime.Now.Month;
            int currentDay=DateTime.Now.Day;


            int age = currentYear - birthYear;

            if (currentMonth < birthMonth || currentMonth == birthMonth && currentDay < birthDay)
            {
                age--;
            }


            Console.WriteLine($"your age is: {age} years old");

        }
    }
}
