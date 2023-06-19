using AutoMapper;
using BusinessObject;
using BusinessObject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class AuthorDAO : IAuthorDAO
    {
        private readonly IMapper _mapper;
        private readonly BookStoreDbContext _context;

        public AuthorDAO(IMapper mapper, BookStoreDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
       
      /*  public static void DeleteAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public static List<Author> GetAllAuthors()
        {
            var listAuthors = new List<Author>();
            try
            {
                using (var context = new BookStoreDbContext())
                {
                    listAuthors = context.Authors.ToList();
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listAuthors;
        }

        public static Author GetAuthorById(int id)
        {
            Author author = null;
            try
            {
                using (var context = new BookStoreDbContext())
                {
                    author = context.Authors.Where(a => a.AuthorId == id).FirstOrDefault();
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return author;
        }*/

        public void InsertAuthor(AuthorDto authorDto)
        {
            try
            {
                    var mappedAuthor = _mapper.Map<Author>(authorDto);
                    _context.Authors.Add(mappedAuthor);
                    _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateAuthor(AuthorDto authorDto, int authorId)
        {
            var author = _context.Authors.Where(a => a.AuthorId == authorId).FirstOrDefault();
            var mappedAuthor = _mapper.Map(authorDto, author);
            _context.SaveChanges();
        }

    }
}
