using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IBookRepository
    {
        Book GetBookById(int id);
        List<Book> GetAllBooks();
        List<Book> GetBooksByAuthorId(int id);
        List<Book> GetBooksByPublisherId(int id);
        void InsertBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(Book book);
        
    }
}
