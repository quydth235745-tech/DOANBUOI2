namespace QuanLyHosting
{
    partial class frmGoiHosting
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
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            numDungLuong = new NumericUpDown();
            numBangThong = new NumericUpDown();
            txtMoTa = new TextBox();
            txtGiaGoi = new TextBox();
            txtTenGoi = new TextBox();
            txtIDGoi = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
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
            dgvGoiHosting = new DataGridView();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDungLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBangThong).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGoiHosting).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1619, 318);
            panel3.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numDungLuong);
            groupBox1.Controls.Add(numBangThong);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(txtGiaGoi);
            groupBox1.Controls.Add(txtTenGoi);
            groupBox1.Controls.Add(txtIDGoi);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.SteelBlue;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1619, 318);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin gói";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(835, 95);
            label3.Name = "label3";
            label3.Size = new Size(123, 23);
            label3.TabIndex = 11;
            label3.Text = "Băng Thông :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(835, 40);
            label2.Name = "label2";
            label2.Size = new Size(127, 23);
            label2.TabIndex = 10;
            label2.Text = "Dung Lượng :";
            // 
            // numDungLuong
            // 
            numDungLuong.Location = new Point(1010, 38);
            numDungLuong.Name = "numDungLuong";
            numDungLuong.Size = new Size(359, 30);
            numDungLuong.TabIndex = 9;
            // 
            // numBangThong
            // 
            numBangThong.Location = new Point(1010, 88);
            numBangThong.Name = "numBangThong";
            numBangThong.Size = new Size(359, 30);
            numBangThong.TabIndex = 8;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(160, 195);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(1360, 92);
            txtMoTa.TabIndex = 7;
            // 
            // txtGiaGoi
            // 
            txtGiaGoi.Location = new Point(160, 139);
            txtGiaGoi.Name = "txtGiaGoi";
            txtGiaGoi.Size = new Size(545, 30);
            txtGiaGoi.TabIndex = 6;
            txtGiaGoi.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTenGoi
            // 
            txtTenGoi.Location = new Point(160, 83);
            txtTenGoi.Name = "txtTenGoi";
            txtTenGoi.Size = new Size(545, 30);
            txtTenGoi.TabIndex = 5;
            // 
            // txtIDGoi
            // 
            txtIDGoi.Location = new Point(160, 37);
            txtIDGoi.Name = "txtIDGoi";
            txtIDGoi.ReadOnly = true;
            txtIDGoi.Size = new Size(545, 30);
            txtIDGoi.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(41, 218);
            label7.Name = "label7";
            label7.Size = new Size(72, 23);
            label7.TabIndex = 3;
            label7.Text = "Mô tả :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(41, 146);
            label6.Name = "label6";
            label6.Size = new Size(111, 23);
            label6.TabIndex = 2;
            label6.Text = "Giá Tháng :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(41, 90);
            label5.Name = "label5";
            label5.Size = new Size(90, 23);
            label5.TabIndex = 1;
            label5.Text = "Tên Gói :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(41, 44);
            label4.Name = "label4";
            label4.Size = new Size(79, 23);
            label4.TabIndex = 0;
            label4.Text = "ID Gói :";
            // 
            // panel2
            // 
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
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.Location = new Point(1034, 343);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(129, 46);
            btnTimKiem.TabIndex = 11;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(1169, 343);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(419, 46);
            txtTimKiem.TabIndex = 9;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnThem.Location = new Point(21, 343);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(146, 46);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(781, 343);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(142, 46);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnXoa.Location = new Point(173, 343);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(146, 46);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.Silver;
            btnHuyBo.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnHuyBo.Location = new Point(629, 343);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(146, 46);
            btnHuyBo.TabIndex = 7;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 128, 128);
            btnSua.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSua.Location = new Point(325, 343);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(146, 46);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.DeepSkyBlue;
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnLuu.Location = new Point(477, 343);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(146, 46);
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
            panel1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(340, 32);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ GÓI HOSTING";
            // 
            // dgvGoiHosting
            // 
            dgvGoiHosting.AllowUserToAddRows = false;
            dgvGoiHosting.AllowUserToDeleteRows = false;
            dgvGoiHosting.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGoiHosting.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGoiHosting.Dock = DockStyle.Fill;
            dgvGoiHosting.Location = new Point(0, 477);
            dgvGoiHosting.MultiSelect = false;
            dgvGoiHosting.Name = "dgvGoiHosting";
            dgvGoiHosting.RowHeadersWidth = 51;
            dgvGoiHosting.Size = new Size(1619, 453);
            dgvGoiHosting.TabIndex = 16;
            // 
            // frmGoiHosting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1619, 930);
            Controls.Add(dgvGoiHosting);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmGoiHosting";
            Text = "Gói Hosting";
            Load += frmGoiHosting_Load;
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDungLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBangThong).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGoiHosting).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private GroupBox groupBox1;
        private TextBox txtMoTa;
        private TextBox txtGiaGoi;
        private TextBox txtTenGoi;
        private TextBox txtIDGoi;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel2;
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
        private Label label3;
        private Label label2;
        private NumericUpDown numDungLuong;
        private NumericUpDown numBangThong;
        private DataGridView dgvGoiHosting;
    }
}