using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public IList<Ingredient> Ingredients { get; } = new List<Ingredient>();

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
