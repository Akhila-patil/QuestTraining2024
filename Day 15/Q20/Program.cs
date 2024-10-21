/*  Zip Two Lists Together
Given two lists of the same length, combine corresponding elements into pairs.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Name = new List<string> { "Anu","Ankith","Sonu","Akhila"};
            List<int> Age= new List<int> {6 ,7,8,9 };
            var res = Name.Zip(Age, (names, ages) => new { Name=names, Age=ages}).ToList();
            foreach (var pair in res)
            {
                Console.WriteLine($"Name:{pair.Name} Age:{pair.Age}");
            }


        }
    }
}
