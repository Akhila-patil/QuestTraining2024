/* In delegates we have three types
    -Action
    -Func
    -Predicate

Action:In this while calling the method using action we have to pass the equal and same type of paremeters 
Func:In this while calling the method we have to pass the equal number of parameters and return type.
predicate: In this we have pass parameters only.








*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        //Action delegates
        //static void Greet() => Console.WriteLine("Hello");
        //static void GreetWithMessage(string message) => Console.WriteLine(message);

        //static void Add(int a, int b) => Console.WriteLine(a + b);

        //func delegates
        //static int GetNumber() => 10;
        //static string Add(int a, int b) => (a + b).ToString();

        //predicate delegates
        //static bool Iseven(int n) => n % 2 == 0;

        static void GetDataOnCondition(int[] data,Predicate<int> predicate)
        {
            var result = new List<int>();
            foreach(var item in data)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            Console.WriteLine(string.Join(",", result));
        }

        static void Main(string[] args)
        {
            //Action g = Greet;
            //Action<string> gm = GreetWithMessage;
            //Action<int ,int > i = Add;

            //Func<int> gn = GetNumber;
            //Func<int, int, string> add = Add;

            //Func<int, bool> a = Iseven;
            //Predicate<int> b = Iseven;
            //var res = a(1);
            //var res2 = b(1);

            var data = new [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -1, -2, -4 };

           GetDataOnCondition(data, i => i % 2 == 0);
            GetDataOnCondition(data, x => x < 0);



        }
    }
}
