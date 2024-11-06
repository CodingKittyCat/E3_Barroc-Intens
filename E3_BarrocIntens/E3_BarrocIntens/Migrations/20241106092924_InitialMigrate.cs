using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E3_BarrocIntens.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrate : Migration
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

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CustomerName", "DueDate", "InvoiceDate", "IsPayed", "TotalAmount" },
                values: new object[,]
                {
                    { 1, "John Doe", new DateTime(2024, 10, 27, 10, 29, 24, 29, DateTimeKind.Local).AddTicks(6444), new DateTime(2024, 10, 7, 10, 29, 24, 29, DateTimeKind.Local).AddTicks(6368), true, 1200.5f },
                    { 2, "Jane Smith", new DateTime(2024, 11, 21, 10, 29, 24, 29, DateTimeKind.Local).AddTicks(6463), new DateTime(2024, 10, 22, 10, 29, 24, 29, DateTimeKind.Local).AddTicks(6460), false, 800.75f },
                    { 3, "Acme Corp", new DateTime(2024, 11, 1, 10, 29, 24, 29, DateTimeKind.Local).AddTicks(6468), new DateTime(2024, 9, 22, 10, 29, 24, 29, DateTimeKind.Local).AddTicks(6466), true, 2500f },
                    { 4, "Global Industries", new DateTime(2024, 11, 16, 10, 29, 24, 29, DateTimeKind.Local).AddTicks(6473), new DateTime(2024, 10, 17, 10, 29, 24, 29, DateTimeKind.Local).AddTicks(6471), false, 1500.3f },
                    { 5, "Tech Solutions", new DateTime(2024, 11, 26, 10, 29, 24, 29, DateTimeKind.Local).AddTicks(6478), new DateTime(2024, 10, 27, 10, 29, 24, 29, DateTimeKind.Local).AddTicks(6476), false, 950.6f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoices");
        }
    }
}
