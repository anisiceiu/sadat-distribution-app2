using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderDisburse.Migrations
{
    /// <inheritdoc />
    public partial class totalsamountadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "SaleOrders",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "SaleOrders");
        }
    }
}
