using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZaporArrow.Migrations
{
    public partial class fixedPicPathMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("088f9fb0-70b6-49e0-b80a-cca1dd3c631a"),
                column: "ImageSource",
                value: "/images/ujpest1.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("211aee93-89cb-46d4-b946-e8f4c7d938c9"),
                column: "ImageSource",
                value: "/images/svb1.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("babbf4a6-d5ec-4054-b2e8-2b5c508a947a"),
                column: "ImageSource",
                value: "/images/bfb1.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("088f9fb0-70b6-49e0-b80a-cca1dd3c631a"),
                column: "ImageSource",
                value: "../wwwroot/images/ujpest1.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("211aee93-89cb-46d4-b946-e8f4c7d938c9"),
                column: "ImageSource",
                value: "../wwwroot/images/svb1.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("babbf4a6-d5ec-4054-b2e8-2b5c508a947a"),
                column: "ImageSource",
                value: "../wwwroot/images/bfb1.jpg");
        }
    }
}
