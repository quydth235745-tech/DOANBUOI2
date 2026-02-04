using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyHosting.Migrations
{
    /// <inheritdoc />
    public partial class AddHoadon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "DaThanhToan",
                table: "HoaDon",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DaThanhToan",
                table: "HoaDon");
        }
    }
}
