using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GummiBearKingdom.Migrations
{
    public partial class UpdateColumnNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "Products",
                newName: "Origin");

            migrationBuilder.RenameColumn(
                name: "OriginCountry",
                table: "Products",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Origin",
                table: "Products",
                newName: "ProductName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "OriginCountry");
        }
    }
}
