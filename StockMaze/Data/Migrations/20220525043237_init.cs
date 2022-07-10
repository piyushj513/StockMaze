using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockMaze.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    productId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    productDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vendorId = table.Column<int>(type: "int", nullable: false),
                    vendorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    productCost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    productMargin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    productSellingPrice = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.productId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
