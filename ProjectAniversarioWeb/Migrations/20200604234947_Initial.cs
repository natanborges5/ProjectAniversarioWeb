using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectAniversarioWeb.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aniversariante",
                columns: table => new
                {
                    primeiroNome = table.Column<string>(nullable: false),
                    segundoNome = table.Column<string>(nullable: true),
                    dataAniversario = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aniversariante", x => x.primeiroNome);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aniversariante");
        }
    }
}
