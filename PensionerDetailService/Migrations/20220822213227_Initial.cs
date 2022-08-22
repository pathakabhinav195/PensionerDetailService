using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PensionerDetailService.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pensioners",
                columns: table => new
                {
                    Aadhar = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    PAN = table.Column<string>(nullable: true),
                    SalaryEarned = table.Column<decimal>(nullable: false),
                    Allowances = table.Column<decimal>(nullable: false),
                    PensionType = table.Column<int>(nullable: false),
                    BankName = table.Column<string>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true),
                    BankType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pensioners", x => x.Aadhar);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pensioners");
        }
    }
}
