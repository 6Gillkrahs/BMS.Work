using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMS.Work.Migrations
{
    /// <inheritdoc />
    public partial class createmenutable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BMSMenus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RouterLink = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Url = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Label = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Order = table.Column<int>(type: "int", nullable: true),
                    Iconclass = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    RequiredPolicy = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Layout = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsGroup = table.Column<bool>(type: "bit", nullable: false),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BMSMenus", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BMSMenus_ClientId",
                table: "BMSMenus",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_BMSMenus_ParentId",
                table: "BMSMenus",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_BMSMenus_TenantId",
                table: "BMSMenus",
                column: "TenantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BMSMenus");
        }
    }
}
