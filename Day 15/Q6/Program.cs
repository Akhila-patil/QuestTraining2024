/* 6. Find First String Starting with 'B'
From a list of strings, return the first string that starts with the letter 'B'. If none exists, return null.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string> { "Bapu", "Bhavya", "Akith", "Sunil", "Bhuvi" };
            var result = Names.Where(x => x.First() == 'B');
            if (result.Count() == 0) {
                Console.WriteLine("No name start with Letter 'B'");
            }
            else
            {
                {
                    Console.WriteLine(string.Join(", ", result));
                }
            }
        }
    }
}
