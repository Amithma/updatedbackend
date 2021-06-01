using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthDemo.Migrations
{
    public partial class poupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_POs_LOs_ID",
                table: "POs");

            migrationBuilder.DropIndex(
                name: "IX_POs_ID",
                table: "POs");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "72265c5d-d3d8-4c52-bf62-b6357fb78ff7");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a1b13364-4495-447a-ac26-fbf441552f46");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b081fddb-c2d4-45ca-87c4-820be0b532c6");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "POs");

            migrationBuilder.DropColumn(
                name: "LOID",
                table: "POs");

            migrationBuilder.AlterColumn<string>(
                name: "type",
                table: "Modules",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Modules",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Modules",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Credits",
                table: "Modules",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "POs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LOID",
                table: "POs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "type",
                table: "Modules",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Modules",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Modules",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Credits",
                table: "Modules",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b081fddb-c2d4-45ca-87c4-820be0b532c6", "82ec5a23-a59e-421e-a0b9-7fd6564c5ec5", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "72265c5d-d3d8-4c52-bf62-b6357fb78ff7", "6e9d6847-bb15-4ce5-9f0d-71a40a76a932", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a1b13364-4495-447a-ac26-fbf441552f46", "4e5f17f8-f290-46e0-be71-9722abb9ab0f", "Lecturer", "LECTURER" });

            migrationBuilder.CreateIndex(
                name: "IX_POs_ID",
                table: "POs",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_POs_LOs_ID",
                table: "POs",
                column: "ID",
                principalTable: "LOs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
