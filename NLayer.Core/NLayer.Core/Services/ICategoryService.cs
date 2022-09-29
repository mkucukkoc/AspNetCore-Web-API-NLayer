using NLayer.Core.DTOs;
using NLayer.Core.Models;

namespace NLayer.Core.Services
{
    public interface ICategoryService : IService<Category>
    {
        public Task<CustomResponseDto<CategoryWithProductDto>> GetSingleCategoryByWidthProductsAsync(int categoryId);
    }
}
