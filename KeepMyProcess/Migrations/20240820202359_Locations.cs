using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KeepMyProcess.Migrations
{
    public partial class Locations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BackupLocations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 225, nullable: true),
                    Path = table.Column<string>(maxLength: 5000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackupLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UploadLocations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 225, nullable: false),
                    HostAddress = table.Column<string>(maxLength: 5000, nullable: false),
                    Port = table.Column<int>(nullable: false),
                    Username = table.Column<string>(maxLength: 225, nullable: false),
                    Password = table.Column<string>(maxLength: 1000, nullable: false),
                    Protocol = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadLocations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BackupLocations");

            migrationBuilder.DropTable(
                name: "UploadLocations");
        }
    }
}
