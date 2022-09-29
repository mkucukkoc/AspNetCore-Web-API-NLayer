using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{

    public class CategoryController : CustomeBaseController
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("[action]/{categoryId}")]
        public async Task<IActionResult> GetSingleCategoryByWithProducts(int categoryId)
        {
            return CreateActionResult(await _categoryService.GetSingleCategoryByWidthProductsAsync(categoryId));

        }

    }
}
