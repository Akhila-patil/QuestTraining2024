/* Check for Numbers Greater Than 50
From a list of integers, check if any number is greater than 50.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 150, 200, 45, 5, 8, 9, 16, 55 };
            var res = numbers.Where(x => x > 50);
            
            Console.WriteLine(string.Join(",", res));
        }
    }
}
