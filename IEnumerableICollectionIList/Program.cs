using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableICollectionIList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //---------------------------------------------------------------------------------
           
            ICollection<string> fruits = new List<string> { "Apple", "banana", "cherry" };
            fruits.Add("Mango");
            fruits.Remove("banana");

            Console.WriteLine(fruits.Contains("apple"));
            Console.WriteLine(fruits.Count());
            foreach(var item in fruits)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //-----------------------------------------------------------------------------

            IList<string> names = new List<string>();
            IList<string> hobbies = new List<string> { "Painting","drawing" };
            names.Add("Akhila");
            names.Insert(1, "Sunil");
            Console.WriteLine(names.First(x=>x.StartsWith("A")));
            names.ToList();
            names.Concat(hobbies);
            Console.WriteLine(names.Contains("Sunil"));
            foreach(var item in names)
            {
                Console.WriteLine(item);
            }

        }
    }
}
