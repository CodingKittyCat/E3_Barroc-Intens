using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E3_BarrocIntens.Migrations
{
    /// <inheritdoc />
    public partial class Added_TestUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "Password", "RoleId", "Username" },
                values: new object[] { 5, "George Cassel", "$2a$11$X5rTrUDorrtZr4piJNI47e3ZF.G24f.KYBciKGGbbfUjXz7ciAQHe", 1, "maintenance" });
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
                values: new object[] { new DateTime(2024, 11, 5, 15, 54, 46, 859, DateTimeKind.Local).AddTicks(1991), new DateTime(2024, 10, 16, 15, 54, 46, 859, DateTimeKind.Local).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 30, 15, 54, 46, 859, DateTimeKind.Local).AddTicks(2007), new DateTime(2024, 10, 31, 15, 54, 46, 859, DateTimeKind.Local).AddTicks(2006) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 10, 15, 54, 46, 859, DateTimeKind.Local).AddTicks(2012), new DateTime(2024, 10, 1, 15, 54, 46, 859, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 25, 15, 54, 46, 859, DateTimeKind.Local).AddTicks(2020), new DateTime(2024, 10, 26, 15, 54, 46, 859, DateTimeKind.Local).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 5, 15, 54, 46, 859, DateTimeKind.Local).AddTicks(2029), new DateTime(2024, 11, 5, 15, 54, 46, 859, DateTimeKind.Local).AddTicks(2027) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$aegl3HDxlWFkyp7HZMQ8D./uO.ZUflfc2xDefKc.I/9rJRCOiA9La");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$znGg0KVYjV6YY.B50SUTpep7sCuraoTULbeiDv/4U4Ys10HAEpSj.");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$nrwU72qo3gEd9onQpzCpjOiCpkarbfftcFwJg8dzA1lCC0koa1zDq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$jFAt.mvir7ahD2bMX/j2KOHGhBX0rNL8vinG4QrEWDn.rHHJB.A8K");
        }
    }
}
