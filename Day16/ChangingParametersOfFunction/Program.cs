using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangingParametersOfFunction
{
    internal class Program
    {
        static int Add(bool doAddition, int a, int b)
        {
            return doAddition ? a + b : a - b;
        }
        static void Main(string[] args)
        {
            var res = Add(true, 1, 2);
            Console.WriteLine(res);
        }
    }
}
