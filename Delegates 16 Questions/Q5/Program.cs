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

        public static void Add(int x, int y)
        {
            Console.WriteLine($"Addition is:{x + y}");
        }
        public static void Sub(int x,int y)
        {
            Console.WriteLine($"Subraction :{x - y}");
        }


         
        static void Main(string[] args)
        {
            Operations op = Add;
            op += Sub;
            op(10, 5);

        }
    }
}
