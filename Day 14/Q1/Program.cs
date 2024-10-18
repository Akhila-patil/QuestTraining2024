using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        abstract class Vehicle {
          public abstract void Drive();
            public virtual void FuelEfficiency()
            {

            }
        
        }
            




        /*abstract class CalculatorBase
        {
            public void Add(int a ,int b) => Console.WriteLine(a + b);
            public void Sub(int a, int b) => Console.WriteLine(a - b);
            public void Mul(int a, int b) => Console.WriteLine(a * b);
            public virtual  void Divide(int a, int b) => Console.WriteLine(a / b);
            public abstract void Pow(int a, int b);



        }
        class Calculator : CalculatorBase
        {
            public override void Divide(int a, int b)
            {
                if (b == 0)
                {
                    Console.WriteLine("The value of b cannot be zero");
                }
                
            }
            public override void Pow(int a, int b) => Console.WriteLine(Math.Pow(a, b));
            
                
            
        }*/
        static void Main(string[] args)
        {

            //var c = new Calculator();
            //c.Divide(1, 0);
            //c.Add(1, 2);
        }
    }
}
