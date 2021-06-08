using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthDemo.Migrations
{
    public partial class cros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "2a517dcc-7c4e-4940-baf5-619d6727b279", "ec3e6928-183f-4f22-894f-2aecccb4c0b3", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "175c732b-204a-4583-860d-44e80c84dd73", "894e5526-ab08-4b56-91f0-996b2908769c", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "51eecfae-8048-4971-acf4-5c4b96e75771", "1587115c-1d39-47c8-b2bc-dbefb7916e42", "Lecturer", "LECTURER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "175c732b-204a-4583-860d-44e80c84dd73");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2a517dcc-7c4e-4940-baf5-619d6727b279");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "51eecfae-8048-4971-acf4-5c4b96e75771");

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
    }
}
