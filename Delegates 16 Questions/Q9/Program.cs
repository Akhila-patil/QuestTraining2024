using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9
{
    internal class Program
    {
        static void Greet(string msg) => Console.WriteLine(msg);
        static void Main(string[] args)
        {
            Action<string > message =Greet;
            message("Welcome to C# training");
        }
    }
}
