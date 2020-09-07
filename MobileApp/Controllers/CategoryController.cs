using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MobileApp.Data.Repositories;

namespace MobileApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        [Route("GetAll")]
        [AllowAnonymous]
        public IActionResult GetAll()
        {
            var categories = _categoryRepository.GetCategories();

            return Ok(categories);
        }

        [HttpGet]
        [Route("GetCategoryByParentCategory")]
        [AllowAnonymous]
        public IActionResult GetCategoryByParentCategory([FromForm] int parentCategoryId)
        {
            var categories = _categoryRepository.GetCategoryByParentCategory(parentCategoryId);

            return Ok(categories);
        }
    }
}
