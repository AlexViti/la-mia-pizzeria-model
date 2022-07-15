﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using la_mia_pizzeria_static.DB;

#nullable disable

namespace la_mia_pizzeria_static.Migrations
{
    [DbContext(typeof(PizzaContext))]
    [Migration("20220715105534_PizzaSeed")]
    partial class PizzaSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("la_mia_pizzeria_static.Models.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Pizze");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Pomodoro, mozzarella, basilico",
                            ImageUrl = "img/margherita.png",
                            Name = "Margherita",
                            Price = 9.99m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Pomodoro, mozzarella, prosciutto",
                            ImageUrl = "img/prosciutto.png",
                            Name = "Prosciutto",
                            Price = 10.99m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Pomodoro ciliegino, mozarella di bufala, olive",
                            ImageUrl = "img/bufalina.jpg",
                            Name = "Bufalina",
                            Price = 11.99m
                        },
                        new
                        {
                            Id = 4,
                            Description = "Pomodoro, mozzarella, prosciutto",
                            ImageUrl = "https://www.pizzaventura.com/wp-content/uploads/2020/03/calzone.jpg",
                            Name = "Calzone",
                            Price = 12.99m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
