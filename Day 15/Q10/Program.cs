/* 10. Find Minimum Value
From a list of integers, return the minimum valu
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    public delegate void GreetDelegate(string name);
    internal class Program
    { 
        static void GreetEnglish(string name)
        {
            Console.WriteLine("hello" + name);
        }
        static void GreetSpanish(string name)
        {
            Console.WriteLine("hello" + name);
        }
        static void Main(string[] args)
        {
            GreetDelegate greet = GreetEnglish;
            greet += GreetSpanish;


            Func<int, int> Squares = x => x * x;
            Console.WriteLine(Squares(5));

            Func<int, int, int> Addition = (x, y) => x + y;
            Console.WriteLine(Addition(2, 4));



            Action<string> greetPerson = name => Console.WriteLine(name);
            greetPerson("Akhila");

            Action<string, int> PrintAgeAndName = (name, age) => Console.WriteLine($"{name} {age}");

            PrintAgeAndName("Akhila", 34);

            Action<int, int> Addition1 = (n1, n2) => Console.WriteLine($"{n1 + n2}");
            Addition1(2, 2);



            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            Predicate<int> IsEven = num => num % 2 == 0;
            int evenNumber = numbers.Find(IsEven);
            Console.WriteLine(evenNumber);

            List<int> allEvenNumber = numbers.FindAll(IsEven);
            Console.WriteLine(string.Join(",", allEvenNumber));
        }
    }
}
