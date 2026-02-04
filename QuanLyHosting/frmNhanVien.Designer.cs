namespace QuanLyHosting
{
    partial class frmNhanVien
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
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dtpNgaysinh = new DateTimePicker();
            label14 = new Label();
            txtDiaChi = new TextBox();
            label8 = new Label();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            txtTen = new TextBox();
            txtMaNV = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            txtMatkhau = new TextBox();
            txtDangNhap = new TextBox();
            cboVaitro = new ComboBox();
            cboTrangthai = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnHuyBo = new Button();
            btnThoat = new Button();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            dgvNhanVien = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
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
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(306, 32);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ NHÂN VIÊN";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpNgaysinh);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
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
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // dtpNgaysinh
            // 
            dtpNgaysinh.CustomFormat = "";
            dtpNgaysinh.Format = DateTimePickerFormat.Custom;
            dtpNgaysinh.Location = new Point(239, 257);
            dtpNgaysinh.Name = "dtpNgaysinh";
            dtpNgaysinh.Size = new Size(466, 30);
            dtpNgaysinh.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Black;
            label14.Location = new Point(41, 264);
            label14.Name = "label14";
            label14.Size = new Size(104, 23);
            label14.TabIndex = 11;
            label14.Text = "Ngày sinh :";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(239, 215);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(466, 30);
            txtDiaChi.TabIndex = 9;
            txtDiaChi.TextChanged += txtDiaChi_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(44, 222);
            label8.Name = "label8";
            label8.Size = new Size(80, 23);
            label8.TabIndex = 8;
            label8.Text = "Địa chỉ :";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(239, 174);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(466, 30);
            txtSDT.TabIndex = 7;
            txtSDT.KeyPress += txtSDT_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(239, 129);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(466, 30);
            txtEmail.TabIndex = 6;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(239, 83);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(466, 30);
            txtTen.TabIndex = 5;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(239, 37);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(466, 30);
            txtMaNV.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(41, 181);
            label7.Name = "label7";
            label7.Size = new Size(130, 23);
            label7.TabIndex = 3;
            label7.Text = "Số điện thoại :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(41, 136);
            label6.Name = "label6";
            label6.Size = new Size(70, 23);
            label6.TabIndex = 2;
            label6.Text = "Email :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(41, 90);
            label5.Name = "label5";
            label5.Size = new Size(109, 23);
            label5.TabIndex = 1;
            label5.Text = "Họ và Tên :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(41, 44);
            label4.Name = "label4";
            label4.Size = new Size(83, 23);
            label4.TabIndex = 0;
            label4.Text = "Mã NV :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtMatkhau);
            groupBox2.Controls.Add(txtDangNhap);
            groupBox2.Controls.Add(cboVaitro);
            groupBox2.Controls.Add(cboTrangthai);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.SteelBlue;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(824, 321);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tài khoản";
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(197, 93);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.Size = new Size(606, 30);
            txtMatkhau.TabIndex = 6;
            txtMatkhau.UseSystemPasswordChar = true;
            // 
            // txtDangNhap
            // 
            txtDangNhap.Enabled = false;
            txtDangNhap.Location = new Point(197, 37);
            txtDangNhap.Name = "txtDangNhap";
            txtDangNhap.Size = new Size(606, 30);
            txtDangNhap.TabIndex = 5;
            // 
            // cboVaitro
            // 
            cboVaitro.FormattingEnabled = true;
            cboVaitro.Location = new Point(197, 139);
            cboVaitro.Name = "cboVaitro";
            cboVaitro.Size = new Size(606, 31);
            cboVaitro.TabIndex = 3;
            // 
            // cboTrangthai
            // 
            cboTrangthai.FormattingEnabled = true;
            cboTrangthai.Location = new Point(197, 195);
            cboTrangthai.Name = "cboTrangthai";
            cboTrangthai.Size = new Size(606, 31);
            cboTrangthai.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Black;
            label12.Location = new Point(33, 205);
            label12.Name = "label12";
            label12.Size = new Size(109, 23);
            label12.TabIndex = 3;
            label12.Text = "Trạng thái :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Black;
            label11.Location = new Point(33, 149);
            label11.Name = "label11";
            label11.Size = new Size(79, 23);
            label11.TabIndex = 2;
            label11.Text = "Vai trò :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(33, 93);
            label10.Name = "label10";
            label10.Size = new Size(103, 23);
            label10.TabIndex = 1;
            label10.Text = "Mật khẩu :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(33, 47);
            label9.Name = "label9";
            label9.Size = new Size(144, 23);
            label9.TabIndex = 0;
            label9.Text = "Tên đăng nhập :";
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnThem.Location = new Point(19, 343);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(105, 46);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnXoa.Location = new Point(141, 343);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(105, 46);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 128, 128);
            btnSua.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSua.Location = new Point(269, 343);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(105, 46);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.DeepSkyBlue;
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnLuu.Location = new Point(395, 343);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(105, 46);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.Silver;
            btnHuyBo.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnHuyBo.Location = new Point(522, 343);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(105, 46);
            btnHuyBo.TabIndex = 7;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
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
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(1089, 343);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(419, 46);
            txtTimKiem.TabIndex = 9;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.Location = new Point(954, 343);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(129, 46);
            btnTimKiem.TabIndex = 11;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnTimKiem);
            panel2.Controls.Add(txtTimKiem);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnHuyBo);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnLuu);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(1619, 401);
            panel2.TabIndex = 12;
            panel2.Paint += panel2_Paint;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox2);
            panel4.Location = new Point(795, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(824, 321);
            panel4.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(739, 318);
            panel3.TabIndex = 12;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(0, 477);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(1619, 453);
            dgvNhanVien.TabIndex = 13;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1619, 930);
            Controls.Add(dgvNhanVien);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ NHÂN VIÊN";
            WindowState = FormWindowState.Maximized;
            Load += frmNhanVien_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtDiaChi;
        private Label label8;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private TextBox txtTen;
        private TextBox txtMaNV;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox cboVaitro;
        private ComboBox cboTrangthai;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox txtMatkhau;
        private TextBox txtDangNhap;
        private DateTimePicker dtpNgaysinh;
        private Label label14;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Button btnHuyBo;
        private Button btnThoat;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private DataGridView dgvNhanVien;
    }
}