/* Calculate Average
Return the average of a list of floating-point numbers.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new [] {1.5, 2.5, 3,5.5,6};
            var res = numbers.Average();
            Console.WriteLine(res);
        }
    }
}
