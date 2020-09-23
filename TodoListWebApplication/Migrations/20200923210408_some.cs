using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoListWebApplication.Migrations
{
    public partial class some : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isComplated",
                schema: "Task",
                table: "Todos");

            migrationBuilder.AddColumn<bool>(
                name: "isCompleted",
                schema: "Task",
                table: "Todos",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isCompleted",
                schema: "Task",
                table: "Todos");

            migrationBuilder.AddColumn<bool>(
                name: "isComplated",
                schema: "Task",
                table: "Todos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
