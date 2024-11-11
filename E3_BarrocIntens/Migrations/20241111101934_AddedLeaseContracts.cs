using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E3_BarrocIntens.Migrations
{
    /// <inheritdoc />
    public partial class AddedLeaseContracts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 1, 11, 19, 33, 459, DateTimeKind.Local).AddTicks(6941), new DateTime(2024, 10, 12, 11, 19, 33, 459, DateTimeKind.Local).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 26, 11, 19, 33, 459, DateTimeKind.Local).AddTicks(6964), new DateTime(2024, 10, 27, 11, 19, 33, 459, DateTimeKind.Local).AddTicks(6962) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 6, 11, 19, 33, 459, DateTimeKind.Local).AddTicks(6972), new DateTime(2024, 9, 27, 11, 19, 33, 459, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 21, 11, 19, 33, 459, DateTimeKind.Local).AddTicks(6977), new DateTime(2024, 10, 22, 11, 19, 33, 459, DateTimeKind.Local).AddTicks(6976) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 1, 11, 19, 33, 459, DateTimeKind.Local).AddTicks(6980), new DateTime(2024, 11, 1, 11, 19, 33, 459, DateTimeKind.Local).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "Lease_Contracts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 11, 11, 11, 19, 33, 913, DateTimeKind.Local).AddTicks(6753), new DateTime(2024, 11, 11, 11, 19, 33, 913, DateTimeKind.Local).AddTicks(6753) });

            migrationBuilder.UpdateData(
                table: "Lease_Contracts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 11, 11, 11, 19, 33, 913, DateTimeKind.Local).AddTicks(6865), new DateTime(2024, 11, 11, 11, 19, 33, 913, DateTimeKind.Local).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "Lease_Contracts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 11, 11, 11, 19, 33, 913, DateTimeKind.Local).AddTicks(6869), new DateTime(2024, 11, 11, 11, 19, 33, 913, DateTimeKind.Local).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "Lease_Contracts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 11, 11, 11, 19, 33, 913, DateTimeKind.Local).AddTicks(6871), new DateTime(2024, 11, 11, 11, 19, 33, 913, DateTimeKind.Local).AddTicks(6871) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$xN64qKrFqW1hPYWjEhUjBOSjVuZdzCMa/sFH3ZgBK7TKFU8QnQdnG");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$wy0LioGZgqI/8aIEkyoNaeYMHYv.cmORrArhhl2JuUe25Yiz1XBMe");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$geUlUTIdU5og0qAVw.irR.hJEJGRsjTPEnoCE.c8FRhlAr6b3pT/6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$vUmU/aIJC57q66x6wjBkt.oWIK5DDPud4BvVyTNO6.8ny/m/PUhBa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 1, 11, 9, 37, 939, DateTimeKind.Local).AddTicks(6241), new DateTime(2024, 10, 12, 11, 9, 37, 939, DateTimeKind.Local).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 26, 11, 9, 37, 939, DateTimeKind.Local).AddTicks(6267), new DateTime(2024, 10, 27, 11, 9, 37, 939, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 6, 11, 9, 37, 939, DateTimeKind.Local).AddTicks(6279), new DateTime(2024, 9, 27, 11, 9, 37, 939, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 21, 11, 9, 37, 939, DateTimeKind.Local).AddTicks(6287), new DateTime(2024, 10, 22, 11, 9, 37, 939, DateTimeKind.Local).AddTicks(6285) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 1, 11, 9, 37, 939, DateTimeKind.Local).AddTicks(6291), new DateTime(2024, 11, 1, 11, 9, 37, 939, DateTimeKind.Local).AddTicks(6289) });

            migrationBuilder.UpdateData(
                table: "Lease_Contracts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 11, 11, 11, 9, 38, 403, DateTimeKind.Local).AddTicks(9345), new DateTime(2024, 11, 11, 11, 9, 38, 403, DateTimeKind.Local).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "Lease_Contracts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 11, 11, 11, 9, 38, 403, DateTimeKind.Local).AddTicks(9503), new DateTime(2024, 11, 11, 11, 9, 38, 403, DateTimeKind.Local).AddTicks(9503) });

            migrationBuilder.UpdateData(
                table: "Lease_Contracts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 11, 11, 11, 9, 38, 403, DateTimeKind.Local).AddTicks(9508), new DateTime(2024, 11, 11, 11, 9, 38, 403, DateTimeKind.Local).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "Lease_Contracts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 11, 11, 11, 9, 38, 403, DateTimeKind.Local).AddTicks(9571), new DateTime(2024, 11, 11, 11, 9, 38, 403, DateTimeKind.Local).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$RaufgxcAIzJKZdqKj9ROcudr.4lRPuy2/XPx1WPd7.xiQ7d96wqY.");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$a60JiLgP9EDJu2ALgMAeBOBS3iULDc6rGOpwAzypoMfyAY1nfuAsu");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$Jnpnmw.8wP5vYLHGt4Bcb.DiZQRtGMV0jHBtWuDTLpEkx3s5BN5Gy");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$cl/L3qkKdvcLjgo8Ou4fe.1LkKPajiXz3NUFavRsmFlvYOOMFYCJO");
        }
    }
}
