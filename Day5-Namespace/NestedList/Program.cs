using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lst=new List<List<int>>();
            lst.Add(new List<int>());
            lst[0].Add(1);
            lst[1].Add(2);

            var lst1 = new List<int> { 1, 2, 3 };
            var lst2 = new List<int> { 3,4,5 };



        }
    }
}
