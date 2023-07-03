using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Gateway.Ocelot.Sample.Products.Services;
using Gateway.Ocelot.Sample.Products.Model;

namespace Gateway.Ocelot.Sample.Products.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repository;
        public ProductController(IProductRepository repository) =>
            _repository = repository;

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repository.GetAll());

        }

        [HttpGet("{Id}")]
        public IActionResult Get(int id)
        {
            var product = _repository.Get(id);
            if(product is null)
                return NotFound();

            return Ok(product);
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            var result = _repository.Add(product);            
            return Ok(result);
        }
    }
}
