namespace QLDaoTao
{
    partial class GiaoDienChinh
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
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemTaiKhoan = new System.Windows.Forms.MenuItem();
            this.menuItemDangNhap = new System.Windows.Forms.MenuItem();
            this.menuItemDangKi = new System.Windows.Forms.MenuItem();
            this.menuItemThongTinCaNhan = new System.Windows.Forms.MenuItem();
            this.menuItemCapNhatMatKhau = new System.Windows.Forms.MenuItem();
            this.menuItemDangXuat = new System.Windows.Forms.MenuItem();
            this.menuItemQuanLi = new System.Windows.Forms.MenuItem();
            this.menuItemQuanLiDanhSachTaiKhoan = new System.Windows.Forms.MenuItem();
            this.menuItemQuanLiDanhSachMonHoc = new System.Windows.Forms.MenuItem();
            this.menuItemQuanLiDanhSachKhoaHoc = new System.Windows.Forms.MenuItem();
            this.menuItemKhoaHoc = new System.Windows.Forms.MenuItem();
            this.menuItemDanhSachKhoaHoc = new System.Windows.Forms.MenuItem();
            this.menuItemDanhSachTheoHoc = new System.Windows.Forms.MenuItem();
            this.menuItemLichSuLamBai = new System.Windows.Forms.MenuItem();
            this.menuItemDanhSachGiangDay = new System.Windows.Forms.MenuItem();
            this.menuItemBangDiem = new System.Windows.Forms.MenuItem();
            this.menuItemBaoCao = new System.Windows.Forms.MenuItem();
            this.menuItemKhoaHocDuocQuanTamNhat = new System.Windows.Forms.MenuItem();
            this.menuItemAbout = new System.Windows.Forms.MenuItem();
            this.tabControlMainMenu = new System.Windows.Forms.TabControl();
            this.tabPageChaoMung = new System.Windows.Forms.TabPage();
            this.tabPageThongTinCaNhan = new System.Windows.Forms.TabPage();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.menuItemQuanLiDanhSachGiaoVien = new System.Windows.Forms.MenuItem();
            this.menuItemQuanLiDanhSachHocVien = new System.Windows.Forms.MenuItem();
            this.tabPageDSTaiKhoan = new System.Windows.Forms.TabPage();
            this.dgvQuanLiDanhSachTaiKhoan = new System.Windows.Forms.DataGridView();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.tabControlMainMenu.SuspendLayout();
            this.tabPageThongTinCaNhan.SuspendLayout();
            this.tabPageDSTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLiDanhSachTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemTaiKhoan,
            this.menuItemQuanLi,
            this.menuItemKhoaHoc,
            this.menuItemBaoCao,
            this.menuItemAbout});
            // 
            // menuItemTaiKhoan
            // 
            this.menuItemTaiKhoan.Index = 0;
            this.menuItemTaiKhoan.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemDangNhap,
            this.menuItemDangKi,
            this.menuItemThongTinCaNhan,
            this.menuItemCapNhatMatKhau,
            this.menuItemDangXuat});
            this.menuItemTaiKhoan.Text = "Tài khoản";
            // 
            // menuItemDangNhap
            // 
            this.menuItemDangNhap.Index = 0;
            this.menuItemDangNhap.Text = "Đăng nhập";
            this.menuItemDangNhap.Click += new System.EventHandler(this.menuItemDangNhap_Click);
            // 
            // menuItemDangKi
            // 
            this.menuItemDangKi.Index = 1;
            this.menuItemDangKi.Text = "Đăng kí";
            this.menuItemDangKi.Click += new System.EventHandler(this.menuItemDangKi_Click);
            // 
            // menuItemThongTinCaNhan
            // 
            this.menuItemThongTinCaNhan.Index = 2;
            this.menuItemThongTinCaNhan.Text = "Thông tin cá nhân";
            this.menuItemThongTinCaNhan.Visible = false;
            this.menuItemThongTinCaNhan.Click += new System.EventHandler(this.menuItemThongTinCaNhan_Click);
            // 
            // menuItemCapNhatMatKhau
            // 
            this.menuItemCapNhatMatKhau.Index = 3;
            this.menuItemCapNhatMatKhau.Text = "Cập nhật mật khẩu";
            this.menuItemCapNhatMatKhau.Visible = false;
            this.menuItemCapNhatMatKhau.Click += new System.EventHandler(this.menuItemCapNhatMatKhau_Click);
            // 
            // menuItemDangXuat
            // 
            this.menuItemDangXuat.Index = 4;
            this.menuItemDangXuat.Text = "Đăng xuất";
            this.menuItemDangXuat.Visible = false;
            this.menuItemDangXuat.Click += new System.EventHandler(this.menuItemDangXuat_Click);
            // 
            // menuItemQuanLi
            // 
            this.menuItemQuanLi.Index = 1;
            this.menuItemQuanLi.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemQuanLiDanhSachTaiKhoan,
            this.menuItemQuanLiDanhSachMonHoc,
            this.menuItemQuanLiDanhSachKhoaHoc,
            this.menuItemQuanLiDanhSachGiaoVien,
            this.menuItemQuanLiDanhSachHocVien});
            this.menuItemQuanLi.Text = "Quản lí";
            this.menuItemQuanLi.Visible = false;
            // 
            // menuItemQuanLiDanhSachTaiKhoan
            // 
            this.menuItemQuanLiDanhSachTaiKhoan.Index = 0;
            this.menuItemQuanLiDanhSachTaiKhoan.Text = "Danh sách tài khoản";
            this.menuItemQuanLiDanhSachTaiKhoan.Visible = false;
            this.menuItemQuanLiDanhSachTaiKhoan.Click += new System.EventHandler(this.menuItemQuanLiDanhSachTaiKhoan_Click);
            // 
            // menuItemQuanLiDanhSachMonHoc
            // 
            this.menuItemQuanLiDanhSachMonHoc.Index = 1;
            this.menuItemQuanLiDanhSachMonHoc.Text = "Danh sách môn học";
            this.menuItemQuanLiDanhSachMonHoc.Visible = false;
            // 
            // menuItemQuanLiDanhSachKhoaHoc
            // 
            this.menuItemQuanLiDanhSachKhoaHoc.Index = 2;
            this.menuItemQuanLiDanhSachKhoaHoc.Text = "Danh sách khoá học";
            this.menuItemQuanLiDanhSachKhoaHoc.Visible = false;
            // 
            // menuItemKhoaHoc
            // 
            this.menuItemKhoaHoc.Index = 2;
            this.menuItemKhoaHoc.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemDanhSachKhoaHoc,
            this.menuItemDanhSachTheoHoc,
            this.menuItemLichSuLamBai,
            this.menuItemDanhSachGiangDay,
            this.menuItemBangDiem});
            this.menuItemKhoaHoc.Text = "Khoá học";
            this.menuItemKhoaHoc.Visible = false;
            // 
            // menuItemDanhSachKhoaHoc
            // 
            this.menuItemDanhSachKhoaHoc.Index = 0;
            this.menuItemDanhSachKhoaHoc.Text = "Danh sách khoá học";
            this.menuItemDanhSachKhoaHoc.Visible = false;
            // 
            // menuItemDanhSachTheoHoc
            // 
            this.menuItemDanhSachTheoHoc.Index = 1;
            this.menuItemDanhSachTheoHoc.Text = "Các khoá học đang theo học";
            this.menuItemDanhSachTheoHoc.Visible = false;
            // 
            // menuItemLichSuLamBai
            // 
            this.menuItemLichSuLamBai.Index = 2;
            this.menuItemLichSuLamBai.Text = "Lịch sử làm bài";
            this.menuItemLichSuLamBai.Visible = false;
            // 
            // menuItemDanhSachGiangDay
            // 
            this.menuItemDanhSachGiangDay.Index = 3;
            this.menuItemDanhSachGiangDay.Text = "Các khoá học đang giảng dạy";
            this.menuItemDanhSachGiangDay.Visible = false;
            // 
            // menuItemBangDiem
            // 
            this.menuItemBangDiem.Index = 4;
            this.menuItemBangDiem.Text = "Bảng điểm";
            this.menuItemBangDiem.Visible = false;
            // 
            // menuItemBaoCao
            // 
            this.menuItemBaoCao.Index = 3;
            this.menuItemBaoCao.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemKhoaHocDuocQuanTamNhat});
            this.menuItemBaoCao.Text = "Báo cáo";
            this.menuItemBaoCao.Visible = false;
            // 
            // menuItemKhoaHocDuocQuanTamNhat
            // 
            this.menuItemKhoaHocDuocQuanTamNhat.Index = 0;
            this.menuItemKhoaHocDuocQuanTamNhat.Text = " Các khoá học được quan tâm nhất";
            this.menuItemKhoaHocDuocQuanTamNhat.Visible = false;
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Index = 4;
            this.menuItemAbout.Text = "About";
            // 
            // tabControlMainMenu
            // 
            this.tabControlMainMenu.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlMainMenu.Controls.Add(this.tabPageChaoMung);
            this.tabControlMainMenu.Controls.Add(this.tabPageThongTinCaNhan);
            this.tabControlMainMenu.Controls.Add(this.tabPageDSTaiKhoan);
            this.tabControlMainMenu.ItemSize = new System.Drawing.Size(50, 50);
            this.tabControlMainMenu.Location = new System.Drawing.Point(12, 12);
            this.tabControlMainMenu.Name = "tabControlMainMenu";
            this.tabControlMainMenu.SelectedIndex = 0;
            this.tabControlMainMenu.Size = new System.Drawing.Size(600, 276);
            this.tabControlMainMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMainMenu.TabIndex = 1;
            // 
            // tabPageChaoMung
            // 
            this.tabPageChaoMung.Location = new System.Drawing.Point(4, 54);
            this.tabPageChaoMung.Name = "tabPageChaoMung";
            this.tabPageChaoMung.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChaoMung.Size = new System.Drawing.Size(592, 218);
            this.tabPageChaoMung.TabIndex = 0;
            this.tabPageChaoMung.Text = "ChaoMung";
            this.tabPageChaoMung.UseVisualStyleBackColor = true;
            // 
            // tabPageThongTinCaNhan
            // 
            this.tabPageThongTinCaNhan.Controls.Add(this.btnLuu);
            this.tabPageThongTinCaNhan.Controls.Add(this.btnSua);
            this.tabPageThongTinCaNhan.Controls.Add(this.txtDiaChi);
            this.tabPageThongTinCaNhan.Controls.Add(this.lblDiaChi);
            this.tabPageThongTinCaNhan.Controls.Add(this.dtpNgaySinh);
            this.tabPageThongTinCaNhan.Controls.Add(this.lblNgaySinh);
            this.tabPageThongTinCaNhan.Controls.Add(this.txtGioiTinh);
            this.tabPageThongTinCaNhan.Controls.Add(this.lblGioiTinh);
            this.tabPageThongTinCaNhan.Controls.Add(this.txtHoTen);
            this.tabPageThongTinCaNhan.Controls.Add(this.lblHoTen);
            this.tabPageThongTinCaNhan.Controls.Add(this.txtTenDangNhap);
            this.tabPageThongTinCaNhan.Controls.Add(this.lblTenDangNhap);
            this.tabPageThongTinCaNhan.Controls.Add(this.pictureBoxAvatar);
            this.tabPageThongTinCaNhan.Location = new System.Drawing.Point(4, 54);
            this.tabPageThongTinCaNhan.Name = "tabPageThongTinCaNhan";
            this.tabPageThongTinCaNhan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThongTinCaNhan.Size = new System.Drawing.Size(592, 218);
            this.tabPageThongTinCaNhan.TabIndex = 1;
            this.tabPageThongTinCaNhan.Text = "TT CaNhan";
            this.tabPageThongTinCaNhan.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(414, 183);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(311, 183);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(471, 58);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(115, 20);
            this.txtDiaChi.TabIndex = 11;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(411, 61);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(40, 13);
            this.lblDiaChi.TabIndex = 10;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Enabled = false;
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(271, 58);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(115, 20);
            this.dtpNgaySinh.TabIndex = 9;
            this.dtpNgaySinh.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(211, 61);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(56, 13);
            this.lblNgaySinh.TabIndex = 8;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Enabled = false;
            this.txtGioiTinh.Location = new System.Drawing.Point(471, 32);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(115, 20);
            this.txtGioiTinh.TabIndex = 7;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(411, 35);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(47, 13);
            this.lblGioiTinh.TabIndex = 6;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Location = new System.Drawing.Point(271, 32);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(115, 20);
            this.txtHoTen.TabIndex = 5;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(211, 35);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(43, 13);
            this.lblHoTen.TabIndex = 4;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Enabled = false;
            this.txtTenDangNhap.Location = new System.Drawing.Point(301, 6);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(100, 20);
            this.txtTenDangNhap.TabIndex = 3;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(211, 9);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(84, 13);
            this.lblTenDangNhap.TabIndex = 2;
            this.lblTenDangNhap.Text = "Tên Đăng Nhập";
            // 
            // menuItemQuanLiDanhSachGiaoVien
            // 
            this.menuItemQuanLiDanhSachGiaoVien.Index = 3;
            this.menuItemQuanLiDanhSachGiaoVien.Text = "Danh sách giáo viên";
            this.menuItemQuanLiDanhSachGiaoVien.Visible = false;
            // 
            // menuItemQuanLiDanhSachHocVien
            // 
            this.menuItemQuanLiDanhSachHocVien.Index = 4;
            this.menuItemQuanLiDanhSachHocVien.Text = "Danh sách học viên";
            this.menuItemQuanLiDanhSachHocVien.Visible = false;
            // 
            // tabPageDSTaiKhoan
            // 
            this.tabPageDSTaiKhoan.Controls.Add(this.dgvQuanLiDanhSachTaiKhoan);
            this.tabPageDSTaiKhoan.Location = new System.Drawing.Point(4, 54);
            this.tabPageDSTaiKhoan.Name = "tabPageDSTaiKhoan";
            this.tabPageDSTaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDSTaiKhoan.Size = new System.Drawing.Size(592, 218);
            this.tabPageDSTaiKhoan.TabIndex = 2;
            this.tabPageDSTaiKhoan.Text = "DSTaiKhoan";
            this.tabPageDSTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // dgvQuanLiDanhSachTaiKhoan
            // 
            this.dgvQuanLiDanhSachTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLiDanhSachTaiKhoan.Location = new System.Drawing.Point(6, 6);
            this.dgvQuanLiDanhSachTaiKhoan.Name = "dgvQuanLiDanhSachTaiKhoan";
            this.dgvQuanLiDanhSachTaiKhoan.RowHeadersVisible = false;
            this.dgvQuanLiDanhSachTaiKhoan.Size = new System.Drawing.Size(350, 200);
            this.dgvQuanLiDanhSachTaiKhoan.TabIndex = 0;
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Image = global::QLDaoTao.Properties.Resources.avatarmale;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(6, 6);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxAvatar.TabIndex = 1;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // GiaoDienChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 290);
            this.Controls.Add(this.tabControlMainMenu);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "GiaoDienChinh";
            this.Text = "Đào tạo online";
            this.tabControlMainMenu.ResumeLayout(false);
            this.tabPageThongTinCaNhan.ResumeLayout(false);
            this.tabPageThongTinCaNhan.PerformLayout();
            this.tabPageDSTaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLiDanhSachTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItemTaiKhoan;
        private System.Windows.Forms.MenuItem menuItemAbout;
        private System.Windows.Forms.MenuItem menuItemDangNhap;
        private System.Windows.Forms.MenuItem menuItemDangKi;
        private System.Windows.Forms.MenuItem menuItemThongTinCaNhan;
        private System.Windows.Forms.MenuItem menuItemDangXuat;
        private System.Windows.Forms.MenuItem menuItemCapNhatMatKhau;
        private System.Windows.Forms.MenuItem menuItemQuanLi;
        private System.Windows.Forms.MenuItem menuItemQuanLiDanhSachTaiKhoan;
        private System.Windows.Forms.MenuItem menuItemQuanLiDanhSachMonHoc;
        private System.Windows.Forms.MenuItem menuItemQuanLiDanhSachKhoaHoc;
        private System.Windows.Forms.MenuItem menuItemKhoaHoc;
        private System.Windows.Forms.MenuItem menuItemDanhSachTheoHoc;
        private System.Windows.Forms.MenuItem menuItemDanhSachKhoaHoc;
        private System.Windows.Forms.MenuItem menuItemBaoCao;
        private System.Windows.Forms.MenuItem menuItemKhoaHocDuocQuanTamNhat;
        private System.Windows.Forms.MenuItem menuItemLichSuLamBai;
        private System.Windows.Forms.MenuItem menuItemDanhSachGiangDay;
        private System.Windows.Forms.MenuItem menuItemBangDiem;
        private System.Windows.Forms.TabControl tabControlMainMenu;
        private System.Windows.Forms.TabPage tabPageChaoMung;
        private System.Windows.Forms.TabPage tabPageThongTinCaNhan;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.MenuItem menuItemQuanLiDanhSachGiaoVien;
        private System.Windows.Forms.MenuItem menuItemQuanLiDanhSachHocVien;
        private System.Windows.Forms.TabPage tabPageDSTaiKhoan;
        private System.Windows.Forms.DataGridView dgvQuanLiDanhSachTaiKhoan;
    }
}

