using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderDisburse.Migrations
{
    /// <inheritdoc />
    public partial class Init_Salesorderd_a : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SOId",
                table: "SaleOrders",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SOId",
                table: "SaleOrders");
        }
    }
}
