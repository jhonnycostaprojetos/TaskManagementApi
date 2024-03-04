using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagement.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TaskProjects_ProjectId",
                table: "TaskProjects");

            migrationBuilder.DropColumn(
                name: "TaskProjectId",
                table: "Projects");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TaskProjects_ProjectId",
                table: "TaskProjects");

            migrationBuilder.AddColumn<Guid>(
                name: "TaskProjectId",
                table: "Projects",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "TaskProjectId" },
                values: new object[] { new DateTime(2024, 3, 3, 23, 15, 5, 374, DateTimeKind.Utc).AddTicks(6089), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "TaskProjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DueDate" },
                values: new object[] { new DateTime(2024, 3, 3, 23, 15, 5, 374, DateTimeKind.Utc).AddTicks(8890), new DateTime(2024, 3, 3, 20, 15, 5, 374, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 3, 23, 15, 5, 375, DateTimeKind.Utc).AddTicks(445));

            migrationBuilder.CreateIndex(
                name: "IX_TaskProjects_ProjectId",
                table: "TaskProjects",
                column: "ProjectId");
        }
    }
}
