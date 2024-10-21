/* Group Words by Length
Group a list of words by their length.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Words = new List<string> {"Akhila","Jhonny","Sunil","aniketh","smita","Baapu"};
            var result = Words.GroupBy(word => word.Length);
            foreach (var item in result)
            {
                Console.WriteLine($"Words count: {item.Key} Names are :{string.Join("," ,item)}\n");
            }
        }
    }
}
