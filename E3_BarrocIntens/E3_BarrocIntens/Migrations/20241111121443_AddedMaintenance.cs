using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E3_BarrocIntens.Migrations
{
    /// <inheritdoc />
    public partial class AddedMaintenance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
