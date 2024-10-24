using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    internal class Program
    {
        class shopingList
        {
            private List<string> items = new List<string>();
            public string this[int index]
            {
                get
                {
                    if (index >= items.Count)
                    {
                        throw new IndexOutOfRangeException("index out of range exception");
                    }
                    return items[index];
                }
                set {
                    if (index >= items.Count)
                    {
                        items.Add(value);
                    }
                    else
                    {
                        items[index] = value;
                    }
                }
            }
            public int Totalitems => items.Count;
        }
        static void Main(string[] args)
        {
            var shoppingList = new shopingList();
            shoppingList[0] = "apple";
            shoppingList[1] = "banana";


           
        }
    }
}
