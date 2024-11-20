using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E3_BarrocIntens.Migrations
{
    /// <inheritdoc />
    public partial class UserNoteClassMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 1, 27, 921, DateTimeKind.Local).AddTicks(9603), new DateTime(2024, 10, 21, 12, 1, 27, 921, DateTimeKind.Local).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 5, 12, 1, 27, 921, DateTimeKind.Local).AddTicks(9617), new DateTime(2024, 11, 5, 12, 1, 27, 921, DateTimeKind.Local).AddTicks(9615) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 15, 12, 1, 27, 921, DateTimeKind.Local).AddTicks(9621), new DateTime(2024, 10, 6, 12, 1, 27, 921, DateTimeKind.Local).AddTicks(9619) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 30, 12, 1, 27, 921, DateTimeKind.Local).AddTicks(9632), new DateTime(2024, 10, 31, 12, 1, 27, 921, DateTimeKind.Local).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 10, 12, 1, 27, 921, DateTimeKind.Local).AddTicks(9641), new DateTime(2024, 11, 10, 12, 1, 27, 921, DateTimeKind.Local).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$zLRcjmyyHMqszhgJc5P8Ru6lKD1ZTZQpYFIbtYVmMFa0sVtxR98mi");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$w9sFHW65SNQVUkLaFqVUaeIRSXdOhxQmIJGdsWx6gEVij1fcG1hva");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$3ESM0XUF.SmJLBBf9jZW3.RRGrTYicjeaQOr/N1UsaWwiiioV.FDa");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$JPcZWUnRdfMztsk744TVuOvZhXXfnwrnKZ2fE223UivbvJhF3uGrG");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$uFjG/oKaEa9.gyFaFoQwSe.qEV/ohS.Nw.eOquQ3Nx55ipumpyN5W");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
