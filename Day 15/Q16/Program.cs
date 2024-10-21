/* Count Elements Greater Than 10
From a list of integers, count how many elements are greater than 10.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 30, 41, 50, 6, 7, 8, 5, 1, 5 };
            var res = numbers.Where(x => x > 10);
            Console.WriteLine(string.Join(", ", res));
        }
    }
}
