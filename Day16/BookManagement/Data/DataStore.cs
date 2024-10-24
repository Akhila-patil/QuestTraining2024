using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagement.Entities;

namespace BookManagement.Data
{
    internal static  class DataStore
    {
        public static List<Book> Books;
        public static List<Member> Members;
        

        static DataStore()
        {
            Books = new List<Book>()
            {
                new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald" },
                new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee" }
            };

            Members = new List<Member>()
            {
                new Member { Id = 1, Name = "John Doe" ,Email="John@gmail.com"},
                new Member { Id = 2, Name = "Jane Smith",Email="Jane@gmail.com" }
            };

        }
    }
}
