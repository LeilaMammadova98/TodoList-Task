using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoListWebApplication.Migrations
{
    public partial class createlanguages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Task");

            migrationBuilder.CreateTable(
                name: "langugaes",
                schema: "Task",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_langugaes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "langugaes",
                schema: "Task");
        }
    }
}
