using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreProject.Migrations
{
    /// <inheritdoc />
    public partial class databasetablesrelationshipd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SupervisorID",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "department",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ManagStartDate",
                table: "department",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "dependents",
                columns: table => new
                {
                    DependentName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    DependentID = table.Column<int>(type: "int", nullable: false),
                    Relationship = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dependents", x => new { x.DependentName, x.EmployeeID });
                    table.ForeignKey(
                        name: "FK_dependents_employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "deptLocations",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    DepartmentLocation = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deptLocations", x => new { x.DepartmentID, x.DepartmentLocation });
                    table.ForeignKey(
                        name: "FK_deptLocations_department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    ProjectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectLocation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.ProjectID);
                });

            migrationBuilder.CreateTable(
                name: "empProjs",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    Hours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empProjs", x => new { x.EmployeeID, x.ProjectID });
                    table.ForeignKey(
                        name: "FK_empProjs_employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_empProjs_projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employees_DepartmentID",
                table: "employees",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_employees_SupervisorID",
                table: "employees",
                column: "SupervisorID");

            migrationBuilder.CreateIndex(
                name: "IX_department_EmployeeID",
                table: "department",
                column: "EmployeeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_dependents_EmployeeID",
                table: "dependents",
                column: "EmployeeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_empProjs_ProjectID",
                table: "empProjs",
                column: "ProjectID");

            migrationBuilder.AddForeignKey(
                name: "FK_department_employees_EmployeeID",
                table: "department",
                column: "EmployeeID",
                principalTable: "employees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_department_DepartmentID",
                table: "employees",
                column: "DepartmentID",
                principalTable: "department",
                principalColumn: "DepartmentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_employees_SupervisorID",
                table: "employees",
                column: "SupervisorID",
                principalTable: "employees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_department_employees_EmployeeID",
                table: "department");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_department_DepartmentID",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_employees_SupervisorID",
                table: "employees");

            migrationBuilder.DropTable(
                name: "dependents");

            migrationBuilder.DropTable(
                name: "deptLocations");

            migrationBuilder.DropTable(
                name: "empProjs");

            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DropIndex(
                name: "IX_employees_DepartmentID",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_SupervisorID",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_department_EmployeeID",
                table: "department");

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "SupervisorID",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "department");

            migrationBuilder.DropColumn(
                name: "ManagStartDate",
                table: "department");
        }
    }
}
