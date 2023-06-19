﻿using BusinessObject;
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
        List<AuthorDto> GetAllAuthors();
        void InsertAuthor(AuthorDto author);
        void UpdateAuthor(AuthorDto author, int authorId);
    }
}
