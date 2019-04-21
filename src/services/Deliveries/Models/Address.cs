using System;

namespace Deliveries.Models
{
    public class Address
    {
        public Guid Id { get; set; }

        public string ZipCode { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}