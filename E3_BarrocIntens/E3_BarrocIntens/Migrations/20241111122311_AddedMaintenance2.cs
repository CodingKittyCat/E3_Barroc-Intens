using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E3_BarrocIntens.Migrations
{
    /// <inheritdoc />
    public partial class AddedMaintenance2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "maintenanceRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RequestedDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 1, 13, 23, 11, 12, DateTimeKind.Local).AddTicks(7895), new DateTime(2024, 10, 12, 13, 23, 11, 12, DateTimeKind.Local).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 26, 13, 23, 11, 12, DateTimeKind.Local).AddTicks(7913), new DateTime(2024, 10, 27, 13, 23, 11, 12, DateTimeKind.Local).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 6, 13, 23, 11, 12, DateTimeKind.Local).AddTicks(7917), new DateTime(2024, 9, 27, 13, 23, 11, 12, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 21, 13, 23, 11, 12, DateTimeKind.Local).AddTicks(7924), new DateTime(2024, 10, 22, 13, 23, 11, 12, DateTimeKind.Local).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 1, 13, 23, 11, 12, DateTimeKind.Local).AddTicks(7931), new DateTime(2024, 11, 1, 13, 23, 11, 12, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$fOakH2yMA6b7l6ssK6WOLexdT4cO3JNs0d0.4Zn.ZvpbZr6Z13oom");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$fIomTUAiPU6F1uTYndEPYecygpFbXF3cNp3zJoPSQ3RgCtkk547DG");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$wS..MHdxW.kdMbBmgI5PM.cUxQTa0r0PhOZ3tzfHSml9ZNAwMoHa6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$m2qgNXWMxK7eVn6hWwCTDOxyVVBn5EEQ2A8dPdIBXiltKAM/AblPi");

            migrationBuilder.CreateIndex(
                name: "IX_maintenanceRequests_ProductId",
                table: "maintenanceRequests",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "maintenanceRequests");

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 1, 13, 14, 42, 617, DateTimeKind.Local).AddTicks(8183), new DateTime(2024, 10, 12, 13, 14, 42, 617, DateTimeKind.Local).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 26, 13, 14, 42, 617, DateTimeKind.Local).AddTicks(8197), new DateTime(2024, 10, 27, 13, 14, 42, 617, DateTimeKind.Local).AddTicks(8196) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 6, 13, 14, 42, 617, DateTimeKind.Local).AddTicks(8200), new DateTime(2024, 9, 27, 13, 14, 42, 617, DateTimeKind.Local).AddTicks(8199) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 21, 13, 14, 42, 617, DateTimeKind.Local).AddTicks(8210), new DateTime(2024, 10, 22, 13, 14, 42, 617, DateTimeKind.Local).AddTicks(8209) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 1, 13, 14, 42, 617, DateTimeKind.Local).AddTicks(8216), new DateTime(2024, 11, 1, 13, 14, 42, 617, DateTimeKind.Local).AddTicks(8215) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$B7sTBy3o6EPI5mFnvONMxOOrW3bzMT4h0BIO6.qCdnoE5Hc6k8mPa");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$VOVddqywr/3gi2fFMgEqgukT121.aZQnyhXRsY6yY20NdOH8TSmES");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$ZPPfdCQPghQgQE1iEECkPe7Mm8lwsMUaP8lTNacK7mhl/FzoONXV6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$MS4kOCUXsVZp8JFY8a5PLep.yA.bpmH1VFEaqW2NqhLEvg1guTaX.");
        }
    }
}
