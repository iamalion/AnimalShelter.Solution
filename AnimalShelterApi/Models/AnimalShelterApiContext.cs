using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Fluffy", Species = "Cat", Breed = "Persian", Age = 2, Description = "Elegant and regal.", Available = true },
          new Animal { AnimalId = 2, Name = "Buddy", Species = "Dog", Breed = "Golden Retriever", Age = 3, Description = "Friendly and loyal companion.", Available = true },
          new Animal { AnimalId = 3, Name = "Nibbles", Species = "Hamster", Breed = "Syrian", Age = 1, Description = "Tiny and energetic ball.", Available = true },
          new Animal { AnimalId = 4, Name = "Cotton", Species = "Bunny", Breed = "Dwarf Hotot", Age = 2, Description = "Fluffy and adorable hopper.", Available = true },
          new Animal { AnimalId = 5, Name = "Spike", Species = "Lizard", Breed = "Bearded Dragon", Age = 4, Description = "Colorful and intriguing reptile.", Available = true },
          new Animal { AnimalId = 6, Name = "Mittens", Species = "Cat", Breed = "Siamese", Age = 1, Description = "Playful and vocal feline.", Available = true },
          new Animal { AnimalId = 7, Name = "Rocky", Species = "Dog", Breed = "Bulldog", Age = 2, Description = "Stubborn but affectionate.", Available = true },
          new Animal { AnimalId = 8, Name = "Whiskers", Species = "Hamster", Breed = "Roborovski", Age = 1, Description = "Quick and curious explorer.", Available = true },
          new Animal { AnimalId = 9, Name = "Cocoa", Species = "Bunny", Breed = "Holland Lop", Age = 3, Description = "Sweet and gentle muncher.", Available = true },
          new Animal { AnimalId = 10, Name = "Ziggy", Species = "Lizard", Breed = "Leopard Gecko", Age = 2, Description = "Nocturnal and patterned Lizard.", Available = true },
          new Animal { AnimalId = 11, Name = "Oliver", Species = "Cat", Breed = "Maine Coon", Age = 4, Description = "Large and fluffy companion.", Available = true },
          new Animal { AnimalId = 12, Name = "Rusty", Species = "Dog", Breed = "Dachshund", Age = 5, Description = "Curious and energetic sausage.", Available = true },
          new Animal { AnimalId = 13, Name = "Peanut", Species = "Hamster", Breed = "Chinese", Age = 1, Description = "Small and shy rodent.", Available = true },
          new Animal { AnimalId = 14, Name = "Luna", Species = "Bunny", Breed = "Flemish Giant", Age = 2, Description = "Gentle giant with big ears.", Available = true },
          new Animal { AnimalId = 15, Name = "Spike", Species = "Lizard", Breed = "Crested Gecko", Age = 3, Description = "Crested and colorful reptile.", Available = true },
          new Animal { AnimalId = 16, Name = "Misty", Species = "Cat", Breed = "Ragdoll", Age = 2, Description = "Relaxed and affectionate beauty.", Available = true },
          new Animal { AnimalId = 17, Name = "Charlie", Species = "Dog", Breed = "Poodle", Age = 4, Description = "Intelligent and curly-haired friend.", Available = true },
          new Animal { AnimalId = 18, Name = "Pippin", Species = "Hamster", Breed = "Dwarf Campbell", Age = 1, Description = "Small and active pocket pet.", Available = true },
          new Animal { AnimalId = 19, Name = "Basil", Species = "Bunny", Breed = "Mini Rex", Age = 1, Description = "Soft and velvety hopper.", Available = true },
          new Animal { AnimalId = 20, Name = "Rango", Species = "Lizard", Breed = "Green Iguana", Age = 6, Description = "Large and leafy-looking reptile.", Available = true }
          );

    }
  }
}