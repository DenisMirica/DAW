using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAW.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eveniment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Participanti = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Organizatori = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specatatori = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Evenimente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eveniment", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eveniment");
        }
    }
}
