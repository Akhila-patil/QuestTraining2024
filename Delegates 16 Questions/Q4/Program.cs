using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {

         public interface ICalculator
        {
             int Add(int a, int b);
            int substract(int a, int b);
        }
         public class Calculator :ICalculator
        {
            public int  Add(int a, int b)
            {
                return a + b;
            }
            public int substract(int a,int b)
            {
                return a - b;
            }

        }
        
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            int sum = c.Add(1, 2);
            int diff = c.substract(10, 5);

            Console.WriteLine($"The addition is:  {sum}");
            Console.WriteLine($"Subtraction is: {diff}");


        }
    }
}
