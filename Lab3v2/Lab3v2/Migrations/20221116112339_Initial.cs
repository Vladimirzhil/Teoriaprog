using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab3v2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Workcatalogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workcatalogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Typeofworks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_number = table.Column<int>(type: "int", nullable: false),
                    Job_line_number = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Job_id = table.Column<int>(type: "int", nullable: false),
                    workcatalogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Typeofworks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Typeofworks_Workcatalogs_workcatalogId",
                        column: x => x.workcatalogId,
                        principalTable: "Workcatalogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Typeofworks_workcatalogId",
                table: "Typeofworks",
                column: "workcatalogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Typeofworks");

            migrationBuilder.DropTable(
                name: "Workcatalogs");
        }
    }
}
