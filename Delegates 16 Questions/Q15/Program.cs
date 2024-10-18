using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q15
{
    internal class Program
    {
        public class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Animals make different sounds");
            }
        }
        public class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Dog bark");
            }
        }
        static void Main(string[] args)
        {
            Animal animal = new Dog();
            animal.MakeSound();

        }
    }
}
