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
    public partial class frmGoiHosting : Form
    {
        public frmGoiHosting()
        {
            InitializeComponent();
        }
        QLHTDbContext context = new QLHTDbContext(); // Context kết nối DB
        bool xuLyThem = false; // Biến phân biệt thêm mới hay cập nhật
        int idGoiChon = -1; // Lưu ID dòng đang chọn để Sửa/Xóa
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            txtTenGoi.Enabled = giaTri;
            txtGiaGoi.Enabled = giaTri;
            numDungLuong.Enabled = giaTri;
            numBangThong.Enabled = giaTri;
            txtMoTa.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmGoiHossting_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            // Xóa trắng các ô nhập
            txtIDGoi.Clear();
            txtTenGoi.Clear();
            txtGiaGoi.Clear();
            txtMoTa.Clear();
            numDungLuong.Value = 0;
            numBangThong.Value = 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGoiHosting.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa gói hosting này?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvGoiHosting.CurrentRow.Cells["ID"].Value);
                    GoiHosting gh = context.GoiHosting.Find(id);
                    if (gh != null)
                    {
                        context.GoiHosting.Remove(gh);
                        context.SaveChanges();
                    }
                    frmGoiHosting_Load(sender, e);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvGoiHosting.CurrentRow != null)
            {
                xuLyThem = false;
                BatTatChucNang(true);
                // Lấy ID dòng đang chọn
                idGoiChon = Convert.ToInt32(dgvGoiHosting.CurrentRow.Cells["ID"].Value);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenGoi.Text))
            {
                MessageBox.Show("Vui lòng nhập tên gói hosting!");
                return;
            }

            if (xuLyThem) // Chế độ Thêm mới
            {
                GoiHosting gh = new GoiHosting();
                gh.TenGoi = txtTenGoi.Text;
                gh.DungLuongGB = (int)numDungLuong.Value;
                gh.BangThongGB = (int)numBangThong.Value;
                gh.GiaThang = decimal.Parse(txtGiaGoi.Text);
                gh.MoTa = txtMoTa.Text;

                context.GoiHosting.Add(gh);
            }
            else // Chế độ Sửa
            {
                GoiHosting gh = context.GoiHosting.Find(idGoiChon);
                if (gh != null)
                {
                    gh.TenGoi = txtTenGoi.Text;
                    gh.DungLuongGB = (int)numDungLuong.Value;
                    gh.BangThongGB = (int)numBangThong.Value;
                    gh.GiaThang = decimal.Parse(txtGiaGoi.Text);
                    gh.MoTa = txtMoTa.Text;
                }
            }
            context.SaveChanges(); // Lưu vào Database
            frmGoiHosting_Load(sender, e); // Tải lại bảng
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmGoiHosting_Load(sender, e); // Thoát trạng thái nhập liệu, nạp lại dữ liệu gốc
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmGoiHosting_Load(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ bảng GoiHostings trong Database
            var danhSachGoi = context.GoiHosting.ToList();

            // Gán dữ liệu vào DataGridView để nó hiện lên màn hình
            dgvGoiHosting.DataSource = danhSachGoi;

            BatTatChucNang(false); // Khóa các ô nhập liệu lúc mới mở for
        }

        private void dgvGoiHosting_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có bấm vào dòng dữ liệu không (tránh bấm vào tiêu đề)
            if (e.RowIndex >= 0)
            {
                // Lấy dòng hiện tại đang được chọn
                DataGridViewRow row = dgvGoiHosting.Rows[e.RowIndex];

                // Đổ dữ liệu từ các cột của dòng đó lên các TextBox tương ứng
                txtIDGoi.Text = row.Cells["ID"].Value.ToString();
                txtTenGoi.Text = row.Cells["TenGoi"].Value.ToString();

                // Chú ý: numDungLuong và numBangThong là kiểu NumericUpDown nên dùng .Value
                numDungLuong.Value = Convert.ToDecimal(row.Cells["DungLuongGB"].Value);
                numBangThong.Value = Convert.ToDecimal(row.Cells["BangThongGB"].Value);

                txtGiaGoi.Text = row.Cells["GiaThang"].Value.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value?.ToString(); // Dấu ? để tránh lỗi nếu mô tả bị trống

                // Khi đã chọn 1 dòng thì cho phép nhấn Sửa hoặc Xóa
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            void LoadData()
            {
                var list = context.GoiHosting.ToList();
                dgvGoiHosting.DataSource = list;

                // Đổi tên tiêu đề cột hiển thị trên DataGridView
                dgvGoiHosting.Columns["ID"].HeaderText = "Mã Gói";
                dgvGoiHosting.Columns["TenGoi"].HeaderText = "Tên Gói Hosting";
                dgvGoiHosting.Columns["DungLuongGB"].HeaderText = "Dung Lượng (GB)";
                dgvGoiHosting.Columns["BangThongGB"].HeaderText = "Băng Thông (GB)";
                dgvGoiHosting.Columns["GiaThang"].HeaderText = "Giá / Tháng";
                dgvGoiHosting.Columns["MoTa"].HeaderText = "Mô Tả Chi Tiết";

                // Ẩn các cột không cần thiết (như cột quan hệ bảng Hosting)
                if (dgvGoiHosting.Columns["Hosting"] != null)
                    dgvGoiHosting.Columns["Hosting"].Visible = false;
            }
        }
    }
}
