using Microsoft.EntityFrameworkCore.Migrations;

namespace BookList.Migrations
{
    public partial class update_name_property2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Books",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Books",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
