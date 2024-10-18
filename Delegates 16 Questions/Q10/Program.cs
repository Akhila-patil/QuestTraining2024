using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    internal class Program
    {
        public static void  Addition(int a,int b)
        {
            Console.WriteLine($"Addition is: {a + b}");
        }
        static void Main(string[] args)
        {
            Action<int, int> sum = Addition;
            sum(5, 5);
            
        }
    }
}
