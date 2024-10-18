using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Program
    {

        abstract class Vehicle
        {
            public double Speed { get; set; }

            public abstract double Drive();

            public  virtual void Display()
            {
                Console.WriteLine("The speed of vehicle is :");
            }

        }
        class Car : Vehicle
        {
            public Car(double speed)
            {
                Speed = speed;
            }
            public override double Drive()
            {
                return Speed;
            }
            public override void Display()
            {
                Console.WriteLine($"The speed of Car is {Speed}");
            }

        }
        class Bicycle : Vehicle
        {
            public Bicycle(double speed)
            {
                Speed = speed;
            }
            public override double Drive()
            {
                return Speed;
            }
            public override void Display()
            {
                Console.WriteLine($"The speed of the Bicyle is {Speed}");
            }

        }
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[]
            {
               new Car(45.55),
               new Bicycle(25.55)
            };
            foreach(var vehicle in vehicles)
            {
                vehicle.Display();
                Console.WriteLine();

            }
        }
    }
}
