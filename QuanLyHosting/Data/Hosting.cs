using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace QuanLyHosting.Data
{
    internal class Hosting
    {
        public int ID { get; set; }
        public int KhachHangID { get; set; }
        public int GoiHostingID { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayHetHan { get; set; }
        public string TrangThai { get; set; } = null!;

        public virtual KhachHang KhachHang { get; set; } = null!;
        public virtual GoiHosting GoiHosting { get; set; } = null!;
        public virtual ObservableCollectionListSource<GiaHan> GiaHan { get; } = new();
        public virtual ObservableCollectionListSource<Website> Website { get; } = new();
    }
}
