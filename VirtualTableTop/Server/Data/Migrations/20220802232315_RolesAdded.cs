using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VirtualTableTop.Server.Data.Migrations
{
    public partial class RolesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0fb48dbd-83a9-4582-a88b-2e47d25f67df", "c48574c0-3cd6-44ff-8c6c-675e3e5124ce", "DungeonMaster", "DUNGEONMASTER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "31597860-42e3-4bb0-8a61-3b1d1931d9cc", "5ca182d3-8b8a-40a5-99cb-e18343c61ba2", "Player", "PLAYER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "baec2253-4ea1-49b1-8c82-bc0a1a7beeb6", "7b7b8be0-2303-4886-b9b6-c1f6a71f58a5", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fb48dbd-83a9-4582-a88b-2e47d25f67df");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31597860-42e3-4bb0-8a61-3b1d1931d9cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "baec2253-4ea1-49b1-8c82-bc0a1a7beeb6");
        }
    }
}
