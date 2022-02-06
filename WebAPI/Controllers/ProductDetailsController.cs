using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {
        IProductService _productService;

        public ProductDetailsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<ProductDetailDto> Get()
        {
            var result = _productService.GetProductDetails();
            return result.Data;
        }
    }
}
