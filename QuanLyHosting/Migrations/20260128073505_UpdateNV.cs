using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyHosting.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNV : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "NhanVien",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "NgayVaoLam",
                table: "NhanVien",
                newName: "NgayTao");

            migrationBuilder.RenameColumn(
                name: "GioiTinh",
                table: "NhanVien",
                newName: "VaiTro");

            migrationBuilder.AddColumn<string>(
                name: "DangNhap",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaNV",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MatKhau",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TrangThai",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DangNhap",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "MaNV",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "MatKhau",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "NhanVien");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "NhanVien",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "VaiTro",
                table: "NhanVien",
                newName: "GioiTinh");

            migrationBuilder.RenameColumn(
                name: "NgayTao",
                table: "NhanVien",
                newName: "NgayVaoLam");
        }
    }
}
