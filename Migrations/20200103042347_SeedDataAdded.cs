using Microsoft.EntityFrameworkCore.Migrations;

namespace pieshop.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Fungus Pies", "All fungus-based pies" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Fruit Pies", "All pies made from alien fruits" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Bean Pies", "Pies with bean fillings" });

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPieOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "", 1, "", "/images/brain.jpg", true, true, "", "Brain Pie", 15.95m, "Made with false morel (Gyromitra esculenta)" },
                    { 2, "", 1, "", "/images/bleeding-tooth.jpg", true, true, "", "Bleeding Tooth Pie", 16.00m, "Made with Hydnellum pecki" },
                    { 3, "", 1, "", "/images/glow.jpg", true, true, "", "Glow Pie", 12.50m, "Made with bioluminiscent mushrooms" },
                    { 4, "", 2, "", "/images/pepino.jpg", true, true, "", "Pepino Pie", 16.75m, "Made with Pepino Fruit from South America" },
                    { 5, "", 2, "", "/images/kumquat.jpg", true, true, "", "Kumquat Pie", 14.25m, "Made with Kumquat Fruit from China" },
                    { 6, "", 2, "", "/images/kiwano.jpg", true, true, "", "Kiwano Pie", 15.75m, "Made with Kiwano Fruit from South Africa" },
                    { 7, "", 3, "", "/images/bean.jpg", true, true, "", "Navy Bean Pie", 13.99m, "With butter, chocolate, and vanilla" },
                    { 8, "", 3, "", "/images/red-bean.jpg", true, true, "", "Sweet Red Bean Pie", 14.50m, "Made with read beans" },
                    { 9, "", 3, "", "/images/edamame.jpg", true, true, "", "Edamame Pie", 16.25m, "Made with edamame beans, mozarella, and zucchini" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
