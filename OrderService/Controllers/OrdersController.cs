using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private static List<Order> orders = new List<Order>();

        [HttpGet]
        public ActionResult<List<Order>> Get() => orders;

        [HttpPost]
        public ActionResult<Order> Create(Order order)
        {
            order.Id = orders.Count + 1;
            orders.Add(order);
            return CreatedAtAction(nameof(Get), new { id = order.Id }, order);
        }
    }
}
