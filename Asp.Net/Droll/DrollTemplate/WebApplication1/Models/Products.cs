namespace WebApplication1.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public float Price { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
    }
}
