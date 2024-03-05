using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagement.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateConfigProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TaskProjects_ProjectId",
                table: "TaskProjects");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 4, 18, 27, 49, 961, DateTimeKind.Utc).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "TaskProjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DueDate" },
                values: new object[] { new DateTime(2024, 3, 4, 18, 27, 49, 961, DateTimeKind.Utc).AddTicks(6958), new DateTime(2024, 3, 4, 15, 27, 49, 961, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 4, 18, 27, 49, 961, DateTimeKind.Utc).AddTicks(8999));

            migrationBuilder.CreateIndex(
                name: "IX_TaskProjects_ProjectId",
                table: "TaskProjects",
                column: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TaskProjects_ProjectId",
                table: "TaskProjects");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 4, 14, 2, 4, 491, DateTimeKind.Utc).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "TaskProjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DueDate" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 2, 4, 492, DateTimeKind.Utc).AddTicks(292), new DateTime(2024, 3, 4, 11, 2, 4, 492, DateTimeKind.Local).AddTicks(254) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 4, 14, 2, 4, 492, DateTimeKind.Utc).AddTicks(2841));

            migrationBuilder.CreateIndex(
                name: "IX_TaskProjects_ProjectId",
                table: "TaskProjects",
                column: "ProjectId",
                unique: true);
        }
    }
}
