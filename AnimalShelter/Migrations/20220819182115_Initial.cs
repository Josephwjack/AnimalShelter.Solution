using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(30) CHARACTER SET utf8mb4", maxLength: 30, nullable: false),
                    Gender = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Species = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Breed = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "varchar(300) CHARACTER SET utf8mb4", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "Description", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 9, "Pitty / Black lab mix", "Loves to be a landshark.", "Female", "Rutabega", "Dog" },
                    { 2, 8, "Australian Mini Shepherd", "Would love an older dog for a brother.", "Male", "Jinx", "Dog" },
                    { 3, 7, "Korat", "Beautiful soft green eyes. Korats are believed to be good luck.", "Male", "Thai", "Cat" },
                    { 4, 4, "Bearded Dragon", "Loves silk worms and nuzzling in long hair or in sweatshirt hoods.", "Male", "Toothless", "Reptile" },
                    { 5, 30, "Cockatoo", "Put on 'Lets go crazy' and be amazed. He'll dance to that song all day.", "Male", "Prince", "Bird" },
                    { 6, 99, "Oak?", "He is Groot", "N/A", "Groot", "Tree?" },
                    { 7, 9, "Maine Coon", "Sweet, fluffy and loves outdoors. Longhair that needs to be brushed to avoid dreads.", "Female", "Luna", "Cat" },
                    { 8, 4, "Golden Retriever", "Loves swimming and being on boats.", "Female", "Penelope", "Dog" },
                    { 9, 7, "Bambino", "Affectionate, friendly with kids and other pets, and very vocal.", "Male", "Rev", "Cat" },
                    { 10, 11, "Axolotl", "Endangered species, new owner must have extensive knowledge of axolotls and pass multiple screenings.", "Female", "Mudkip", "Amphibian" },
                    { 11, 2, "French bulldog", "Chews on fingers, shoes, literally everything.", "Male", "Gatsby", "Dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
