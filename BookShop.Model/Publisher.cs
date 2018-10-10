using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop.Model
{
   public class Publisher
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
    }
}
