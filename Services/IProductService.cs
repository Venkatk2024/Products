using System.Collections.Generic;
using TopSellingProducts.Models;
namespace TopSellingProducts.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetTopSellingProductsBySeason(string season);
    }
}
