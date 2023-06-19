using AutoMapper;
using BusinessObject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Common.Mappings
{
    public class AuthorMapping : Profile
    {
        public AuthorMapping()
        {
            CreateMap<AuthorDto, Author>();
        }
    }
}
