using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore.Migrations
{
    public partial class AddPresetData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "GroupId", "GroupName" },
                values: new object[] { new Guid("366ebfbe-dfe6-4e04-97e9-5edd07ce88c0"), "Math Group" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "GroupId",
                keyValue: new Guid("366ebfbe-dfe6-4e04-97e9-5edd07ce88c0"));
        }
    }
}
