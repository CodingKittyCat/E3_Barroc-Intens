using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E3_BarrocIntens.Migrations
{
    /// <inheritdoc />
    public partial class UserNotesMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Users",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 10, 11, 55, 35, 984, DateTimeKind.Local).AddTicks(6950), new DateTime(2024, 10, 21, 11, 55, 35, 984, DateTimeKind.Local).AddTicks(6892) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 5, 11, 55, 35, 984, DateTimeKind.Local).AddTicks(6963), new DateTime(2024, 11, 5, 11, 55, 35, 984, DateTimeKind.Local).AddTicks(6961) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 15, 11, 55, 35, 984, DateTimeKind.Local).AddTicks(6968), new DateTime(2024, 10, 6, 11, 55, 35, 984, DateTimeKind.Local).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 30, 11, 55, 35, 984, DateTimeKind.Local).AddTicks(6981), new DateTime(2024, 10, 31, 11, 55, 35, 984, DateTimeKind.Local).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 10, 11, 55, 35, 984, DateTimeKind.Local).AddTicks(6994), new DateTime(2024, 11, 10, 11, 55, 35, 984, DateTimeKind.Local).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Notes", "Password" },
                values: new object[] { null, "$2a$11$NQCSo1hHxpTMOmtvKHpqLeneu6MoiP70FWyl/5rRMTC2o1Y0zhG7e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Notes", "Password" },
                values: new object[] { null, "$2a$11$sXK70yYP3G7k1z0/OKEaTOhhAJwWABUmMzciyzB1KbXvk1PloESGi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Notes", "Password" },
                values: new object[] { null, "$2a$11$pLp4r1dn665q0AwE2foFneMkJQiNQVS4UEkl9ivu6bSdUB4x.ODqS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Notes", "Password" },
                values: new object[] { null, "$2a$11$OUf82cTbCMLr8vs1jT9Yeud5EbTIvKGTVHjaP8mVB8O9I3HBfTjvW" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 10, 27, 10, 29, 24, 29, DateTimeKind.Local).AddTicks(6444), new DateTime(2024, 10, 7, 10, 29, 24, 29, DateTimeKind.Local).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 21, 10, 29, 24, 29, DateTimeKind.Local).AddTicks(6463), new DateTime(2024, 10, 22, 10, 29, 24, 29, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 1, 10, 29, 24, 29, DateTimeKind.Local).AddTicks(6468), new DateTime(2024, 9, 22, 10, 29, 24, 29, DateTimeKind.Local).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 16, 10, 29, 24, 29, DateTimeKind.Local).AddTicks(6473), new DateTime(2024, 10, 17, 10, 29, 24, 29, DateTimeKind.Local).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 26, 10, 29, 24, 29, DateTimeKind.Local).AddTicks(6478), new DateTime(2024, 10, 27, 10, 29, 24, 29, DateTimeKind.Local).AddTicks(6476) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$1woNT85mfLEt0PhdI0f.uenlXne/AmE2vv0JeME6AsfZ4neIqwxpC");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$0VYl19UPQUfTQgGcxeT8G.Fk1LJg.6wCd4jDbcWOJ4NcrePMBkl4K");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$ir/DGHvPm1hk9NLUiyy4.Og4QtqK/yW8Gx9zCVLlzGCqvo/VruXaC");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$gYz546qjoU0.GPQddt9tMea1RRg5bxJwhVtww7s2zpczkzidhMMq2");
        }
    }
}
