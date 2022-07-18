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
            List<Ingredient> ingredients = new()
            {
                new()
                {
                    Id = 1,
                    Name = "Pomodoro",
                },
                new()
                {
                    Id = 2,
                    Name = "Mozzarella",
                },
                new()
                {
                    Id = 3,
                    Name = "Prosciutto",
                },
                new()
                {
                    Id = 4,
                    Name = "Olive",
                },
                new()
                {
                    Id = 5,
                    Name = "Pomodoro ciliegino",
                },
                new()
                {
                    Id = 6,
                    Name = "Mozzarella di bufala",
                }
            };

            modelBuilder.Entity<Ingredient>().HasData(ingredients);

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

            for (int i = 0; i < pizzas.Count(); i++)
            {
                pizzas[i].Id = i + 1;
            }

            modelBuilder.Entity<Pizza>().HasData(pizzas);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            PizzaSeed(modelBuilder);
        }
    }
}
