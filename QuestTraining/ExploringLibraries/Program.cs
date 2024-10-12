using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverloading

{
    internal class Program
    {

         static void Add(int a, int b) => Console.WriteLine($"Sum of two no. {a + b}");
        void Add(int a, double b) => Console.WriteLine($"Sum of two no. {a + b}");
        static void Main(string[] args)
        {

            Add(1, 2);
            Add(1,5);

        }
    }
}
