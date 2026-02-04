namespace QuanLyHosting
{
    partial class frmKhachHang
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
            dgvKhachHang = new DataGridView();
            panel2 = new Panel();
            panel4 = new Panel();
            groupBox2 = new GroupBox();
            cboGoiMua = new ComboBox();
            txtGiaGoi = new TextBox();
            label10 = new Label();
            dtpNgayMua = new DateTimePicker();
            label9 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            txtCCCD = new TextBox();
            label2 = new Label();
            txtDiaChi = new TextBox();
            label8 = new Label();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            txtHoTen = new TextBox();
            txtMaKH = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            btnThem = new Button();
            btnThoat = new Button();
            btnXoa = new Button();
            btnHuyBo = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            groupBox2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(0, 477);
            dgvKhachHang.MultiSelect = false;
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.Size = new Size(1619, 453);
            dgvKhachHang.TabIndex = 16;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
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
            panel2.TabIndex = 15;
            panel2.Paint += panel2_Paint;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox2);
            panel4.Location = new Point(877, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(742, 318);
            panel4.TabIndex = 14;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboGoiMua);
            groupBox2.Controls.Add(txtGiaGoi);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(dtpNgayMua);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label3);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.SteelBlue;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(742, 318);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Đăng ký Dịch vụ";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // cboGoiMua
            // 
            cboGoiMua.FormattingEnabled = true;
            cboGoiMua.Location = new Point(191, 75);
            cboGoiMua.Name = "cboGoiMua";
            cboGoiMua.Size = new Size(471, 31);
            cboGoiMua.TabIndex = 18;
            cboGoiMua.SelectedIndexChanged += cboGoiMua_SelectedIndexChanged;
            // 
            // txtGiaGoi
            // 
            txtGiaGoi.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txtGiaGoi.Location = new Point(191, 187);
            txtGiaGoi.Name = "txtGiaGoi";
            txtGiaGoi.Size = new Size(466, 30);
            txtGiaGoi.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(61, 187);
            label10.Name = "label10";
            label10.Size = new Size(89, 23);
            label10.TabIndex = 16;
            label10.Text = "Giá Gói :";
            // 
            // dtpNgayMua
            // 
            dtpNgayMua.CustomFormat = "dd/mm/yyyy";
            dtpNgayMua.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            dtpNgayMua.Format = DateTimePickerFormat.Custom;
            dtpNgayMua.Location = new Point(191, 133);
            dtpNgayMua.Name = "dtpNgayMua";
            dtpNgayMua.Size = new Size(342, 30);
            dtpNgayMua.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(61, 138);
            label9.Name = "label9";
            label9.Size = new Size(109, 23);
            label9.TabIndex = 14;
            label9.Text = "Ngày Mua :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(61, 83);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 12;
            label3.Text = "Gói Mua :";
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(742, 318);
            panel3.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCCCD);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtMaKH);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.SteelBlue;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(739, 318);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(239, 262);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(466, 30);
            txtCCCD.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(44, 269);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 10;
            label2.Text = "CCCD :";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(239, 215);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(466, 30);
            txtDiaChi.TabIndex = 9;
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
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(239, 129);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(466, 30);
            txtEmail.TabIndex = 6;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(239, 83);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(466, 30);
            txtHoTen.TabIndex = 5;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(239, 37);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(466, 30);
            txtMaKH.TabIndex = 4;
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
            label4.Size = new Size(153, 23);
            label4.TabIndex = 0;
            label4.Text = "Mã Khách hàng :";
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
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(1089, 343);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(419, 46);
            txtTimKiem.TabIndex = 9;
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
            label1.Size = new Size(347, 32);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1619, 930);
            Controls.Add(dgvKhachHang);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmKhachHang";
            Text = "frmKhachHang";
            Load += frmKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvKhachHang;
        private Panel panel2;
        private Panel panel3;
        private GroupBox groupBox1;
        private TextBox txtDiaChi;
        private Label label8;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private TextBox txtHoTen;
        private TextBox txtMaKH;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Button btnThem;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnHuyBo;
        private Button btnSua;
        private Button btnLuu;
        private Panel panel1;
        private Label label1;
        private Panel panel4;
        private TextBox txtCCCD;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private TextBox txtGiaGoi;
        private Label label10;
        private DateTimePicker dtpNgayMua;
        private Label label9;
        private ComboBox cboGoiMua;
    }
}