/*
    3. Sort in Descending Order
       Sort a list of integers in descending order.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sorting in desending order
            var data = new int[] { 1, 7, 6, 54, 9, 11, 12, 55, 13, 14, 15, 16, };
            var result=data.OrderByDescending(x=>x).ToList();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
