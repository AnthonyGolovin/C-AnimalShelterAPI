using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
        : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
          .HasData(
              new Animal { AnimalId = 1, Name = "Ancient One", Species = "Cat"},
              new Animal { AnimalId = 2, Name = "Rexie", Species = "Cat"},
              new Animal { AnimalId = 3, Name = "Matilda", Species = "Dog"},
              new Animal { AnimalId = 4, Name = "Pip", Species = "Dog"},
              new Animal { AnimalId = 5, Name = "Bartholomew", Species = "Cat"}
          );
    }
  }
}