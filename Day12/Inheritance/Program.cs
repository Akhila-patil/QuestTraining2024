using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {

        class A
        {
            public string DataA { get; set; }
            public void MethodA() => Console.WriteLine("From class A");
        }
        class B : A
        {
            public string DataB { get; set; }

            public void MethodB() => Console.WriteLine(" A From class B");
            new public void MethodA()
            {
                base.MethodA();
            }
           

        }
        static void Main(string[] args)
        {
        }
    }
}
