using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lehen_webgunea.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class categoryId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Category21Id",
                table: "Categories",
                newName: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories",
                newName: "Category21Id");
        }
    }
}
