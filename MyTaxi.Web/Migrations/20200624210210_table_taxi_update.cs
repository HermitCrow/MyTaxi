using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTaxi.Web.Migrations
{
    public partial class table_taxi_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Plaque",
                table: "Taxis",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 6);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Plaque",
                table: "Taxis",
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 7);
        }
    }
}
