using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthDemo.Migrations
{
    public partial class summarycomponent1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "p4",
                table: "Summary",
                newName: "s4");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "s4",
                table: "Summary",
                newName: "p4");

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
    }
}
