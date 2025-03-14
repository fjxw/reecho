using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reecho.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vynils",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Genre = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", maxLength: 1000000, nullable: false),
                    Quantity = table.Column<int>(type: "integer", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("VynilId", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vynils");
        }
    }
}
