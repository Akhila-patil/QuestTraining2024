using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMissingNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 4 };
            int missingNumber = FindMissingNumber(numbers);
            Console.WriteLine("missing number is: " + missingNumber);
        }
        static int FindMissingNumber(List<int> numbers)
        {
            int n = numbers.Count + 1;
            int expectedSum = n * (n + 1) / 2;
            int actualSum = 0;
            foreach(int num in numbers)
            {
                actualSum += num;
            }
            return expectedSum - actualSum;
        }
    }
}
