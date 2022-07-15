using la_mia_pizzeria_static.Models;
using Microsoft.EntityFrameworkCore;

namespace la_mia_pizzeria_static.DB
{
    public class PizzaContext : DbContext
    {
        public DbSet<Pizza> Pizze { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=pizzeria-db;Integrated Security=True");
        }

        private void PizzaSeed(ModelBuilder modelBuilder)
        {
            List<Pizza> pizzas = new()
            {
                new("Margherita", "Pomodoro, mozzarella, basilico", 9.99m, "~/img/margherita.png"),
                new("Prosciutto", "Pomodoro, mozzarella, prosciutto", 10.99m, "~/img/prosciutto.png"),
                new("Bufalina", "Pomodoro ciliegino, mozarella di bufala, olive", 11.99m, "~/img/bufalina.jpg"),
                new("Calzone", "Pomodoro, mozzarella, prosciutto", 12.99m, "https://www.pizzaventura.com/wp-content/uploads/2020/03/calzone.jpg"),
                new("Margherita2", "Pomodoro, mozzarella, basilico", 9.99m, "~/img/margherita.png"),
                new("Prosciutto2", "Pomodoro, mozzarella, prosciutto", 10.99m, "~/img/prosciutto.png"),
                new("Bufalina2", "Pomodoro ciliegino, mozarella di bufala, olive", 11.99m, "~/img/bufalina.jpg"),
                new("Calzone2", "Pomodoro, mozzarella, prosciutto", 12.99m, "https://www.pizzaventura.com/wp-content/uploads/2020/03/calzone.jpg")
            };

            List<Ingredient> ingredients = new();
            List<string> ingredientsString = new();

            foreach (Pizza pizza in pizzas)
            {
                pizza.Id = pizzas.IndexOf(pizza) + 1;
                List<string> pizzaIngredients = pizza.Description.ToLower().Split(", ").ToList();
                foreach (string pizzaIngredient in pizzaIngredients)
                {
                    if (!ingredientsString.Any(i => i == pizzaIngredient.Trim()))
                    {
                        ingredientsString.Add(pizzaIngredient.Trim());
                    }
                }
            }

            foreach (string ingredient in ingredientsString)
            {
                ingredients.Add(new()
                {
                    Name = ingredient,
                    Id = ingredientsString.IndexOf(ingredient) + 1
                });
            }

            modelBuilder.Entity<Ingredient>().HasData(ingredients);
            modelBuilder.Entity<Pizza>().HasData(pizzas);

            foreach (Pizza pizza in pizzas)
            {
                List<string> pizzaIngredients = pizza.Description.ToLower().Split(", ").ToList();
                foreach (string pizzaIngredient in pizzaIngredients)
                {
                    pizza.Ingredients.Add(ingredients.First(i => i.Name == pizzaIngredient.Trim()));
                }
            }
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            this.PizzaSeed(modelBuilder);
        }

    }
}
