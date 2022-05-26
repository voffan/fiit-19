using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SiliconValley.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(maxLength: 255, nullable: true),
                    Password = table.Column<string>(maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 11, nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    Education = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Placements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: true),
                    Start = table.Column<DateTime>(nullable: true),
                    End = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Placements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    PlacementId = table.Column<int>(nullable: true),
                    GenreId = table.Column<int>(nullable: true),
                    ArtistId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pictures_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Pictures_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Pictures_Placements_PlacementId",
                        column: x => x.PlacementId,
                        principalTable: "Placements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Journals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    PictureId = table.Column<int>(nullable: false),
                    FromID = table.Column<int>(nullable: true),
                    ToID = table.Column<int>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Journals_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Journals_Placements_FromID",
                        column: x => x.FromID,
                        principalTable: "Placements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull
                        );
                    table.ForeignKey(
                        name: "FK_Journals_Pictures_PictureId",
                        column: x => x.PictureId,
                        principalTable: "Pictures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                        );
                    table.ForeignKey(
                        name: "FK_Journals_Placements_ToID",
                        column: x => x.ToID,
                        principalTable: "Placements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction
                        );
                });

            migrationBuilder.CreateIndex(
                name: "IX_Journals_EmployeeId",
                table: "Journals",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Journals_FromID",
                table: "Journals",
                column: "FromID");

            migrationBuilder.CreateIndex(
                name: "IX_Journals_PictureId",
                table: "Journals",
                column: "PictureId");

            migrationBuilder.CreateIndex(
                name: "IX_Journals_ToID",
                table: "Journals",
                column: "ToID");

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_ArtistId",
                table: "Pictures",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_GenreId",
                table: "Pictures",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_PlacementId",
                table: "Pictures",
                column: "PlacementId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Journals");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Placements");
        }
    }
}
