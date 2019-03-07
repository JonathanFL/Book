using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookEFCore.Model
{
    class Review
    {
        [Key]
        public int Id { get; set; }
        public string voterName { get; set; }
        public int numStars { get; set; }
        public string comment { get; set; }
        public Book Book { get; set; }
        public int reviewId { get; set; }
    }
}
