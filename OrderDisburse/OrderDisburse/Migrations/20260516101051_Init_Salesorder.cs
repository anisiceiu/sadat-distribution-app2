using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderDisburse.Migrations
{
    /// <inheritdoc />
    public partial class Init_Salesorder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SaleOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductName = table.Column<string>(type: "TEXT", nullable: false),
                    PackageName = table.Column<string>(type: "TEXT", nullable: false),
                    TotalPiece = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderCarton = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderPiece = table.Column<int>(type: "INTEGER", nullable: false),
                    OnDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleOrders", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaleOrders");
        }
    }
}
