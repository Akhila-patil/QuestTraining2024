using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayresizing
{
    internal class Program
    {
        public static int[] ResizingArray(int[] oldArray,int newsize)
        {
            int[] newArray = new int[newsize];

            for (int i = 0; i < oldArray.Length && i < newsize; i++) { 
            
                newArray[i] = oldArray[i];
            }
            return newArray;
        }

        static void Main(string[] args)
        {
            int[] originalArray = { 1, 2, 3, 4, 5 };
            int[] largerArray = ResizingArray(originalArray,10);

            Console.WriteLine("Larger Array:");
            foreach(int item in largerArray)
            {
                Console.WriteLine(item+"");
            }

            int[] smallerArray=ResizingArray(originalArray,5);
            Console.WriteLine("smaller Array:");
            foreach(int item in smallerArray)
            {
                Console.WriteLine(item + " ");
            }

        }
    }
}
