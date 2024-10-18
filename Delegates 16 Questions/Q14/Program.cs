using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q14
{
    internal class Program
    {
        abstract class Person
        {
            public abstract void Work();
        }

        class Doctor : Person
        {
            public override void Work()
            {
                Console.WriteLine("Doctor Diagnose and treat the patients");
            }
        }
        class Engineer : Person
        {
            public override void Work()
            {
                Console.WriteLine("Can do anything and solve any problem");
            }
        }

        static void Main(string[] args)
        {
            Person doctor = new Doctor();
            doctor.Work();
            Console.WriteLine();
            Person engg = new Engineer();
            engg.Work();
        }
    }
}
