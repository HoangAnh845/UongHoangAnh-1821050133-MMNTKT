using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaNguonMo.Migrations
{
    public partial class Customer_Gender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Customers",
                type: "TEXT",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "INTEGER",
                oldMaxLength: 30);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Gender",
                table: "Customers",
                type: "INTEGER",
                maxLength: 30,
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 30,
                oldNullable: true);
        }
    }
}
