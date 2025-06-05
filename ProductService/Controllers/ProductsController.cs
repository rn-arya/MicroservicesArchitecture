using Microsoft.AspNetCore.Mvc;
using ProductService.Model;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static List<Product> products = new List<Product>
    {
        new Product { Id = 1, Name = "Product A", Price = 10.0m },
        new Product { Id = 2, Name = "Product B", Price = 20.0m }
    };

        [HttpGet]
        public ActionResult<List<Product>> Get() => products;

        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id) => products.FirstOrDefault(p => p.Id == id);

        [HttpPost]
        public ActionResult<Product> Create(Product product)
        {
            product.Id = products.Max(p => p.Id) + 1;
            products.Add(product);
            return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
        }
    }
}
