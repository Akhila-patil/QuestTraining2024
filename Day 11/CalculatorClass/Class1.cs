using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClass
{
    internal class Class1
    {
        private int x;
        private int y;
        
           
            public void Add() => Console.WriteLine($"Sum is:{x + y}");
            public void Sub() => Console.WriteLine($"Subtraction is:{x - y}");
            public void Mul() => Console.WriteLine($"Multiply is:{x * y}");
            public void Div() => Console.WriteLine($"Division is:{x / y}");

        public void Run()
        {
            Console.WriteLine("Enter x value");
             x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter y value");
             y = int.Parse(Console.ReadLine());

            Add();
            Sub();
            Mul();
            Div();

        }
    

        
    }
}
