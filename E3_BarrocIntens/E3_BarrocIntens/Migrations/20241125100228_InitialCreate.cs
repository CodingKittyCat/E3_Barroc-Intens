using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E3_BarrocIntens.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CustomerName", "DueDate", "InvoiceDate", "IsPayed", "TotalAmount" },
                values: new object[,]
                {
                    { 1, "John Doe", new DateTime(2024, 11, 15, 11, 2, 27, 193, DateTimeKind.Local).AddTicks(741), new DateTime(2024, 10, 26, 11, 2, 27, 193, DateTimeKind.Local).AddTicks(676), true, 1200.5f },
                    { 2, "Jane Smith", new DateTime(2024, 12, 10, 11, 2, 27, 193, DateTimeKind.Local).AddTicks(754), new DateTime(2024, 11, 10, 11, 2, 27, 193, DateTimeKind.Local).AddTicks(751), false, 800.75f },
                    { 3, "Acme Corp", new DateTime(2024, 11, 20, 11, 2, 27, 193, DateTimeKind.Local).AddTicks(761), new DateTime(2024, 10, 11, 11, 2, 27, 193, DateTimeKind.Local).AddTicks(759), true, 2500f },
                    { 4, "Global Industries", new DateTime(2024, 12, 5, 11, 2, 27, 193, DateTimeKind.Local).AddTicks(768), new DateTime(2024, 11, 5, 11, 2, 27, 193, DateTimeKind.Local).AddTicks(766), false, 1500.3f },
                    { 5, "Tech Solutions", new DateTime(2024, 12, 15, 11, 2, 27, 193, DateTimeKind.Local).AddTicks(771), new DateTime(2024, 11, 15, 11, 2, 27, 193, DateTimeKind.Local).AddTicks(770), false, 950.6f }
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
                columns: new[] { "Id", "Name", "Password", "RoleId", "Username" },
                values: new object[,]
                {
                    { 1, "Customer User", "$2a$11$eIPKDDHo5ZE5jjoPOoNuYeeebCNdvgvDAgJXd7vlhmYiN.ErJgLf.", 4, "customer" },
                    { 2, "Finance User", "$2a$11$4pTnT0febeIfp4dv8iNwoOLfuvu/uePQ.OGG622wAzEn7b1pBRf1a", 2, "finance" },
                    { 3, "Sales User", "$2a$11$nCkKe8LkzjCnVehoJ915ben4wGTxGzUPPgXXtDEAyyoxYFZSGj.lC", 3, "sales" },
                    { 4, "Maintenance User", "$2a$11$R/OIGCRTaXbb2yJCsvBOu.p5iOAc1mjNb0odpJweEixs0dp.35yOq", 1, "maintenance" },
                    { 5, "George Cassel", "$2a$11$YKMph2nFURAkxgfMaPihj.fGII65LxyFJbTaZUbL.KIwhOEBTouSu", 1, "georgecassel" },
                    { 6, "Stan Baker", "$2a$11$z6d3iPNZAmhrDJGqvFtpd.i0vBBYeonYlLsdPe50VUyIqlmdkwhea", 1, "stanbaker" }
                });

            migrationBuilder.InsertData(
                table: "LeaseContracts",
                columns: new[] { "Id", "Amount_Of_Periods", "Bkr_Check", "Date_Created", "End_Date", "Payment_Status", "Price_Per_Period", "ProductId", "Time_Per_Period", "Total_Price", "Type_Of_Time", "UserId" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2024, 11, 25, 11, 2, 27, 881, DateTimeKind.Local).AddTicks(2626), new DateTime(2024, 11, 25, 11, 2, 27, 881, DateTimeKind.Local).AddTicks(2626), "Unpaid", 100.0, 1, 1, 1000.0, "Monthly", 1 },
                    { 2, 1, false, new DateTime(2024, 11, 25, 11, 2, 27, 881, DateTimeKind.Local).AddTicks(2797), new DateTime(2024, 11, 25, 11, 2, 27, 881, DateTimeKind.Local).AddTicks(2797), "Unpaid", 200.0, 1, 1, 2000.0, "Monthly", 2 },
                    { 3, 1, false, new DateTime(2024, 11, 25, 11, 2, 27, 881, DateTimeKind.Local).AddTicks(2801), new DateTime(2024, 11, 25, 11, 2, 27, 881, DateTimeKind.Local).AddTicks(2801), "Unpaid", 300.0, 1, 1, 3000.0, "Monthly", 3 },
                    { 4, 1, false, new DateTime(2024, 11, 25, 11, 2, 27, 881, DateTimeKind.Local).AddTicks(2805), new DateTime(2024, 11, 25, 11, 2, 27, 881, DateTimeKind.Local).AddTicks(2805), "Unpaid", 400.0, 1, 1, 4000.0, "Monthly", 4 }
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
                name: "IX_ReceiptMaterials_MaterialId",
                table: "ReceiptMaterials",
                column: "MaterialId");

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
                name: "ReceiptMaterials");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "WorkReceipts");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
