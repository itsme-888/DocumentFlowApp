using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DocumentFlowApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "file_request",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Message = table.Column<string>(type: "text", nullable: false),
                    RequestStatus = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    CreatedByUserId = table.Column<long>(type: "bigint", nullable: false),
                    ApprovedByUserId = table.Column<long>(type: "bigint", nullable: true),
                    CommentDecline = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_file_request", x => x.Id);
                    table.ForeignKey(
                        name: "FK_file_request_users_ApprovedByUserId",
                        column: x => x.ApprovedByUserId,
                        principalTable: "users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_file_request_users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "attached_files_to_request",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    FileInfoId = table.Column<long>(type: "bigint", nullable: false),
                    FileRequestId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attached_files_to_request", x => x.Id);
                    table.ForeignKey(
                        name: "FK_attached_files_to_request_file_info_FileInfoId",
                        column: x => x.FileInfoId,
                        principalTable: "file_info",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_attached_files_to_request_file_request_FileRequestId",
                        column: x => x.FileRequestId,
                        principalTable: "file_request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_attached_files_to_request_FileInfoId",
                table: "attached_files_to_request",
                column: "FileInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_attached_files_to_request_FileRequestId",
                table: "attached_files_to_request",
                column: "FileRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_file_request_ApprovedByUserId",
                table: "file_request",
                column: "ApprovedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_file_request_CreatedByUserId",
                table: "file_request",
                column: "CreatedByUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "attached_files_to_request");

            migrationBuilder.DropTable(
                name: "file_request");
        }
    }
}
