/* 10. Find Minimum Value
From a list of integers, return the minimum valu
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 4, 5, 8, 9, 16, 55 };

            var minNumber = numbers.Min();
            Console.WriteLine($"Maximum Number from the list is: {minNumber}");
        }
    }
}
