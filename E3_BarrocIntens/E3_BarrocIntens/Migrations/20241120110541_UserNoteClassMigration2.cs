using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E3_BarrocIntens.Migrations
{
    /// <inheritdoc />
    public partial class UserNoteClassMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Note = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserNotes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 5, 40, 309, DateTimeKind.Local).AddTicks(7081), new DateTime(2024, 10, 21, 12, 5, 40, 309, DateTimeKind.Local).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 5, 12, 5, 40, 309, DateTimeKind.Local).AddTicks(7097), new DateTime(2024, 11, 5, 12, 5, 40, 309, DateTimeKind.Local).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 15, 12, 5, 40, 309, DateTimeKind.Local).AddTicks(7103), new DateTime(2024, 10, 6, 12, 5, 40, 309, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 30, 12, 5, 40, 309, DateTimeKind.Local).AddTicks(7119), new DateTime(2024, 10, 31, 12, 5, 40, 309, DateTimeKind.Local).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 10, 12, 5, 40, 309, DateTimeKind.Local).AddTicks(7131), new DateTime(2024, 11, 10, 12, 5, 40, 309, DateTimeKind.Local).AddTicks(7128) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$0qUE7A0W8qjcPkqMuxw4guF2IAtkfecu88AGzWeRUIgCLHASqCwNO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$F9rehGJB1lvJGYQBmH.yR.8CYRu5bgkqCKrAr/DNLlCy4Qdv7p70K");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$vxv.5lREBT5HIh1to1Q6zeWqAq/0aFJPLG9piGYzDtKyOvZDnU62i");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$2AsFodSR3wm.vIK6jb9XruQ.rgwY0fi5tul0XFLScLGRkSk62v.bq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$kQGPU4TSzmzolMzhi9dlpOLRH4LXWTSbcWdR0EePmxXJQEANg83KS");

            migrationBuilder.CreateIndex(
                name: "IX_UserNotes_UserId",
                table: "UserNotes",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserNotes");

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 1, 27, 921, DateTimeKind.Local).AddTicks(9603), new DateTime(2024, 10, 21, 12, 1, 27, 921, DateTimeKind.Local).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 5, 12, 1, 27, 921, DateTimeKind.Local).AddTicks(9617), new DateTime(2024, 11, 5, 12, 1, 27, 921, DateTimeKind.Local).AddTicks(9615) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 15, 12, 1, 27, 921, DateTimeKind.Local).AddTicks(9621), new DateTime(2024, 10, 6, 12, 1, 27, 921, DateTimeKind.Local).AddTicks(9619) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 11, 30, 12, 1, 27, 921, DateTimeKind.Local).AddTicks(9632), new DateTime(2024, 10, 31, 12, 1, 27, 921, DateTimeKind.Local).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "InvoiceDate" },
                values: new object[] { new DateTime(2024, 12, 10, 12, 1, 27, 921, DateTimeKind.Local).AddTicks(9641), new DateTime(2024, 11, 10, 12, 1, 27, 921, DateTimeKind.Local).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$zLRcjmyyHMqszhgJc5P8Ru6lKD1ZTZQpYFIbtYVmMFa0sVtxR98mi");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$w9sFHW65SNQVUkLaFqVUaeIRSXdOhxQmIJGdsWx6gEVij1fcG1hva");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$3ESM0XUF.SmJLBBf9jZW3.RRGrTYicjeaQOr/N1UsaWwiiioV.FDa");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$JPcZWUnRdfMztsk744TVuOvZhXXfnwrnKZ2fE223UivbvJhF3uGrG");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$uFjG/oKaEa9.gyFaFoQwSe.qEV/ohS.Nw.eOquQ3Nx55ipumpyN5W");
        }
    }
}
