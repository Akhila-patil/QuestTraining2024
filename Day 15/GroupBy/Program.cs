using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupBy
{
    internal class Program
    {
        class person
        {
            public string Name { get; set; }
            public string Country { get; set; }

        }
        static void Main(string[] args)
        {
            var data = new List<person>()
            {
                new person{Name="Person1",Country="IND"},
                new person{Name="Person2",Country="IND"},
                new person{Name="Person3",Country="Us"},
                new person{Name="Person4",Country="Canada"}
            };

            var groups=
        }
    }
}
