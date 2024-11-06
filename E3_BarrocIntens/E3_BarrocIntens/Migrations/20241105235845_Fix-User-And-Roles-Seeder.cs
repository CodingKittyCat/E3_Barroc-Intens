using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E3_BarrocIntens.Migrations
{
    /// <inheritdoc />
    public partial class FixUserAndRolesSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Password", "RoleId" },
                values: new object[] { "$2a$11$rd9x5Ac0kUFdOKvuh4.ejuJg297.ReVKgqT2TpgRZ01ADA/w2O1Wy", 4 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$iBHJpoNWKELwgb5sQZffSuiLvX6/KxBbnL7G7cFDqcv5LNWrFGjE.");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$Wxz5fVfi6cfzXo2cfWrGf.Ypu.9zMa.U7WPeXTIZDxav20cNIsmHm");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Password", "RoleId" },
                values: new object[] { "$2a$11$kVGJSsjeNLnDZO1B30N37.prJg/4jErd7pUk8dhog5wqr3wo8a/uW", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Password", "RoleId" },
                values: new object[] { "$2a$11$5aWxXQktGeJUlvpXcCyuYOHEZQb8ortPq7.LJK6i3doS8sqZ3Oa5e", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$p5T2irAsjVaD3roSZk5Gd.SVKbRac9fWDIkEhAHyfew9G21gBNWd.");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$e3WAsZqK8Ah6Xvs4wno9Xe5zIux18wfWS76EpJo8ocUjzKLTwGMkK");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Password", "RoleId" },
                values: new object[] { "$2a$11$MFLkMDvJZZIUQ7ErTW4ceOO63sREAfRsUeeEJKG.0ZT4.2eaR3u9q", 3 });
        }
    }
}
