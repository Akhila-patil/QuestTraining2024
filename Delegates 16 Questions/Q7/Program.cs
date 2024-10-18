using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionDelegate_7_
{
    internal class Program
    {

        static int Addition(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Func<int, int, int> add = Addition;
            Console.WriteLine("Addition is:" + add(1,2));
        }
    }
}
