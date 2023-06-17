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
    public class AuthorRepository : IAuthorRepository
    {
        public void DeleteAuthor(Author author) => AuthorDAO.DeleteAuthor(author);

        public List<Author> GetAllAuthors() => AuthorDAO.GetAllAuthors();

        public Author GetAuthorById(int id) => AuthorDAO.GetAuthorById(id);

        public void InsertAuthor(Author author) => AuthorDAO.InsertAuthor(author);

        public void UpdateAuthor(Author author) => AuthorDAO.UpdateAuthor(author);
    }
}
