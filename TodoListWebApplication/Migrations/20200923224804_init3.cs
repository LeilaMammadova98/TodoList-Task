﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoListWebApplication.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Task");

            migrationBuilder.CreateTable(
                name: "ProgrammingLanguages",
                schema: "Task",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammingLanguages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Todos",
                schema: "Task",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    ResponsiblePerson = table.Column<string>(nullable: true),
                    isCompleted = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "DATEADD(HOUR,4,getutcdate())"),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: true),
                    PlId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Todos_ProgrammingLanguages_PlId",
                        column: x => x.PlId,
                        principalSchema: "Task",
                        principalTable: "ProgrammingLanguages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_PlId",
                schema: "Task",
                table: "Todos",
                column: "PlId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todos",
                schema: "Task");

            migrationBuilder.DropTable(
                name: "ProgrammingLanguages",
                schema: "Task");
        }
    }
}
