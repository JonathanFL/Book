using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BookEFCore.Model
{
    class Book
    {
        public int price { get; set; }
        [Key]
        public string ISBN { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string publishedOn { get; set; }
        public string imgURL { get; set; }
        public List<AuthorBooks> Books { get; set; }
        public List<Review> ReviewsList { get; set; }
    }
}
