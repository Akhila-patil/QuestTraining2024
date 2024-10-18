using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12
{
    internal class Program
    {
        public static bool checkString(string str)
        {
            return str.StartsWith("A");
        }
        static void Main(string[] args)
        {
            List<string> names = new List<string> {"Akhila","Bapu","anusha","Ankita","Sunil" };

            Predicate<string> pridicateString = checkString;

            List<string> namesStartWithA = names.FindAll(pridicateString);

            Console.WriteLine("Names starting with A are:");

            foreach(string name in namesStartWithA)
            {
                Console.WriteLine(name);
            }


        }
    }
}
