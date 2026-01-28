using System;
using System.Collections.Generic;
using System.Text;
using QuanLyHosting.Data;

namespace QuanLyHosting.Data
{
    internal class NhatKyHeThong
    {
        public int ID { get; set; }
        public string HanhDong { get; set; } = null!;
        public string NguoiThucHien { get; set; } = null!;
        public DateTime ThoiGian { get; set; }
    }
}
