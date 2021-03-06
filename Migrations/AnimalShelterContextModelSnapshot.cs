﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CAnimalShelterAPI.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    partial class AnimalShelterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Species");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Name = "Ancient One",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 2,
                            Name = "Rexie",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 3,
                            Name = "Matilda",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 4,
                            Name = "Pip",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 5,
                            Name = "Bartholomew",
                            Species = "Cat"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
