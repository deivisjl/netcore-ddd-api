using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class CourseFilters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "CourseStudent",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "CourseStudent",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "CourseStudent",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "CourseStudent");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "CourseStudent");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "CourseStudent");
        }
    }
}
