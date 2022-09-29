namespace NLayer.Core.DTOs
{
    public class CategoryWithProductDto : CategoryDto
    {
        public List<ProductDto> Products { get; set; }
    }
}
