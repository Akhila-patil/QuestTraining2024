using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateOperations
{
    internal class Program
    {

        public delegate void Operations(int x, int y);


        public  static void Add(int a, int b) => Console.WriteLine($"Addition:{a + b}");


        public static  void Sub(int a, int b) => Console.WriteLine($"Subtraction:{a - b}");




        static void Main(string[] args)
        {
            Operations op = Add;
            op += Sub;
            op(10, 5);

        }
    }
}
