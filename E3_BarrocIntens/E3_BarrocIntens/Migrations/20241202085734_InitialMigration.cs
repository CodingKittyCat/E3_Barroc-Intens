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
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
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
                name: "WorkReceipts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkReceipts", x => x.Id);
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
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Username = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    IsFirstLogin = table.Column<bool>(type: "tinyint(1)", nullable: false)
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
                name: "ReceiptMaterials",
                columns: table => new
                {
                    ReceiptId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptMaterials", x => new { x.ReceiptId, x.MaterialId });
                    table.ForeignKey(
                        name: "FK_ReceiptMaterials_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceiptMaterials_WorkReceipts_ReceiptId",
                        column: x => x.ReceiptId,
                        principalTable: "WorkReceipts",
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

            migrationBuilder.CreateTable(
                name: "maintenanceRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RequestedDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PlannedDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    WorkReceiptId = table.Column<int>(type: "int", nullable: true),
                    IsClosed = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_maintenanceRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_maintenanceRequests_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_maintenanceRequests_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_maintenanceRequests_WorkReceipts_WorkReceiptId",
                        column: x => x.WorkReceiptId,
                        principalTable: "WorkReceipts",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    QuoteDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Status = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quotes_Users_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Note = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserNotes_Users_UserId",
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
                    { 1, "John Doe", new DateTime(2024, 11, 22, 9, 57, 33, 19, DateTimeKind.Local).AddTicks(4062), new DateTime(2024, 11, 2, 9, 57, 33, 19, DateTimeKind.Local).AddTicks(3972), true, 1200.5f },
                    { 2, "Jane Smith", new DateTime(2024, 12, 17, 9, 57, 33, 19, DateTimeKind.Local).AddTicks(4071), new DateTime(2024, 11, 17, 9, 57, 33, 19, DateTimeKind.Local).AddTicks(4069), false, 800.75f },
                    { 3, "Acme Corp", new DateTime(2024, 11, 27, 9, 57, 33, 19, DateTimeKind.Local).AddTicks(4105), new DateTime(2024, 10, 18, 9, 57, 33, 19, DateTimeKind.Local).AddTicks(4073), true, 2500f },
                    { 4, "Global Industries", new DateTime(2024, 12, 12, 9, 57, 33, 19, DateTimeKind.Local).AddTicks(4111), new DateTime(2024, 11, 12, 9, 57, 33, 19, DateTimeKind.Local).AddTicks(4109), false, 1500.3f },
                    { 5, "Tech Solutions", new DateTime(2024, 12, 22, 9, 57, 33, 19, DateTimeKind.Local).AddTicks(4119), new DateTime(2024, 11, 22, 9, 57, 33, 19, DateTimeKind.Local).AddTicks(4114), false, 950.6f }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "This plank is made from wood, I promise, no deceptions here.", "Wooden Plank 50cm" },
                    { 2, "This plank is made from wood, I promise, deceptions here.", "Wooden Plink 75cm" },
                    { 3, "This plank is made from iron, I swear, no deceptions here.", "Wooden Plonk 25cm" },
                    { 4, "This 20cm is made from wood, I promise, deceptions here.", "Wooden Plunk 20cm" }
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
                table: "WorkReceipts",
                columns: new[] { "Id", "Description" },
                values: new object[] { 1, "This is most definitely a work receipt" });

            migrationBuilder.InsertData(
                table: "ReceiptMaterials",
                columns: new[] { "MaterialId", "ReceiptId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 3 },
                    { 2, 1, 3 },
                    { 3, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsFirstLogin", "Name", "Password", "RoleId", "Username" },
                values: new object[,]
                {
                    { 1, "D295372@edu.curio.nl", true, "Customer User1", "$2a$11$sMTbExgH5YD40vwviXPeLOiFXj2VFVylJm1OiGZDKvJKVpW9cMBKu", 4, "customer1" },
                    { 2, "customer2@example.com", true, "Customer User2", "$2a$11$H0hjOb6n8aUi45ozHqGPvuJiATyEReNWs8m0oneL0O6O5.IxZGZV2", 4, "customer2" },
                    { 3, "customer3@example.com", true, "Customer User3", "$2a$11$8x0od4zuD4zR4p0k4E5DrOOfEHd5yGjevclNcYpKApk78hv1ARKce", 4, "customer3" },
                    { 4, "finance@example.com", true, "Finance User", "$2a$11$lsNTjfn8nVXG6KHH7.t8out0m/omAOVG13wItzqXOS7lTl5BPJO72", 2, "finance" },
                    { 5, "sales@example.com", true, "Sales User", "$2a$11$iDzgHtQWtwIH5crgUH6Ke.QxwmTXwMRb2BHZ1w6azkX3emHERx8aS", 3, "sales" },
                    { 6, "maintenance@example.com", true, "Maintenance User", "$2a$11$aqXYI6NUf4NlCJMis7zj0.YsMZK3JbKO98BhCp4dQZzN/DoYZbpAe", 1, "maintenance" },
                    { 7, "georgecassel@example.com", true, "George Cassel", "$2a$11$.kDVy/qoTIDFXkt9sXsllONq0zuxdrhiXhbsDAYqn/FPF/gqgUhpO", 1, "georgecassel" },
                    { 8, "stanbaker@example.com", true, "Stan Baker", "$2a$11$wHqigdc/2rHereo1YFi/bOGdwrR7g7UwkEbLu4B0plSZ17l7WM3JS", 1, "stanbaker" }
                });

            migrationBuilder.InsertData(
                table: "LeaseContracts",
                columns: new[] { "Id", "Amount_Of_Periods", "Bkr_Check", "Date_Created", "End_Date", "Payment_Status", "Price_Per_Period", "ProductId", "Time_Per_Period", "Total_Price", "Type_Of_Time", "UserId" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2024, 12, 2, 9, 57, 34, 50, DateTimeKind.Local).AddTicks(1941), new DateTime(2024, 12, 2, 9, 57, 34, 50, DateTimeKind.Local).AddTicks(1941), "Unpaid", 100.0, 1, 1, 1000.0, "Monthly", 1 },
                    { 2, 1, false, new DateTime(2024, 12, 2, 9, 57, 34, 50, DateTimeKind.Local).AddTicks(2034), new DateTime(2024, 12, 2, 9, 57, 34, 50, DateTimeKind.Local).AddTicks(2034), "Unpaid", 200.0, 1, 1, 2000.0, "Monthly", 2 },
                    { 3, 1, false, new DateTime(2024, 12, 2, 9, 57, 34, 50, DateTimeKind.Local).AddTicks(2165), new DateTime(2024, 12, 2, 9, 57, 34, 50, DateTimeKind.Local).AddTicks(2165), "Unpaid", 300.0, 1, 1, 3000.0, "Monthly", 3 },
                    { 4, 1, false, new DateTime(2024, 12, 2, 9, 57, 34, 50, DateTimeKind.Local).AddTicks(2174), new DateTime(2024, 12, 2, 9, 57, 34, 50, DateTimeKind.Local).AddTicks(2174), "Unpaid", 400.0, 1, 1, 4000.0, "Monthly", 4 }
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "CustomerId", "ExpirationDate", "QuoteDate", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 1, 1, 9, 57, 34, 50, DateTimeKind.Local).AddTicks(2277), new DateTime(2024, 12, 2, 9, 57, 34, 50, DateTimeKind.Local).AddTicks(2272), "Pending", 1000m },
                    { 2, 2, new DateTime(2025, 1, 1, 9, 57, 34, 50, DateTimeKind.Local).AddTicks(2625), new DateTime(2024, 12, 2, 9, 57, 34, 50, DateTimeKind.Local).AddTicks(2614), "Pending", 2000m },
                    { 3, 3, new DateTime(2025, 1, 1, 9, 57, 34, 50, DateTimeKind.Local).AddTicks(2653), new DateTime(2024, 12, 2, 9, 57, 34, 50, DateTimeKind.Local).AddTicks(2642), "Pending", 3000m }
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
                name: "IX_maintenanceRequests_ProductId",
                table: "maintenanceRequests",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_maintenanceRequests_UserId",
                table: "maintenanceRequests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_maintenanceRequests_WorkReceiptId",
                table: "maintenanceRequests",
                column: "WorkReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_CustomerId",
                table: "Quotes",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptMaterials_MaterialId",
                table: "ReceiptMaterials",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNotes_UserId",
                table: "UserNotes",
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
                name: "maintenanceRequests");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Quotes");

            migrationBuilder.DropTable(
                name: "ReceiptMaterials");

            migrationBuilder.DropTable(
                name: "UserNotes");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "WorkReceipts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
