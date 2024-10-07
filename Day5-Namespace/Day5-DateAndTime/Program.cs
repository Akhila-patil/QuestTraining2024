using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_DateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //local time
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            //universal time
            DateTime dtu = DateTime.UtcNow;
            Console.WriteLine(dtu);

            Console.WriteLine($"Day :{dt.Day}");





            //date time operartion








            //Construction Date Time
            var myDt = new DateTime(2024, 10, 7, 12, 50, 59);
            Console.WriteLine($" My Date and time :{myDt}");
        }
    }
}
