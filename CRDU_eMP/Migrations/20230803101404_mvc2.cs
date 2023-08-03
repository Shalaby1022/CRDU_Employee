using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRDU_eMP.Migrations
{
    /// <inheritdoc />
    public partial class mvc2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpProjects_Employees_EmployeeId",
                table: "EmpProjects");

            migrationBuilder.DropIndex(
                name: "IX_EmpProjects_EmployeeId",
                table: "EmpProjects");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "EmpProjects");

            migrationBuilder.CreateIndex(
                name: "IX_EmpProjects_WorkingHours",
                table: "EmpProjects",
                column: "WorkingHours");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpProjects_Employees_WorkingHours",
                table: "EmpProjects",
                column: "WorkingHours",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpProjects_Employees_WorkingHours",
                table: "EmpProjects");

            migrationBuilder.DropIndex(
                name: "IX_EmpProjects_WorkingHours",
                table: "EmpProjects");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "EmpProjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmpProjects_EmployeeId",
                table: "EmpProjects",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpProjects_Employees_EmployeeId",
                table: "EmpProjects",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
