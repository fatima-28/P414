namespace WebApplication1.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsDeleted { get; set; }
        public int ProductsId { get; set; }
        public Products? Products { get; set; }
    }
}
