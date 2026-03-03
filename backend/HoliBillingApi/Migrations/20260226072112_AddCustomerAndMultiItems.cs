using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoliBillingApi.Migrations
{
    public partial class AddCustomerAndMultiItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Bills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Bills");
        }
    }
}
