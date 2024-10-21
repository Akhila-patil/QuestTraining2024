/*  Sum of All Elements
Return the sum of all elements in a list of integers.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 5,1,5};
            int res = numbers.Sum();
            Console.WriteLine(res);
        }
    }
}
