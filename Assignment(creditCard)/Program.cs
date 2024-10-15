using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_creditCard_
{
    internal class Program
    {
        public static List<CreditCard> creditcard = new List<CreditCard>();

        static void AddCard()
        {
            Console.WriteLine("Enter the card number: ");
            long  cardNumber = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter the card holder name: ");
            string holderName = Console.ReadLine();

            Console.WriteLine("Enter the expiry date in MM/YY format: ");
            byte expiry = byte.Parse(Console.ReadLine().Split('/')[0]);

            Console.WriteLine("Enter the  Cvc value: ");
            int cvc = int.Parse(Console.ReadLine());

            var newCard = new CreditCard()
            {
                CardNumber = cardNumber,
                AccountHolderName = holderName,
                Expiry = expiry,
                Cvc = cvc
            };

            creditcard.Add(newCard);
            Console.WriteLine($"Card details has been added successfully");
        }

        static void UpdateDetails()
        {
            Console.WriteLine("Enter the card number:");
            int cardNumber = int.Parse(Console.ReadLine());

            CreditCard updatingCard = null;
            foreach(var number in creditcard)
            {
                if (number.CardNumber == cardNumber)
                {
                    updatingCard = number;
                    break;
                }
            }
            if (updatingCard != null)
            {
                Console.WriteLine("1.Update credit holdername:");
                Console.WriteLine("2.Update Cvc");
                Console.WriteLine("3.Exit");

                var choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("Enter the new name:");
                    string newname = Console.ReadLine();
                    updatingCard.AccountHolderName = newname;
                    Console.WriteLine($"Card holder name updated successfully!!");
                }

                if (choice == "2")
                {
                    Console.WriteLine("Enter the new cvc value:");
                    int cvc = int.Parse(Console.ReadLine());
                    updatingCard.Cvc = cvc;
                    Console.WriteLine($"Card holder cvc value is  updated successfully!!");
                }
                

            }
            else
            {
                Console.WriteLine("Card number does not exist");
            }
        }
        static void DeleteDetails()
        {
            Console.WriteLine("Enter the card number:");
            int cardNumber = int.Parse(Console.ReadLine());

            CreditCard deletingCard = null;
            foreach (var number in creditcard)
            {
                if (number.CardNumber == cardNumber)
                {
                    deletingCard = number;
                    break;
                }
            }
            if (deletingCard != null)
            {
                creditcard.Remove(deletingCard);
                Console.WriteLine($"Card number has been deleted Successfully!!");
            }
            else
            {
                Console.WriteLine($"Card number not found!!");
            }
        }

        static void SearchDeatails()
        {
            Console.WriteLine("Enter the card number:");
            int cardNumber = int.Parse(Console.ReadLine());
            CreditCard serachcard = null;
            foreach(var number in creditcard)
            {
                if (number.CardNumber == cardNumber)
                {
                    serachcard = number;
                    break;
                }
            }
            if (serachcard != null)
            {
                Console.WriteLine(serachcard);
            }
            else
            {
                Console.WriteLine("Card not found");
            }

        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.Add new creditcard");
                Console.WriteLine("2.Update the card details");
                Console.WriteLine("3.Delete the credit card");
                Console.WriteLine("4.Search for credit card number");
                Console.WriteLine("5. Exit");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddCard();
                        break;
                    case "2":
                        UpdateDetails();
                        break;
                    case "3":
                        DeleteDetails();
                        break;
                    case "4":
                        SearchDeatails();
                        break;
                    default :
                        Console.WriteLine("invalid enter try later");
                        break;
                       
                }
            }
           
        }
    }

    
}
