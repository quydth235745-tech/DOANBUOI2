using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHosting.Data
{
    internal class Website
    {
        public int ID { get; set; }
        public string TenWebsite { get; set; } = null!;
        public string Url { get; set; } = null!;
        public int HostingID { get; set; }

        public virtual Hosting Hosting { get; set; } = null!;
    }
}
