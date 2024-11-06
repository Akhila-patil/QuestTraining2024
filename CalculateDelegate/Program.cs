using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDelegate
{
    //public delegate void Notify(string message);
    internal class Program
    {
        //public static void SendEmails(string message)
        //{
        //    Console.WriteLine("You have Email Notification" + message);
        //}
        //public static void SendWhatsUpMessage(string message)
        //{
        //    Console.WriteLine("You have whatsup message" + message);
        //}
        static void Main(string[] args)
        {
            //Notify msg = SendEmails;
            //msg += SendWhatsUpMessage;

            //msg("You have mail by Akhila");
            //msg("You have whatsup msg by Akhila");
            //msg -= SendEmails;

            int a = 10;
            int b = 5;
            int addition = CalculateDelegate(a, b, add);
            Console.WriteLine("addition is:" + addition);

            int multiply = CalculateDelegate(a, b, mul);
            Console.WriteLine("multiplication" + multiply);
        }


        static int CalculateDelegate(int a, int b, Func<int, int, int> Operations) => Operations(a, b);

        static int add(int x, int y) => x + y;

        static int mul(int x, int y) => x * y;

    }
}
