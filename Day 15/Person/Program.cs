using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string country { get; set; }
            public int Age { get; set; }

            static void Main(string[] args)
            {
                var data = new List<Person>()
                {
                    new Person{Name="Person1",country="US",Age=20},
                    new Person{Name="Person2",country="US",Age=40},
                    new Person{Name="Person3",country="US",Age=70},
                    new Person{Name="Person4",country="IND",Age=52},

                };

                //person age in decending order
                var res = data.OrderByDescending(x => x.Age);
                foreach(var person in res)
                {
                    Console.WriteLine(person.Name);
                }
                var pplDesendingOrder = data.OrderByDescending(x => x.Age);
                

                //find the disticnt country

                var result = data.Select(p => p.country).Distinct();
                foreach(var Countries in result)
                {
                    Console.WriteLine(Countries);
                }

                
                List<Dictionary<string,string>> countries=data.Select(p=> new Dictionary<string, string>
                {
                    {"Name",p.Name },
                    {"Country",p.country},
                    {"Age",p.Age.ToString()}

                }).ToList();
                foreach(var item in countries)
                {
                    Console.WriteLine(item.);
                }
                




                //var res = data.Where(p => p.country == "US");
                //foreach (var preson in res)
                //{
                //    Console.WriteLine(preson.Name);
                //}
                //Console.WriteLine();

                //var minAge=data.Where(p=>p.country=="US").Min(p=>p.Age);
                //var person = data.Where(p => p.country == "US" && p.Age == minAge).FirstOrDefault();
                //Console.WriteLine(person.Name + " and age is "+ person.Age);
            }
        }
    }
}
