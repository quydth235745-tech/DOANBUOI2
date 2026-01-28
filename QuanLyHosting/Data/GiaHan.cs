using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHosting.Data
{
    internal class GiaHan
    {
        public int ID { get; set; }
        public int HostingID { get; set; }
        public DateTime NgayGiaHan { get; set; }
        public int SoThang { get; set; }
        public decimal PhiGiaHan { get; set; }

        public virtual Hosting Hosting { get; set; } = null!;
    }
}
