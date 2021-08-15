using Microsoft.EntityFrameworkCore.Migrations;

namespace Gigster.Migrations
{
    public partial class PopulateGenreTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Jazz')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Blues')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Classical')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Country')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Dance')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Drill')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'Drum and Bass')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Dubstep')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (9, 'Funk')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (10, 'Folk')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (11, 'Garage')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (12, 'Grunge')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (13, 'Grime')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (14, 'Hiphop')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (15, 'Indie')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (16, 'Metal')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (17, 'Motown')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (18, 'Reggae')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (19, 'Disco')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (20, 'Pop Rock')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (21, 'Instrumental')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (22, 'Orchestra')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (23, 'Opera')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (24, 'Indie')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (25, 'Dubstep')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Genres WHERE ID IN (1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25)");
        }
    }
}
