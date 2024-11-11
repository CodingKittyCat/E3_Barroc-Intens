using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E3_BarrocIntens.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomerName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InvoiceDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TotalAmount = table.Column<float>(type: "float", nullable: false),
                    IsPayed = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDelivered = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Username = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LeaseContracts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type_Of_Time = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Time_Per_Period = table.Column<int>(type: "int", nullable: false),
                    Amount_Of_Periods = table.Column<int>(type: "int", nullable: false),
                    Total_Price = table.Column<double>(type: "double", nullable: false),
                    Price_Per_Period = table.Column<double>(type: "double", nullable: false),
                    Date_Created = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    End_Date = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Payment_Status = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bkr_Check = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaseContracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaseContracts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeaseContracts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CustomerName", "DueDate", "InvoiceDate", "IsPayed", "TotalAmount" },
                values: new object[,]
                {
                    { 1, "John Doe", new DateTime(2024, 11, 1, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1399), new DateTime(2024, 10, 12, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1313), true, 1200.5f },
                    { 2, "Jane Smith", new DateTime(2024, 11, 26, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1428), new DateTime(2024, 10, 27, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1426), false, 800.75f },
                    { 3, "Acme Corp", new DateTime(2024, 11, 6, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1443), new DateTime(2024, 9, 27, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1441), true, 2500f },
                    { 4, "Global Industries", new DateTime(2024, 11, 21, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1453), new DateTime(2024, 10, 22, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1451), false, 1500.3f },
                    { 5, "Tech Solutions", new DateTime(2024, 12, 1, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1458), new DateTime(2024, 11, 1, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1456), false, 950.6f }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Amount", "Description", "IsDelivered", "Name", "Status" },
                values: new object[,]
                {
                    { 1, 1, "Delivery to Cafe Aroma", false, "La Marzocco Linea Mini", 0 },
                    { 2, 3, "Delivery of 3 units to Office Central", false, "Breville Barista Pro", 0 },
                    { 3, 1, "Delivery to Small Bean Coffee Shop", false, "Keurig K-Elite Brewer", 0 },
                    { 4, 2, "Two units for University Campus Cafe", false, "De'Longhi La Specialista", 0 },
                    { 5, 10, "Bulk order of 10 units for Hotel Deluxe", false, "Jura E8 Automatic Coffee Machine", 0 },
                    { 6, 1, "Shipped to Coffee House", false, "La Marzocco GS3", 1 },
                    { 7, 1, "Shipped to Gourmet Coffee Roasters", false, "Gaggia Classic Pro", 1 },
                    { 8, 1, "Shipped to Riverside Cafe", false, "Nespresso VertuoPlus Deluxe", 1 },
                    { 9, 2, "Shipped to Downtown Coffee Hub", false, "Philips 3200 Series", 1 },
                    { 10, 4, "Shipped to Green Leaf Hotel", false, "Miele CM5310 Silence", 1 },
                    { 11, 2, "Delivered to The Daily Grind", true, "Breville Bambino Plus", 2 },
                    { 12, 1, "Delivered to Tech Corp Office", true, "Saeco Xelsis", 2 },
                    { 13, 3, "Delivered to The Roastery", true, "Rancilio Silvia", 2 },
                    { 14, 2, "Delivered to Cozy Corner Cafe", true, "De'Longhi Dinamica Plus", 2 },
                    { 15, 1, "Delivered to Bella's Bistro", true, "Rocket Appartamento", 2 },
                    { 16, 1, "Order canceled for The Brew House", false, "Ascaso Dream PID", 3 },
                    { 17, 1, "Order canceled for Java Junction", false, "Nuova Simonelli Oscar II", 3 },
                    { 18, 2, "Order canceled for Bites & Brews", false, "Smeg ECF01", 3 },
                    { 19, 1, "Order canceled for Sunset Cafe", false, "Breville Oracle Touch", 3 },
                    { 20, 1, "Order canceled for The Coffee Spot", false, "De'Longhi Magnifica S", 3 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Status", "Stock", "Title" },
                values: new object[,]
                {
                    { 1, "Description 1", "Delivered", 10, "Product 1" },
                    { 2, "Description 2", "On The Way", 20, "Product 2" },
                    { 3, "Description 3", "Pending", 30, "Product 3" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { 1, "Maintenance" },
                    { 2, "Finance" },
                    { 3, "Sales" },
                    { 4, "Customer" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "Password", "RoleId", "Username" },
                values: new object[,]
                {
                    { 1, "Customer User", "$2a$11$N2yBIyO9xot.sR6GzuSpwulvYANUGZdd.IIxY4.mzNUwVsItgYUpe", 4, "customer" },
                    { 2, "Finance User", "$2a$11$7BkYyT9zTpNQLKAXBpVQcuytFqksMdjEYYjUF7ouPHxnXFRp5edL2", 2, "finance" },
                    { 3, "Sales User", "$2a$11$De8nOWc9d/m/gTt6Js03Juz.BlzhYdqeIwm5YLoM7k4Tkvhi7.Ox2", 3, "sales" },
                    { 4, "Maintenance User", "$2a$11$p3BpXjddK/oIErrOsCQc3OXZHuve5pll9uwmLe5.f9lTVJ3Va6DF6", 1, "maintenance" }
                });

            migrationBuilder.InsertData(
                table: "LeaseContracts",
                columns: new[] { "Id", "Amount_Of_Periods", "Bkr_Check", "Date_Created", "End_Date", "Payment_Status", "Price_Per_Period", "ProductId", "Time_Per_Period", "Total_Price", "Type_Of_Time", "UserId" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2024, 11, 11, 14, 47, 49, 456, DateTimeKind.Local).AddTicks(6495), new DateTime(2024, 11, 11, 14, 47, 49, 456, DateTimeKind.Local).AddTicks(6495), "Unpaid", 100.0, 1, 1, 1000.0, "Monthly", 1 },
                    { 2, 1, false, new DateTime(2024, 11, 11, 14, 47, 49, 456, DateTimeKind.Local).AddTicks(6595), new DateTime(2024, 11, 11, 14, 47, 49, 456, DateTimeKind.Local).AddTicks(6595), "Unpaid", 200.0, 1, 1, 2000.0, "Monthly", 2 },
                    { 3, 1, false, new DateTime(2024, 11, 11, 14, 47, 49, 456, DateTimeKind.Local).AddTicks(6601), new DateTime(2024, 11, 11, 14, 47, 49, 456, DateTimeKind.Local).AddTicks(6601), "Unpaid", 300.0, 1, 1, 3000.0, "Monthly", 3 },
                    { 4, 1, false, new DateTime(2024, 11, 11, 14, 47, 49, 456, DateTimeKind.Local).AddTicks(6606), new DateTime(2024, 11, 11, 14, 47, 49, 456, DateTimeKind.Local).AddTicks(6606), "Unpaid", 400.0, 1, 1, 4000.0, "Monthly", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LeaseContracts_ProductId",
                table: "LeaseContracts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaseContracts_UserId",
                table: "LeaseContracts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "LeaseContracts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
