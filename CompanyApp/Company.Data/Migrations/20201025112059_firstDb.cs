using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Data.Migrations
{
    public partial class firstDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DEPARTMENTID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DEPARTMENT_NAME = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DEPARTMENTID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EMPLOYEEID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIRST_NAME = table.Column<string>(nullable: true),
                    LAST_NAME = table.Column<string>(nullable: true),
                    EMAIL = table.Column<string>(nullable: true),
                    PHONE_NUMBER = table.Column<string>(nullable: true),
                    HIRE_DATE = table.Column<DateTime>(nullable: false),
                    SALARY = table.Column<double>(nullable: false),
                    DEPARTMENTID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EMPLOYEEID);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DEPARTMENTID",
                        column: x => x.DEPARTMENTID,
                        principalTable: "Departments",
                        principalColumn: "DEPARTMENTID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DEPARTMENTID",
                table: "Employees",
                column: "DEPARTMENTID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
