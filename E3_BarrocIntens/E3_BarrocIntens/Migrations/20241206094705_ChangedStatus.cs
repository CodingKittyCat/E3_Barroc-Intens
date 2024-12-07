using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E3_BarrocIntens.Migrations
{
    /// <inheritdoc />
    public partial class ChangedStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Status",
                keyValue: null,
                column: "Status",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Products",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 26, 10, 47, 3, 492, DateTimeKind.Local).AddTicks(1961), new DateTime(2024, 11, 6, 10, 47, 3, 492, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 21, 10, 47, 3, 492, DateTimeKind.Local).AddTicks(1975), new DateTime(2024, 11, 21, 10, 47, 3, 492, DateTimeKind.Local).AddTicks(1973) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 1, 10, 47, 3, 492, DateTimeKind.Local).AddTicks(2005), new DateTime(2024, 10, 22, 10, 47, 3, 492, DateTimeKind.Local).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 16, 10, 47, 3, 492, DateTimeKind.Local).AddTicks(2008), new DateTime(2024, 11, 16, 10, 47, 3, 492, DateTimeKind.Local).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 47, 3, 492, DateTimeKind.Local).AddTicks(2014), new DateTime(2024, 11, 26, 10, 47, 3, 492, DateTimeKind.Local).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 12, 6, 10, 47, 4, 433, DateTimeKind.Local).AddTicks(6250), new DateTime(2024, 12, 6, 10, 47, 4, 433, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 12, 6, 10, 47, 4, 433, DateTimeKind.Local).AddTicks(6335), new DateTime(2024, 12, 6, 10, 47, 4, 433, DateTimeKind.Local).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 12, 6, 10, 47, 4, 433, DateTimeKind.Local).AddTicks(6339), new DateTime(2024, 12, 6, 10, 47, 4, 433, DateTimeKind.Local).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "LeaseContracts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date_Created", "End_Date" },
                values: new object[] { new DateTime(2024, 12, 6, 10, 47, 4, 433, DateTimeKind.Local).AddTicks(6342), new DateTime(2024, 12, 6, 10, 47, 4, 433, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: "InStock");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: "OutOfStock");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Status",
                value: "InStock");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "QuoteDate" },
                values: new object[] { new DateTime(2025, 1, 5, 10, 47, 4, 433, DateTimeKind.Local).AddTicks(6453), new DateTime(2024, 12, 6, 10, 47, 4, 433, DateTimeKind.Local).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "QuoteDate" },
                values: new object[] { new DateTime(2025, 1, 5, 10, 47, 4, 433, DateTimeKind.Local).AddTicks(6479), new DateTime(2024, 12, 6, 10, 47, 4, 433, DateTimeKind.Local).AddTicks(6477) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpirationDate", "QuoteDate" },
                values: new object[] { new DateTime(2025, 1, 5, 10, 47, 4, 433, DateTimeKind.Local).AddTicks(6528), new DateTime(2024, 12, 6, 10, 47, 4, 433, DateTimeKind.Local).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$aj8Fw1WlTKYevK4g/bflo.40SQM4H/7wTRQZ.uWTRpkU7qJ51Wxz6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$saGfccQEFiR3liEwBn8gb.3rGOr6YcCtLQWXXerrO9cdv6xMheMVG");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$72Ph5uaggyhIsnhVz4hlyes5PoZNBpaFpLk4FNUGtDTnwsBcK1yWW");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$OV9nfT6lk7cM3ENLG5rayuxJBsndnbK71bYuXm1UQkV7fk5P.Q0Oy");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$WtKZmy0rW.OshC.Dxekbsuid5jWJpY7FCIYlErjPSGxtpCmlM/CQu");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$eROAbdyfQqF1t2/gXTpDOO.F2XcbBz7IeNR6eRlzkA6Uu3JiIlCuC");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$j5.OCEwCLd6Zs7T0Qwz4TOL8QSwJzhIkH8vXuotr8PAprq2Ek2DzS");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$PXxlxHPTZxdTUpvfZoXrruJiY9T4aVSmGF.xZtyqCF0GN3fXsvLCy");

            migrationBuilder.UpdateData(
                table: "WorkReceipts",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReceiptDate",
                value: new DateTime(2024, 12, 6, 10, 47, 3, 492, DateTimeKind.Local).AddTicks(1673));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Products",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: "Delivered");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: "On The Way");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Status",
                value: "Pending");

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
    }
}
