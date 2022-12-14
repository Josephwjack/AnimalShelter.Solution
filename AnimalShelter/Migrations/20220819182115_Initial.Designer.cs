// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    [Migration("20220819182115_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300) CHARACTER SET utf8mb4");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 9,
                            Breed = "Pitty / Black lab mix",
                            Description = "Loves to be a landshark.",
                            Gender = "Female",
                            Name = "Rutabega",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 8,
                            Breed = "Australian Mini Shepherd",
                            Description = "Would love an older dog for a brother.",
                            Gender = "Male",
                            Name = "Jinx",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 7,
                            Breed = "Korat",
                            Description = "Beautiful soft green eyes. Korats are believed to be good luck.",
                            Gender = "Male",
                            Name = "Thai",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 4,
                            Breed = "Bearded Dragon",
                            Description = "Loves silk worms and nuzzling in long hair or in sweatshirt hoods.",
                            Gender = "Male",
                            Name = "Toothless",
                            Species = "Reptile"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 30,
                            Breed = "Cockatoo",
                            Description = "Put on 'Lets go crazy' and be amazed. He'll dance to that song all day.",
                            Gender = "Male",
                            Name = "Prince",
                            Species = "Bird"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 99,
                            Breed = "Oak?",
                            Description = "He is Groot",
                            Gender = "N/A",
                            Name = "Groot",
                            Species = "Tree?"
                        },
                        new
                        {
                            AnimalId = 7,
                            Age = 9,
                            Breed = "Maine Coon",
                            Description = "Sweet, fluffy and loves outdoors. Longhair that needs to be brushed to avoid dreads.",
                            Gender = "Female",
                            Name = "Luna",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 8,
                            Age = 4,
                            Breed = "Golden Retriever",
                            Description = "Loves swimming and being on boats.",
                            Gender = "Female",
                            Name = "Penelope",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 9,
                            Age = 7,
                            Breed = "Bambino",
                            Description = "Affectionate, friendly with kids and other pets, and very vocal.",
                            Gender = "Male",
                            Name = "Rev",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 10,
                            Age = 11,
                            Breed = "Axolotl",
                            Description = "Endangered species, new owner must have extensive knowledge of axolotls and pass multiple screenings.",
                            Gender = "Female",
                            Name = "Mudkip",
                            Species = "Amphibian"
                        },
                        new
                        {
                            AnimalId = 11,
                            Age = 2,
                            Breed = "French bulldog",
                            Description = "Chews on fingers, shoes, literally everything.",
                            Gender = "Male",
                            Name = "Gatsby",
                            Species = "Dog"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
