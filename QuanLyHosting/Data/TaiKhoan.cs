using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace QuanLyHosting.Data
{
    internal class TaiKhoan
    {
        public int ID { get; set; }
        public string TenDangNhap { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public bool TrangThai { get; set; }
        public int VaiTroID { get; set; }

        public virtual VaiTro VaiTro { get; set; } = null!;
    }
}
