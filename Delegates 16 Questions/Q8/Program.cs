using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    internal class Program
    {
        static int  LengthOfString(string input)
        {
            return (input.Length);
        }
        static void Main(string[] args)
        {
            Func<string, int> result = LengthOfString;
            Console.WriteLine($"The length of string is:{result("Welcome to C#")}");

        }
    }
}
