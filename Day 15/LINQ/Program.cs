using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, -1, -2, -3 };

            //var sum = data.Skip(3).Take(5).Where(x => x%2==0).Sum();
            //Console.WriteLine(sum);

            var fitem=data.First();
            Console.WriteLine(fitem);

            var forDefaultItem = data.FirstOrDefault();
            Console.WriteLine(forDefaultItem);

            var lastItem=data.Last();
            Console.WriteLine(lastItem);

            var lastOrDefault = data.LastOrDefault();
            Console.WriteLine(lastOrDefault);

            var sortAscending = data.OrderBy(x=>x);
            foreach (var item in sortAscending) { 
              Console.WriteLine(item);
            }
            var sortDecending=data.OrderByDescending(x=>x);
            foreach (var item in sortDecending) {
                var res=(string.Join(",",sortDecending));
                
            }
            
            
            



        }
    }
}
