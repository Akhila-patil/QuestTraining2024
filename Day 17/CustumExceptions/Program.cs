using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustumExceptions
{
    internal class Program
    { 
        public class InvalidAgeException : Exception
        {
            public InvalidAgeException():base("Age cannot be zero or less than 0 and more than 120")
            {

            }
            public InvalidAgeException(string message) : base(message)
            {

            }
            
        }
        public static void validate(int age)
        {
            if (age <= 0 || age > 120)
            {
                throw new InvalidAgeException();
            }
        }
        //static string ReverseString(string str)
        //{
        //    char[] charArray = new char[str.Length];
        //    int j = 0;
        //    for(int i = str.Length - 1; i >= 0; i--)
        //    {
        //        charArray[j] = str[i];
        //        j++;
        //    }
        //    return new string(charArray);
        //}
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the age");
                int age = int.Parse(Console.ReadLine());
                validate(age);
                Console.WriteLine("your age is:" + age);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }


            //Console.WriteLine(ReverseString("Hello"));


            //int[] array = { 21, 3, 4, 5, 12, 89, 67, 5, 6, 74, 3, 24 };
            //int temp = 0;
            //for(int i = 0; i < array.Length; i++)
            //{
            //    for(int j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] < array[j])
            //        {
            //            temp = array[i];
            //            array[i] = array[j];
            //            array[j] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine("Desending array is:");
            //foreach(var item in array)
            //{
            //    Console.WriteLine(item);
            //}


            //int[] array = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Reversed array:");
            //for(int i = array.Length - 1; i >=0; i--)
            //{
            //    Console.WriteLine(array[i]);
            //}

        }
    }
}
