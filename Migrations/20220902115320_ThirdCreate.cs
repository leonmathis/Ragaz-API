using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RagazAPI.Migrations
{
    public partial class ThirdCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EventDate",
                table: "Events",
                type: "SmallDateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EventDate",
                table: "Events",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "SmallDateTime");
        }
    }
}
