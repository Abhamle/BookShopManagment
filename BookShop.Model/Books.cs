using System;

namespace BookShop.Model
{
    public class Books
    {
        public int Id { get; }
        public string Title { get; set; }
        public Guid ISBN { get; set; }
        public int NumberOnHand { get; set; }
        public Publisher Publisher { get; set; }
        public BookGenre Genre { get; set; } 
    }
}
