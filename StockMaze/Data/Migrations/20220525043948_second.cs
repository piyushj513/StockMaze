using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockMaze.Data.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    customerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.customerId);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    transactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransactionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionInvoiceRef = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InventoryInUnit = table.Column<int>(type: "int", nullable: false),
                    InventoryOutUnit = table.Column<int>(type: "int", nullable: false),
                    InventoryBalUnit = table.Column<int>(type: "int", nullable: false),
                    ProductCostPricePU = table.Column<double>(type: "float", nullable: false),
                    ProductSellingPricePU = table.Column<double>(type: "float", nullable: false),
                    InvBalCostPriceTotal = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.transactionId);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    vendorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vendorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vendorAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vendorPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vendorEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.vendorId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "Vendor");
        }
    }
}
