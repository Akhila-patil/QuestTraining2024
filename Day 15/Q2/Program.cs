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
    public delegate void Greet(string name);
    internal class Program
    {
        public void Greet1(string msg)
        {
            Console.WriteLine("Good morning"+msg);
        }
        public void Greet2(string msg)
        {
            Console.WriteLine("have a good day"+msg);
        }
        static void Main(string[] args)
        {
            //List<string>  data = new List<string> { "Akhila", "Anil", "Bapu", "sunil", "Ankita" };
            //var result = data.Where(x => x.First() == 'A');
            //Console.WriteLine(string.Join(" ", result));
            Program p = new Program();
            Greet g = p.Greet1;
            g = g + p.Greet2;
            g("Akhila");


        }
    }
}
