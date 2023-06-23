using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.DTO
{
    public class PublisherDto
    {
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public string City { get; set; }
    }
}
