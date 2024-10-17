/*
 -> ENum:
         An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).
         To create an enum, use the enum keyword (instead of class or interface), and separate the enum items with a comma
Example:
       class Program
       {
          enum Level
          {
            Low,
            Medium,
            High
           }
         static void Main(string[] args)
         {
         Level myVar = Level.Medium;
         Console.WriteLine(myVar);
         }
         }
 
 
 
 
 
 
 
 
 
 
 */











using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {

        public enum ConvertTo
        {
            upper,
            lower,
            swapcase
        }
        public static void ConvertCasing(string input,ConvertTo targetOutput)
        {
            switch (targetOutput)
            {
                case ConvertTo.upper:
                    Console.WriteLine(input.ToUpper());
                    break;

                    case ConvertTo.lower:
                    Console.WriteLine(input.ToLower());
                    break;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
