using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteItlater
{
    internal class Program
    {

        class Circle : IShape
        {
            private double Radius;
            public Circle(double radius)=>(Radius)=(radius);

            public double Area()
            {
                return Math.PI*Radius*Radius;

            }
            public double Perimeter()
            {
                return 2 * Math.PI*Radius;
            }
            

        }
       /* abstract class Shape
        {
            public abstract double Area();
            public abstract double Perimeter();
        }
            class Circle : Shape
            {
                private double radius;
                public Circle (double Radius)
                {
                    radius = Radius;
                }
                public  override  double  Area()
                {
                    return Math.PI * radius * radius;  
                }
                public override double Perimeter()
                {
                    return 2 * Math.PI * radius;
                }
            }
        
         //parameterized Constructor
           class Person
         {
             public string Name { get; set; }
             public int Age { get; set; }

             public Person(string name, int age) => (Name, Age) = (name, age);


             public void DisplayData() => Console.WriteLine($"Name:{Name} Age:{Age} ");

         }*/
        /* Copy Constructor
           class Person
         {
             public string Name { get; set; }
             public int Age { get; set; }
             public Person(string name, int age) => (Name, Age) = (name, age);
             public Person(Person copy) => (Name, Age) = (copy.Name, copy.Age);

             public void Display() => Console.WriteLine($"Name:{Name} Age:{Age}");

         }*/
        //static constructor
        /*class Person
        {
            static string Name { get; set; }
            static int Age { get; set; }

            public Person() => (Name, Age) = ("Akhila", 24);

            static Person()=> Console.WriteLine("Satic Instructor");

            public void Display() => Console.WriteLine($"Name:{Name} Age;{Age}");


        }
        //internal protected
        public class BaseClass
        {
            protected internal int num = 10;
            public void Display()
            {
                Console.WriteLine($"Number:{num}");
            }
        }
        public class DerivedClass : BaseClass
        {
            public void Show()
            {
                Console.WriteLine($"Number:{num}");
            }
        }
        public class DerivedClass2 : DerivedClass
        {
            public void Anothershow()
            {
                BaseClass obj1=new BaseClass();
                Console.WriteLine(obj1.num);
            }
        }
        
        //params keyword
        
        
            public static void PrintingNumber(string text, params int[] numbers)
            {
                Console.WriteLine($"{text}:");
                foreach (int number in numbers)
                {
                Console.WriteLine(number);
                }
            }
        */
        




        static void Main(string[] args)
        {
            IShape myCircle = new Circle(10);
            Console.WriteLine(myCircle.Area());
            Console.WriteLine(myCircle.Perimeter());

            //Shape mycircle=new Circle(10);
            //Console.WriteLine("Area of circle:"+mycircle.Area());
            //Console.WriteLine("Perimeter of circle:"+mycircle.Perimeter());

            //Person p1 = new Person("Akhila Patil",24);
            //p1.DisplayData();

            //Person p1 = new Person("Akhila",24);
            //Person p2 = new Person(p1);
            //p1.Display();
            //p2.Display();

            //Person p1=new Person();
            //p1.Display();

            //BaseClass obj2 = new BaseClass();
            //obj2.Display();
            //DerivedClass obj3 = new DerivedClass();
            //obj3.Show();
            //DerivedClass2 obj4 = new DerivedClass2();
            //obj4.Anothershow();

            

        }
    }
}
