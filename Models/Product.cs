namespace TopSellingProducts.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal SalePrice { get; set; }
        public DateTime SaleDate { get; set; }
        public string Season { get; set; }

    }
}
