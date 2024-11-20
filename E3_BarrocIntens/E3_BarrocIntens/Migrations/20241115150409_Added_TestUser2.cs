using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E3_BarrocIntens.Migrations
{
    /// <inheritdoc />
    public partial class Added_TestUser2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 5, 16, 4, 8, 613, DateTimeKind.Local).AddTicks(1506), new DateTime(2024, 10, 16, 16, 4, 8, 613, DateTimeKind.Local).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 30, 16, 4, 8, 613, DateTimeKind.Local).AddTicks(1524), new DateTime(2024, 10, 31, 16, 4, 8, 613, DateTimeKind.Local).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 10, 16, 4, 8, 613, DateTimeKind.Local).AddTicks(1529), new DateTime(2024, 10, 1, 16, 4, 8, 613, DateTimeKind.Local).AddTicks(1527) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 25, 16, 4, 8, 613, DateTimeKind.Local).AddTicks(1536), new DateTime(2024, 10, 26, 16, 4, 8, 613, DateTimeKind.Local).AddTicks(1535) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 5, 16, 4, 8, 613, DateTimeKind.Local).AddTicks(1544), new DateTime(2024, 11, 5, 16, 4, 8, 613, DateTimeKind.Local).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$QaUelqNDuNGOhRuPbQfVpOOE//xnrPBjO8U1YncqizO5tQChAdn0K");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$NWP7AiCCdyUmOMyK7hgjo.e0CyvkTgExTLQtLI4gL3U/mqSAgAfYS");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$lB3B3cE3/yH6K8kbTZhzneKZ2PtpDiu638gnAcpLWl/E2sBmP4oly");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$fDqf7vGhBRQliaw50E/q3uqsJN2hj3NKuz57BTR0tII1lt5qn7SFe");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$GBmSe4XU85ebUZ8cOVNyeOp7AUugpfatWr/TYtTLDYaDwgXFmJNKO");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "Password", "RoleId", "Username" },
                values: new object[] { 6, "Stan Baker", "$2a$11$uwA41IoDUEBVESpFopFz7eWuefsJEY5Br9TJPL0OvDaTFB.lIAbc.", 1, "maintenance" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 5, 15, 58, 57, 769, DateTimeKind.Local).AddTicks(3545), new DateTime(2024, 10, 16, 15, 58, 57, 769, DateTimeKind.Local).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 30, 15, 58, 57, 769, DateTimeKind.Local).AddTicks(3566), new DateTime(2024, 10, 31, 15, 58, 57, 769, DateTimeKind.Local).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 10, 15, 58, 57, 769, DateTimeKind.Local).AddTicks(3570), new DateTime(2024, 10, 1, 15, 58, 57, 769, DateTimeKind.Local).AddTicks(3568) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 25, 15, 58, 57, 769, DateTimeKind.Local).AddTicks(3577), new DateTime(2024, 10, 26, 15, 58, 57, 769, DateTimeKind.Local).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 5, 15, 58, 57, 769, DateTimeKind.Local).AddTicks(3585), new DateTime(2024, 11, 5, 15, 58, 57, 769, DateTimeKind.Local).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$.H/79c4NmpdQqmvTcWyrX.CqcDiy1V1NdUFWrS44pvuiwc84Fib8i");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$vBzC1O..yQfZ0ruikiIJ..GsfSs8cCLtWMw2.H/rKgUrK2Wat9qOS");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$8YrLQkAva9L1wMl8jQ1QD.bWkQkBDhiSAKd2vRRKrx9MjWMza19a2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$OgFvWye8QtQ5iyLkpvSwhuCTMP352y3eiDIV8Khz7jEy2dcWmeKnu");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$X5rTrUDorrtZr4piJNI47e3ZF.G24f.KYBciKGGbbfUjXz7ciAQHe");
        }
    }
}
