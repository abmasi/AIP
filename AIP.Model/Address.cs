﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIP.Model
{
    public class Address : IEntity
    {
        public string Id { get; set; }
        public long AddressId { get; set; }
        public string StreetAddress { get; set; }
        public string ApartmentNumber { get; set; }
        public string Address2 { get; set; } 
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public AddressType? Type { get; set; }
        public string PersonId { get; set; }
    }
}
