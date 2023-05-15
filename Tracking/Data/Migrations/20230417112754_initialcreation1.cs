using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tracking.Data.Migrations
{
    /// <inheritdoc />
    public partial class initialcreation1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Issues");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Issues",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
