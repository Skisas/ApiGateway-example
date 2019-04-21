using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Orders.Models;

namespace Orders.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private static readonly Random _random = new Random();

        public async Task<IEnumerable<Order>> GetClientOrders(Guid clientId)
        {
            var numberOfOrders = _random.Next(0, 4);
            var orders = new List<Order>(numberOfOrders);

            for (var i = 0; i < numberOfOrders; i++)
            {
                var orderId = Guid.NewGuid();
                var order = CreateMockOrder(clientId, orderId);

                orders.Add(order);
            }

            return orders;
        }

        public async Task<Order> GetOrder(Guid orderId)
        {
            var clientId = Guid.NewGuid();

            return CreateMockOrder(clientId, orderId);
        }

        private static Order CreateMockOrder(Guid clientId, Guid orderId)
        {
            var createdAt = DateTimeOffset.UtcNow;

            return new Order
            {
                Id = orderId,
                ClientId = clientId,
                Created = createdAt,
                Modified = createdAt,
                State = OrderStates.Created
            };
        }
    }
}