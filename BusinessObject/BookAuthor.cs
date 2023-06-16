using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class BookAuthor
    {
        [Key]
        public int AuthorId { get; set; }
        public int BookId { get; set; }
        public int? AuthorOrder { get; set; }
        public decimal? RoyaltyPercentage { get; set; }

        public virtual Author Author { get; set; } = null!;
        public virtual Book Book { get; set; } = null!;
    }
}
