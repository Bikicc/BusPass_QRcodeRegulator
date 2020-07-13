using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusPass.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Months",
                columns: table => new
                {
                    MonthId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Months", x => x.MonthId);
                });

            migrationBuilder.CreateTable(
                name: "PassTypes",
                columns: table => new
                {
                    PassTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassTypes", x => x.PassTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    OIB = table.Column<string>(maxLength: 11, nullable: false),
                    Role = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IBAN = table.Column<string>(maxLength: 21, nullable: false),
                    Balance = table.Column<double>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_Accounts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BusPasses",
                columns: table => new
                {
                    BusPassportId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Valid = table.Column<bool>(nullable: false),
                    DateOfIssue = table.Column<DateTime>(nullable: false),
                    PassTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusPasses", x => x.BusPassportId);
                    table.ForeignKey(
                        name: "FK_BusPasses_PassTypes_PassTypeId",
                        column: x => x.PassTypeId,
                        principalTable: "PassTypes",
                        principalColumn: "PassTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusPasses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BusPassPayments",
                columns: table => new
                {
                    BusPassPaymentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfPayment = table.Column<DateTime>(nullable: false),
                    BusPassportId = table.Column<int>(nullable: false),
                    MonthId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusPassPayments", x => x.BusPassPaymentId);
                    table.ForeignKey(
                        name: "FK_BusPassPayments_BusPasses_BusPassportId",
                        column: x => x.BusPassportId,
                        principalTable: "BusPasses",
                        principalColumn: "BusPassportId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusPassPayments_Months_MonthId",
                        column: x => x.MonthId,
                        principalTable: "Months",
                        principalColumn: "MonthId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_UserId",
                table: "Accounts",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BusPasses_PassTypeId",
                table: "BusPasses",
                column: "PassTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BusPasses_UserId",
                table: "BusPasses",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BusPassPayments_BusPassportId",
                table: "BusPassPayments",
                column: "BusPassportId");

            migrationBuilder.CreateIndex(
                name: "IX_BusPassPayments_MonthId",
                table: "BusPassPayments",
                column: "MonthId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "BusPassPayments");

            migrationBuilder.DropTable(
                name: "BusPasses");

            migrationBuilder.DropTable(
                name: "Months");

            migrationBuilder.DropTable(
                name: "PassTypes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
