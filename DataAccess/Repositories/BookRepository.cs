using BusinessObject;
using DataAccess.DAO;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    internal class BookRepository : IBookRepository
    {
        public void DeleteBook(Book book) => BookDAO.DeleteBook(book);

        public List<Book> GetAllBooks() => BookDAO.GetAllBooks();

        public Book GetBookById(int id) => BookDAO.GetBookById(id);

        public List<Book> GetBooksByAuthorId(int id) => BookDAO.GetBooksByAuthorId(id);

        public List<Book> GetBooksByPublisherId(int id) => BookDAO.GetBooksByPublisherId(id);
        public void InsertBook(Book book) => BookDAO.InsertBook(book);

        public void UpdateBook(Book book) => BookDAO.UpdateBook(book);
    }
}
