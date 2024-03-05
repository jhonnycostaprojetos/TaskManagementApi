using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagement.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class removeListTaskProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskProjects_LogTaskProjects_LogTaskProjectId",
                table: "TaskProjects");

            migrationBuilder.DropIndex(
                name: "IX_TaskProjects_LogTaskProjectId",
                table: "TaskProjects");

            migrationBuilder.DropColumn(
                name: "LogTaskProjectId",
                table: "TaskProjects");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 5, 19, 39, 43, 353, DateTimeKind.Utc).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "TaskProjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DueDate" },
                values: new object[] { new DateTime(2024, 3, 5, 19, 39, 43, 354, DateTimeKind.Utc).AddTicks(704), new DateTime(2024, 3, 5, 16, 39, 43, 354, DateTimeKind.Local).AddTicks(673) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 5, 19, 39, 43, 354, DateTimeKind.Utc).AddTicks(2307));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LogTaskProjectId",
                table: "TaskProjects",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 5, 19, 25, 54, 837, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "TaskProjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DueDate", "LogTaskProjectId" },
                values: new object[] { new DateTime(2024, 3, 5, 19, 25, 54, 837, DateTimeKind.Utc).AddTicks(7830), new DateTime(2024, 3, 5, 16, 25, 54, 837, DateTimeKind.Local).AddTicks(7787), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 5, 19, 25, 54, 837, DateTimeKind.Utc).AddTicks(9584));

            migrationBuilder.CreateIndex(
                name: "IX_TaskProjects_LogTaskProjectId",
                table: "TaskProjects",
                column: "LogTaskProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskProjects_LogTaskProjects_LogTaskProjectId",
                table: "TaskProjects",
                column: "LogTaskProjectId",
                principalTable: "LogTaskProjects",
                principalColumn: "Id");
        }
    }
}
