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
            new Animal { AnimalId = 1, Name = "Rutabega", Gender = "Female", Species = "Dog", Breed = "Pitty / Black lab mix", Age = 9, Description = "Loves to be a landshark."},
            new Animal { AnimalId = 2, Name = "Jinx", Gender = "Male", Species = "Dog", Breed = "Australian Mini Shepherd", Age = 8, Description = "Would love an older dog for a brother."},
            new Animal { AnimalId = 3, Name = "Thai", Gender = "Male", Species = "Cat", Breed = "Korat", Age = 7, Description = "Beautiful soft green eyes. Korats are believed to be good luck." },
            new Animal { AnimalId = 4, Name = "Toothless", Gender = "Male", Species = "Reptile", Breed = "Bearded Dragon", Age = 4, Description = "Loves silk worms and nuzzling in long hair or in sweatshirt hoods."},
            new Animal { AnimalId = 5, Name = "Prince", Gender = "Male", Species = "Bird", Breed = "Cockatoo", Age = 30, Description = "Put on 'Lets go crazy' and be amazed. He'll dance to that song all day."},
            new Animal { AnimalId = 6, Name = "Groot", Gender = "N/A", Species = "Tree?", Breed = "Oak?", Age = 99, Description = "He is Groot" },
            new Animal { AnimalId = 7, Name = "Luna", Gender = "Female", Species = "Cat", Breed = "Maine Coon", Age = 9, Description = "Sweet, fluffy and loves outdoors. Longhair that needs to be brushed to avoid dreads."},
            new Animal { AnimalId = 8, Name = "Penelope", Gender = "Female", Species = "Dog", Breed = "Golden Retriever", Age = 4, Description = "Loves swimming and being on boats."},
            new Animal { AnimalId = 9, Name = "Rev", Gender = "Male", Species = "Cat", Breed = "Bambino", Age = 7, Description = "Affectionate, friendly with kids and other pets, and very vocal." },
            new Animal { AnimalId = 10, Name = "Mudkip", Gender = "Female", Species = "Amphibian", Breed = "Axolotl", Age = 11, Description = "Endangered species, new owner must have extensive knowledge of axolotls and pass multiple screenings."},
            new Animal { AnimalId = 11, Name = "Gatsby", Gender = "Male", Species = "Dog", Breed = "French bulldog", Age = 2, Description = "Chews on fingers, shoes, literally everything." }
          );

          
        }
    }
}