using la_mia_pizzeria_static.Models;
using Microsoft.EntityFrameworkCore;

namespace la_mia_pizzeria_static.DB
{
    public class PizzaContext : DbContext
    {
        public DbSet<Pizza> Pizze { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=pizzeria-db;Integrated Security=True");
        }

        private void PizzaSeed(ModelBuilder modelBuilder)
        {
            List<Pizza> pizzas = new()
            {
                new("Margherita", "Pomodoro, mozzarella, basilico", 9.99m, "img/margherita.png"),
                new("Prosciutto", "Pomodoro, mozzarella, prosciutto", 10.99m, "img/prosciutto.png"),
                new("Bufalina", "Pomodoro ciliegino, mozarella di bufala, olive", 11.99m, "img/bufalina.jpg"),
                new("Calzone", "Pomodoro, mozzarella, prosciutto", 12.99m, "https://www.pizzaventura.com/wp-content/uploads/2020/03/calzone.jpg")
            };

            foreach (Pizza pizza in pizzas)
            {
                pizza.Id = pizzas.IndexOf(pizza) + 1;
            }

            modelBuilder.Entity<Pizza>().HasData(pizzas);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            this.PizzaSeed(modelBuilder);
        }

    }
}
