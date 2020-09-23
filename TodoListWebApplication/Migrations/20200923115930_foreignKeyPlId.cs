using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoListWebApplication.Migrations
{
    public partial class foreignKeyPlId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "Task",
                table: "Todos",
                nullable: false,
                defaultValueSql: "DATEADD(HOUR,4,getutcdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "PlId",
                schema: "Task",
                table: "Todos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Todos_PlId",
                schema: "Task",
                table: "Todos",
                column: "PlId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_langugaes_PlId",
                schema: "Task",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Todos_PlId",
                schema: "Task",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "PlId",
                schema: "Task",
                table: "Todos");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "Task",
                table: "Todos",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "DATEADD(HOUR,4,getutcdate())");
        }
    }
}
