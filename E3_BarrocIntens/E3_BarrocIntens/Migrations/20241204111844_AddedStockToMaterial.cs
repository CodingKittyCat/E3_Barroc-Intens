using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E3_BarrocIntens.Migrations
{
    /// <inheritdoc />
    public partial class AddedStockToMaterial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Materials",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 24, 12, 18, 43, 203, DateTimeKind.Local).AddTicks(1696), new DateTime(2024, 11, 4, 12, 18, 43, 203, DateTimeKind.Local).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 19, 12, 18, 43, 203, DateTimeKind.Local).AddTicks(1708), new DateTime(2024, 11, 19, 12, 18, 43, 203, DateTimeKind.Local).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 29, 12, 18, 43, 203, DateTimeKind.Local).AddTicks(1725), new DateTime(2024, 10, 20, 12, 18, 43, 203, DateTimeKind.Local).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 14, 12, 18, 43, 203, DateTimeKind.Local).AddTicks(1728), new DateTime(2024, 11, 14, 12, 18, 43, 203, DateTimeKind.Local).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 24, 12, 18, 43, 203, DateTimeKind.Local).AddTicks(1735), new DateTime(2024, 11, 24, 12, 18, 43, 203, DateTimeKind.Local).AddTicks(1734) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 12, 4, 12, 18, 44, 115, DateTimeKind.Local).AddTicks(3280), new DateTime(2024, 12, 4, 12, 18, 44, 115, DateTimeKind.Local).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 12, 4, 12, 18, 44, 115, DateTimeKind.Local).AddTicks(3361), new DateTime(2024, 12, 4, 12, 18, 44, 115, DateTimeKind.Local).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 12, 4, 12, 18, 44, 115, DateTimeKind.Local).AddTicks(3365), new DateTime(2024, 12, 4, 12, 18, 44, 115, DateTimeKind.Local).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 12, 4, 12, 18, 44, 115, DateTimeKind.Local).AddTicks(3368), new DateTime(2024, 12, 4, 12, 18, 44, 115, DateTimeKind.Local).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "QuoteDate" },
                values: new object[] { new DateTime(2025, 1, 3, 12, 18, 44, 115, DateTimeKind.Local).AddTicks(3474), new DateTime(2024, 12, 4, 12, 18, 44, 115, DateTimeKind.Local).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "QuoteDate" },
                values: new object[] { new DateTime(2025, 1, 3, 12, 18, 44, 115, DateTimeKind.Local).AddTicks(3496), new DateTime(2024, 12, 4, 12, 18, 44, 115, DateTimeKind.Local).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpirationDate", "QuoteDate" },
                values: new object[] { new DateTime(2025, 1, 3, 12, 18, 44, 115, DateTimeKind.Local).AddTicks(3552), new DateTime(2024, 12, 4, 12, 18, 44, 115, DateTimeKind.Local).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$.uqg8rVaMfYSMVH2lAwygO42jGPQeva6.TcvabutGSTFgHIwjqKGq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$wWJ1/JokcOVkYHIoPOdZqelTMLEXXHmDNC7PDRLe2g/hHX1EMUlFe");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$a1Qk9E6E5fZwz5KqS6Ipyump80pbgc637cfU0Sxbhv6YxTxwrq9pm");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$w5.wdMNQhx3GpqLfd3dlgO9sqwfWTy1I17r86RqJiNxK6ciNB3gni");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$Dt0JZxMlumjHCM0xhe7H4u/q/X.Uv/PpdY.0Ujv3pqWV4jc4HUQR2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$LJzUbbmzVdc9XsYJfvrYIOa7FNHCdunBcU62Nx9bc00ZEjZL1A/8W");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$taVOnpTMkgnKsx.No/zg4O/fOucOWYQ3DmHFYTpae01Kk85OIDToK");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$od8O6BLtCS2d8HJi2cq60uZl.HBBsfriLrLSFBgSzTJYtDAurswoi");

            migrationBuilder.UpdateData(
                table: "WorkReceipts",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReceiptDate",
                value: new DateTime(2024, 12, 4, 12, 18, 43, 203, DateTimeKind.Local).AddTicks(1398));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Materials");

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 24, 10, 1, 28, 586, DateTimeKind.Local).AddTicks(7518), new DateTime(2024, 11, 4, 10, 1, 28, 586, DateTimeKind.Local).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 19, 10, 1, 28, 586, DateTimeKind.Local).AddTicks(7529), new DateTime(2024, 11, 19, 10, 1, 28, 586, DateTimeKind.Local).AddTicks(7528) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 29, 10, 1, 28, 586, DateTimeKind.Local).AddTicks(7566), new DateTime(2024, 10, 20, 10, 1, 28, 586, DateTimeKind.Local).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 14, 10, 1, 28, 586, DateTimeKind.Local).AddTicks(7570), new DateTime(2024, 11, 14, 10, 1, 28, 586, DateTimeKind.Local).AddTicks(7568) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 24, 10, 1, 28, 586, DateTimeKind.Local).AddTicks(7575), new DateTime(2024, 11, 24, 10, 1, 28, 586, DateTimeKind.Local).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 12, 4, 10, 1, 29, 516, DateTimeKind.Local).AddTicks(2795), new DateTime(2024, 12, 4, 10, 1, 29, 516, DateTimeKind.Local).AddTicks(2795) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 12, 4, 10, 1, 29, 516, DateTimeKind.Local).AddTicks(2876), new DateTime(2024, 12, 4, 10, 1, 29, 516, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 12, 4, 10, 1, 29, 516, DateTimeKind.Local).AddTicks(2880), new DateTime(2024, 12, 4, 10, 1, 29, 516, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 12, 4, 10, 1, 29, 516, DateTimeKind.Local).AddTicks(2882), new DateTime(2024, 12, 4, 10, 1, 29, 516, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "QuoteDate" },
                values: new object[] { new DateTime(2025, 1, 3, 10, 1, 29, 516, DateTimeKind.Local).AddTicks(3002), new DateTime(2024, 12, 4, 10, 1, 29, 516, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "QuoteDate" },
                values: new object[] { new DateTime(2025, 1, 3, 10, 1, 29, 516, DateTimeKind.Local).AddTicks(3022), new DateTime(2024, 12, 4, 10, 1, 29, 516, DateTimeKind.Local).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpirationDate", "QuoteDate" },
                values: new object[] { new DateTime(2025, 1, 3, 10, 1, 29, 516, DateTimeKind.Local).AddTicks(3078), new DateTime(2024, 12, 4, 10, 1, 29, 516, DateTimeKind.Local).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$PE1uR/mrE1Nv13r7YyGh7OngfjN0MOzSykO1iqTmB9ChyWS1nJUEC");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$rXUbqv5BwGdQV9b/9jFVCe6.QqnhLzqwx9FLWr2aaGP5aagDjK/6W");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$v9DH2sOhMXf55ZoyqR6hXunCQHVUZZeJEt/kxT.v6bggPvAVF/JNS");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$YZToz/lKcIuauibHymbrnOI.BwYLHWJJZKH7xfCKP1D93MgvjnIeu");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$1oXAjY0q1sZ.NVJOKX1rtugiyieg0otU1mNXPGSYMFglnBZksTOxm");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$cuen5izgR9Dl9tvuDWoByuPxdA4qmVgw5ShPkT2J.ddAmlUOXk1EC");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$bQHENr7rIceCbCzugEXk/ek.cS520tyCOiqZXLoT9UYAl4BpkgjFy");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$/t/VYmymRjTPxVSHATz2X.wHDuA0M.EDA55VFH4ZaY.e/Bn3HHQrm");

            migrationBuilder.UpdateData(
                table: "WorkReceipts",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReceiptDate",
                value: new DateTime(2024, 12, 4, 10, 1, 28, 586, DateTimeKind.Local).AddTicks(7197));
        }
    }
}
