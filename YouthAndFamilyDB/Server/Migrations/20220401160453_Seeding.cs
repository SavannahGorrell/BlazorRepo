using Microsoft.EntityFrameworkCore.Migrations;

namespace YouthAndFamilyDB.Server.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teens_HouseChurches_HouseChurchId",
                table: "Teens");

            migrationBuilder.AlterColumn<int>(
                name: "HouseChurchId",
                table: "Teens",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "HouseChurches",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Kinzer" });

            migrationBuilder.InsertData(
                table: "HouseChurches",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Ammon" });

            migrationBuilder.InsertData(
                table: "HouseChurches",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Rodriguez" });

            migrationBuilder.InsertData(
                table: "Teens",
                columns: new[] { "Id", "FirstName", "GradeLevel", "HouseChurchId", "LastName" },
                values: new object[] { 2, "Damion", 4, 1, "Wayne" });

            migrationBuilder.InsertData(
                table: "Teens",
                columns: new[] { "Id", "FirstName", "GradeLevel", "HouseChurchId", "LastName" },
                values: new object[] { 1, "Peter", 3, 2, "Parker" });

            migrationBuilder.AddForeignKey(
                name: "FK_Teens_HouseChurches_HouseChurchId",
                table: "Teens",
                column: "HouseChurchId",
                principalTable: "HouseChurches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teens_HouseChurches_HouseChurchId",
                table: "Teens");

            migrationBuilder.DeleteData(
                table: "HouseChurches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teens",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teens",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HouseChurches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HouseChurches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "HouseChurchId",
                table: "Teens",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Teens_HouseChurches_HouseChurchId",
                table: "Teens",
                column: "HouseChurchId",
                principalTable: "HouseChurches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
