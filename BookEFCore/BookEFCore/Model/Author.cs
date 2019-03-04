using System;
using System.Collections.Generic;
using System.Text;

namespace BookEFCore.Model
{
    class Author
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string imgURL { get; set; }
        public List<AuthorBooks> Authors { get; set; }
    }
}
