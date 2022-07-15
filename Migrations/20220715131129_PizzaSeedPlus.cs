using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace la_mia_pizzeria_static.Migrations
{
    public partial class PizzaSeedPlus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pizze",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "~/img/margherita.png");

            migrationBuilder.UpdateData(
                table: "Pizze",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "~/img/prosciutto.png");

            migrationBuilder.UpdateData(
                table: "Pizze",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "~/img/bufalina.jpg");

            migrationBuilder.InsertData(
                table: "Pizze",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 5, "Pomodoro, mozzarella, basilico", "~/img/margherita.png", "Margherita2", 9.99m },
                    { 6, "Pomodoro, mozzarella, prosciutto", "~/img/prosciutto.png", "Prosciutto2", 10.99m },
                    { 7, "Pomodoro ciliegino, mozarella di bufala, olive", "~/img/bufalina.jpg", "Bufalina2", 11.99m },
                    { 8, "Pomodoro, mozzarella, prosciutto", "https://www.pizzaventura.com/wp-content/uploads/2020/03/calzone.jpg", "Calzone2", 12.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pizze",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pizze",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pizze",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pizze",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Pizze",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "img/margherita.png");

            migrationBuilder.UpdateData(
                table: "Pizze",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "img/prosciutto.png");

            migrationBuilder.UpdateData(
                table: "Pizze",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "img/bufalina.jpg");
        }
    }
}
