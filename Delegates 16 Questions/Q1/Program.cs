using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        abstract class Shapes
        {
            public abstract double Area();
            public void Info()
            {
                Console.WriteLine("This is the shape:");
            }
            public  virtual void  Display()
            {
                Console.WriteLine("Displaying the Area of Shapes");
            }
            
        }
        class Circle : Shapes
        {
            public double Radius { get; set; }

            public  Circle(double radius)
            {
                Radius = radius;
            }
            public override double Area()
            {
                return (Math.PI * Radius * Radius); 

            }
            public override void Display()
            {
                Console.WriteLine($"The radius of the circle is {Radius}");
            }
            
        }

        class Rectangle : Shapes
        {
            public double Height { get; set; }
            public double Width { get; set; }

            public Rectangle(double height,double width)
            {
                Height=height;
                Width=width;

            }
            public override double Area()
            {
                return(Height*Width);
            }
            public  override void Display()
            {
                Console.WriteLine($"The radius of rectangle is {Height} and {Width}");
            }
        }
        static void Main(string[] args)
        {
            Shapes[] shapes = new Shapes[]
            {
                new Circle(5),
                new Rectangle(4,6)

            };
            foreach(var shape in shapes)
            {
                shape.Display();
                Console.WriteLine($"Area of {shape.Area()} ");
                Console.WriteLine();

            }
            
        }
    }
}
