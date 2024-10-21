using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreaditCard cc = new CreaditCard();

            Console.WriteLine("Enter card number:");
            cc.CardNumber=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Expiry Month:");
            cc.ExpiryMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Expiry Year:");
            cc.ExpiryYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the cvc:");
            cc.Cvc= int.Parse(Console.ReadLine());

 
        }
    }
}
