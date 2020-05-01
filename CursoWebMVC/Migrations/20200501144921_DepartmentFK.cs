using Microsoft.EntityFrameworkCore.Migrations;

namespace CursoWebMVC.Migrations
{
    public partial class DepartmentFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Saller_Department_DepartmentId",
                table: "Saller");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Saller",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Saller_Department_DepartmentId",
                table: "Saller",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Saller_Department_DepartmentId",
                table: "Saller");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Saller",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Saller_Department_DepartmentId",
                table: "Saller",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
