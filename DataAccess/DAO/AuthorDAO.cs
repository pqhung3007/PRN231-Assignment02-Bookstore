﻿using AutoMapper;
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
    public class AuthorDAO : IAuthorDAO
    {
        private readonly IMapper _mapper;
        private readonly BookStoreDbContext _context;

        public AuthorDAO(IMapper mapper, BookStoreDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public void DeleteAuthor(int authorId)
        {
            var author = _context.Authors.FirstOrDefault(a => a.AuthorId == authorId);
            var bookAuthor = _context.BookAuthors.Where(x => x.AuthorId == authorId).ToList();

            _context.BookAuthors.RemoveRange(bookAuthor);
            _context.Authors.Remove(author);
            
            _context.SaveChanges();
        }

        public List<AuthorDto> GetAllAuthors()
        {
            var listAuthors = _context.Authors.ToList();
            return _mapper.Map<List<AuthorDto>>(listAuthors);
        }

        public AuthorDto GetAuthorById(int authorId)
        {
            var author = _context.Authors.FirstOrDefault(a => a.AuthorId == authorId);
            return _mapper.Map<AuthorDto>(author);
        }

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
            var author = _context.Authors.FirstOrDefault(x => x.AuthorId == authorId);
            var mappedAuthor = _mapper.Map(authorDto, author);
            _context.Authors.Update(mappedAuthor);
            _context.SaveChanges();
        }

    }
}
