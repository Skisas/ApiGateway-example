using System;
using Orders.Models;

namespace Orders.ViewModels
{
    public class OrderViewModel
    {
        public Guid Id { get; set; }

        public OrderStates State { get; set; }

        public DateTimeOffset Created { get; set; }

        public DateTimeOffset Modified { get; set; }
    }
}