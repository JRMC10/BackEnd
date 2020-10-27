using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class inicialDos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaExp",
                table: "TarjetaCredito");

            migrationBuilder.AddColumn<string>(
                name: "FechaExpiracion",
                table: "TarjetaCredito",
                type: "varchar(5)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaExpiracion",
                table: "TarjetaCredito");

            migrationBuilder.AddColumn<string>(
                name: "FechaExp",
                table: "TarjetaCredito",
                type: "varchar(10)",
                nullable: false,
                defaultValue: "");
        }
    }
}
