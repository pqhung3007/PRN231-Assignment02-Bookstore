using BusinessObject;
using DataAccess.DAO;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    internal class PublisherRepository : IPublisherRepository
    {
        public void DeletePublisher(Publisher publisher) => PublisherDAO.DeletePublisher(publisher);

        public List<Publisher> GetAllPublishers() => PublisherDAO.GetAllPublishers();

        public Publisher GetPublisherById(int publisherId) => PublisherDAO.GetPublisherById(publisherId);

        public void InsertPublisher(Publisher publisher) => PublisherDAO.InsertPublisher(publisher);

        public void UpdatePublisher(Publisher publisher) => PublisherDAO.UpdatePublisher(publisher);
    }
}
