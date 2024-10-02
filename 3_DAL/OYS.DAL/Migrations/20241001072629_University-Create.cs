using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OYS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UniversityCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "universities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_universities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_universities_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Faculties_CityId",
                table: "Faculties",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_universities_CityId",
                table: "universities",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Faculties_Cities_CityId",
                table: "Faculties",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faculties_Cities_CityId",
                table: "Faculties");

            migrationBuilder.DropTable(
                name: "universities");

            migrationBuilder.DropIndex(
                name: "IX_Faculties_CityId",
                table: "Faculties");
        }
    }
}
