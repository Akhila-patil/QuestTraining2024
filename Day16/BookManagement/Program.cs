using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagement.Repositories;

namespace BookManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bookRepository = new BookRepository();
            var memberRepository= new MemberRepository();

            var bookResult = bookRepository.GetBookById(1);
            if (bookResult.Success)
            {
                Console.WriteLine($"Book title:{bookResult.Data.Title}")
            }
        }
    }
}
