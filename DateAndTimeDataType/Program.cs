using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTimeDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Current date and time:" + now);

            DateTime specificDate = new DateTime(2024, 11, 5, 10, 20, 10);
            Console.WriteLine("Specific date and time: " + specificDate);

            DateTime format = DateTime.Now;
            Console.WriteLine("Formatted date: " + format.ToString("dd/MM/yyyy"));
            Console.WriteLine("Formatted Time: " + format.ToString("HH:mm:ss"));

            DateTime today = DateTime.Today;
            DateTime addWeek = DateTime.Today.AddDays(7);
            DateTime addMonth = DateTime.Today.AddMonths(1);
            DateTime lastYear = DateTime.Today.AddYears(-1);
            DateTime nextYear = DateTime.Today.AddYears(1);

            Console.WriteLine("Today: " + today);
            Console.WriteLine("NextWeek: " + addWeek);
            Console.WriteLine("NextMonth: " + addMonth);
            Console.WriteLine("lastYear: " + lastYear);
            Console.WriteLine("NextYear: " + nextYear);

            DateTime startDate = DateTime.Now;
            DateTime endDate =  new DateTime(2024, 12, 31);
            TimeSpan difference = startDate - endDate;
            Console.WriteLine(difference);

            


        }
    }
}
