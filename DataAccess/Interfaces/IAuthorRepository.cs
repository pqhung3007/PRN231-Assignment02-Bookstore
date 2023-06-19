using BusinessObject;
using BusinessObject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IAuthorRepository
    {
       /* Author GetAuthorById(int id);
        List<Author> GetAllAuthors();
        void UpdateAuthor(Author author);
        void DeleteAuthor(Author author);*/
        void InsertAuthor(AuthorDto author);
    }
}
