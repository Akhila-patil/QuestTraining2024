/* Skip and Take Elements
From a list of integers, skip the first 5 elements and return the next 3 elements.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, };
            var res = numbers
                .Skip(5)
                .Take(3)
                .ToList();
            Console.WriteLine(string.Join(",",res));
        }
    }
}
