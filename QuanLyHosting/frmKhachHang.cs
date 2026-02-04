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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        QLHTDbContext context = new QLHTDbContext();
        bool xuLyThem = false;
        int idKhachChon = -1;

        // Hàm bật tắt các ô nhập liệu
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            txtMaKH.Enabled = giaTri;
            txtHoTen.Enabled = giaTri;
            txtEmail.Enabled = giaTri;
            txtSDT.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtCCCD.Enabled = giaTri;
            cboGoiMua.Enabled = giaTri;
            dtpNgayMua.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            // 1. Nạp danh sách Gói Hosting vào ComboBox trước
            var dsGoi = context.GoiHosting.ToList();
            if (dsGoi != null && dsGoi.Count > 0)
            {
                cboGoiMua.DataSource = dsGoi;
                cboGoiMua.DisplayMember = "TenGoi"; // Hiện tên gói cho ní chọn
                cboGoiMua.ValueMember = "ID";      // Lưu mã ID ngầm bên dưới
            }

            // 2. Sau đó mới Load dữ liệu khách hàng
            LoadData();
            BatTatChucNang(false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            // Xóa trắng các ô để nhập mới
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtCCCD.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow != null)
            {
                if (MessageBox.Show("Xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells["ID"].Value);
                    var kh = context.KhachHang.Find(id);
                    if (kh != null)
                    {
                        context.KhachHang.Remove(kh);
                        context.SaveChanges();
                    }
                    frmKhachHang_Load(sender, e);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow != null)
            {
                xuLyThem = false;
                BatTatChucNang(true);
                idKhachChon = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells["ID"].Value);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng!");
                return;
            }

            try
            {
                if (xuLyThem)
                {
                    KhachHang kh = new KhachHang();
                    kh.HoTen = txtHoTen.Text;
                    kh.Email = txtEmail.Text;
                    kh.DienThoai = txtSDT.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    kh.NgayDangKy = dtpNgayMua.Value;

                    // Gán MaGoi từ ComboBox
                    if (cboGoiMua.SelectedValue != null)
                        kh.MaGoi = (int)cboGoiMua.SelectedValue;

                    context.KhachHang.Add(kh);
                }
                else // Chế độ CẬP NHẬT
                {
                    var kh = context.KhachHang.Find(idKhachChon);
                    if (kh != null)
                    {
                        kh.HoTen = txtHoTen.Text;
                        kh.Email = txtEmail.Text;
                        kh.DienThoai = txtSDT.Text;
                        kh.DiaChi = txtDiaChi.Text;
                        kh.NgayDangKy = dtpNgayMua.Value;

                        // Cập nhật luôn MaGoi khi sửa
                        if (cboGoiMua.SelectedValue != null)
                            kh.MaGoi = (int)cboGoiMua.SelectedValue;
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Đã lưu thông tin khách hàng thành công!");
                frmKhachHang_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // 1. Khóa các chức năng nhập liệu lại
            BatTatChucNang(false);

            // 2. Xóa sạch các ô nhập liệu để tránh nhầm lẫn
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtCCCD.Clear();
            txtGiaGoi.Clear();

            // 3. Nạp lại dữ liệu lên bảng để đồng bộ
            frmKhachHang_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];

                // Đổ dữ liệu lên các ô TextBox
                txtMaKH.Text = row.Cells["ID"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtSDT.Text = row.Cells["DienThoai"].Value.ToString(); // Phải khớp với model
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();

                if (row.Cells["NgayDangKy"].Value != null)
                    dtpNgayMua.Value = Convert.ToDateTime(row.Cells["NgayDangKy"].Value);

                // Mở khóa các nút để Sửa hoặc Xóa
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                if (row.Cells["MaGoi"].Value != null)
                    cboGoiMua.SelectedValue = row.Cells["MaGoi"].Value;
            }
        }
        private void LoadData()
        {
            try
            {
                // 1. Lấy toàn bộ danh sách khách hàng từ context
                var listKH = context.KhachHang.ToList();

                // 2. Gán dữ liệu vào DataGridView
                dgvKhachHang.DataSource = listKH;

                // 3. Chỉnh sửa tiêu đề cột cho đẹp (Tiếng Việt)
                dgvKhachHang.Columns["ID"].HeaderText = "Mã KH";
                dgvKhachHang.Columns["HoTen"].HeaderText = "Họ và Tên";
                dgvKhachHang.Columns["Email"].HeaderText = "Email";
                dgvKhachHang.Columns["DienThoai"].HeaderText = "Số điện thoại";
                dgvKhachHang.Columns["DiaChi"].HeaderText = "Địa chỉ";
                dgvKhachHang.Columns["NgayDangKy"].HeaderText = "Ngày Mua";
                //dgvKhachHang.Columns["ID"].HeaderText = "Mã Gói";

                // 4. Ẩn bớt các cột ID và cột quan hệ để giao diện gọn hơn
                dgvKhachHang.Columns["ID"].Visible = false; // Ẩn ID vì ní không dùng tới
                if (dgvKhachHang.Columns["Hosting"] != null) dgvKhachHang.Columns["Hosting"].Visible = false;
                if (dgvKhachHang.Columns["HoaDon"] != null) dgvKhachHang.Columns["HoaDon"].Visible = false;

                // 5. Làm mới lại bảng
                dgvKhachHang.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void cboGoiMua_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu đã chọn một gói hợp lệ
            if (cboGoiMua.SelectedItem is GoiHosting goiChon)
            {
                // Hiển thị giá tiền vào ô txtGiaGoi, định dạng có dấu phân cách hàng nghìn
                txtGiaGoi.Text = goiChon.GiaThang.ToString("N0") + " VNĐ";
            }
        }
    }
}
