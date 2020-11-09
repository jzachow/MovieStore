using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieStore.Data.Migrations
{
    public partial class CreateAndSeedMovieTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    ActorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.ActorId);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    DirectorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.DirectorId);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Genre = table.Column<string>(maxLength: 20, nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Runtime = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "ActorMovies",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false),
                    ActorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorMovies", x => new { x.ActorId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_ActorMovies_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "ActorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorMovies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DirectorMovies",
                columns: table => new
                {
                    DirectorId = table.Column<int>(nullable: false),
                    MovieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectorMovies", x => new { x.MovieId, x.DirectorId });
                    table.ForeignKey(
                        name: "FK_DirectorMovies_Directors_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Directors",
                        principalColumn: "DirectorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DirectorMovies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Morgan", "Freeman" },
                    { 18, "Leonardo", "DiCaprio" },
                    { 17, "Jamie", "Foxx" },
                    { 16, "Joaquin", "Phoenix" },
                    { 15, "Russel", "Crowe" },
                    { 14, "Miyu", "Irino" },
                    { 13, "Rumi", "Hiiragi" },
                    { 12, "Sergi", "Lopez" },
                    { 11, "Ivana", "Baquero" },
                    { 19, "Joseph", "Gordon-Levitt" },
                    { 9, "Al", "Pacino" },
                    { 8, "Marlon", "Brando" },
                    { 7, "Anthony", "Hopkins" },
                    { 6, "Jodie", "Foster" },
                    { 5, "Brad", "Pitt" },
                    { 4, "Kevin", "Spacey" },
                    { 3, "Bob", "Gunton" },
                    { 2, "Tim", "Robbins" },
                    { 10, "Christopher", "Waltz" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "DirectorId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 9, "Christopher", "Nolan" },
                    { 8, "Ridley", "Scott" },
                    { 7, "Hayao", "Miyazaki" },
                    { 6, "Guillermo", "del Toro" },
                    { 5, "Quentin", "Tarantino" },
                    { 3, "Jonathan", "Demme" },
                    { 2, "David", "Fincher" },
                    { 1, "Frank", "Darabont" },
                    { 4, "Francis", "Coppola" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Genre", "Runtime", "Title", "Year" },
                values: new object[,]
                {
                    { 9, "Western", 165.0, "Django Unchained", 2012 },
                    { 1, "Drama", 144.0, "The Shawshank Redemption", 1994 },
                    { 2, "Mystery", 127.0, "Se7en", 1995 },
                    { 3, "Thriller", 118.0, "The Silence of the Lambs", 1991 },
                    { 4, "Crime", 175.0, "The Godfather", 1972 },
                    { 5, "Adventure", 153.0, "Inglourious Basterds", 2009 },
                    { 6, "Fantasy", 118.0, "Pan's Labyrinth", 2006 },
                    { 7, "Animation", 125.0, "Spirited Away", 2001 },
                    { 8, "Action", 155.0, "Gladiator", 2000 },
                    { 10, "Sci-Fi", 148.0, "Inception", 2010 }
                });

            migrationBuilder.InsertData(
                table: "ActorMovies",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 13, 7 },
                    { 14, 7 },
                    { 18, 9 },
                    { 12, 6 },
                    { 11, 6 },
                    { 19, 10 },
                    { 10, 5 },
                    { 5, 5 },
                    { 17, 9 },
                    { 15, 8 },
                    { 9, 4 },
                    { 10, 9 },
                    { 7, 3 },
                    { 6, 3 },
                    { 5, 2 },
                    { 4, 2 },
                    { 1, 2 },
                    { 18, 10 },
                    { 2, 1 },
                    { 3, 1 },
                    { 8, 4 },
                    { 16, 8 }
                });

            migrationBuilder.InsertData(
                table: "DirectorMovies",
                columns: new[] { "MovieId", "DirectorId" },
                values: new object[,]
                {
                    { 9, 5 },
                    { 8, 8 },
                    { 5, 5 },
                    { 6, 6 },
                    { 4, 4 },
                    { 3, 3 },
                    { 2, 2 },
                    { 1, 1 },
                    { 7, 7 },
                    { 10, 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovies_MovieId",
                table: "ActorMovies",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_DirectorMovies_DirectorId",
                table: "DirectorMovies",
                column: "DirectorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorMovies");

            migrationBuilder.DropTable(
                name: "DirectorMovies");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
