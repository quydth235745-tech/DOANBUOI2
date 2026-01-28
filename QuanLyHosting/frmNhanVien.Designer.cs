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
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtChucvu = new TextBox();
            dtpNgaysinh = new DateTimePicker();
            label14 = new Label();
            label13 = new Label();
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
            txtTimkiem = new TextBox();
            dgvNhanVien = new DataGridView();
            MaNV = new DataGridViewTextBoxColumn();
            HovaTen = new DataGridViewTextBoxColumn();
            Tendangnhap = new DataGridViewTextBoxColumn();
            Vaitro = new DataGridViewTextBoxColumn();
            Trangthai = new DataGridViewTextBoxColumn();
            Ngaytao = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1273, 76);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(1154, 25);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Đăng xuất";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(1004, 28);
            label3.Name = "label3";
            label3.Size = new Size(113, 22);
            label3.TabIndex = 2;
            label3.Text = "Quản trị viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(889, 27);
            label2.Name = "label2";
            label2.Size = new Size(96, 22);
            label2.TabIndex = 1;
            label2.Text = "Admin      |";
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
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtChucvu);
            groupBox1.Controls.Add(dtpNgaysinh);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
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
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.SteelBlue;
            groupBox1.Location = new Point(21, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(575, 293);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtChucvu
            // 
            txtChucvu.Location = new Point(172, 253);
            txtChucvu.Name = "txtChucvu";
            txtChucvu.Size = new Size(371, 30);
            txtChucvu.TabIndex = 13;
            // 
            // dtpNgaysinh
            // 
            dtpNgaysinh.CustomFormat = "";
            dtpNgaysinh.Format = DateTimePickerFormat.Custom;
            dtpNgaysinh.Location = new Point(172, 217);
            dtpNgaysinh.Name = "dtpNgaysinh";
            dtpNgaysinh.Size = new Size(371, 30);
            dtpNgaysinh.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Black;
            label14.Location = new Point(41, 223);
            label14.Name = "label14";
            label14.Size = new Size(104, 23);
            label14.TabIndex = 11;
            label14.Text = "Ngày sinh :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Black;
            label13.Location = new Point(41, 260);
            label13.Name = "label13";
            label13.Size = new Size(92, 23);
            label13.TabIndex = 10;
            label13.Text = "Chức vụ :";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(172, 181);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(371, 30);
            txtDiaChi.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(41, 188);
            label8.Name = "label8";
            label8.Size = new Size(80, 23);
            label8.TabIndex = 8;
            label8.Text = "Địa chỉ :";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(172, 145);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(371, 30);
            txtSDT.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(172, 109);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(371, 30);
            txtEmail.TabIndex = 6;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(172, 73);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(371, 30);
            txtTen.TabIndex = 5;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(172, 37);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(371, 30);
            txtMaNV.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(41, 152);
            label7.Name = "label7";
            label7.Size = new Size(130, 23);
            label7.TabIndex = 3;
            label7.Text = "Số điện thoại :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(41, 116);
            label6.Name = "label6";
            label6.Size = new Size(70, 23);
            label6.TabIndex = 2;
            label6.Text = "Email :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(41, 80);
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
            groupBox2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.SteelBlue;
            groupBox2.Location = new Point(627, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(621, 283);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tài khoản";
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(202, 93);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.Size = new Size(353, 28);
            txtMatkhau.TabIndex = 6;
            // 
            // txtDangNhap
            // 
            txtDangNhap.Location = new Point(202, 37);
            txtDangNhap.Name = "txtDangNhap";
            txtDangNhap.Size = new Size(353, 28);
            txtDangNhap.TabIndex = 5;
            // 
            // cboVaitro
            // 
            cboVaitro.FormattingEnabled = true;
            cboVaitro.Location = new Point(202, 139);
            cboVaitro.Name = "cboVaitro";
            cboVaitro.Size = new Size(353, 28);
            cboVaitro.TabIndex = 3;
            // 
            // cboTrangthai
            // 
            cboTrangthai.FormattingEnabled = true;
            cboTrangthai.Location = new Point(202, 195);
            cboTrangthai.Name = "cboTrangthai";
            cboTrangthai.Size = new Size(353, 28);
            cboTrangthai.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Black;
            label12.Location = new Point(33, 205);
            label12.Name = "label12";
            label12.Size = new Size(99, 20);
            label12.TabIndex = 3;
            label12.Text = "Trạng thái :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Black;
            label11.Location = new Point(33, 149);
            label11.Name = "label11";
            label11.Size = new Size(71, 20);
            label11.TabIndex = 2;
            label11.Text = "Vai trò :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(33, 93);
            label10.Name = "label10";
            label10.Size = new Size(95, 20);
            label10.TabIndex = 1;
            label10.Text = "Mật khẩu :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(33, 37);
            label9.Name = "label9";
            label9.Size = new Size(135, 20);
            label9.TabIndex = 0;
            label9.Text = "Tên đăng nhập :";
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnThem.Location = new Point(41, 415);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(87, 46);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnXoa.Location = new Point(174, 415);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(87, 46);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSua.Location = new Point(311, 415);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(87, 46);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnLuu.Location = new Point(441, 415);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(87, 46);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnHuyBo.Location = new Point(578, 415);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(87, 46);
            btnHuyBo.TabIndex = 7;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(712, 415);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(83, 46);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(905, 415);
            txtTimkiem.Multiline = true;
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(343, 35);
            txtTimkiem.TabIndex = 9;
            txtTimkiem.Text = "🔍Search";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { MaNV, HovaTen, Tendangnhap, Vaitro, Trangthai, Ngaytao });
            dgvNhanVien.Location = new Point(18, 480);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(1230, 347);
            dgvNhanVien.TabIndex = 10;
            // 
            // MaNV
            // 
            MaNV.DataPropertyName = "MaNV";
            MaNV.HeaderText = "Mã NV";
            MaNV.MinimumWidth = 6;
            MaNV.Name = "MaNV";
            MaNV.ReadOnly = true;
            // 
            // HovaTen
            // 
            HovaTen.DataPropertyName = "HovaTen";
            HovaTen.HeaderText = "Họ và Tên";
            HovaTen.MinimumWidth = 6;
            HovaTen.Name = "HovaTen";
            HovaTen.ReadOnly = true;
            // 
            // Tendangnhap
            // 
            Tendangnhap.DataPropertyName = "Tendangnhap";
            Tendangnhap.HeaderText = "Tên đăng nhập";
            Tendangnhap.MinimumWidth = 6;
            Tendangnhap.Name = "Tendangnhap";
            Tendangnhap.ReadOnly = true;
            // 
            // Vaitro
            // 
            Vaitro.DataPropertyName = "Vaitro";
            Vaitro.HeaderText = "Vai trò";
            Vaitro.MinimumWidth = 6;
            Vaitro.Name = "Vaitro";
            Vaitro.ReadOnly = true;
            // 
            // Trangthai
            // 
            Trangthai.DataPropertyName = "Trangthai";
            Trangthai.HeaderText = "Trạng thái";
            Trangthai.MinimumWidth = 6;
            Trangthai.Name = "Trangthai";
            Trangthai.ReadOnly = true;
            // 
            // Ngaytao
            // 
            Ngaytao.DataPropertyName = "Ngaytao";
            Ngaytao.HeaderText = "Ngày tạo";
            Ngaytao.MinimumWidth = 6;
            Ngaytao.Name = "Ngaytao";
            Ngaytao.ReadOnly = true;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1273, 839);
            Controls.Add(dgvNhanVien);
            Controls.Add(txtTimkiem);
            Controls.Add(btnThoat);
            Controls.Add(btnHuyBo);
            Controls.Add(btnLuu);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button button1;
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
        private TextBox txtChucvu;
        private DateTimePicker dtpNgaysinh;
        private Label label14;
        private Label label13;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Button btnHuyBo;
        private Button btnThoat;
        private TextBox txtTimkiem;
        private DataGridView dgvNhanVien;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn HovaTen;
        private DataGridViewTextBoxColumn Tendangnhap;
        private DataGridViewTextBoxColumn Vaitro;
        private DataGridViewTextBoxColumn Trangthai;
        private DataGridViewTextBoxColumn Ngaytao;
    }
}