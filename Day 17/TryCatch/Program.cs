using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter two number");
                int n1=int.Parse(Console.ReadLine());
                int n2=int.Parse(Console.ReadLine());


                if (n2 == 0)
                {
                    throw new DivideByZeroException("second nomber canoot be zero");
                }

                Console.WriteLine(n1+n2);
                Console.WriteLine(n1 - n2);
                Console.WriteLine(n1 * n2);
                Console.WriteLine(n2 / n2);

            }


            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}

                //catch (OverflowException)
                //{
                //    Console.WriteLine("Number too large");
                //}

                //catch (FormatException)
                //{
                //    Console.WriteLine("enter a valid number");
                //}

                //catch(Exception e) 
                //{
                //    Console.WriteLine(e.Message);
                //    Console.WriteLine(e.StackTrace);



                //}
            finally
            {
                Console.WriteLine("Finally");
            }
        }
            
    }
}
