using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E3_BarrocIntens.Migrations
{
    /// <inheritdoc />
    public partial class AddedDateTimeToReceipt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ReceiptDate",
                table: "WorkReceipts",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReceiptDate",
                table: "WorkReceipts");

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 4, 30, 894, DateTimeKind.Local).AddTicks(7197), new DateTime(2024, 11, 2, 9, 4, 30, 894, DateTimeKind.Local).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 17, 9, 4, 30, 894, DateTimeKind.Local).AddTicks(7206), new DateTime(2024, 11, 17, 9, 4, 30, 894, DateTimeKind.Local).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 27, 9, 4, 30, 894, DateTimeKind.Local).AddTicks(7232), new DateTime(2024, 10, 18, 9, 4, 30, 894, DateTimeKind.Local).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 12, 9, 4, 30, 894, DateTimeKind.Local).AddTicks(7236), new DateTime(2024, 11, 12, 9, 4, 30, 894, DateTimeKind.Local).AddTicks(7235) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 22, 9, 4, 30, 894, DateTimeKind.Local).AddTicks(7244), new DateTime(2024, 11, 22, 9, 4, 30, 894, DateTimeKind.Local).AddTicks(7238) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 12, 2, 9, 4, 32, 131, DateTimeKind.Local).AddTicks(3995), new DateTime(2024, 12, 2, 9, 4, 32, 131, DateTimeKind.Local).AddTicks(3995) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 12, 2, 9, 4, 32, 131, DateTimeKind.Local).AddTicks(4092), new DateTime(2024, 12, 2, 9, 4, 32, 131, DateTimeKind.Local).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 12, 2, 9, 4, 32, 131, DateTimeKind.Local).AddTicks(4098), new DateTime(2024, 12, 2, 9, 4, 32, 131, DateTimeKind.Local).AddTicks(4098) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 12, 2, 9, 4, 32, 131, DateTimeKind.Local).AddTicks(4103), new DateTime(2024, 12, 2, 9, 4, 32, 131, DateTimeKind.Local).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "QuoteDate" },
                values: new object[] { new DateTime(2025, 1, 1, 9, 4, 32, 131, DateTimeKind.Local).AddTicks(4177), new DateTime(2024, 12, 2, 9, 4, 32, 131, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "QuoteDate" },
                values: new object[] { new DateTime(2025, 1, 1, 9, 4, 32, 131, DateTimeKind.Local).AddTicks(4212), new DateTime(2024, 12, 2, 9, 4, 32, 131, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpirationDate", "QuoteDate" },
                values: new object[] { new DateTime(2025, 1, 1, 9, 4, 32, 131, DateTimeKind.Local).AddTicks(4230), new DateTime(2024, 12, 2, 9, 4, 32, 131, DateTimeKind.Local).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$D7LUDxY5Pl5zhHyOKpeo/.6ucVZFcFf6sHpf5xj8cCxBgvxLTFS1K");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$fKcf5JqD0JjK32Cpr3SKu./kaM8H3b30d6JmUESRNlyeVkkkMEiAK");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$oMH6zYcylHf9M5lePVGEl.p50hLvwEOVybVrlptjcKeE0PWFmcLLO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$2vEVbNsqUrbZVHDVqKkPIOUFyQy/s7.cimqlyTwpkgjMYo5xED9n2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$Rqm6PBtpuvviNsC4epVIEu1m/GXkCl7YZVot8B0TSPqnWeMYeXcLW");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$NGNXLBarxfxvowcWyKR9KuWixXfZ5UuU9NH13A81tvkuAI6XFzv7G");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$npBtRIJG77AMXNUlkMKG.uCXuzKZKDVNjHcWvdP./AjwVhXyHQX7u");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$JUidKx.mUEQVwdUNXokhW.tGktcrcQYSj4ozPMdcDgUg7tGUdbnge");
        }
    }
}
