﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop.Model
{
    public class Address
    {
        public int Id { get; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }

    }
}
