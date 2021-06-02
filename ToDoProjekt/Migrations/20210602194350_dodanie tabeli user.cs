using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoProjekt.Migrations
{
    public partial class dodanietabeliuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Zadania",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Haslo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zadania_UserId",
                table: "Zadania",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Zadania_User_UserId",
                table: "Zadania",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zadania_User_UserId",
                table: "Zadania");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_Zadania_UserId",
                table: "Zadania");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Zadania");
        }
    }
}
