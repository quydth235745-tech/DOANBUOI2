using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace QuanLyHosting.Data
{
    internal class VaiTro
    {
        public int ID { get; set; }
        public string TenVaiTro { get; set; } = null!;
        public string MoTa { get; set; } = null!;

        public virtual ObservableCollectionListSource<TaiKhoan> TaiKhoan { get; } = new();
    }
}
