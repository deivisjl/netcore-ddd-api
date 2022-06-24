using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class BirthDayStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Student",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Birthday",
                table: "Student",
                type: "Text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Student");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Student",
                type: "Text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
