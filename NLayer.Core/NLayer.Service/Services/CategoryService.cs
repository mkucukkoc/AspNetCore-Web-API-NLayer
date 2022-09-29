using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;

namespace NLayer.Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {

        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(IGenericRepository<Category> repository, IMapper mapper, ICategoryRepository categoryRepository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task<CustomResponseDto<CategoryWithProductDto>> GetSingleCategoryByWidthProductsAsync(int categoryId)
        {
            var category = await _categoryRepository.GetSingleCategoryWithProductsAsync(categoryId);
            var categoryDto = _mapper.Map<CategoryWithProductDto>(category);
            return CustomResponseDto<CategoryWithProductDto>.Success(200, categoryDto);
        }
    }
}
