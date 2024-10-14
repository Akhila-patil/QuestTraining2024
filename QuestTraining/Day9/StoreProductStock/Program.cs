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

         

        /*
        static Dictionary<string, Dictionary<string, object>> library = new Dictionary<string, Dictionary<string, object>>();
        static void AddBook()
        {
            Console.WriteLine("Enter book ID:");
            string bookId = Console.ReadLine();

            Console.WriteLine("Enter book title:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter author of book:");
            string author = Console.ReadLine();

            Console.WriteLine("Enter the copies of book:");
            int copies = int.Parse(Console.ReadLine());

            if (!library.ContainsKey(bookId))
            {
                library.Add(bookId, new Dictionary<string, object>{
                    { "Title",title },
                    { "Author",author },
                    { "Copies",copies }

                });
            }
            else
            {
                Console.WriteLine("Book id already exist!!!");
            }
        }
        static void BorrowBook()
        {
            Console.WriteLine("Enter book ID:");
            string bookId = Console.ReadLine();

            if (library.ContainsKey(bookId))
            {
                if ((int)library[bookID]["Copies"] > 0)
                {
                    library[bookId]["Copies"] = (int)library[bookId]["Copies"] - 1;

                    Console.WriteLine("Book borrowed Successfully");
                }
                else
                {
                    Console.WriteLine("No copies available");
                }
            }
            else
            {
                Console.WriteLine("Book id does not exist");
            }

        }


        static void ReturnBook()
        {
            Console.WriteLine("Enter book id:");
            string bookId = Console.ReadLine();

            if (library.ContainsKey(bookId))
            {


                library[bookId]["Copies"] = (int)library[bookId]["Copies"] - 1;

                Console.WriteLine("Book borrowed Successfully");
            }
            else
            {
                Console.WriteLine("Book id does'nt contain");
            }


        }
        static void GetAvailableBook()
        {
            foreach (var book in library)
            {
                if ((int)book.Value["Copies"] > 0)
                {


                    Console.WriteLine($"book Id:{book.Key},Title{book.Value["Title"]},Author{book.Value["Author"]},Copies{book.Value["copies"]}");



                }
            }



            static void Main(string[] args)
            {
                while (true)
                {

                    Console.WriteLine("1. AddBook");
                    Console.WriteLine("2. BorrowBook");
                    Console.WriteLine("3. ReturnBook");
                    Console.WriteLine("4. GetAvailable Books");
                    Console.WriteLine("5. Exit");

                    var option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            AddProduct();
                            break;
                        case "2":
                            BorrowBook();
                            break;
                        case "3":
                            ReturnBook();
                            break;
                        case "4":
                            GetAvailableBook();
                            break;
                        default:
                            Console.WriteLine("Invalid entry");
                            break;

                    }

                }


            }*/
        }

    }


