using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11
{
    internal class Program
    {
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        static void Main(string[] args)
        {
            Predicate<int> isEvenNumber = IsEven;
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumbers = numbers.FindAll(isEvenNumber);
            Console.WriteLine($"Even numbers in the list are:");
            foreach(int num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
