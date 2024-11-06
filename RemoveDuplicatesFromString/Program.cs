using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesFromString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string input = "Hi all hope all are doing great";
            //var result = input.ToLower()
            //    .Select(x => x).Distinct().ToList();
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //---------------------------------------------------------------------------
            //Number is prime or not
            //int n = 5, a = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        a++;
            //    }
            //}
            //if (a == 2)
            //{
            //    Console.WriteLine("{0} is a Prime Number", n);
            //}
            //else
            //{
            //    Console.WriteLine("Not a Prime Number");
            //}
            //Console.ReadLine();
            //-------------------------------------------------------------------------------------
            /*string input = "Hi hello my self akhila patil hope all are good";
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char item in input)
            {
                if (item != ' ') 
                {
                    if (charCount.ContainsKey(item))
                    {
                        charCount[item]++;
                    }
                    else
                    {
                        charCount[item] = 1;
                    }
                }
            }
            int maxCount = charCount.Values.Max();
            var maxChars = charCount.Where(x => x.Value == maxCount).Select(x => x.Key);

            
            int minCount = charCount.Values.Min();
            var minChars = charCount.Where(x => x.Value == minCount).Select(x => x.Key);

            Console.WriteLine("Character(s) with maximum occurrences:");
            foreach (var maxChar in maxChars)
            {
                Console.WriteLine($"'{maxChar}' appears {maxCount} times");
            }

            Console.WriteLine("Character(s) with minimum occurrences:");
            foreach (var minChar in minChars)
            {
                Console.WriteLine($"'{minChar}' appears {minCount} times");
            }
        
            */
        }





    }
}
