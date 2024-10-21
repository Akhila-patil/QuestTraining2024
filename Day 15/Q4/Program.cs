/* 
4. Square of Each Number
From a list of integers, return the square of each integer.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new  List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            var result = num.Select(x => x * x);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
