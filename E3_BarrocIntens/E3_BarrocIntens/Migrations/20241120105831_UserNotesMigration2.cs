using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E3_BarrocIntens.Migrations
{
    /// <inheritdoc />
    public partial class UserNotesMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 10, 11, 58, 30, 518, DateTimeKind.Local).AddTicks(2405), new DateTime(2024, 10, 21, 11, 58, 30, 518, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 5, 11, 58, 30, 518, DateTimeKind.Local).AddTicks(2415), new DateTime(2024, 11, 5, 11, 58, 30, 518, DateTimeKind.Local).AddTicks(2413) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 15, 11, 58, 30, 518, DateTimeKind.Local).AddTicks(2419), new DateTime(2024, 10, 6, 11, 58, 30, 518, DateTimeKind.Local).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 30, 11, 58, 30, 518, DateTimeKind.Local).AddTicks(2430), new DateTime(2024, 10, 31, 11, 58, 30, 518, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 10, 11, 58, 30, 518, DateTimeKind.Local).AddTicks(2441), new DateTime(2024, 11, 10, 11, 58, 30, 518, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Notes", "Password" },
                values: new object[] { "", "$2a$11$B2j0q1OYa95KuLQUOhvFWOYwTO0F6Awprf/ao8thLOd6LnTdS9usa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Notes", "Password" },
                values: new object[] { "", "$2a$11$aOLi8czcCwl5xKjAWzpN.uhYDmXC2Hvr1i1gzUnFNIJs1gydeGeRW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Notes", "Password" },
                values: new object[] { "", "$2a$11$sTeIxXQu9it45lL/Y6B7i.YEJhi5LABDCj82KDYDU5w9IfAmkH3YW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Notes", "Password" },
                values: new object[] { "", "$2a$11$HIqf7NiO4TP/s0llj9AB8ebPRm0oy.XeBl9Q6xs5f.4A.6.OlzYeC" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "Notes", "Password", "RoleId", "Username" },
                values: new object[] { 5, "Customer2", "", "$2a$11$wpzNR//XOa0MvKplro85uuHscFgWlRVhytXhSp68QhtqGVBQ24TSm", 4, "customer2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

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
    }
}
