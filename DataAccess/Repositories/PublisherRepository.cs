using BusinessObject;
using BusinessObject.DTO;
using DataAccess.DAO;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class PublisherRepository : IPublisherRepository
    {
        private readonly IPublisherDAO _publisherDao;

        public PublisherRepository(IPublisherDAO publisherDao)
        {
            _publisherDao = publisherDao;
        }

        public void DeletePublisher(int id) => _publisherDao.DeletePublisher(id);

        public List<PublisherDto> GetAllPublishers() => _publisherDao.GetAllPublishers();

        public PublisherDto GetPublisherById(int publisherId) => _publisherDao.GetPublisherById(publisherId);
        public void InsertPublisher(PublisherDto publisherDto) => _publisherDao.InsertPublisher(publisherDto);

        public void UpdatePublisher(int id, PublisherDto publisherDto) => _publisherDao.UpdatePublisher(id, publisherDto);
       
    }
}
