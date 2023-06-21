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
    public class AuthorRepository : IAuthorRepository
    {
        private readonly IAuthorDAO _authorDao;
        public AuthorRepository(IAuthorDAO authorDao)
        {
            _authorDao = authorDao;
        }

        public List<AuthorDto> GetAllAuthors() => _authorDao.GetAllAuthors();

        public void UpdateAuthor(AuthorDto author, int authorId) => _authorDao.UpdateAuthor(author, authorId);

        public void InsertAuthor(AuthorDto author) => _authorDao.InsertAuthor(author);

        public void DeleteAuthor(int authorId) => _authorDao.DeleteAuthor(authorId);
    }
}
