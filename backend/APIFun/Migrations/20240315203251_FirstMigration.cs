using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIFun.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bowlers",
                columns: table => new
                {
                    BowlerID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BowlerLastName = table.Column<string>(type: "TEXT", nullable: true),
                    BowlerFirstName = table.Column<string>(type: "TEXT", nullable: true),
                    BowlerMiddleInit = table.Column<string>(type: "TEXT", nullable: true),
                    BowlerAddress = table.Column<string>(type: "TEXT", nullable: true),
                    BowlerCity = table.Column<string>(type: "TEXT", nullable: true),
                    BowlerState = table.Column<string>(type: "TEXT", nullable: true),
                    BowlerZip = table.Column<int>(type: "INTEGER", nullable: true),
                    BowlerPhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    TeamName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bowlers", x => x.BowlerID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bowlers");
        }
    }
}
