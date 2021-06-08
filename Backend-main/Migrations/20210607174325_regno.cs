using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthDemo.Migrations
{
    public partial class regno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1b6a97e4-fc74-4e50-bfd3-8dde7b87fc95");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8b69d8ed-4b02-4736-b476-7496fb086170");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "bf97894d-1370-4259-aaa3-ecbc33c6f1c7");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "653e556b-4232-4239-9b82-bff0e263a8f9", "b243a9f7-78b1-44cb-b6ac-98b31ffb4140", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "509f44fa-24c8-4640-b651-5d4e0bd88d43", "bdc41014-6fed-42e7-b41d-60eae9c80de1", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0f28440d-2b4f-4a69-b495-5019ca273cb5", "3e8c800a-d80d-456a-bd6a-2fe38047d22d", "Lecturer", "LECTURER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0f28440d-2b4f-4a69-b495-5019ca273cb5");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "509f44fa-24c8-4640-b651-5d4e0bd88d43");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "653e556b-4232-4239-9b82-bff0e263a8f9");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf97894d-1370-4259-aaa3-ecbc33c6f1c7", "78fcdcc1-d7ab-406d-8433-b52da3af4061", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8b69d8ed-4b02-4736-b476-7496fb086170", "08abdf93-1cd3-44b8-9ff0-67f3f11dcfa2", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1b6a97e4-fc74-4e50-bfd3-8dde7b87fc95", "1df29533-cc59-4d39-b370-e54fda011fbe", "Lecturer", "LECTURER" });
        }
    }
}
