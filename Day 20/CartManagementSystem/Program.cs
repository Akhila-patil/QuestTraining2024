/*1.E - commerce Cart Management System
Scenario: You're developing a shopping cart feature for an e-commerce platform.
Questions:
Design a Cart class that allows items to be added, updated, and removed. Each item has a name, quantity, and price.
Challenge: Ensure the Cart class follows the Single Responsibility Principle (SRP) by separating the cart’s functionality from the billing calculations.
Implement a discount system for the cart that allows adding different discount strategies (percentage-based, flat discount, buy-one-get-one).
Challenge: Use the Open/Closed Principle (OCP) to ensure that you can add new discount types without modifying existing code.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICartRepository cartRepository = new CartRepository();
            Cart cart = new Cart(cartRepository);

            
            cart.Add(new Item("Laptop", 1, 1200));
            cart.Add(new Item("Headphones", 2, 100));

           
            PercentageDiscount percentageDiscount = new PercentageDiscount(10);

            
            BillingService billingService = new BillingService(cart, percentageDiscount);

            
            decimal finalTotal = billingService.CalculateFinalTotal();
            Console.WriteLine($"Final Total with Percentage Discount: ${finalTotal}");

        }
    }
}
