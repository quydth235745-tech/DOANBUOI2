using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;


namespace QuanLyHosting.Data
{
    internal class KhachHang
    {
        public int ID { get; set; }
        public string HoTen { get; set; } = null!;
        public string DienThoai { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string DiaChi { get; set; } = null!;
        public DateTime NgayDangKy { get; set; }

        public virtual ObservableCollectionListSource<Hosting> Hosting { get; } = new();
        public virtual ObservableCollectionListSource<HoaDon> HoaDon { get; } = new();
    }
}
