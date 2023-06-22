using AutoMapper;
using BusinessObject;
using BusinessObject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class PublisherDAO : IPublisherDAO
    {
        private readonly IMapper _mapper;
        private readonly BookStoreDbContext _context;

        public PublisherDAO(IMapper mapper, BookStoreDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public void DeletePublisher(int id)
        {
            var publisher = _context.Publishers.FirstOrDefault(a => a.PubId == id);
            _context.Publishers.Remove(publisher);
            _context.SaveChanges();
        }

        public List<PublisherDto> GetAllPublishers()
        {
            var listPublishers = _context.Publishers.ToList();
            return _mapper.Map<List<PublisherDto>>(listPublishers);
        }

        public PublisherDto GetPublisherById(int publisherId)
        {
            var publisher = _context.Publishers.FirstOrDefault(a => a.PubId == publisherId);
            if (publisher == null)
            {
                throw new Exception("Publisher not found");
            }
            return _mapper.Map<PublisherDto>(publisher);
        }

        public void InsertPublisher(PublisherDto publisherDto)
        {
            try
            {
                var mappedPublisher = _mapper.Map<Publisher>(publisherDto);
                _context.Publishers.Add(mappedPublisher);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdatePublisher(int id, PublisherDto publisherDto)
        {
            var publisher= _context.Publishers.FirstOrDefault(x => x.PubId == id);
            var mappedPublisher = _mapper.Map(publisherDto, publisher);
            _context.Publishers.Update(mappedPublisher);
            _context.SaveChanges();
        }
    }
}
