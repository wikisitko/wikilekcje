using Microsoft.EntityFrameworkCore.Migrations;

namespace Zadanka17_Baza.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Userzy",
                table: "Userzy");

            migrationBuilder.AlterColumn<string>(
                name: "Imie",
                table: "Userzy",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Userzy",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Userzy",
                table: "Userzy",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Userzy",
                table: "Userzy");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Userzy");

            migrationBuilder.AlterColumn<string>(
                name: "Imie",
                table: "Userzy",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Userzy",
                table: "Userzy",
                column: "Imie");
        }
    }
}
