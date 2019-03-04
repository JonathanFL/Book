using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookEFCore.Model
{
    class AuthorBooks
    {
        public Book Book { get; set; }
        
        public int BookIsbn { get; set; }
        public Author Author { get; set; }
        public string firstName_FK { get; set; }
        public string lastName_FK { get; set; }
    }
}
