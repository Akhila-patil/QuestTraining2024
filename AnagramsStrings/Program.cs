using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramsStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array ={ 5,3,9,2,7};
            int max = int.MinValue;
            int secMax = int.MinValue;

            foreach(int num in array)
            {
                if (num > max)
                {
                    secMax = max;
                    max = num;
                }
                else if(num>secMax && num != max)
                {
                    secMax = num;
                }
            }
            Console.WriteLine("second largest element is:" + secMax);















            //Console.WriteLine("Enter str1:");
            //string str1 = Console.ReadLine();

            //Console.WriteLine("Enter str1:");
            //string str2 = Console.ReadLine();

            //bool isAnagram = AreAnagram(str1, str2);
            //if (isAnagram==true)
            //{
            //    Console.WriteLine("Strings are anagram");
            //}
            //else
            //{
            //    Console.WriteLine("Strings not are anagram");

            //}
            
        }
        //static bool AreAnagram(string str1,string str2)
        //{
        //    if (str1.Length != str2.Length)
        //    {
        //        return false;
        //    }
        //    char[] charArray1 = str1.ToCharArray();
        //    char[] charArray2 = str2.ToCharArray();

        //    Array.Sort(charArray1);
        //    Array.Sort(charArray2);

        //    return new string(charArray1) == new string(charArray2);
        //}
    }
}
