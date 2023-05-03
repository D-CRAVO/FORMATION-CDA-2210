using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Legumos.Migrations
{
    /// <inheritdoc />
    public partial class vegetablesv1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_vegetables",
                columns: table => new
                {
                    VegetableId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Variety = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lifetime = table.Column<int>(type: "int", nullable: false),
                    Fresh = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_vegetables", x => x.VegetableId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_vegetables");
        }
    }
}
