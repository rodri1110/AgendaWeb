using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendaWeb.Migrations
{
    public partial class CódigoDeÁrea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodArea",
                table: "Contato");

            migrationBuilder.AlterColumn<long>(
                name: "Telefone",
                table: "Contato",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Telefone",
                table: "Contato",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<int>(
                name: "CodArea",
                table: "Contato",
                nullable: false,
                defaultValue: 0);
        }
    }
}
