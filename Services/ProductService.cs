using System.Collections.Generic;
using System.Linq;
using TopSellingProducts.Models;
using TopSellingProducts.Repositories;

namespace TopSellingProducts.Services
{
    public class ProductService: IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetTopSellingProductsBySeason(string season)
        {
            return _productRepository.GetAllProducts()
                .Where(p => p.Season.Equals(season, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(p => p.SalePrice)
                .Take(5); // Top 5 products
        }
    }
}
