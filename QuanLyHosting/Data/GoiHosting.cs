using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace QuanLyHosting.Data
{
    internal class GoiHosting
    {
        public int ID { get; set; }
        public string TenGoi { get; set; } = null!;
        public int DungLuongGB { get; set; }
        public int BangThongGB { get; set; }
        public decimal GiaThang { get; set; }
        public string MoTa { get; set; } = null!;

        public virtual ObservableCollectionListSource<Hosting> Hosting { get; } = new();
    }
}
