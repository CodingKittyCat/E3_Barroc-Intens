using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E3_BarrocIntens.Migrations
{
    /// <inheritdoc />
    public partial class AddedMaintenancePlannedDateTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PlannedDateTime",
                table: "maintenanceRequests",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 5, 11, 34, 8, 716, DateTimeKind.Local).AddTicks(9645), new DateTime(2024, 10, 16, 11, 34, 8, 716, DateTimeKind.Local).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 30, 11, 34, 8, 716, DateTimeKind.Local).AddTicks(9655), new DateTime(2024, 10, 31, 11, 34, 8, 716, DateTimeKind.Local).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 10, 11, 34, 8, 716, DateTimeKind.Local).AddTicks(9659), new DateTime(2024, 10, 1, 11, 34, 8, 716, DateTimeKind.Local).AddTicks(9658) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 25, 11, 34, 8, 716, DateTimeKind.Local).AddTicks(9674), new DateTime(2024, 10, 26, 11, 34, 8, 716, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 5, 11, 34, 8, 716, DateTimeKind.Local).AddTicks(9685), new DateTime(2024, 11, 5, 11, 34, 8, 716, DateTimeKind.Local).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$EaEuepb09uldnyNAAYui8uqaeTIpPPBAj90JkfTgBj/OGGMdQLjnO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$qJexDf1MwEkaHzeKa7ZslO1NaBTdnWeGSUT/gDGR0ygXfqP5RGGta");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$yD3O5ntqtwprIgTeq4/RJ.tbUX1I4N.xRkPKdUJ5Drupam2z1CIrm");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$SGh6ktSFruO5A887OtfhROI6sPTiVzQ5UKc0SEQu1hzHSZUfhU.QK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlannedDateTime",
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
