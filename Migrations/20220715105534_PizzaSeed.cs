using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace la_mia_pizzeria_static.Migrations
{
    public partial class PizzaSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pizzas",
                table: "Pizzas");

            migrationBuilder.RenameTable(
                name: "Pizzas",
                newName: "Pizze");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pizze",
                table: "Pizze",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Pizze",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Pomodoro, mozzarella, basilico", "img/margherita.png", "Margherita", 9.99m },
                    { 2, "Pomodoro, mozzarella, prosciutto", "img/prosciutto.png", "Prosciutto", 10.99m },
                    { 3, "Pomodoro ciliegino, mozarella di bufala, olive", "img/bufalina.jpg", "Bufalina", 11.99m },
                    { 4, "Pomodoro, mozzarella, prosciutto", "https://www.pizzaventura.com/wp-content/uploads/2020/03/calzone.jpg", "Calzone", 12.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pizze",
                table: "Pizze");

            migrationBuilder.DeleteData(
                table: "Pizze",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pizze",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pizze",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pizze",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameTable(
                name: "Pizze",
                newName: "Pizzas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pizzas",
                table: "Pizzas",
                column: "Id");
        }
    }
}
