using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //define an list

            List<int> lst=new List<int>();
            //var lst=new List<int>();

            
            //Adding single value
            lst.Add(10);

            //Adding multiple element
            var valuesToAdd=new int[] {20,30,40,50};
            lst.AddRange(valuesToAdd);

            //updating the element
            lst[0] = 100;

            //deleting the element
            //To remove the first ocuurence of 50
            lst.Remove(50);

            //remove from a specific index
            lst.RemoveAt(1);

            for(int i=0;i<lst.Count; i++)
            {
                Console.Write(lst[i] +" ");
            }

            Console.WriteLine();    
            foreach(var item in lst)
            {
                Console.Write(item + " ");
            }
            //create a list with value

            var lst2=new List<int>() {1,2,3,4,5,6,7,7,8,9,10};

        }
    }
}
