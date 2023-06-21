﻿using BusinessObject;
using BusinessObject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IPublisherRepository
    {
        void DeletePublisher(int id);
        List<PublisherDto> GetAllPublishers();
        void InsertPublisher(PublisherDto publisherDto);
        void UpdatePublisher(int id, PublisherDto publisherDto);
    }
}

