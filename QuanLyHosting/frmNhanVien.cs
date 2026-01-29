using QuanLyHosting.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace QuanLyHosting
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        QLHTDbContext context = new QLHTDbContext();
        bool xuLyThem = false;
        int id = 0;

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            BatTatChucNang(true);
            dgvNhanVien.AutoGenerateColumns = true;
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        void BatTatChucNang(bool xem)
        {
            btnThem.Enabled = xem;
            btnSua.Enabled = xem;
            btnXoa.Enabled = xem;

            btnLuu.Enabled = !xem;
            btnHuyBo.Enabled = !xem;

            txtMaNV.Enabled = !xem;
            txtTen.Enabled = !xem;
            txtEmail.Enabled = !xem;
            txtSDT.Enabled = !xem;
            txtDiaChi.Enabled = !xem;
            txtDangNhap.Enabled = !xem;
            txtMatkhau.Enabled = !xem;
            cboVaitro.Enabled = !xem;
            cboTrangthai.Enabled = !xem;
            dtpNgaysinh.Enabled = !xem;
        }
        private void LoadNhanVien()
        {
            dgvNhanVien.DataSource = context.NhanVien
        .Select(nv => new
        {
            nv.Id,
            nv.MaNV,
            nv.HoTen,
            nv.Email,
            nv.DienThoai,
            nv.DiaChi,
            nv.NgaySinh,
            nv.DangNhap,
            nv.VaiTro,
            nv.TrangThai,
            nv.NgayTao
        }).ToList();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(false);

            txtMaNV.Clear();
            txtTen.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtDangNhap.Clear();
            txtMatkhau.Clear();
            cboVaitro.SelectedIndex = -1;
            cboTrangthai.SelectedIndex = -1;
            dtpNgaysinh.Value = DateTime.Now;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["Id"].Value);

            var nv = context.NhanVien.Find(id);
            if (nv != null)
            {
                if (MessageBox.Show("Xóa nhân viên này?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    context.NhanVien.Remove(nv);
                    context.SaveChanges();
                    LoadNhanVien();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) return;

            xuLyThem = false;
            BatTatChucNang(false);

            id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["Id"].Value);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu()) return;
            if (xuLyThem)
            {
                NhanVien nv = new NhanVien()
                {
                    MaNV = txtMaNV.Text,
                    HoTen = txtTen.Text,
                    Email = txtEmail.Text,
                    DienThoai = txtSDT.Text,
                    DiaChi = txtDiaChi.Text,
                    NgaySinh = dtpNgaysinh.Value,
                    DangNhap = txtDangNhap.Text,
                    MatKhau = txtMatkhau.Text,
                    VaiTro = cboVaitro.Text,
                    TrangThai = cboTrangthai.Text,
                    NgayTao = DateTime.Now
                };

                context.NhanVien.Add(nv);
            }
            else
            {
                NhanVien nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    nv.HoTen = txtTen.Text;
                    nv.Email = txtEmail.Text;
                    nv.DienThoai = txtSDT.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    nv.NgaySinh = dtpNgaysinh.Value;
                    nv.VaiTro = cboVaitro.Text;
                    nv.TrangThai = cboTrangthai.Text;
                }
            }

            context.SaveChanges();
            LoadNhanVien();
            BatTatChucNang(true);

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtTen.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtDangNhap.Clear();
            txtMatkhau.Clear();
            cboVaitro.SelectedIndex = -1;
            cboTrangthai.SelectedIndex = -1;
            dtpNgaysinh.CustomFormat = " ";

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

            txtMaNV.Text = row.Cells["MaNV"].Value?.ToString();
            txtTen.Text = row.Cells["HoTen"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();
            txtSDT.Text = row.Cells["DienThoai"].Value?.ToString();
            txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
            txtDangNhap.Text = row.Cells["DangNhap"].Value?.ToString();
            cboVaitro.Text = row.Cells["VaiTro"].Value?.ToString();
            cboTrangthai.Text = row.Cells["TrangThai"].Value?.ToString();
            dtpNgaysinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
        }
        bool KiemTraDuLieu()
        {
            // Mã NV: NV00 + số
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtMaNV.Text, @"^NV00\d+$"))
            {
                MessageBox.Show("Mã NV phải có dạng NV00 + số (VD: NV001)", "Lỗi");
                txtMaNV.Focus();
                return false;
            }

            // Họ tên
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên", "Lỗi");
                txtTen.Focus();
                return false;
            }

            // Email gmail
            if (!txtEmail.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email phải có đuôi @gmail.com", "Lỗi");
                txtEmail.Focus();
                return false;
            }

            // SĐT
            if (txtSDT.Text.Length < 9 || txtSDT.Text.Length > 11)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Lỗi");
                txtSDT.Focus();
                return false;
            }

            // Đủ 18 tuổi
            int tuoi = DateTime.Now.Year - dtpNgaysinh.Value.Year;
            if (dtpNgaysinh.Value.AddYears(tuoi) > DateTime.Now)
                tuoi--;

            if (tuoi < 18)
            {
                MessageBox.Show("Nhân viên phải đủ 18 tuổi", "Lỗi");
                return false;
            }

            return true;
        }

        private void txtSDT_TextChanged(object sender, KeyPressEventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadNhanVien(); // load lại toàn bộ
                return;
            }

            var ds = context.NhanVien
                .Where(nv =>
                    nv.MaNV.Contains(keyword) ||
                    nv.HoTen.Contains(keyword) ||
                    nv.VaiTro.Contains(keyword)
                )
                .Select(nv => new
                {
                    nv.Id,
                    nv.MaNV,
                    nv.HoTen,
                    nv.DangNhap,
                    nv.VaiTro,
                    nv.TrangThai,
                    nv.NgayTao
                })
                .ToList();

            dgvNhanVien.DataSource = ds;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem_Click(sender, e);
        }
    }
}
