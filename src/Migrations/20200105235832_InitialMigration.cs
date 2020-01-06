using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace pieshop.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Pies",
                columns: table => new
                {
                    PieId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    AllergyInformation = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageThumbnailUrl = table.Column<string>(nullable: true),
                    InStock = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    IsPieOfTheWeek = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pies", x => x.PieId);
                    table.ForeignKey(
                        name: "FK_Pies_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    { 1, "", 1, "", "/images/brain.jpg", true, false, "", "Brain Pie", 15.95m, "Made with false morel (Gyromitra esculenta)" },
                    { 2, "", 1, "", "/images/bleeding-tooth.jpg", true, true, "", "Bleeding Tooth Pie", 16.00m, "Made with Hydnellum pecki" },
                    { 3, "", 1, "", "/images/glow.jpg", true, true, "", "Glow Pie", 12.50m, "Made with bioluminiscent mushrooms" },
                    { 4, "", 2, "", "/images/pepino.jpg", true, false, "", "Pepino Pie", 16.75m, "Made with Pepino Fruit from South America" },
                    { 5, "", 2, "", "/images/kumquat.jpg", true, true, "", "Kumquat Pie", 14.25m, "Made with Kumquat Fruit from China" },
                    { 6, "", 2, "", "/images/kiwano.jpg", true, false, "", "Kiwano Pie", 15.75m, "Made with Kiwano Fruit from South Africa" },
                    { 7, "", 3, "", "/images/bean.jpg", true, true, "", "Navy Bean Pie", 13.99m, "With butter, chocolate, and vanilla" },
                    { 8, "", 3, "", "/images/red-bean.jpg", true, false, "", "Sweet Red Bean Pie", 14.50m, "Made with read beans" },
                    { 9, "", 3, "", "/images/edamame.jpg", true, false, "", "Edamame Pie", 16.25m, "Made with edamame beans, mozarella, and zucchini" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pies_CategoryId",
                table: "Pies",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pies");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
