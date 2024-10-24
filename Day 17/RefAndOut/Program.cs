using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOut
{
    internal class Program
    {
        //static void DoThis(string s)
        //{
        //    s = "Heloo";
        //}

        //static void DoThis(ref int  num)
        //{
        //    num = 0;

        //}
        
        //static void DoThis(out int num)
        //{
        //    num = 0;
        //}
        static bool TrimToFive( ref string data)
        {
            if (data.Length > 0)
            {
                data = data.Substring(0, 5);
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            //DoThis(out int number);
            //Console.WriteLine(number);

            //int number = 1;
            //DoThis(ref number);
            //Console.WriteLine(number);
            //string data = "Hiii";
            //DoThis(data);
            //Console.WriteLine(data);

            string text = "old data";
            if(TrimToFive(ref text))
            {
                Console.WriteLine(text + ".....");

            }
            else
            {
                Console.WriteLine(text);
            }
        }
    }
}
