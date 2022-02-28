using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaNguonMo.Migrations
{
    public partial class UHA1821051033Create_Table_Student : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Students",
                type: "TEXT",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Persons",
                type: "TEXT",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "Movies",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Employees",
                type: "TEXT",
                maxLength: 30,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
