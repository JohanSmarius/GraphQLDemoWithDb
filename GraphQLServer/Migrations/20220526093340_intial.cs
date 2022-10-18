using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraphQLServer.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    EMailAddress = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    EANCode = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Weight = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    OrderStatus = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orderlines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    DiscountPercentage = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orderlines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orderlines_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orderlines_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "EMailAddress", "Name" },
                values: new object[] { 1, null, "Customer 1" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "EMailAddress", "Name" },
                values: new object[] { 2, null, "Customer 2" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "EANCode", "Name", "Price", "Weight" },
                values: new object[] { 1, "123439900", "Product 1", 100m, 300m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "EANCode", "Name", "Price", "Weight" },
                values: new object[] { 2, "37034034039", "Product 2", 200m, 700m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "OrderStatus", "OrderTime" },
                values: new object[] { 1, 1, 0, new DateTime(2022, 5, 26, 11, 33, 40, 82, DateTimeKind.Local).AddTicks(8150) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "OrderStatus", "OrderTime" },
                values: new object[] { 2, 2, 0, new DateTime(2022, 5, 26, 11, 33, 40, 82, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.InsertData(
                table: "Orderlines",
                columns: new[] { "Id", "DiscountPercentage", "OrderId", "ProductId", "Quantity" },
                values: new object[] { 1, 5m, 1, 2, 5 });

            migrationBuilder.InsertData(
                table: "Orderlines",
                columns: new[] { "Id", "DiscountPercentage", "OrderId", "ProductId", "Quantity" },
                values: new object[] { 2, 0m, 1, 1, 2 });

            migrationBuilder.InsertData(
                table: "Orderlines",
                columns: new[] { "Id", "DiscountPercentage", "OrderId", "ProductId", "Quantity" },
                values: new object[] { 3, 0m, 2, 1, 7 });

            migrationBuilder.InsertData(
                table: "Orderlines",
                columns: new[] { "Id", "DiscountPercentage", "OrderId", "ProductId", "Quantity" },
                values: new object[] { 4, 20.0m, 2, 2, 10 });

            migrationBuilder.CreateIndex(
                name: "IX_Orderlines_OrderId",
                table: "Orderlines",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orderlines_ProductId",
                table: "Orderlines",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orderlines");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
