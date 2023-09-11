using System;
using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.Persistence.Database.Configuration
{
    public class ProductInStockConfiguration
	{
		public ProductInStockConfiguration(EntityTypeBuilder<ProductInStock> entityBuilder)
		{
			//Aqui como prueba solo se esta especificando el campo que sera clave primaria
			entityBuilder.HasKey(e => e.ProductInStockId);

            var products = new List<ProductInStock>();
            var random = new Random();

            Enumerable.Range(1, 100).ToList().ForEach(i =>
            {
                products.Add(new ProductInStock
                {
                    ProductInStockId = i,
                    ProductId = i,
                    Stock = random.Next(0,20)
                });
            });

            entityBuilder.HasData(products);
        }
	}
}

