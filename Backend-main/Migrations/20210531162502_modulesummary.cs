using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthDemo.Migrations
{
    public partial class modulesummary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Summary");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "86be308e-6079-4fff-9b7f-db8faa7942a2");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "99678162-a542-4e28-87da-0f1529d2043a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b35c56e3-2ad5-4c4e-8914-b9da01b937cf");

            migrationBuilder.AddColumn<string>(
                name: "s1",
                table: "Modules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "s10",
                table: "Modules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "s11",
                table: "Modules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "s12",
                table: "Modules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "s2",
                table: "Modules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "s3",
                table: "Modules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "s4",
                table: "Modules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "s5",
                table: "Modules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "s6",
                table: "Modules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "s7",
                table: "Modules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "s8",
                table: "Modules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "s9",
                table: "Modules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dc066c0a-2a53-4424-a11a-9328c9776387", "e5b30df3-9787-41a5-965d-f553e9e2ff57", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d13df85f-ff06-46cc-b44b-3baf5376fa01", "4e3b5523-7d43-4bd9-8e58-7ef2d2f37a34", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3927cee3-1d1b-4168-86c8-00cbde7834c6", "4bde39f5-e744-4ea5-bcd6-d2ba3c91ee63", "Lecturer", "LECTURER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3927cee3-1d1b-4168-86c8-00cbde7834c6");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d13df85f-ff06-46cc-b44b-3baf5376fa01");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "dc066c0a-2a53-4424-a11a-9328c9776387");

            migrationBuilder.DropColumn(
                name: "s1",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "s10",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "s11",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "s12",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "s2",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "s3",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "s4",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "s5",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "s6",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "s7",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "s8",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "s9",
                table: "Modules");

            migrationBuilder.CreateTable(
                name: "Summary",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    s1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    s10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    s11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    s12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    s2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    s3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    s4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    s5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    s6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    s7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    s8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    s9 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summary", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "99678162-a542-4e28-87da-0f1529d2043a", "11e55b1b-34eb-404c-b6ac-c5da8c865c5f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b35c56e3-2ad5-4c4e-8914-b9da01b937cf", "5bf9a229-2cc3-4be6-9936-705833815746", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "86be308e-6079-4fff-9b7f-db8faa7942a2", "d38324ce-8246-45e2-ab26-ac3d94bed9da", "Lecturer", "LECTURER" });
        }
    }
}
