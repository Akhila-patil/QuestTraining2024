using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustumExceptions
{
    internal class Program
    {
        class MyCustumException:Exception
        {
            public string Message {  get; set; }
            public MyCustumException(string message)
            {
                Message= message;   
            }

        }
            


        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter two number");
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());


                if (n2 == 0)
                {
                    throw new MyCustumException("second nomber canoot be zero");
                }

                Console.WriteLine(n1 + n2);
                Console.WriteLine(n1 - n2);
                Console.WriteLine(n1 * n2);
                Console.WriteLine(n2 / n2);

            }


            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
