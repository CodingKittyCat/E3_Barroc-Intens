using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E3_BarrocIntens.Migrations
{
    /// <inheritdoc />
    public partial class AddedForeignReceiptId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WorkReceiptId",
                table: "maintenanceRequests",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 33, 607, DateTimeKind.Local).AddTicks(279), new DateTime(2024, 10, 22, 13, 52, 33, 607, DateTimeKind.Local).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 6, 13, 52, 33, 607, DateTimeKind.Local).AddTicks(295), new DateTime(2024, 11, 6, 13, 52, 33, 607, DateTimeKind.Local).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 16, 13, 52, 33, 607, DateTimeKind.Local).AddTicks(306), new DateTime(2024, 10, 7, 13, 52, 33, 607, DateTimeKind.Local).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 1, 13, 52, 33, 607, DateTimeKind.Local).AddTicks(312), new DateTime(2024, 11, 1, 13, 52, 33, 607, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 11, 13, 52, 33, 607, DateTimeKind.Local).AddTicks(315), new DateTime(2024, 11, 11, 13, 52, 33, 607, DateTimeKind.Local).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 11, 21, 13, 52, 34, 306, DateTimeKind.Local).AddTicks(5815), new DateTime(2024, 11, 21, 13, 52, 34, 306, DateTimeKind.Local).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 11, 21, 13, 52, 34, 306, DateTimeKind.Local).AddTicks(6056), new DateTime(2024, 11, 21, 13, 52, 34, 306, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 11, 21, 13, 52, 34, 306, DateTimeKind.Local).AddTicks(6060), new DateTime(2024, 11, 21, 13, 52, 34, 306, DateTimeKind.Local).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 11, 21, 13, 52, 34, 306, DateTimeKind.Local).AddTicks(6064), new DateTime(2024, 11, 21, 13, 52, 34, 306, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$MvbTipSIWCamEtCZWdV7BuamRJjCa8dr55P49aRz/jXi9VT.feLS6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$MhvQ0HKR./VY/A6jDYDnWuUf4uCx/0yt5xhMJio7xXc6ir9R866Nu");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$Nse5W1zLlIWRp/XUgVXShuLydP3Ry6pIqNcqeE7m1IIRyzJ04cvBO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$L/UsZ5vRrhPrONf/KrDPCO0rPB6R98DCBuNOZ0EhImuyZTEroBqzG");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$p7aUNNs.N7Q0MKronf1LD..V6.rZNQzJp68B31r8NYc4RbGd73o.i");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$LIqr0IiYN1U85hTQ65JNdOFTHYYqh6ybfgIzEWkZCSg4G1PiI5r2C");

            migrationBuilder.CreateIndex(
                name: "IX_maintenanceRequests_WorkReceiptId",
                table: "maintenanceRequests",
                column: "WorkReceiptId");

            migrationBuilder.AddForeignKey(
                name: "FK_maintenanceRequests_WorkReceipts_WorkReceiptId",
                table: "maintenanceRequests",
                column: "WorkReceiptId",
                principalTable: "WorkReceipts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_maintenanceRequests_WorkReceipts_WorkReceiptId",
                table: "maintenanceRequests");

            migrationBuilder.DropIndex(
                name: "IX_maintenanceRequests_WorkReceiptId",
                table: "maintenanceRequests");

            migrationBuilder.DropColumn(
                name: "WorkReceiptId",
                table: "maintenanceRequests");

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 44, 20, 624, DateTimeKind.Local).AddTicks(5093), new DateTime(2024, 10, 22, 13, 44, 20, 624, DateTimeKind.Local).AddTicks(5004) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 6, 13, 44, 20, 624, DateTimeKind.Local).AddTicks(5140), new DateTime(2024, 11, 6, 13, 44, 20, 624, DateTimeKind.Local).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 16, 13, 44, 20, 624, DateTimeKind.Local).AddTicks(5148), new DateTime(2024, 10, 7, 13, 44, 20, 624, DateTimeKind.Local).AddTicks(5146) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 1, 13, 44, 20, 624, DateTimeKind.Local).AddTicks(5153), new DateTime(2024, 11, 1, 13, 44, 20, 624, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 11, 13, 44, 20, 624, DateTimeKind.Local).AddTicks(5157), new DateTime(2024, 11, 11, 13, 44, 20, 624, DateTimeKind.Local).AddTicks(5155) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 11, 21, 13, 44, 21, 323, DateTimeKind.Local).AddTicks(25), new DateTime(2024, 11, 21, 13, 44, 21, 323, DateTimeKind.Local).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 11, 21, 13, 44, 21, 323, DateTimeKind.Local).AddTicks(182), new DateTime(2024, 11, 21, 13, 44, 21, 323, DateTimeKind.Local).AddTicks(182) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 11, 21, 13, 44, 21, 323, DateTimeKind.Local).AddTicks(187), new DateTime(2024, 11, 21, 13, 44, 21, 323, DateTimeKind.Local).AddTicks(187) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 11, 21, 13, 44, 21, 323, DateTimeKind.Local).AddTicks(190), new DateTime(2024, 11, 21, 13, 44, 21, 323, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$OsI0Prr2eMC7sqKtEGLjxO/iCx2Z389SSAYO4BChS6Hs47zAyMFkK");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$LFiWFjAPawvs/1XmY1A/JOqaqgtY6q41FQYsYJgdVzHCUB91vRtVq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$NjQgiVCOKIxTGagz6mSMSOCYE9bQEEMqEpQqWubNFDKm73MZOaNHy");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$oplfp1lscvXT3v6odg./SuYBPin7SJ9EjPlbsDSt7RAVF28A9TjJy");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$BTg7U2A8m7VZQupIhFA9B.Q9PIsVZvcQl6nTP9DiNo6SHGXgpAbyC");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$2WRt8H97WiyN3WtOrZtj7eg/0oXQDIp.gq0bTe2X8/zmw/MpLRyMe");
        }
    }
}
