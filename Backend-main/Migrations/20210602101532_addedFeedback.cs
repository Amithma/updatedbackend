using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthDemo.Migrations
{
    public partial class addedFeedback : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q10 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedback");

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
    }
}
