using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies.Migrations
{
    /// <inheritdoc />
    public partial class moviesv1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    movie_year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    movie_length = table.Column<int>(type: "int", nullable: false),
                    movie_title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    movie_subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    movie_actor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    movie_actress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    movie_director = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    movie_popularity = table.Column<int>(type: "int", nullable: false),
                    movie_awards = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_movies", x => x.MovieId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_movies");
        }
    }
}
