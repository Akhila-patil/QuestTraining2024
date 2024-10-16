using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonGetSet
{
    public class Person
    {
        public string name { get; set; }
        public string email { get; set; }

        public List<Address> Addresses=new List<Address>();
    }

    public class Address
    {
        public string AddressType { get; set; }

        public string AddressLine1 {  get; set; }
        public string AddressLine2 { get; set; }
        public string pincode { get; set; }
    }
}
