using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{

    class SmartPhone
    {
        public string Name;
        public string Manufacturer;
        public List<int>  MemorySize;

        public void DisplayDetails()
        {
            Console.WriteLine($"Name:{ Name}");
            Console.WriteLine($"Manufacturer:{Manufacturer}");
            Console.WriteLine($"MemorySize  "+string.Join(",",MemorySize));
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var smartphone1 = new SmartPhone()
            {
                Name = "Vivo",
                Manufacturer = "xyz",
                MemorySize = new List<int> { 23, 45, 67 }

            };
            smartphone1.DisplayDetails();
            
        }
    }
}
