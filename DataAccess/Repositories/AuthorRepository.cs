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

        /*public void DeleteAuthor(Author author) => AuthorDAO.DeleteAuthor(author);

        public List<Author> GetAllAuthors() => AuthorDAO.GetAllAuthors();

        public Author GetAuthorById(int id) => AuthorDAO.GetAuthorById(id);
        public void UpdateAuthor(Author author) => AuthorDAO.UpdateAuthor(author);*/

        public void InsertAuthor(AuthorDto author) => _authorDao.InsertAuthor(author);

    }
}
