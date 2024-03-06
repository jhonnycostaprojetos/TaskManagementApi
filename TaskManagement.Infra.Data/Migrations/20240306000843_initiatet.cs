using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagement.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class initiatet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Comments_CommentId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CommentId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CommentId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "IdUser",
                table: "Comments",
                newName: "UserId");

            migrationBuilder.AddColumn<int>(
                name: "Profile",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 6, 0, 8, 43, 106, DateTimeKind.Utc).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "TaskProjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DueDate" },
                values: new object[] { new DateTime(2024, 3, 6, 0, 8, 43, 107, DateTimeKind.Utc).AddTicks(429), new DateTime(2024, 3, 5, 21, 8, 43, 107, DateTimeKind.Local).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "Profile" },
                values: new object[] { new DateTime(2024, 3, 6, 0, 8, 43, 107, DateTimeKind.Utc).AddTicks(2321), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Profile",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Comments",
                newName: "IdUser");

            migrationBuilder.AddColumn<int>(
                name: "CommentId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 5, 22, 12, 14, 292, DateTimeKind.Utc).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "TaskProjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DueDate" },
                values: new object[] { new DateTime(2024, 3, 5, 22, 12, 14, 292, DateTimeKind.Utc).AddTicks(2381), new DateTime(2024, 3, 5, 19, 12, 14, 292, DateTimeKind.Local).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentId", "CreateAt" },
                values: new object[] { null, new DateTime(2024, 3, 5, 22, 12, 14, 292, DateTimeKind.Utc).AddTicks(3981) });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CommentId",
                table: "Users",
                column: "CommentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Comments_CommentId",
                table: "Users",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "Id");
        }
    }
}
