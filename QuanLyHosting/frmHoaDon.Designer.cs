namespace QuanLyHosting
{
    partial class frmHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvHoaDon = new DataGridView();
            panel4 = new Panel();
            groupBox2 = new GroupBox();
            numSoLuong = new NumericUpDown();
            label8 = new Label();
            txtThanhTien = new TextBox();
            label6 = new Label();
            cboTrangThai = new ComboBox();
            label2 = new Label();
            txtGoiMua = new TextBox();
            txtDonGia = new TextBox();
            label10 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            btnXuatHD = new Button();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            txtGhiChu = new TextBox();
            label9 = new Label();
            cboNhanVien = new ComboBox();
            label7 = new Label();
            cboKhachHang = new ComboBox();
            dtpNgayLap = new DateTimePicker();
            label14 = new Label();
            txtMaHD = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btnTimKiemHD = new Button();
            txtTimKiemHD = new TextBox();
            btnThemHD = new Button();
            btnThoat = new Button();
            btnXoaHD = new Button();
            btnHuyBoHD = new Button();
            btnSuaHD = new Button();
            btnLuuHD = new Button();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            panel4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Location = new Point(0, 477);
            dgvHoaDon.MultiSelect = false;
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.Size = new Size(1619, 453);
            dgvHoaDon.TabIndex = 16;
            dgvHoaDon.CellClick += dgvHoaDon_CellClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox2);
            panel4.Location = new Point(795, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(824, 321);
            panel4.TabIndex = 13;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numSoLuong);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtThanhTien);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cboTrangThai);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtGoiMua);
            groupBox2.Controls.Add(txtDonGia);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label3);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.SteelBlue;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(824, 321);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(181, 204);
            numSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(282, 30);
            numSoLuong.TabIndex = 30;
            numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numSoLuong.ValueChanged += numSoLuong_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(54, 208);
            label8.Name = "label8";
            label8.Size = new Size(104, 23);
            label8.TabIndex = 29;
            label8.Text = "Số Lượng :";
            // 
            // txtThanhTien
            // 
            txtThanhTien.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txtThanhTien.Location = new Point(181, 253);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(515, 30);
            txtThanhTien.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(54, 260);
            label6.Name = "label6";
            label6.Size = new Size(118, 23);
            label6.TabIndex = 27;
            label6.Text = "Thành Tiền :";
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Đã thanh toán", "Chưa thanh toán " });
            cboTrangThai.Location = new Point(181, 97);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(515, 31);
            cboTrangThai.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(51, 105);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 25;
            label2.Text = "Trạng Thái :";
            // 
            // txtGoiMua
            // 
            txtGoiMua.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txtGoiMua.Location = new Point(181, 40);
            txtGoiMua.Name = "txtGoiMua";
            txtGoiMua.Size = new Size(515, 30);
            txtGoiMua.TabIndex = 24;
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txtDonGia.Location = new Point(181, 151);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.ReadOnly = true;
            txtDonGia.Size = new Size(282, 30);
            txtDonGia.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(54, 158);
            label10.Name = "label10";
            label10.Size = new Size(93, 23);
            label10.TabIndex = 22;
            label10.Text = "Đơn Giá :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(51, 47);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 19;
            label3.Text = "Gói Mua :";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnXuatHD);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnTimKiemHD);
            panel2.Controls.Add(txtTimKiemHD);
            panel2.Controls.Add(btnThemHD);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnXoaHD);
            panel2.Controls.Add(btnHuyBoHD);
            panel2.Controls.Add(btnSuaHD);
            panel2.Controls.Add(btnLuuHD);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(1619, 401);
            panel2.TabIndex = 15;
            // 
            // btnXuatHD
            // 
            btnXuatHD.BackColor = Color.LemonChiffon;
            btnXuatHD.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuatHD.ForeColor = Color.Peru;
            btnXuatHD.Location = new Point(773, 343);
            btnXuatHD.Name = "btnXuatHD";
            btnXuatHD.Size = new Size(109, 46);
            btnXuatHD.TabIndex = 14;
            btnXuatHD.Text = "Xuất HD";
            btnXuatHD.UseVisualStyleBackColor = false;
            btnXuatHD.Click += btnXuatHD_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(739, 318);
            panel3.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(dtpNgayLap);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txtMaHD);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.SteelBlue;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(739, 318);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(186, 229);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(547, 78);
            txtGhiChu.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(26, 241);
            label9.Name = "label9";
            label9.Size = new Size(93, 23);
            label9.TabIndex = 16;
            label9.Text = "Ghi Chú :";
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(224, 141);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(466, 31);
            cboNhanVien.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(26, 149);
            label7.Name = "label7";
            label7.Size = new Size(146, 23);
            label7.TabIndex = 14;
            label7.Text = "Nhân Viên Lập :";
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(224, 88);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(466, 31);
            cboKhachHang.TabIndex = 13;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.CustomFormat = "";
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.Location = new Point(224, 193);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(211, 30);
            dtpNgayLap.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Black;
            label14.Location = new Point(26, 200);
            label14.Name = "label14";
            label14.Size = new Size(104, 23);
            label14.TabIndex = 11;
            label14.Text = "Ngày Lập :";
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(224, 40);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(466, 30);
            txtMaHD.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(26, 96);
            label5.Name = "label5";
            label5.Size = new Size(162, 23);
            label5.TabIndex = 1;
            label5.Text = "Tên Khách Hàng :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(26, 47);
            label4.Name = "label4";
            label4.Size = new Size(130, 23);
            label4.TabIndex = 0;
            label4.Text = "Mã Hóa Đơn :";
            // 
            // btnTimKiemHD
            // 
            btnTimKiemHD.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiemHD.Location = new Point(954, 343);
            btnTimKiemHD.Name = "btnTimKiemHD";
            btnTimKiemHD.Size = new Size(129, 46);
            btnTimKiemHD.TabIndex = 11;
            btnTimKiemHD.Text = "Tìm Kiếm";
            btnTimKiemHD.UseVisualStyleBackColor = true;
            // 
            // txtTimKiemHD
            // 
            txtTimKiemHD.Location = new Point(1089, 343);
            txtTimKiemHD.Multiline = true;
            txtTimKiemHD.Name = "txtTimKiemHD";
            txtTimKiemHD.Size = new Size(419, 46);
            txtTimKiemHD.TabIndex = 9;
            // 
            // btnThemHD
            // 
            btnThemHD.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnThemHD.Location = new Point(19, 343);
            btnThemHD.Name = "btnThemHD";
            btnThemHD.Size = new Size(105, 46);
            btnThemHD.TabIndex = 3;
            btnThemHD.Text = "Thêm";
            btnThemHD.UseVisualStyleBackColor = true;
            btnThemHD.Click += btnThemHD_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(641, 343);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(101, 46);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoaHD
            // 
            btnXoaHD.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnXoaHD.Location = new Point(141, 343);
            btnXoaHD.Name = "btnXoaHD";
            btnXoaHD.Size = new Size(105, 46);
            btnXoaHD.TabIndex = 4;
            btnXoaHD.Text = "Xóa";
            btnXoaHD.UseVisualStyleBackColor = true;
            btnXoaHD.Click += btnXoaHD_Click;
            // 
            // btnHuyBoHD
            // 
            btnHuyBoHD.BackColor = Color.Silver;
            btnHuyBoHD.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnHuyBoHD.Location = new Point(522, 343);
            btnHuyBoHD.Name = "btnHuyBoHD";
            btnHuyBoHD.Size = new Size(105, 46);
            btnHuyBoHD.TabIndex = 7;
            btnHuyBoHD.Text = "Hủy bỏ";
            btnHuyBoHD.UseVisualStyleBackColor = false;
            btnHuyBoHD.Click += btnHuyBoHD_Click;
            // 
            // btnSuaHD
            // 
            btnSuaHD.BackColor = Color.FromArgb(255, 128, 128);
            btnSuaHD.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSuaHD.Location = new Point(269, 343);
            btnSuaHD.Name = "btnSuaHD";
            btnSuaHD.Size = new Size(105, 46);
            btnSuaHD.TabIndex = 5;
            btnSuaHD.Text = "Sửa";
            btnSuaHD.UseVisualStyleBackColor = false;
            btnSuaHD.Click += btnSuaHD_Click;
            // 
            // btnLuuHD
            // 
            btnLuuHD.BackColor = Color.DeepSkyBlue;
            btnLuuHD.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnLuuHD.Location = new Point(395, 343);
            btnLuuHD.Name = "btnLuuHD";
            btnLuuHD.Size = new Size(105, 46);
            btnLuuHD.TabIndex = 6;
            btnLuuHD.Text = "Lưu";
            btnLuuHD.UseVisualStyleBackColor = false;
            btnLuuHD.Click += btnLuuHD_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1619, 76);
            panel1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(280, 32);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1619, 930);
            Controls.Add(dgvHoaDon);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHoaDon";
            Text = "frmHoaDon";
            Load += frmHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            panel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel4;
        private GroupBox groupBox2;
        private Panel panel2;
        private Panel panel3;
        private GroupBox groupBox1;
        private ComboBox cboKhachHang;
        private DateTimePicker dtpNgayLap;
        private Label label14;
        private TextBox txtMaHD;
        private Label label5;
        private Label label4;
        private Button btnTimKiemHD;
        private TextBox txtTimKiemHD;
        private Button btnThemHD;
        private Button btnThoat;
        private Button btnXoaHD;
        private Button btnHuyBoHD;
        private Button btnSuaHD;
        private Button btnLuuHD;
        private Panel panel1;
        private Label label1;
        private ComboBox cboTrangThai;
        private Label label2;
        private TextBox txtGoiMua;
        private TextBox txtDonGia;
        private Label label10;
        private Label label3;
        private Label label8;
        private TextBox txtThanhTien;
        private Label label6;
        private ComboBox cboNhanVien;
        private Label label7;
        private TextBox txtGhiChu;
        private Label label9;
        private NumericUpDown numSoLuong;
        private Button btnXuatHD;
        private DataGridView dgvHoaDon;
    }
}