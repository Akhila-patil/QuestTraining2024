/* 2. Filter Strings Starting with 'A'
From a list of strings, return those that start with the letter 'A'.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string>  data = new List<string> { "Akhila", "Anil", "Bapu", "sunil", "Ankita" };
            var result = data.Where(x => x.First() == 'A');
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
