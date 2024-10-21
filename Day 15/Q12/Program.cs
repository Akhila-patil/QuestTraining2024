/* Check if All Numbers Are Positive
From a list of integers, check if all numbers are positive.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, -1, 0, -2 };
            var res=numbers.All(x=>x>0);
            if (res==true)
            {
                Console.WriteLine("All numbers are positive");
            }
            else
            {
                Console.WriteLine("Not all numbers in the list are positive");
            }
        }
    }
}
