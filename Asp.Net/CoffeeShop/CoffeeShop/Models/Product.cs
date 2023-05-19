namespace CoffeeShop.Models
{
    public class Product:BaseEntity
    {
        public string? Name { get; set; }
        public string? Image { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }
    }
}
