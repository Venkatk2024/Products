using System.Collections.Generic;
using TopSellingProducts.Models;

namespace TopSellingProducts.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
    }
}
