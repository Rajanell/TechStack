using Microsoft.EntityFrameworkCore.Migrations;

namespace Rajanell.TechStack.Infrastructure.Data.Migrations
{
    public partial class Product_AddTags_Category_AddActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "ProductCategories",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "ProductCategories");
        }
    }
}
