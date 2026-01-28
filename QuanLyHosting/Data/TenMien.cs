using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace QuanLyHosting.Data
{
    internal class TenMien
    {
        public int ID { get; set; }
        public string DomainName { get; set; } = null!;
        public DateTime NgayDangKy { get; set; }
        public DateTime NgayHetHan { get; set; }
        public decimal PhiGiaHan { get; set; }
    }
}
