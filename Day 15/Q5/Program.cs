/* 5. Square of Even Numbers
From a list of integers, return the squares of only the even numbers.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = numbers.Where(x=>x%2==0);
            var SqOfEvenNumber=evenNumbers.Select(x=>x*x).ToList();
            Console.WriteLine(string.Join(", ", SqOfEvenNumber));
        }
    }
}
