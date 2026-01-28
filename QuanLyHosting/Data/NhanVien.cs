using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHosting.Data
{
    internal class NhanVien
    {
        public int Id { get; set; }

        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }

        public DateTime NgaySinh { get; set; }

        public string DangNhap { get; set; }
        public string MatKhau { get; set; }

        public string VaiTro { get; set; }
        public string TrangThai { get; set; }

        public DateTime NgayTao { get; set; }

        public virtual ObservableCollectionListSource<HoaDon> HoaDon { get; } = new();
    }
}
