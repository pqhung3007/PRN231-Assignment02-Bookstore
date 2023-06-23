using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.DTO
{
    public class AuthorDto
    {
		public int AuthorId { get; set; }
		public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? City { get; set; }
        public string? EmailAddress { get; set; }
    }
}
