using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E3_BarrocIntens.Migrations
{
    /// <inheritdoc />
    public partial class material_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 8, 10, 5, 53, 130, DateTimeKind.Local).AddTicks(7044), new DateTime(2024, 10, 19, 10, 5, 53, 130, DateTimeKind.Local).AddTicks(6972) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 3, 10, 5, 53, 130, DateTimeKind.Local).AddTicks(7067), new DateTime(2024, 11, 3, 10, 5, 53, 130, DateTimeKind.Local).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 13, 10, 5, 53, 130, DateTimeKind.Local).AddTicks(7075), new DateTime(2024, 10, 4, 10, 5, 53, 130, DateTimeKind.Local).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 28, 10, 5, 53, 130, DateTimeKind.Local).AddTicks(7083), new DateTime(2024, 10, 29, 10, 5, 53, 130, DateTimeKind.Local).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 8, 10, 5, 53, 130, DateTimeKind.Local).AddTicks(7086), new DateTime(2024, 11, 8, 10, 5, 53, 130, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 11, 18, 10, 5, 53, 564, DateTimeKind.Local).AddTicks(982), new DateTime(2024, 11, 18, 10, 5, 53, 564, DateTimeKind.Local).AddTicks(982) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 11, 18, 10, 5, 53, 564, DateTimeKind.Local).AddTicks(1105), new DateTime(2024, 11, 18, 10, 5, 53, 564, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 11, 18, 10, 5, 53, 564, DateTimeKind.Local).AddTicks(1109), new DateTime(2024, 11, 18, 10, 5, 53, 564, DateTimeKind.Local).AddTicks(1109) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 11, 18, 10, 5, 53, 564, DateTimeKind.Local).AddTicks(1113), new DateTime(2024, 11, 18, 10, 5, 53, 564, DateTimeKind.Local).AddTicks(1113) });

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$gB/W4hyd.wPD2s77gFefbuobd5lrLxqyar5o60pNHTcP2opAt7fYq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$GvAoeuyBpSLZEb9dvLrrWOCNh1h6q.I1u.pjt3W5qzMPT66e55ucK");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$N9YWJzfyy8MFe6LUpfmW.eIT43gRMbHr5dfLFt0e3ZVin7iC7XdHu");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$Rutpw7yKt9gLXBCmtvpZUezB1HEw0tvP5adG8G7FeNpF00x2RfJr6");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1399), new DateTime(2024, 10, 12, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1313) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 26, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1428), new DateTime(2024, 10, 27, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1426) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 6, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1443), new DateTime(2024, 9, 27, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1441) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 21, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1453), new DateTime(2024, 10, 22, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 1, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1458), new DateTime(2024, 11, 1, 14, 47, 48, 915, DateTimeKind.Local).AddTicks(1456) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 11, 11, 14, 47, 49, 456, DateTimeKind.Local).AddTicks(6495), new DateTime(2024, 11, 11, 14, 47, 49, 456, DateTimeKind.Local).AddTicks(6495) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 11, 11, 14, 47, 49, 456, DateTimeKind.Local).AddTicks(6595), new DateTime(2024, 11, 11, 14, 47, 49, 456, DateTimeKind.Local).AddTicks(6595) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 11, 11, 14, 47, 49, 456, DateTimeKind.Local).AddTicks(6601), new DateTime(2024, 11, 11, 14, 47, 49, 456, DateTimeKind.Local).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 11, 11, 14, 47, 49, 456, DateTimeKind.Local).AddTicks(6606), new DateTime(2024, 11, 11, 14, 47, 49, 456, DateTimeKind.Local).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$N2yBIyO9xot.sR6GzuSpwulvYANUGZdd.IIxY4.mzNUwVsItgYUpe");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$7BkYyT9zTpNQLKAXBpVQcuytFqksMdjEYYjUF7ouPHxnXFRp5edL2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$De8nOWc9d/m/gTt6Js03Juz.BlzhYdqeIwm5YLoM7k4Tkvhi7.Ox2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$p3BpXjddK/oIErrOsCQc3OXZHuve5pll9uwmLe5.f9lTVJ3Va6DF6");
        }
    }
}
