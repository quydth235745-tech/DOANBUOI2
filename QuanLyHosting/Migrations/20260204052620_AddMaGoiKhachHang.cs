using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyHosting.Migrations
{
    /// <inheritdoc />
    public partial class AddMaGoiKhachHang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaGoi",
                table: "KhachHang",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaGoi",
                table: "KhachHang");
        }
    }
}
