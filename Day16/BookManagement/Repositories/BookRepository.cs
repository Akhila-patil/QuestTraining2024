using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using BookManagement.Data;
using BookManagement.Entities;

namespace BookManagement.Repositories
{
    internal class BookRepository
    {
        //To Get all the books
        public GenericResponse<List<Book>> GetAllBooks()
        {
            var books = DataStore.Books;
            return new GenericResponse<List<Book>>
            {
                Success = true,
                Data = books
            };

        }

        //Get a book by Id
        public GenericResponse<Book> GetBookById(int id)
        {

            var book = DataStore.Books[id];
            if (book == null)
            {
                return new GenericResponse<Book>
                {
                    Success = false,
                    Message = "Book not found"
                };

            }
            return new GenericResponse<Book>
            {
                Success = true,
                Data = book
            };
        }
        //Search a book by name
        public GenericResponse<List<Book>> SearchByBookName(string bookName)
        {
            var books = DataStore.Books
                .Where(x => x.Title.ToLower().Contains(bookName.ToLower()))
                .ToList();

            if (books.Count == 0)
            {
                return new GenericResponse<List<Book>>
                {
                    Success = false,
                    Message = "No book found with this book name"
                };
            }
            return new GenericResponse<List<Book>>
            {
                Success = true,
                Data = books
            };
        }
    }
}
