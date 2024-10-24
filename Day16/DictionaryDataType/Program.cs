using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDataType
{

    class SortedList<T>
    {
        private List<T> _data=new List<T>();
        public int Count=>_data.Count;

        public void Add(T data)
        {
            _data.Add(data);
        }
    }
    //class MyDictionary<TKey, Tvalue>
    //{
    //    private Dictionary<TKey,Tvalue> _data= new Dictionary<TKey, Tvalue>();

    //    public int Count=>_data.Count;

    //    public void Add(TKey key, Tvalue value)
    //    {
    //        _data.Add(key, value);
    //    }
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            //var data = new MyDictionary<string, string>();
            //data.Add("Name", "Akhila Patil");
            //Console.WriteLine(string.Join(", ", data));


            var data = new List<int>();
            data.Add(1);
            data.Add(2);
            Console.WriteLine(string.Join(", ", data));
        }
    }
}
