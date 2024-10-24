using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAndRectangle
{
    internal class Rectangle:IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length,double width)
        {
            Length= length;
            Width= width;
        }
        public double Area()
        {
            return Length*Width;
        }
        public double Perimeter()
        {
            return 2 *(Length+Width);
        }
    }
}
