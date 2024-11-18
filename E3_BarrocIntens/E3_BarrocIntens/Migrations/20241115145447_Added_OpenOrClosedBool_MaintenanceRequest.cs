using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E3_BarrocIntens.Migrations
{
    /// <inheritdoc />
    public partial class Added_OpenOrClosedBool_MaintenanceRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsClosed",
                table: "maintenanceRequests",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsClosed",
                table: "maintenanceRequests");

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 3, 40, 633, DateTimeKind.Local).AddTicks(3875), new DateTime(2024, 10, 12, 14, 3, 40, 633, DateTimeKind.Local).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 26, 14, 3, 40, 633, DateTimeKind.Local).AddTicks(3900), new DateTime(2024, 10, 27, 14, 3, 40, 633, DateTimeKind.Local).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 6, 14, 3, 40, 633, DateTimeKind.Local).AddTicks(3903), new DateTime(2024, 9, 27, 14, 3, 40, 633, DateTimeKind.Local).AddTicks(3902) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 21, 14, 3, 40, 633, DateTimeKind.Local).AddTicks(3915), new DateTime(2024, 10, 22, 14, 3, 40, 633, DateTimeKind.Local).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 1, 14, 3, 40, 633, DateTimeKind.Local).AddTicks(3922), new DateTime(2024, 11, 1, 14, 3, 40, 633, DateTimeKind.Local).AddTicks(3921) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$uTMyFeGp3xbbsEp2qHU0Ber5xS9izmBrsC76NQ6adJOajD08dgrw.");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$3.DMS4CHAw7AnC5NVUvO2Oe1V2yk9kQRIpNLZbX29fh0AH0U7YvMS");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$OGwwdoslXOmYJC8NmnjqAOg6sISd6u8HL.HHx0rYDaIPgGThYwufO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$1h8MUq47CVVYCEgi1jRm0u9HzNGfdU1Px88XgCJ6o4cEALRhkyIKe");
        }
    }
}
