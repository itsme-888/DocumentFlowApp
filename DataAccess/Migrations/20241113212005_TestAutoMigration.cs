using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocumentFlowApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class TestAutoMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("select 1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
