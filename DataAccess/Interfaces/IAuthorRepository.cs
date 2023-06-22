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
        void DeleteAuthor(int authorId);
        List<AuthorDto> GetAllAuthors();
        AuthorDto GetAuthorById(int authorId);
        void InsertAuthor(AuthorDto author);
        void UpdateAuthor(AuthorDto author, int authorId);
    }
}
