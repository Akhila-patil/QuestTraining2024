using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printingmessage
{
    internal class Program
    {
        public delegate string PrintMessage(string msg);

        public  static string Display(string msg)
        {
            return msg;
        }
        static void Main(string[] args)
        {
            PrintMessage print = Display;
           Console.WriteLine( Display("HIIII"));


        }
    }
}
