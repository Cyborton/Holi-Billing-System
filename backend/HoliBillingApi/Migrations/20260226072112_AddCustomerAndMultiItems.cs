using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoliBillingApi.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomerAndMultiItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Bills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Bills");
        }
    }
}
