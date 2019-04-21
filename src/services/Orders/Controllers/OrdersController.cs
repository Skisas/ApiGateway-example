using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Orders.Repositories;

namespace Orders.Controllers
{
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersRepository _ordersRepository;

        public OrdersController(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository ?? throw new ArgumentNullException(nameof(ordersRepository));
        }

        [HttpGet]
        [Route("api/clients/{clientId:guid}/orders")]
        public async Task<IActionResult> GetOrders([FromRoute]Guid clientId)
        {
            if (clientId == Guid.Empty)
            {
                throw new ArgumentException(nameof(clientId));
            }

            var orders = await _ordersRepository.GetClientOrders(clientId);

            return Ok(orders);
        }

        [HttpGet("api/orders/{orderId:guid}")]
        public async Task<IActionResult> Get([FromRoute]Guid orderId)
        {
            if (orderId == Guid.Empty)
            {
                throw new ArgumentException(nameof(orderId));
            }

            var order = await _ordersRepository.GetOrder(orderId);

            return Ok(order);
        }
    }
}
