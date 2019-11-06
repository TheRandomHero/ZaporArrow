using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZaporArrow.Migrations
{
    public partial class initMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arrows",
                columns: table => new
                {
                    ArrowId = table.Column<Guid>(nullable: false),
                    Length = table.Column<double>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arrows", x => x.ArrowId);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageId = table.Column<Guid>(nullable: false),
                    ArrowId = table.Column<Guid>(nullable: false),
                    Size = table.Column<double>(nullable: false),
                    ImageSource = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Images_Arrows_ArrowId",
                        column: x => x.ArrowId,
                        principalTable: "Arrows",
                        principalColumn: "ArrowId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Arrows",
                columns: new[] { "ArrowId", "Description", "Length" },
                values: new object[] { new Guid("97bcd962-2a0d-4489-8e48-19dd2c848893"), "extra donga 7mm, 22 - 22, 2gramm 30 font!", 30.0 });

            migrationBuilder.InsertData(
                table: "Arrows",
                columns: new[] { "ArrowId", "Description", "Length" },
                values: new object[] { new Guid("e71847d9-1ddb-4db1-8af5-801803d6151c"), "35 font, 23g 0,3tized gramm szórásban. 8 ról 7es extra donga!", 29.5 });

            migrationBuilder.InsertData(
                table: "Arrows",
                columns: new[] { "ArrowId", "Description", "Length" },
                values: new object[] { new Guid("019e54c4-5a54-42d3-a78a-8b3d9dd0d85d"), "35#, 22,2-22,5g Extra dongás. (7mm)", 30.0 });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "ArrowId", "ImageSource", "Size" },
                values: new object[] { new Guid("babbf4a6-d5ec-4054-b2e8-2b5c508a947a"), new Guid("97bcd962-2a0d-4489-8e48-19dd2c848893"), "../wwwroot/images/bfb1.jpg", 563.0 });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "ArrowId", "ImageSource", "Size" },
                values: new object[] { new Guid("088f9fb0-70b6-49e0-b80a-cca1dd3c631a"), new Guid("e71847d9-1ddb-4db1-8af5-801803d6151c"), "../wwwroot/images/ujpest1.jpg", 467.0 });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "ArrowId", "ImageSource", "Size" },
                values: new object[] { new Guid("211aee93-89cb-46d4-b946-e8f4c7d938c9"), new Guid("019e54c4-5a54-42d3-a78a-8b3d9dd0d85d"), "../wwwroot/images/svb1.jpg", 351.0 });

            migrationBuilder.CreateIndex(
                name: "IX_Images_ArrowId",
                table: "Images",
                column: "ArrowId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Arrows");
        }
    }
}
