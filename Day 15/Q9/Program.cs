/* Find Maximum Value
From a list of integers, return the maximum value.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 4, 5, 8, 9, 16, 55 };

            var maxNumber = numbers.Max();
            Console.WriteLine($"Maximum Number from the list is: {maxNumber}");
        }
    }
}
