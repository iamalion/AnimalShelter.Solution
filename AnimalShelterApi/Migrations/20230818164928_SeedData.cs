using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelterApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Available", "Breed", "Description", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 2, true, "Persian", "Elegant and regal.", "Fluffy", "Cat" },
                    { 2, 3, true, "Golden Retriever", "Friendly and loyal companion.", "Buddy", "Dog" },
                    { 3, 1, true, "Syrian", "Tiny and energetic ball.", "Nibbles", "Hamster" },
                    { 4, 2, true, "Dwarf Hotot", "Fluffy and adorable hopper.", "Cotton", "Bunny" },
                    { 5, 4, true, "Bearded Dragon", "Colorful and intriguing reptile.", "Spike", "Lizard" },
                    { 6, 1, true, "Siamese", "Playful and vocal feline.", "Mittens", "Cat" },
                    { 7, 2, true, "Bulldog", "Stubborn but affectionate.", "Rocky", "Dog" },
                    { 8, 1, true, "Roborovski", "Quick and curious explorer.", "Whiskers", "Hamster" },
                    { 9, 3, true, "Holland Lop", "Sweet and gentle muncher.", "Cocoa", "Bunny" },
                    { 10, 2, true, "Leopard Gecko", "Nocturnal and patterned Lizard.", "Ziggy", "Lizard" },
                    { 11, 4, true, "Maine Coon", "Large and fluffy companion.", "Oliver", "Cat" },
                    { 12, 5, true, "Dachshund", "Curious and energetic sausage.", "Rusty", "Dog" },
                    { 13, 1, true, "Chinese", "Small and shy rodent.", "Peanut", "Hamster" },
                    { 14, 2, true, "Flemish Giant", "Gentle giant with big ears.", "Luna", "Bunny" },
                    { 15, 3, true, "Crested Gecko", "Crested and colorful reptile.", "Spike", "Lizard" },
                    { 16, 2, true, "Ragdoll", "Relaxed and affectionate beauty.", "Misty", "Cat" },
                    { 17, 4, true, "Poodle", "Intelligent and curly-haired friend.", "Charlie", "Dog" },
                    { 18, 1, true, "Dwarf Campbell", "Small and active pocket pet.", "Pippin", "Hamster" },
                    { 19, 1, true, "Mini Rex", "Soft and velvety hopper.", "Basil", "Bunny" },
                    { 20, 6, true, "Green Iguana", "Large and leafy-looking reptile.", "Rango", "Lizard" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 20);
        }
    }
}
