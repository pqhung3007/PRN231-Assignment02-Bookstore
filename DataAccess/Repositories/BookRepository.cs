using BusinessObject;
using BusinessObject.DTO;
using DataAccess.DAO;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly IBookDAO _bookDao;

        public BookRepository(IBookDAO bookDao)
        {
            _bookDao = bookDao;
        }

        public List<BookDto> GetAllBooks() => _bookDao.GetAllBooks();
    }
}
