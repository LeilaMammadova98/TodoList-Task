using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoListWebApplication.Migrations
{
    public partial class Todo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_langugaes_PlId",
                schema: "Task",
                table: "Todos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_langugaes",
                schema: "Task",
                table: "langugaes");

            migrationBuilder.RenameTable(
                name: "langugaes",
                schema: "Task",
                newName: "ProgrammeLanguages",
                newSchema: "Task");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProgrammeLanguages",
                schema: "Task",
                table: "ProgrammeLanguages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_ProgrammeLanguages_PlId",
                schema: "Task",
                table: "Todos",
                column: "PlId",
                principalSchema: "Task",
                principalTable: "ProgrammeLanguages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_ProgrammeLanguages_PlId",
                schema: "Task",
                table: "Todos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProgrammeLanguages",
                schema: "Task",
                table: "ProgrammeLanguages");

            migrationBuilder.RenameTable(
                name: "ProgrammeLanguages",
                schema: "Task",
                newName: "langugaes",
                newSchema: "Task");

            migrationBuilder.AddPrimaryKey(
                name: "PK_langugaes",
                schema: "Task",
                table: "langugaes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_langugaes_PlId",
                schema: "Task",
                table: "Todos",
                column: "PlId",
                principalSchema: "Task",
                principalTable: "langugaes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
