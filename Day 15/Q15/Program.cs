/*  Remove Duplicates
From a list of integers with duplicates, return only the distinct numbers.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 5, 1, 5 };
            var res = numbers.Distinct();
            Console.WriteLine(string.Join(",", res));
        }
    }
}
