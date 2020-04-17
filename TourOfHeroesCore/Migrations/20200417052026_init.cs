using Microsoft.EntityFrameworkCore.Migrations;

namespace TourOfHeroesCore.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hero",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hero", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Hero",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Mr. Nice" });

            migrationBuilder.InsertData(
                table: "Hero",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Narco" });

            migrationBuilder.InsertData(
                table: "Hero",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Bombasto" });

            migrationBuilder.InsertData(
                table: "Hero",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Celeritas" });

            migrationBuilder.InsertData(
                table: "Hero",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Magneta" });

            migrationBuilder.InsertData(
                table: "Hero",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "RubberMan" });

            migrationBuilder.InsertData(
                table: "Hero",
                columns: new[] { "Id", "Name" },
                values: new object[] { 7, "Dynama" });

            migrationBuilder.InsertData(
                table: "Hero",
                columns: new[] { "Id", "Name" },
                values: new object[] { 8, "Dr IQ" });

            migrationBuilder.InsertData(
                table: "Hero",
                columns: new[] { "Id", "Name" },
                values: new object[] { 9, "Magma" });

            migrationBuilder.InsertData(
                table: "Hero",
                columns: new[] { "Id", "Name" },
                values: new object[] { 10, "Tornado" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hero");
        }
    }
}
