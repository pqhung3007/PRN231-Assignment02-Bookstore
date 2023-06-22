using AutoMapper;
using BusinessObject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Common.Mappings
{
    public class BookMapping : Profile
    {
        public BookMapping()
        {
            CreateMap<Book, BookDto>()
                .ForMember(dest => dest.PublisherName,
               opt => opt.MapFrom(src => src.Publisher.PublisherName));
        }
    }
}
