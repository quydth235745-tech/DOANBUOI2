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
            dgvNhanVien.DataSource = context.NhanVien.ToList();
            BatTatChucNang(true);
            LoadNhanVien();
        }
        void BatTatChucNang(bool giaTri)
        {
            btnThem.Enabled = giaTri;
            btnSua.Enabled = giaTri;
            btnXoa.Enabled = giaTri;

            btnLuu.Enabled = !giaTri;
            btnHuyBo.Enabled = !giaTri;

            txtMaNV.Enabled = !giaTri;
            txtTen.Enabled = !giaTri;
            txtEmail.Enabled = !giaTri;
            txtSDT.Enabled = !giaTri;
            txtDiaChi.Enabled = !giaTri;
            txtDangNhap.Enabled = !giaTri;
            txtMatkhau.Enabled = !giaTri;
            cboVaitro.Enabled = !giaTri;
            cboTrangthai.Enabled = !giaTri;
            dtpNgaysinh.Enabled = !giaTri;
        }
        private void LoadNhanVien()
        {
            dgvNhanVien.DataSource = context.NhanVien
         .Select(nv => new
         {
             nv.Id,
             nv.MaNV,
             nv.HoTen,
             nv.DangNhap,
             nv.VaiTro,
             nv.TrangThai,
             nv.NgayTao
         }).ToList();

            BatTatChucNang(false);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
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
            if (dgvNhanVien.CurrentRow == null)
                return;

            int id = Convert.ToInt32(
                dgvNhanVien.CurrentRow.Cells["ID"].Value.ToString()
            );

            var nv = context.NhanVien.Find(id);
            if (nv != null)
            {
                DialogResult rs = MessageBox.Show(
                    "Bạn có chắc muốn xóa nhân viên này?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (rs == DialogResult.Yes)
                {
                    context.NhanVien.Remove(nv);
                    context.SaveChanges();
                    frmNhanVien_Load(sender, e);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);

            id = Convert.ToInt32(
                dgvNhanVien.CurrentRow.Cells["ID"].Value.ToString()
            );
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên");
                return;
            }

            if (xuLyThem)
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = txtMaNV.Text;
                nv.HoTen = txtTen.Text;
                nv.Email = txtEmail.Text;
                nv.DienThoai = txtSDT.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.NgaySinh = dtpNgaysinh.Value;
                nv.DangNhap = txtDangNhap.Text;
                nv.MatKhau = txtMatkhau.Text;
                nv.VaiTro = cboVaitro.Text;
                nv.TrangThai = cboTrangthai.Text;
                nv.NgayTao = DateTime.Now;

                context.NhanVien.Add(nv);
                context.SaveChanges();
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

                    context.NhanVien.Update(nv);
                    context.SaveChanges();
                }
            }

            frmNhanVien_Load(sender, e);
            BatTatChucNang(false);

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
    }
}
