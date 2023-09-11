using System;
using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.Persistence.Database.Configuration
{
	public class ProductConfiguration
	{
		public ProductConfiguration(EntityTypeBuilder<Product> entityBuilder)
		{
			entityBuilder.HasIndex(e => e.ProductId);
			entityBuilder.Property(e => e.Name).IsRequired().HasMaxLength(100);
			entityBuilder.Property(e => e.Description).IsRequired().HasMaxLength(500);

			var products = new List<Product>();
			var random = new Random();

			Enumerable.Range(1, 100).ToList().ForEach(i =>
            {
                products.Add(new Product
                {
                    ProductId = i,
                    Name = $"Product {i}",
                    Description = $"Description for product {i}",
                    Price = random.Next(100, 1000),
                });
            });

            entityBuilder.HasData(products);
		}
	}
}

