using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProductStock
{
    internal class Program
    {
        static Dictionary<string, Dictionary<string, object>> inventry
                                  = new Dictionary<string, Dictionary<string, object>>();

        static void AddProduct()
        {
            Console.WriteLine("Enter the product ID:");
            string productId=Console.ReadLine();

            Console.WriteLine("Enter Product name:");
            string name=Console.ReadLine();

            Console.WriteLine("Enter Product Price:");
            decimal price=Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the initial stock quantity:");
            int intialstock=int.Parse(Console.ReadLine());

            if (!inventry.ContainsKey(productId))
            {
                inventry.Add(productId, new Dictionary<string, object>
                {
                    {"Name",name },
                    {"Price",price },
                    {"Stock",intialstock }
                });
                Console.WriteLine("Product added successfully:");
            }
            else
            {
                Console.WriteLine("ProductId already exsist");
            }
        }
        static void UpdateStock()
        {
            Console.WriteLine("Enter product:");
            string productId=Console.ReadLine();
            if (inventry.ContainsKey(productId)) {
                Console.WriteLine("Enter new stock quantity:");
                int newStock=int.Parse(Console.ReadLine());
                inventry[productId]["Stock"]=newStock;
                Console.WriteLine("Stock is updated successfully:");
            }
            else
            {
                Console.WriteLine("ProductId not found");
            }

        }
        static void GetProductDetails()
        {

            Console.WriteLine("Enter product id:");
            string productId = Console.ReadLine();
            if (inventry.ContainsKey(productId))
            {
                Dictionary<string, object> product = inventry[productId];
                Console.WriteLine($"Product ID:{productId},Name:{product["Name"]},Price{product["Price"]},Stock{product["Stock"]}");
            }
            else
            {
                Console.WriteLine("Product Id not found:");
            }


        }
        static void GetLowStockProducts()
        {
            Console.WriteLine("Enter the low stock value:");
            int LowStock = int.Parse(Console.ReadLine());

            List<string>LowStockProducts= new List<string>();
            foreach(var product in inventry)
            {
                if ((int)product.Value["Stock"] < LowStock)
                {
                    Console.WriteLine("Products with Low stock details:");

                    foreach(var productId in LowStockProducts)
                    {
                        Dictionary<string,object> product= inventry[productId];
                        Console.WriteLine($"Product ID{productId},Name:{product["Name"]},Price:{product["Price"]},Stock:{product["Stock"]}");

                    }
                }
                else
                {
                    Console.WriteLine("No product with Low stock;");

                }
            }


        }
        static void Main(string[] args)
        {
            while (true) {

                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Update Stock");
                Console.WriteLine("3. Get Product Details");
                Console.WriteLine("4. Get Low Stock Products");
                Console.WriteLine("5. Exit");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        UpdateStock();
                        break;
                    case "3":
                        GetProductDetails(); 
                        break;
                    case "4":
                        GetLowStockProducts();
                        break;
                    default:
                        Console.WriteLine("Invalid entry");
                        break;

                }

            }

        }
    }
}
