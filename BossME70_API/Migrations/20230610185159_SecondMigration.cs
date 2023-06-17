using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BossME70_API.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bank",
                schema: "me70",
                table: "patch",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                schema: "me70",
                table: "patch",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bank",
                schema: "me70",
                table: "patch");

            migrationBuilder.DropColumn(
                name: "Name",
                schema: "me70",
                table: "patch");
        }
    }
}
