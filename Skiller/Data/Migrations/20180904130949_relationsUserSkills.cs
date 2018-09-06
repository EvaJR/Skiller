using Microsoft.EntityFrameworkCore.Migrations;

namespace Skiller.Data.Migrations
{
    public partial class relationsUserSkills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserAccountId",
                table: "Skill",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skill_UserAccountId",
                table: "Skill",
                column: "UserAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skill_AspNetUsers_UserAccountId",
                table: "Skill",
                column: "UserAccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skill_AspNetUsers_UserAccountId",
                table: "Skill");

            migrationBuilder.DropIndex(
                name: "IX_Skill_UserAccountId",
                table: "Skill");

            migrationBuilder.DropColumn(
                name: "UserAccountId",
                table: "Skill");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AspNetUsers");
        }
    }
}
