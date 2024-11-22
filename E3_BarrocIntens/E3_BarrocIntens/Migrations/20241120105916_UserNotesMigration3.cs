using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E3_BarrocIntens.Migrations
{
    /// <inheritdoc />
    public partial class UserNotesMigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 10, 11, 59, 15, 371, DateTimeKind.Local).AddTicks(8614), new DateTime(2024, 10, 21, 11, 59, 15, 371, DateTimeKind.Local).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 5, 11, 59, 15, 371, DateTimeKind.Local).AddTicks(8626), new DateTime(2024, 11, 5, 11, 59, 15, 371, DateTimeKind.Local).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 15, 11, 59, 15, 371, DateTimeKind.Local).AddTicks(8630), new DateTime(2024, 10, 6, 11, 59, 15, 371, DateTimeKind.Local).AddTicks(8628) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 30, 11, 59, 15, 371, DateTimeKind.Local).AddTicks(8640), new DateTime(2024, 10, 31, 11, 59, 15, 371, DateTimeKind.Local).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 10, 11, 59, 15, 371, DateTimeKind.Local).AddTicks(8650), new DateTime(2024, 11, 10, 11, 59, 15, 371, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Notes", "Password" },
                values: new object[] { null, "$2a$11$AH4lpwH.gmh.oNGANmA1m.3Uo.KhLWuLDWReX7vtmMX4e2ismyLGW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Notes", "Password" },
                values: new object[] { null, "$2a$11$jqBdT1v.ZhUJIE6Ou4FX9ehzHVarW2a7bZ65BtIbP4AguC8slLB.m" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Notes", "Password" },
                values: new object[] { null, "$2a$11$WY3ICuk2jiFtOrspgAayqe.cvgfZbjhZuGcmnL67I5OVVMEVB72ly" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Notes", "Password" },
                values: new object[] { null, "$2a$11$f9mL/OQCCskPRA5ZM0ckGudCzW52Dj6tGjdvR.gDejA8tof8U63sy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Notes", "Password" },
                values: new object[] { null, "$2a$11$h1HhxA.C5Wf.aWMbqHCCZeUSeohZK1Yzx8RRWXjwCd4/kkp3Zowuq" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Notes", "Password" },
                values: new object[] { "", "$2a$11$wpzNR//XOa0MvKplro85uuHscFgWlRVhytXhSp68QhtqGVBQ24TSm" });
        }
    }
}
