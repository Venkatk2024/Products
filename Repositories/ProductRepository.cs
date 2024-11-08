using System;
using System.Collections.Generic;
using System.Linq;
using TopSellingProducts.Models;

namespace TopSellingProducts.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly List<Product> _products = new()
        {
            new Product { ProductId = 1, Name = "ProductA", SalePrice = 100, SaleDate = new DateTime(2024, 4, 1), Season = "Spring" },
            new Product { ProductId = 2, Name = "ProductB", SalePrice = 150, SaleDate = new DateTime(2024, 5, 15), Season = "Spring" },
            // Add more products as needed
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }
    }
}
