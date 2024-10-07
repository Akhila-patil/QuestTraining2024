using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*var data1 = new List<List<int>>();
            
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter mark1:");
                string m1=Console.ReadLine();

                Console.WriteLine("Enter mark1:");
                string m2 = Console.ReadLine();

                Console.WriteLine("Enter mark1:");
                string m3 = Console.ReadLine();

                var marks = new List<int>();
                marks.Add(int.Parse(m1));
                marks.Add(int.Parse(m2));
                marks.Add(int.Parse(m3));
            }*/

            var data2=new List<List<int>>();


            for(int i=1;i<=2; i++)
            {
                Console.WriteLine($"Enter the marks of student{i}: ");
                var markss=new List<int>();
               
                for(int j = 1; j <= 3; j++)
                {
                    Console.Write($"Enter mark {j}:");
                    int mark=int.Parse(Console.ReadLine());
                    markss.Add(mark);
                }
                data2.Add(markss);
            }
            Console.WriteLine();






        }
    }
}
