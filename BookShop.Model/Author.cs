using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop.Model
{
    public class Author
    {
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
    }
}
