using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E3_BarrocIntens.Migrations
{
    /// <inheritdoc />
    public partial class LeaseContractMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Leases",
                table: "Leases");

            migrationBuilder.DropColumn(
                name: "Product_Id",
                table: "Leases");

            migrationBuilder.RenameTable(
                name: "Leases",
                newName: "Lease_Contracts");

            migrationBuilder.AddColumn<bool>(
                name: "Bkr_Check",
                table: "Lease_Contracts",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date_Created",
                table: "Lease_Contracts",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "End_Date",
                table: "Lease_Contracts",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Payment_Status",
                table: "Lease_Contracts",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Product",
                table: "Lease_Contracts",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lease_Contracts",
                table: "Lease_Contracts",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Lease_Contracts",
                columns: new[] { "Id", "Bkr_Check", "Company_Id", "Date_Created", "End_Date", "Payment_Status", "Price_Per_Period", "Product", "Time_Per_Period", "Total_Price", "Type_Of_Time" },
                values: new object[,]
                {
                    { 1, false, 1, new DateTime(2024, 11, 8, 12, 38, 15, 844, DateTimeKind.Local).AddTicks(4597), new DateTime(2024, 11, 8, 12, 38, 15, 844, DateTimeKind.Local).AddTicks(4597), "Unpaid", 100.0, "TestProduct", 1, 1000.0, "Monthly" },
                    { 2, false, 2, new DateTime(2024, 11, 8, 12, 38, 15, 844, DateTimeKind.Local).AddTicks(4660), new DateTime(2024, 11, 8, 12, 38, 15, 844, DateTimeKind.Local).AddTicks(4660), "Unpaid", 200.0, "TestProduct", 1, 2000.0, "Monthly" },
                    { 3, false, 3, new DateTime(2024, 11, 8, 12, 38, 15, 844, DateTimeKind.Local).AddTicks(4663), new DateTime(2024, 11, 8, 12, 38, 15, 844, DateTimeKind.Local).AddTicks(4663), "Unpaid", 300.0, "TestProduct", 1, 3000.0, "Monthly" },
                    { 4, false, 4, new DateTime(2024, 11, 8, 12, 38, 15, 844, DateTimeKind.Local).AddTicks(4666), new DateTime(2024, 11, 8, 12, 38, 15, 844, DateTimeKind.Local).AddTicks(4666), "Unpaid", 400.0, "TestProduct", 1, 4000.0, "Monthly" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Lease_Contracts",
                table: "Lease_Contracts");

            migrationBuilder.DeleteData(
                table: "Lease_Contracts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lease_Contracts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lease_Contracts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lease_Contracts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Bkr_Check",
                table: "Lease_Contracts");

            migrationBuilder.DropColumn(
                name: "Date_Created",
                table: "Lease_Contracts");

            migrationBuilder.DropColumn(
                name: "End_Date",
                table: "Lease_Contracts");

            migrationBuilder.DropColumn(
                name: "Payment_Status",
                table: "Lease_Contracts");

            migrationBuilder.DropColumn(
                name: "Product",
                table: "Lease_Contracts");

            migrationBuilder.RenameTable(
                name: "Lease_Contracts",
                newName: "Leases");

            migrationBuilder.AddColumn<int>(
                name: "Product_Id",
                table: "Leases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Leases",
                table: "Leases",
                column: "Id");
        }
    }
}
