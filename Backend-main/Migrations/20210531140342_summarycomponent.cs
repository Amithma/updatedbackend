using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthDemo.Migrations
{
    public partial class summarycomponent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "LOs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LOID",
                table: "LOs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Summary",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    s1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    s2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    s3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    p4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    s5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    s6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    s7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    s8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    s9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    s10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    s11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    s12 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summary", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f385dfd1-4070-4f1d-9373-dff9aac3897e", "fee5d17d-fe8c-4e41-9e65-ae9358bc7b9e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "db6dbc51-41e8-402e-ba74-0cdfecf69bee", "fe23e903-ce64-4e2e-a831-dff497ed8328", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4c088cd5-b045-408a-9e97-561da29326b8", "46c6c46c-2c64-4818-b2c6-f18e49f35752", "Lecturer", "LECTURER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Summary");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "4c088cd5-b045-408a-9e97-561da29326b8");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "db6dbc51-41e8-402e-ba74-0cdfecf69bee");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f385dfd1-4070-4f1d-9373-dff9aac3897e");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "LOs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LOID",
                table: "LOs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
