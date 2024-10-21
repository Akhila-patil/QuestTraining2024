/* Filter and Sort Products by Price
From a list of products, return those with prices greater than $100, sorted in ascending order.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q18
{
    internal class Program
    {
        public class Product
        {
            public string Name;  
            public decimal Price;
        }
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
           {
               new Product{Name="Watch",Price=50},
               new Product { Name = "Smartphone", Price = 600 },
               new Product { Name = "Tv", Price = 25000 },
               new Product { Name = "Monitor", Price = 300 }
           };
            var res=products
                .Where(p=>p.Price >100)
                .OrderBy(p=>p.Price)
                .ToList();
            foreach (Product p in res)
            {
                Console.WriteLine($"Product Name {p.Name} Price:{p.Price}");
            }
        }
    }
}
