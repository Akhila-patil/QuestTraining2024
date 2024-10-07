using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombineListAndArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new List<List<int[]>>();

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter the marks of {i}:");
                var marks=new List<int>();

                for(int j = 1; j < 3; j++)
                {
                    int mark = int.Parse(Console.ReadLine());
                    marks.Add(mark);

                }
                data.Add(marks);
            }
            






        }


    }
    
}
