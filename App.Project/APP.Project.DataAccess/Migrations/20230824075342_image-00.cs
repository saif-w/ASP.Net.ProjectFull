using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APP.Project.DataAccess.Migrations
{
    public partial class image00 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "Employees",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "Employees");
        }
    }
}
