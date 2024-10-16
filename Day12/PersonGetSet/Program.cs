using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PersonGetSet.Person;

namespace PersonGetSet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var p = new Person();
            p.name = "Akhila";
            p.email = "ak@gmail.com";

            Console.WriteLine($"Name : {p.name} and Email :{p.email}");

            p.Addresses = new List<Address>();
            p.Addresses.Add(new Address { AddressType = "Home", AddressLine1 = "Moshi", AddressLine2 = "Dehu" });
            p.Addresses.Add(new Address { AddressType = "office", AddressLine1 = "pune", AddressLine2 = "hinjewadi" });

           







        }
    }
}
