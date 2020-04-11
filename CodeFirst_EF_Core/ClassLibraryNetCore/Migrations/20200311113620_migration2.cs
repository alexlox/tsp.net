using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibraryNetCore.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_People_PeopleId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PeopleId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PeopleId",
                table: "Orders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PeopleId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PeopleId",
                table: "Orders",
                column: "PeopleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_People_PeopleId",
                table: "Orders",
                column: "PeopleId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
