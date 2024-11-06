
/*Filter Even Numbers
Given a list of integers, return all the even numbers.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            var list = new int[] { 10, 21, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
           
            var res=list.Where(x=>x%2==0);
            Console.WriteLine(string.Join(", ",res));


            var sortedList = list.OrderByDescending(x => x);
            Console.WriteLine("Sorted List:" + string.Join(",",sortedList));

            List<Person> people = new List<Person>
            {
                new Person { Name = "Alice", Age = 30 },
                new Person { Name = "Bob", Age = 25 },
                new Person { Name = "Charlie", Age = 35 },
                new Person {Name="Akhila",Age=25}

            };

            
            var groupAge = people.GroupBy(x => x.Age);
            foreach(var item in groupAge)
            {
                Console.WriteLine($" Age group:{item.Key}");
                foreach(var person in item)
                {
                    Console.WriteLine($"{person.Name}");
                }
            }
            Console.WriteLine("\n\n");
            var groupByAge = from person in people
                             group person by person.Age into ageGruop
                             select ageGruop;
            foreach (var item in groupByAge)
            {
                Console.WriteLine("Age group: "+item.Key);
                foreach(var person in item)
                {
                    Console.WriteLine($"{person.Name}");
                }
            }



            var result1 = from person in people
                          select person.Name;

            var result2 = people.Select(x => x.Name);

            Console.WriteLine("Result 1 is:" + string.Join(", ", result1));
            Console.WriteLine("Result 2 is:" + string.Join(" ,", result2));



        }
    }
}
