using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAnimal
{
    internal class Program
    {

        interface IAnimal
        {
            void speak();
            
        }
        class Dog :IAnimal
        {
            public void speak()
            {
                Console.WriteLine("Dog bark");
            }
        }
        class Cat : IAnimal
        {
            public void speak()
            {
                Console.WriteLine("Cat bark");
            }
        }
        static void Main(string[] args)
        {
            IAnimal dog = new Dog();
            dog.speak();
            IAnimal cat = new Cat();
            cat.speak();
        }
    }
}
