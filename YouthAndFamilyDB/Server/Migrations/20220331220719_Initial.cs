using Microsoft.EntityFrameworkCore.Migrations;

namespace YouthAndFamilyDB.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HouseChurches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseChurches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradeLevel = table.Column<int>(type: "int", nullable: false),
                    HouseChurchId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teens_HouseChurches_HouseChurchId",
                        column: x => x.HouseChurchId,
                        principalTable: "HouseChurches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teens_HouseChurchId",
                table: "Teens",
                column: "HouseChurchId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teens");

            migrationBuilder.DropTable(
                name: "HouseChurches");
        }
    }
}
