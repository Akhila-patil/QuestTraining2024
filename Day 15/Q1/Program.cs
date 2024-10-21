
/*Filter Even Numbers
Given a list of integers, return all the even numbers.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            var res=list.Where(x=>x%2==0);
            Console.WriteLine(string.Join(", ",res));   
            

        }
    }
}
