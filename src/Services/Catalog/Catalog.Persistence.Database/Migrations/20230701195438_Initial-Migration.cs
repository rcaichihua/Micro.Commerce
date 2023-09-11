using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Catalog.Persistence.Database.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 661m },
                    { 2, "Description for product 2", "Product 2", 109m },
                    { 3, "Description for product 3", "Product 3", 676m },
                    { 4, "Description for product 4", "Product 4", 694m },
                    { 5, "Description for product 5", "Product 5", 820m },
                    { 6, "Description for product 6", "Product 6", 222m },
                    { 7, "Description for product 7", "Product 7", 272m },
                    { 8, "Description for product 8", "Product 8", 117m },
                    { 9, "Description for product 9", "Product 9", 476m },
                    { 10, "Description for product 10", "Product 10", 568m },
                    { 11, "Description for product 11", "Product 11", 626m },
                    { 12, "Description for product 12", "Product 12", 627m },
                    { 13, "Description for product 13", "Product 13", 258m },
                    { 14, "Description for product 14", "Product 14", 162m },
                    { 15, "Description for product 15", "Product 15", 261m },
                    { 16, "Description for product 16", "Product 16", 723m },
                    { 17, "Description for product 17", "Product 17", 895m },
                    { 18, "Description for product 18", "Product 18", 830m },
                    { 19, "Description for product 19", "Product 19", 661m },
                    { 20, "Description for product 20", "Product 20", 432m },
                    { 21, "Description for product 21", "Product 21", 781m },
                    { 22, "Description for product 22", "Product 22", 601m },
                    { 23, "Description for product 23", "Product 23", 887m },
                    { 24, "Description for product 24", "Product 24", 756m },
                    { 25, "Description for product 25", "Product 25", 474m },
                    { 26, "Description for product 26", "Product 26", 994m },
                    { 27, "Description for product 27", "Product 27", 251m },
                    { 28, "Description for product 28", "Product 28", 509m },
                    { 29, "Description for product 29", "Product 29", 290m },
                    { 30, "Description for product 30", "Product 30", 373m },
                    { 31, "Description for product 31", "Product 31", 198m },
                    { 32, "Description for product 32", "Product 32", 464m },
                    { 33, "Description for product 33", "Product 33", 408m },
                    { 34, "Description for product 34", "Product 34", 146m },
                    { 35, "Description for product 35", "Product 35", 859m },
                    { 36, "Description for product 36", "Product 36", 370m },
                    { 37, "Description for product 37", "Product 37", 217m },
                    { 38, "Description for product 38", "Product 38", 328m },
                    { 39, "Description for product 39", "Product 39", 499m },
                    { 40, "Description for product 40", "Product 40", 312m },
                    { 41, "Description for product 41", "Product 41", 656m },
                    { 42, "Description for product 42", "Product 42", 992m },
                    { 43, "Description for product 43", "Product 43", 372m },
                    { 44, "Description for product 44", "Product 44", 679m },
                    { 45, "Description for product 45", "Product 45", 752m },
                    { 46, "Description for product 46", "Product 46", 454m },
                    { 47, "Description for product 47", "Product 47", 823m },
                    { 48, "Description for product 48", "Product 48", 174m },
                    { 49, "Description for product 49", "Product 49", 854m },
                    { 50, "Description for product 50", "Product 50", 744m },
                    { 51, "Description for product 51", "Product 51", 924m },
                    { 52, "Description for product 52", "Product 52", 860m },
                    { 53, "Description for product 53", "Product 53", 985m },
                    { 54, "Description for product 54", "Product 54", 116m },
                    { 55, "Description for product 55", "Product 55", 564m },
                    { 56, "Description for product 56", "Product 56", 514m },
                    { 57, "Description for product 57", "Product 57", 952m },
                    { 58, "Description for product 58", "Product 58", 717m },
                    { 59, "Description for product 59", "Product 59", 221m },
                    { 60, "Description for product 60", "Product 60", 682m },
                    { 61, "Description for product 61", "Product 61", 592m },
                    { 62, "Description for product 62", "Product 62", 286m },
                    { 63, "Description for product 63", "Product 63", 750m },
                    { 64, "Description for product 64", "Product 64", 657m },
                    { 65, "Description for product 65", "Product 65", 186m },
                    { 66, "Description for product 66", "Product 66", 766m },
                    { 67, "Description for product 67", "Product 67", 704m },
                    { 68, "Description for product 68", "Product 68", 519m },
                    { 69, "Description for product 69", "Product 69", 511m },
                    { 70, "Description for product 70", "Product 70", 207m },
                    { 71, "Description for product 71", "Product 71", 325m },
                    { 72, "Description for product 72", "Product 72", 144m },
                    { 73, "Description for product 73", "Product 73", 867m },
                    { 74, "Description for product 74", "Product 74", 833m },
                    { 75, "Description for product 75", "Product 75", 265m },
                    { 76, "Description for product 76", "Product 76", 539m },
                    { 77, "Description for product 77", "Product 77", 715m },
                    { 78, "Description for product 78", "Product 78", 659m },
                    { 79, "Description for product 79", "Product 79", 646m },
                    { 80, "Description for product 80", "Product 80", 421m },
                    { 81, "Description for product 81", "Product 81", 192m },
                    { 82, "Description for product 82", "Product 82", 768m },
                    { 83, "Description for product 83", "Product 83", 296m },
                    { 84, "Description for product 84", "Product 84", 561m },
                    { 85, "Description for product 85", "Product 85", 273m },
                    { 86, "Description for product 86", "Product 86", 815m },
                    { 87, "Description for product 87", "Product 87", 648m },
                    { 88, "Description for product 88", "Product 88", 437m },
                    { 89, "Description for product 89", "Product 89", 296m },
                    { 90, "Description for product 90", "Product 90", 228m },
                    { 91, "Description for product 91", "Product 91", 642m },
                    { 92, "Description for product 92", "Product 92", 775m },
                    { 93, "Description for product 93", "Product 93", 916m },
                    { 94, "Description for product 94", "Product 94", 610m },
                    { 95, "Description for product 95", "Product 95", 746m },
                    { 96, "Description for product 96", "Product 96", 445m },
                    { 97, "Description for product 97", "Product 97", 962m },
                    { 98, "Description for product 98", "Product 98", 838m },
                    { 99, "Description for product 99", "Product 99", 384m },
                    { 100, "Description for product 100", "Product 100", 577m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 12 },
                    { 2, 2, 0 },
                    { 3, 3, 11 },
                    { 4, 4, 15 },
                    { 5, 5, 11 },
                    { 6, 6, 19 },
                    { 7, 7, 1 },
                    { 8, 8, 9 },
                    { 9, 9, 17 },
                    { 10, 10, 6 },
                    { 11, 11, 6 },
                    { 12, 12, 10 },
                    { 13, 13, 2 },
                    { 14, 14, 1 },
                    { 15, 15, 6 },
                    { 16, 16, 14 },
                    { 17, 17, 10 },
                    { 18, 18, 18 },
                    { 19, 19, 4 },
                    { 20, 20, 8 },
                    { 21, 21, 10 },
                    { 22, 22, 0 },
                    { 23, 23, 4 },
                    { 24, 24, 8 },
                    { 25, 25, 14 },
                    { 26, 26, 9 },
                    { 27, 27, 9 },
                    { 28, 28, 12 },
                    { 29, 29, 16 },
                    { 30, 30, 17 },
                    { 31, 31, 19 },
                    { 32, 32, 0 },
                    { 33, 33, 0 },
                    { 34, 34, 4 },
                    { 35, 35, 19 },
                    { 36, 36, 4 },
                    { 37, 37, 9 },
                    { 38, 38, 15 },
                    { 39, 39, 0 },
                    { 40, 40, 18 },
                    { 41, 41, 5 },
                    { 42, 42, 6 },
                    { 43, 43, 4 },
                    { 44, 44, 1 },
                    { 45, 45, 15 },
                    { 46, 46, 19 },
                    { 47, 47, 8 },
                    { 48, 48, 8 },
                    { 49, 49, 10 },
                    { 50, 50, 0 },
                    { 51, 51, 3 },
                    { 52, 52, 2 },
                    { 53, 53, 7 },
                    { 54, 54, 3 },
                    { 55, 55, 17 },
                    { 56, 56, 15 },
                    { 57, 57, 15 },
                    { 58, 58, 13 },
                    { 59, 59, 17 },
                    { 60, 60, 18 },
                    { 61, 61, 9 },
                    { 62, 62, 8 },
                    { 63, 63, 1 },
                    { 64, 64, 7 },
                    { 65, 65, 13 },
                    { 66, 66, 2 },
                    { 67, 67, 10 },
                    { 68, 68, 15 },
                    { 69, 69, 12 },
                    { 70, 70, 5 },
                    { 71, 71, 5 },
                    { 72, 72, 15 },
                    { 73, 73, 18 },
                    { 74, 74, 4 },
                    { 75, 75, 5 },
                    { 76, 76, 1 },
                    { 77, 77, 14 },
                    { 78, 78, 9 },
                    { 79, 79, 12 },
                    { 80, 80, 16 },
                    { 81, 81, 13 },
                    { 82, 82, 10 },
                    { 83, 83, 6 },
                    { 84, 84, 12 },
                    { 85, 85, 0 },
                    { 86, 86, 7 },
                    { 87, 87, 8 },
                    { 88, 88, 19 },
                    { 89, 89, 14 },
                    { 90, 90, 10 },
                    { 91, 91, 2 },
                    { 92, 92, 17 },
                    { 93, 93, 9 },
                    { 94, 94, 9 },
                    { 95, 95, 8 },
                    { 96, 96, 16 },
                    { 97, 97, 15 },
                    { 98, 98, 0 },
                    { 99, 99, 0 },
                    { 100, 100, 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                schema: "Catalog",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
