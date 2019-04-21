using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Deliveries.Models;

namespace Deliveries.Repositories
{
    public interface IDeliveriesRepository
    {
        Task<IEnumerable<Delivery>> GetOrderDeliveries(Guid orderId);

        Task<Delivery> GetDelivery(Guid id);
    }
}