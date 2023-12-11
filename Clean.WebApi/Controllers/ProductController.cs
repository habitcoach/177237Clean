using Clean.Application.DTOs;
using Clean.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Clean.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }
        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_productService.GetProductsDto().Products.ToList());

        }

        [HttpPost]
        public IActionResult Create(ProductDto productDto)
        {
            var result = _productService.CreateProduct(productDto);

            return Ok(result);

        }
    }
}
