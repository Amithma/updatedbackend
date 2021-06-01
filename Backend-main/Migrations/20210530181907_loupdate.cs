using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthDemo.Migrations
{
    public partial class loupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9dda72b3-1c21-4879-986b-967fd864601f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a2ee505c-4835-47fb-98e3-5913677d2f2e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b195a05f-048b-48f9-bdc9-8f5f76af8ac5");

            migrationBuilder.AddColumn<string>(
                name: "p1",
                table: "LOs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "p10",
                table: "LOs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "p11",
                table: "LOs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "p12",
                table: "LOs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "p2",
                table: "LOs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "p3",
                table: "LOs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "p4",
                table: "LOs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "p5",
                table: "LOs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "p6",
                table: "LOs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "p7",
                table: "LOs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "p8",
                table: "LOs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "p9",
                table: "LOs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "638615da-9cf2-4466-92e9-16c643df7575", "3a2908aa-d63d-40a9-aaf0-75164fe65449", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f91cf5ee-c529-4863-8455-b61371ac356c", "b988c89a-acd1-44cb-b0bf-35966db35d4b", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f5c739ea-6760-4f2a-9559-ae9273d17a02", "0b4acb2f-e806-468d-9206-d621ee6f8068", "Lecturer", "LECTURER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "638615da-9cf2-4466-92e9-16c643df7575");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f5c739ea-6760-4f2a-9559-ae9273d17a02");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f91cf5ee-c529-4863-8455-b61371ac356c");

            migrationBuilder.DropColumn(
                name: "p1",
                table: "LOs");

            migrationBuilder.DropColumn(
                name: "p10",
                table: "LOs");

            migrationBuilder.DropColumn(
                name: "p11",
                table: "LOs");

            migrationBuilder.DropColumn(
                name: "p12",
                table: "LOs");

            migrationBuilder.DropColumn(
                name: "p2",
                table: "LOs");

            migrationBuilder.DropColumn(
                name: "p3",
                table: "LOs");

            migrationBuilder.DropColumn(
                name: "p4",
                table: "LOs");

            migrationBuilder.DropColumn(
                name: "p5",
                table: "LOs");

            migrationBuilder.DropColumn(
                name: "p6",
                table: "LOs");

            migrationBuilder.DropColumn(
                name: "p7",
                table: "LOs");

            migrationBuilder.DropColumn(
                name: "p8",
                table: "LOs");

            migrationBuilder.DropColumn(
                name: "p9",
                table: "LOs");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9dda72b3-1c21-4879-986b-967fd864601f", "a879e960-b4dc-4144-a1b5-73883290b24c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b195a05f-048b-48f9-bdc9-8f5f76af8ac5", "3a1f91fb-f928-43aa-a6aa-5267d1b5a1b6", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a2ee505c-4835-47fb-98e3-5913677d2f2e", "deb709a4-48b4-44d8-b4f1-9f71138dc8eb", "Lecturer", "LECTURER" });
        }
    }
}
