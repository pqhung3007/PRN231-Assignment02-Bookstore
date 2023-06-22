using AutoMapper;
using BusinessObject;
using BusinessObject.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class BookDAO : IBookDAO
    {
        private readonly IMapper _mapper;
        private readonly BookStoreDbContext _context;

        public BookDAO(IMapper mapper, BookStoreDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        
        public List<BookDto> GetAllBooks()
        {
            var books = _context.Books.Include(b => b.Publisher).ToList();
            return _mapper.Map<List<BookDto>>(books);
        }
    }
}
