using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthDemo.Migrations
{
    public partial class reqiredfeilds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "4da7ea5f-accb-4588-a5b3-f711793c6593");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9d559a48-0a47-4598-964a-47b3575d8ad1");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "dddd9185-a98a-4896-9aab-37c4e8b3a576");

            migrationBuilder.AlterColumn<string>(
                name: "LOID",
                table: "AsComponents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ascomponent",
                table: "AsComponents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "LOID",
                table: "AsComponents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Ascomponent",
                table: "AsComponents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d559a48-0a47-4598-964a-47b3575d8ad1", "78af510f-b62c-438c-a8e1-b66c0aa21e60", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4da7ea5f-accb-4588-a5b3-f711793c6593", "2b5dc1f9-78c7-4392-aec7-230f60387b96", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dddd9185-a98a-4896-9aab-37c4e8b3a576", "f4d1876b-4a46-4ae0-a5ed-b2b197523e14", "Lecturer", "LECTURER" });
        }
    }
}
