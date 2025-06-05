using Microsoft.AspNetCore.Mvc;
using ShippingService.Model;

namespace ShippingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingController : ControllerBase
    {
        private static List<Shipping> shippingDetails = new List<Shipping>();

        [HttpGet]
        public ActionResult<List<Shipping>> Get() => shippingDetails;

        [HttpPost]
        public ActionResult<Shipping> Create(Shipping shipping)
        {
            shipping.Id = shippingDetails.Count + 1;
            shippingDetails.Add(shipping);
            return CreatedAtAction(nameof(Get), new { id = shipping.Id }, shipping);
        }
    }
}
