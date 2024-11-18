using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocumentFlowApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddNameForUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Name",
                value: "Администратор");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Name",
                value: "Иванов И.И.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "users");
        }
    }
}
