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
        void InsertAuthor(AuthorDto authorDto);
    }
}
