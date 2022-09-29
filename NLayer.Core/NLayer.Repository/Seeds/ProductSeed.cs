using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    //Seeds kullanmamızın sebebi database tarafına default degerler girmemiz için kullanılıyor.
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
            new Product { Id = 1, CategoryId = 1, Name = "Kalem 1", Price = 100, Stock = 20, CreatedDate = DateTime.Now },
            new Product { Id = 2, CategoryId = 1, Name = "Kalem 2", Price = 200, Stock = 10, CreatedDate = DateTime.Now },
            new Product { Id = 3, CategoryId = 1, Name = "Kalem 3", Price = 50, Stock = 20, CreatedDate = DateTime.Now });
        }
    }
}
