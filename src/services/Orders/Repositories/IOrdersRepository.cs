using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Orders.Models;

namespace Orders.Repositories
{
    public interface IOrdersRepository
    {
        Task<IEnumerable<Order>> GetClientOrders(Guid clientId);
        Task<Order> GetOrder(Guid orderId);
    }
}