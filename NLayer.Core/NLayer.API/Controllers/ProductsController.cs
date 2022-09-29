using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.API.Filters;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Services;
using NLayer.Service.Services;

namespace NLayer.API.Controllers
{
    public class ProductsController :CustomeBaseController
    {
        private readonly IMapper _mapper;
        private readonly IProductService _service;
        public ProductsController(IMapper mapper ,IProductService productService)
        {
            _mapper = mapper;
            _service = productService;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetProductWithCategory()
        {
            return CreateActionResult(await _service.GetProductWithCategory());

        }
        [HttpGet]
        public async Task<IActionResult>All()
        {
            var products=await _service.GetAllAsync();  
            var productsDtos=_mapper.Map<List<ProductDto>>(products.ToList());
            return CreateActionResult(CustomResponseDto<List<ProductDto>>.Success(200,productsDtos));
        }
        [ServiceFilter(typeof(NotFoundFilter<Product>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _service.GetByIdAsync(id);
            var productDto=_mapper.Map<ProductDto>(product);
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(200,productDto));
        }
        [HttpPost]
        public async Task<IActionResult> Save(ProductDto productDto)
        {
            var product = await _service.AddAsync(_mapper.Map<Product>(productDto));
            var productsDto = _mapper.Map<ProductDto>(product);
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(201,productsDto)); ;
        }
        [HttpPut]
        public async Task<IActionResult> Update(ProductDto productDto)
        {
            await _service.Update(_mapper.Map<Product>(productDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult>Remove(int id)
        {
            var product = await _service.GetByIdAsync(id);
            await _service.Remove(product);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
