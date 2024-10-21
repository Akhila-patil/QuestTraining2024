/* 
   Students Scoring Above 80
   Given two lists, one containing students' names and the other their grades, return the names of students who scored more than 80.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{

    
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string> { "John", "Jonny", "Akhila", "Sunil","Sony","Ani" };
            List<int> Marks = new List<int> { 85, 90, 55, 65,95,88 };

            var result = Names.Zip(Marks, (name, mark) => { return new { name, mark }; })
                .Where(s => s.mark > 80)
                .Select(s => s.name);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
