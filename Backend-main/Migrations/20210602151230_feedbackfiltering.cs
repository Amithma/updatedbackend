using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthDemo.Migrations
{
    public partial class feedbackfiltering : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "cc53340a-814a-4f04-8c22-ca63b8f07fd6");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "cd219a5e-6106-45d0-ad00-1339e8b3879a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d02e8529-f7da-4821-b088-3ca61ad7ff2c");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11c14d8c-f5d8-484b-a7b4-4156af015eaa", "07360954-ba03-45d2-9da2-9d3ee8a1286a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "89b38869-e36b-495e-a285-0089bdca87ea", "87844b03-ef3a-4cc5-bf77-41ddcd59992c", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a3183908-a9fa-4ad3-9303-2870385bc48d", "4e646401-528b-4a43-bcd4-e7793ff0b925", "Lecturer", "LECTURER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "11c14d8c-f5d8-484b-a7b4-4156af015eaa");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "89b38869-e36b-495e-a285-0089bdca87ea");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a3183908-a9fa-4ad3-9303-2870385bc48d");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d02e8529-f7da-4821-b088-3ca61ad7ff2c", "54489616-1de8-4079-b411-6bed4accb936", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd219a5e-6106-45d0-ad00-1339e8b3879a", "3e4b9f3a-d1aa-4aae-a85f-6f19f88cc92e", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cc53340a-814a-4f04-8c22-ca63b8f07fd6", "e05c6693-3b34-4ce2-88b4-c719654f2240", "Lecturer", "LECTURER" });
        }
    }
}
