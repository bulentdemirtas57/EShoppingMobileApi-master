using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MobileApp.Data.Repositories;
using MobileApp.Models;

namespace MobileApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        [HttpGet]
        [Route("GetProducts")]
        public IActionResult GetProducts()
        {
            return Ok(_productRepository.GetAllProducts());
        }

        [HttpPost]
        [Route("GetProductsByCategory")]
        public IActionResult GetProductsByCategory(ProductByCategoryRequestModel request)
        {
            return Ok(_productRepository.GetProductsByCategory(request.CategoryId));
        }

        [HttpPost]
        [Route("GetProductsByCategoryAndSubCategory")]
        public IActionResult GetProductsByCategoryAndSubCategory(ProductByCategoryAndSubCategoryRequestModel request)
        {
            return Ok(_productRepository.GetProductsByCategoryAndSubCategory(request.CategoryId, request.SubCategoryId));
        }
    }
}
