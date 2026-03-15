using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LuckyLottery.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EuroMillionenAtDraws",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrawDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    N1 = table.Column<int>(type: "int", nullable: false),
                    N2 = table.Column<int>(type: "int", nullable: false),
                    N3 = table.Column<int>(type: "int", nullable: false),
                    N4 = table.Column<int>(type: "int", nullable: false),
                    N5 = table.Column<int>(type: "int", nullable: false),
                    Star1 = table.Column<int>(type: "int", nullable: false),
                    Star2 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EuroMillionenAtDraws", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EuroMillionenAtPlayedCombinations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatePlayed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    N1 = table.Column<int>(type: "int", nullable: false),
                    N2 = table.Column<int>(type: "int", nullable: false),
                    N3 = table.Column<int>(type: "int", nullable: false),
                    N4 = table.Column<int>(type: "int", nullable: false),
                    N5 = table.Column<int>(type: "int", nullable: false),
                    Star1 = table.Column<int>(type: "int", nullable: false),
                    Star2 = table.Column<int>(type: "int", nullable: false),
                    Matches = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EuroMillionenAtPlayedCombinations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LottoAtDraws",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrawDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    N1 = table.Column<int>(type: "int", nullable: false),
                    N2 = table.Column<int>(type: "int", nullable: false),
                    N3 = table.Column<int>(type: "int", nullable: false),
                    N4 = table.Column<int>(type: "int", nullable: false),
                    N5 = table.Column<int>(type: "int", nullable: false),
                    N6 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LottoAtDraws", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LottoAtPlayedCombinations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatePlayed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    N1 = table.Column<int>(type: "int", nullable: false),
                    N2 = table.Column<int>(type: "int", nullable: false),
                    N3 = table.Column<int>(type: "int", nullable: false),
                    N4 = table.Column<int>(type: "int", nullable: false),
                    N5 = table.Column<int>(type: "int", nullable: false),
                    N6 = table.Column<int>(type: "int", nullable: false),
                    Matches = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LottoAtPlayedCombinations", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EuroMillionenAtDraws");

            migrationBuilder.DropTable(
                name: "EuroMillionenAtPlayedCombinations");

            migrationBuilder.DropTable(
                name: "LottoAtDraws");

            migrationBuilder.DropTable(
                name: "LottoAtPlayedCombinations");
        }
    }
}
