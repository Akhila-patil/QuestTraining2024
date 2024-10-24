using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAndRectangle
{
    internal class Program
    {

        //interface Ishape
        //{
        //     double Area();
        //     double Perimeter();
        //}
        //class Circle : IShape
        //{
        //    public double Radius { get; set; }
        //    public double Area() => Math.PI * Radius * Radius;
        //    public double Perimeter() => 2 * Math.PI * Radius;
        //}
        //class Rectangle : Ishape
        //{
        //    public double Length { get; set; }
        //    public double Width { get; set; }
        //    public double Area() => Length * Width;
        //    public double Perimeter()=>2*(Length+Width);
        //}
        static void Main(string[] args)
        {



            IShape circle = new Circle(5);
            IShape rect = new Rectangle(10, 2);

            List<IShape> shapes=new List<IShape> { circle, rect };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Shape:{shape.GetType().Name}\n");
                Console.WriteLine($"Area:{shape.Area()}");
                Console.WriteLine($"Perimeter:{shape.Perimeter()}\n");
            }

        }
    }
}
