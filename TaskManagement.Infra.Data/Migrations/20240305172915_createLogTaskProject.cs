using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagement.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class createLogTaskProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LogTaskProjectId",
                table: "TaskProjects",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LogTaskProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskProjectId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogTaskProjects", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 5, 17, 29, 15, 507, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "TaskProjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DueDate", "LogTaskProjectId" },
                values: new object[] { new DateTime(2024, 3, 5, 17, 29, 15, 507, DateTimeKind.Utc).AddTicks(6182), new DateTime(2024, 3, 5, 14, 29, 15, 507, DateTimeKind.Local).AddTicks(6143), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 5, 17, 29, 15, 507, DateTimeKind.Utc).AddTicks(7812));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskProjects_LogTaskProjects_LogTaskProjectId",
                table: "TaskProjects");

            migrationBuilder.DropTable(
                name: "LogTaskProjects");

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
                value: new DateTime(2024, 3, 5, 16, 47, 33, 685, DateTimeKind.Utc).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "TaskProjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DueDate" },
                values: new object[] { new DateTime(2024, 3, 5, 16, 47, 33, 685, DateTimeKind.Utc).AddTicks(2933), new DateTime(2024, 3, 5, 13, 47, 33, 685, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 3, 5, 16, 47, 33, 685, DateTimeKind.Utc).AddTicks(4801));
        }
    }
}
