using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;

namespace Revision
{
    internal class Program
    {
        //abstract class Shape
        //{
        //    public abstract double CalculateArea();
        //    public void Display()
        //    {
        //        Console.WriteLine("Calculating area:");
        //    }
        //}
        //class Circle : Shape
        //{
        //    public double radius { get; set; }
        //    public Circle(double Radius)
        //    {
        //        radius = Radius;
        //    }
        //    public override double CalculateArea()
        //    {
        //        return Math.PI * radius * radius;
        //    }
        //}
        //class Rectangle : Shape
        //{
        //    public double length { get; set; }
        //    public double width { get; set; }
        //    public Rectangle(double length,double width)
        //    {
        //        this.length = length;
        //        this.width = width;
        //    }
        //    public override double CalculateArea()
        //    {
        //        return length * width;
        //    }
        //}
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            //public Person(string name, int age)
            //{
            //    Name = name;
            //    Age = age;
            //}
        }
        

        static void Main(string[] args)
        {
            Person p = new Person("Akhila", 24);
            Person p1 = new Person { Name = "Akhila", Age = 25 };
            Person p2 = new Person("Akhila", 34) { Age = 23};
            var p3 = new Person { Name = "akhila", Age = 34 };
            List<Person> P4 = new List<Person>
            {
                new Person{Name="akhila",Age=34},
                new Person{Name="sunil",Age=55}
            };
            
            //Shape circle = new Circle(10);
            //Shape rectangle = new Rectangle(5, 6);

            //circle.Display();
            //Console.WriteLine("The  area of circle is:" + circle.CalculateArea());

            //rectangle.Display();
            //Console.WriteLine("The  area of rectangle is:" + rectangle.CalculateArea());
            //BankAccount myAccount = new BankAccount("11234", "Akhila", 5000);

            //myAccount.Deposit(2000);
            //myAccount.Withdraw(500);
            //myAccount.GetBalance();

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            //int[] arrayNumbers = new int[6];
            //numbers.CopyTo(arrayNumbers);
            //Console.WriteLine(string.Join(",", numbers));

            //int[] array = { 1, 2, 3, 2, 4, 5, 6, 7 };
            //int index = Array.LastIndexOf(array, 2);
            //Console.WriteLine(string.Join(",", index));

            //Console.WriteLine("Even numbers are:");
            //for (int i = 0; i < array.Length; i++)
            //{   
            //    if (array[i] % 2 == 0)
            //    {
            //        Console.WriteLine(array[i]);
            //    }
            //}
            //string[] fruits = { "Apple", "Banana", "orange" };
            //Console.WriteLine(string.Join(",",fruits));

            //string text1 = "apple";
            //string text2 = "Apple";
            //int res = string.Compare(text1, text2,StringComparison.OrdinalIgnoreCase);
            //Console.WriteLine(res);
            //string s1 = "Hello";
            //string s2 = "world";
            //string result = string.Concat(s1," ", s2);
            //Console.WriteLine(result);

            //int[] array = { 1, 2, 2, 3,1, 2, 4, 5, 6, 4, 7, 8, 6 };
            //bool[] visited = new bool[array.Length];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (visited[i])
            //        continue;
            //    int count = 1;
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            count++;
            //            visited[j] = true;

            //        }
            //    }
            //    if (count > 1)
            //    {
            //        Console.WriteLine($"{array[i]},{count} times");
            //    }


            //}


            //var duplicates = array.GroupBy(x => x)
            //               .Where(g => g.Count() > 1)
            //               .Select(g => g.Key);

            //foreach(int val in duplicates)
            //{
            //    Console.WriteLine(val);
            //}

        }
    }
}
