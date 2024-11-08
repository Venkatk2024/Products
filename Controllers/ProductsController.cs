using Microsoft.AspNetCore.Mvc;
using TopSellingProducts.Services;
using Microsoft.AspNetCore.Http;


namespace TopSellingProducts.Controllers
{
   
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("top-selling")]
        public IActionResult GetTopSellingProducts([FromQuery] string season)
        {
            var products = _productService.GetTopSellingProductsBySeason(season);
            return Ok(products);
        }
    }
}



