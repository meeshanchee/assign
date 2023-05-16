using Microsoft.AspNetCore.Mvc;

namespace assign.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<OrderController> Get()
        {
            List<OrderController> orders = new List<OrderController>();
            orders.Add(new OrderController { Name = "test", order = "123" });
            orders.Add(new OrderController { Name = "test1", order = "124" });
            return orders;
        }
    }
}
