using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

        public Pizza(string name, string description, decimal price, string imageUrl)
        {
            Name = name;
            Description = description;
            Price = price;
            ImageUrl = imageUrl;
        }

        public string GetPrice()
        {
            return $"{Price:C2}";
        }
    }
}
