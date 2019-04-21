using System;

namespace Deliveries.Models
{
    public class Delivery
    {
        public Guid Id { get; set; }

        public string Comment { get; set; }

        public string PhoneNumber { get; set; }

        public Address FromAddress { get; set; }

        public Address ToAddress { get; set; }

        public Guid OrderId { get; set; }
    }
}