using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HoodooDonuts.Migrations
{
    public partial class UpdatedDonutClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PromoEndDate",
                table: "Donut");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PromoEndDate",
                table: "Donut",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
