using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace QuanLyHosting.Data
{
    internal class QLHTDbContext : DbContext
    {
            public DbSet<VaiTro> VaiTro { get; set; }
            public DbSet<TaiKhoan> TaiKhoan { get; set; }
            public DbSet<NhanVien> NhanVien { get; set; }
            public DbSet<KhachHang> KhachHang { get; set; }
            public DbSet<GoiHosting> GoiHosting { get; set; }
            public DbSet<Hosting> Hosting { get; set; }
            public DbSet<TenMien> TenMien { get; set; }
            public DbSet<Website> Website { get; set; }
            public DbSet<HoaDon> HoaDon { get; set; }
            public DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
            public DbSet<GiaHan> GiaHan { get; set; }
            public DbSet<NhatKyHeThong> NhatKyHeThong { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Data Source=.\\SQLEXPRESS;" +
                    "Initial Catalog=QLHT;" +
                    "Integrated Security=True;" +
                    "TrustServerCertificate=True"
                );
            }
        }
        }
}
