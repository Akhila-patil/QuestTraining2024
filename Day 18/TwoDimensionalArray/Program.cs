using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[2, 3];
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter the values {i},{j}");
                    data[i,j]=int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{data[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
