using System;
using System.Collections.Generic;
using System.Text;

namespace BookEFCore.Model
{
    class PriceOffer
    {
        public int bookISBN { get; set; }
        public int newPrice { get; set; }
        public int Id { get; set; }
        public string promotionText { get; set; }
    }
}
