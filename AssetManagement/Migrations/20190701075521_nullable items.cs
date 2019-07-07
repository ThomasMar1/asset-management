using Microsoft.EntityFrameworkCore.Migrations;

namespace AssetManagement.Migrations
{
    public partial class nullableitems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountCost",
                table: "Items",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<short>(
                name: "Discount",
                table: "Items",
                nullable: true,
                oldClrType: typeof(short));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountCost",
                table: "Items",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "Discount",
                table: "Items",
                nullable: false,
                oldClrType: typeof(short),
                oldNullable: true);
        }
    }
}
