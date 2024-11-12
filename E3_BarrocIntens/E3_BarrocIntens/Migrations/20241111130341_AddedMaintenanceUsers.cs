using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E3_BarrocIntens.Migrations
{
    /// <inheritdoc />
    public partial class AddedMaintenanceUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "maintenanceRequests",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_maintenanceRequests_UserId",
                table: "maintenanceRequests",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_maintenanceRequests_Users_UserId",
                table: "maintenanceRequests",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_maintenanceRequests_Users_UserId",
                table: "maintenanceRequests");

            migrationBuilder.DropIndex(
                name: "IX_maintenanceRequests_UserId",
                table: "maintenanceRequests");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "maintenanceRequests");

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
        }
    }
}
