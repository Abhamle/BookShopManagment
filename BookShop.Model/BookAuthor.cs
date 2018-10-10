using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop.Model
{
    public class BookAuthor
    {
        public int Id { get; set; }
        public List<Author> Authors { get; set; }
        public List<Books> Books { get; set; } 
    }
}
