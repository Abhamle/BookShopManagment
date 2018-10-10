using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop.Model
{
   public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
    }
}
