using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E3_BarrocIntens.Migrations
{
    /// <inheritdoc />
    public partial class AddedTotalQuantityToMaterial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 22, 13, 21, 57, 530, DateTimeKind.Local).AddTicks(286), new DateTime(2024, 11, 2, 13, 21, 57, 530, DateTimeKind.Local).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 17, 13, 21, 57, 530, DateTimeKind.Local).AddTicks(301), new DateTime(2024, 11, 17, 13, 21, 57, 530, DateTimeKind.Local).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 27, 13, 21, 57, 530, DateTimeKind.Local).AddTicks(328), new DateTime(2024, 10, 18, 13, 21, 57, 530, DateTimeKind.Local).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 12, 13, 21, 57, 530, DateTimeKind.Local).AddTicks(332), new DateTime(2024, 11, 12, 13, 21, 57, 530, DateTimeKind.Local).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 22, 13, 21, 57, 530, DateTimeKind.Local).AddTicks(337), new DateTime(2024, 11, 22, 13, 21, 57, 530, DateTimeKind.Local).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 12, 2, 13, 21, 58, 570, DateTimeKind.Local).AddTicks(2630), new DateTime(2024, 12, 2, 13, 21, 58, 570, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 12, 2, 13, 21, 58, 570, DateTimeKind.Local).AddTicks(2720), new DateTime(2024, 12, 2, 13, 21, 58, 570, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 12, 2, 13, 21, 58, 570, DateTimeKind.Local).AddTicks(2725), new DateTime(2024, 12, 2, 13, 21, 58, 570, DateTimeKind.Local).AddTicks(2725) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 12, 2, 13, 21, 58, 570, DateTimeKind.Local).AddTicks(2729), new DateTime(2024, 12, 2, 13, 21, 58, 570, DateTimeKind.Local).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "QuoteDate" },
                values: new object[] { new DateTime(2025, 1, 1, 13, 21, 58, 570, DateTimeKind.Local).AddTicks(2807), new DateTime(2024, 12, 2, 13, 21, 58, 570, DateTimeKind.Local).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "QuoteDate" },
                values: new object[] { new DateTime(2025, 1, 1, 13, 21, 58, 570, DateTimeKind.Local).AddTicks(2829), new DateTime(2024, 12, 2, 13, 21, 58, 570, DateTimeKind.Local).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpirationDate", "QuoteDate" },
                values: new object[] { new DateTime(2025, 1, 1, 13, 21, 58, 570, DateTimeKind.Local).AddTicks(2877), new DateTime(2024, 12, 2, 13, 21, 58, 570, DateTimeKind.Local).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$Ma//srJPdT.h2us18AfJ6uWLqWWPchPxYKekmiF2qXbBae28nEOHO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$CLFuGr9/ItmSsScwzCS1XOc1xcsdYsrfggoNEPTb.KpwAIJtnLWyW");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$YFAUWCDK4oGf2Fp6Gwznt.G8IqML.2TfMi3Gdo7Uqoc/wHKD9C88q");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$HB8NZeIvqZIAzWl/qpjQOO0Q5oZSLfL76D1I846o5T8ZRhH2XyS9.");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$V1tgv6/vcaiaosWc3c2x0eGbMd3DJ0GExoHoNExrpYVsQ9xD4SP3m");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$LBJHRuWKB905n8vWgFp84ekS/8m./NITPMrCtTdtZadT.6BphDRny");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$pQa/a0GlJnY/OFaQ142Soel4a6nqtmmywe4vMqBKvBczeZDMpHJIW");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$BXWhWlPblYfbLbKmGWI8Q.Wbn8CkXh4Nk/Aimsv8hUdLR33TFGCGK");

            migrationBuilder.UpdateData(
                table: "WorkReceipts",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReceiptDate",
                value: new DateTime(2024, 12, 2, 13, 21, 57, 529, DateTimeKind.Local).AddTicks(9984));
        }
    }
}
