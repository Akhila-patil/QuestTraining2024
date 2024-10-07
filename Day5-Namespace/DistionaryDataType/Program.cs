using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistionaryDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //usage of dictionary
            //Dictionary<string> d=new Dictionary<string,string>();

            var d = new Dictionary<string, string>();

            //add values
            d.Add("First Name", "Akhila");
            d.Add("Last Name", "Patil");
            d.Add("Age", "25");
            //Accessing a value
            Console.WriteLine(d["First Name"]);

            //updating value
            d["First Name"] = "sunil";
            Console.WriteLine(d["First Name"]);

            //remove a value
            d.Remove("Last Name");

            //check if key exist

            if (d.ContainsKey("Age"))
            {
                Console.WriteLine("Age key exist");
            }
            else
            {
                Console.WriteLine("Age key does not exist");
            }
             
            //looping a dictionary
            foreach(var item in d)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
