using Microsoft.EntityFrameworkCore.Migrations;

namespace Entsoftlab.University.Questioning.Data.Migrations
{
    public partial class AddEnumFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<uint>(
                name: "StartYear",
                table: "Groups",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<uint>(
                name: "FinishYear",
                table: "Groups",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "StartYear",
                table: "Groups",
                nullable: false,
                oldClrType: typeof(uint));

            migrationBuilder.AlterColumn<int>(
                name: "FinishYear",
                table: "Groups",
                nullable: false,
                oldClrType: typeof(uint));
        }
    }
}
