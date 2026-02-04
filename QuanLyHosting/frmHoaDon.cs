using QuanLyHosting.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyHosting
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        QLHTDbContext context = new QLHTDbContext();
        int? currentHoaDonID = null;

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            // Load danh sách khách hàng vào ComboBox
            cboKhachHang.DataSource = context.KhachHang.ToList();
            cboKhachHang.DisplayMember = "HoTen";
            cboKhachHang.ValueMember = "ID";

            // Load danh sách nhân viên
            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "ID";

            LoadDataGridView(); // Gọi hàm load bảng
        }
        private void LoadDataGridView()
        {
            var listHD = context.HoaDon.Select(hd => new
            {
                MaHD = hd.ID,
                KhachHang = hd.KhachHang.HoTen,
                NgayLap = hd.NgayLap,
                TongTien = hd.TongTien,
                GhiChu = hd.GhiChu
            }).ToList();

            dgvHoaDon.DataSource = listHD;
            dgvHoaDon.Columns["MaHD"].HeaderText = "Mã HD";
            dgvHoaDon.Columns["KhachHang"].HeaderText = "Khách Hàng";
            dgvHoaDon.Columns["NgayLap"].HeaderText = "Ngày Lập";
            dgvHoaDon.Columns["TongTien"].HeaderText = "Tổng Tiền";
        }

        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {
            decimal donGia = decimal.Parse(txtDonGia.Text);
            decimal thanhTien = numSoLuong.Value * donGia;
            txtThanhTien.Text = thanhTien.ToString("N0"); // Định dạng số cho đẹp
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            currentHoaDonID = null;
            txtMaHD.Clear();
            numSoLuong.Value = 1;
            txtGhiChu.Clear();
            txtThanhTien.Text = "0";
            dtpNgayLap.Value = DateTime.Now;
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if (currentHoaDonID == null) return;
            var confirm = MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                var hd = context.HoaDon.Find(currentHoaDonID);
                context.HoaDon.Remove(hd);
                context.SaveChanges();
                LoadDataGridView();
            }
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            if (currentHoaDonID == null)
            {
                MessageBox.Show("Bạn phải chọn một hóa đơn dưới bảng trước khi sửa chứ!");
                return;
            }

            // Mở khóa các ô để cho phép sửa (nếu ní có dùng hàm BatTatChucNang)
            txtGhiChu.ReadOnly = false;
            numSoLuong.Enabled = true;
            dtpNgayLap.Enabled = true;

            MessageBox.Show("Bạn có thể sửa Ghi chú hoặc Số lượng rồi đó, sửa xong nhớ nhấn LƯU nha!");
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentHoaDonID == null)
                { // TRƯỜNG HỢP THÊM MỚI
                    var hd = new HoaDon
                    {
                        KhachHangID = (int)cboKhachHang.SelectedValue,
                        NhanVienID = (int)cboNhanVien.SelectedValue,
                        NgayLap = dtpNgayLap.Value,
                        TongTien = decimal.Parse(txtThanhTien.Text),
                        GhiChu = txtGhiChu.Text
                    };
                    context.HoaDon.Add(hd);

                    // Ghi nhật ký hệ thống
                    context.NhatKyHeThong.Add(new NhatKyHeThong
                    {
                        HanhDong = $"Tạo hóa đơn mới cho khách {cboKhachHang.Text}",
                        ThoiGian = DateTime.Now,
                        NguoiThucHien = "Admin"
                    });
                }
                else
                { // TRƯỜNG HỢP SỬA
                    var hd = context.HoaDon.Find(currentHoaDonID);
                    if (hd != null)
                    {
                        hd.GhiChu = txtGhiChu.Text;
                        hd.TongTien = decimal.Parse(txtThanhTien.Text);
                        // Nhật ký sửa chữa
                        context.NhatKyHeThong.Add(new NhatKyHeThong
                        {
                            HanhDong = $"Cập nhật hóa đơn ID {hd.ID}",
                            ThoiGian = DateTime.Now,
                            NguoiThucHien = "Admin"
                        });
                    }
                }
                context.SaveChanges();
                LoadDataGridView();
                MessageBox.Show("Đã lưu dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnHuyBoHD_Click(object sender, EventArgs e)
        {
            // 1. Xóa sạch các ô nhập liệu
            currentHoaDonID = null;
            txtMaHD.Clear();
            txtGhiChu.Clear();
            txtThanhTien.Text = "0";
            numSoLuong.Value = 1;
            dtpNgayLap.Value = DateTime.Now;

            // 2. Tải lại dữ liệu lên bảng để đảm bảo tính Nhất quán
            LoadDataGridView();

            MessageBox.Show("Đã hủy bỏ các thay đổi hiện tại!");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            string path = $@"D:\HoaDon_{txtMaHD.Text}.txt";
            string noidung = $"MA HD: {txtMaHD.Text}\nKHACH: {cboKhachHang.Text}\nTIEN: {txtThanhTien.Text}";
            System.IO.File.WriteAllText(path, noidung);
            MessageBox.Show("Đã xuất hóa đơn ra file tại: " + path);
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];
                currentHoaDonID = (int)row.Cells["MaHD"].Value;

                txtMaHD.Text = row.Cells["MaHD"].Value.ToString();
                cboKhachHang.Text = row.Cells["KhachHang"].Value.ToString();
                dtpNgayLap.Value = (DateTime)row.Cells["NgayLap"].Value;
                txtThanhTien.Text = row.Cells["TongTien"].Value.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString();
            }
        }
    }
}
