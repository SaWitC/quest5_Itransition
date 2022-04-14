using Microsoft.EntityFrameworkCore.Migrations;

namespace MyVkQuest5.Migrations
{
    public partial class updatechtModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreaterUserNAme",
                table: "Chats",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "interlocutorrUserNAme",
                table: "Chats",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreaterUserNAme",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "interlocutorrUserNAme",
                table: "Chats");
        }
    }
}
