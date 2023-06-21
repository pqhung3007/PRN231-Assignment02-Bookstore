using BusinessObject;
using BusinessObject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public interface IAuthorDAO
    {
        void DeleteAuthor(int authorId);
        List<AuthorDto> GetAllAuthors();
        void InsertAuthor(AuthorDto authorDto);
        void UpdateAuthor(AuthorDto authorDto, int authorId);
    }
}
