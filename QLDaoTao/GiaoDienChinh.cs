using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDaoTao
{
    public partial class GiaoDienChinh : Form
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Tab))
            {
                MessageBox.Show("Xin chào! Đây là menu debug ẩn :)");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public String TenDangNhap;
        public String Quyen;
        public GiaoDienChinh()
        {
            InitializeComponent();
        }

        private void menuItemDangNhap_Click(object sender, EventArgs e)
        {
            Auth.FormDangNhap subform = new Auth.FormDangNhap();
            subform.ShowDialog(this);

            if (TenDangNhap == null || TenDangNhap.Equals(""))
            {
                return;
            }

            menuItemDangNhap.Visible = false;
            menuItemDangKi.Visible = false;
            menuItemCapNhatMatKhau.Visible = true;
            menuItemDangXuat.Visible = true;

            if (Quyen.Equals("admin"))
            {
                menuItemThongTinCaNhan.Visible = false;
                menuItemQuanLi.Visible = true;
                menuItemQuanLiDanhSachTaiKhoan.Visible = true;
                menuItemQuanLiDanhSachMonHoc.Visible = true;
                menuItemQuanLiDanhSachKhoaHoc.Visible = true;
                menuItemQuanLiDanhSachGiaoVien.Visible = true;
                menuItemQuanLiDanhSachHocVien.Visible = true;
            }
            if (Quyen.Equals("giaovien"))
            {
                menuItemThongTinCaNhan.Visible = true;
                menuItemQuanLi.Visible = false;
                menuItemQuanLiDanhSachTaiKhoan.Visible = false;
                menuItemQuanLiDanhSachMonHoc.Visible = false;
                menuItemQuanLiDanhSachKhoaHoc.Visible = false;
                menuItemQuanLiDanhSachGiaoVien.Visible = false;
                menuItemQuanLiDanhSachHocVien.Visible = false;
            }
            if (Quyen.Equals("hocvien"))
            {
                menuItemThongTinCaNhan.Visible = true;
                menuItemQuanLi.Visible = false;
                menuItemQuanLiDanhSachTaiKhoan.Visible = false;
                menuItemQuanLiDanhSachMonHoc.Visible = false;
                menuItemQuanLiDanhSachKhoaHoc.Visible = false;
                menuItemQuanLiDanhSachGiaoVien.Visible = false;
                menuItemQuanLiDanhSachHocVien.Visible = false;
            }
        }

        private void menuItemDangKi_Click(object sender, EventArgs e)
        {
            Auth.FormDangKi subform = new Auth.FormDangKi();
            subform.ShowDialog(this);
        }

        private void menuItemDangXuat_Click(object sender, EventArgs e)
        {
            TenDangNhap = "";
            Quyen = "";

            tabControlMainMenu.SelectedTab = tabPageChaoMung;
            menuItemDangNhap.Visible = true;
            menuItemDangKi.Visible = true;
            menuItemThongTinCaNhan.Visible = false;
            menuItemCapNhatMatKhau.Visible = false;
            menuItemDangXuat.Visible = false;
            menuItemQuanLi.Visible = false;
            menuItemQuanLiDanhSachTaiKhoan.Visible = false;
            menuItemQuanLiDanhSachMonHoc.Visible = false;
            menuItemQuanLiDanhSachKhoaHoc.Visible = false;
            menuItemQuanLiDanhSachGiaoVien.Visible = false;
            menuItemQuanLiDanhSachHocVien.Visible = false;
            txtTenDangNhap.Text = "";
            txtHoTen.Text = "";
            dtpNgaySinh.Value = new DateTime(1990, 1, 1);
            txtGioiTinh.Text = "";
            txtDiaChi.Text = "";
        }

        private void menuItemThongTinCaNhan_Click(object sender, EventArgs e)
        {
            tabControlMainMenu.SelectedTab = tabPageThongTinCaNhan;
            DisableThongTinCaNhan();

            GetThongTinCaNhan();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            EnableThongTinCaNhan();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DisableThongTinCaNhan();
            UpdateThongTinCaNhan();
            GetThongTinCaNhan();
        }

        private void EnableThongTinCaNhan()
        {
            txtHoTen.Enabled = true;
            dtpNgaySinh.Enabled = true;
            txtGioiTinh.Enabled = true;
            txtDiaChi.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
        }

        private void DisableThongTinCaNhan()
        {
            txtHoTen.Enabled = false;
            dtpNgaySinh.Enabled = false;
            txtGioiTinh.Enabled = false;
            txtDiaChi.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
        }

        private void GetThongTinCaNhan()
        {
            txtTenDangNhap.Text = TenDangNhap;
            String sql = "";
            if (Quyen.Equals("hocvien"))
            {
                sql = String.Format(@"SELECT * FROM HocVien WHERE (MaHV = '{0}')", TenDangNhap);
            }
            else if (Quyen.Equals("giaovien"))
            {
                sql = String.Format(@"SELECT * FROM GiaoVien WHERE (MaGV = '{0}')", TenDangNhap);
            }
            DataTable data = DB.ExecuteQuery(sql);

            if (data.Rows.Count > 0)
            {
                txtHoTen.Text = data.Rows[0]["HoTen"].ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(data.Rows[0]["NgaySinh"].ToString());
                txtGioiTinh.Text = data.Rows[0]["GioiTinh"].ToString();
                txtDiaChi.Text = data.Rows[0]["DiaChi"].ToString();
            }
            if (txtGioiTinh.Text.Trim().Equals("Nam"))
            {
                pictureBoxAvatar.Image = Properties.Resources.avatarmale;
            }
            else
            {
                pictureBoxAvatar.Image = Properties.Resources.avatarfemale;
            }
        }

        private void UpdateThongTinCaNhan()
        {
            String sql = "";
            String hoTen = txtHoTen.Text.Trim();
            String ngaySinh = dtpNgaySinh.Value.ToShortDateString();
            String gioiTinh = txtGioiTinh.Text.Trim().Equals("Nam") ? "Nam" : "Nữ";
            String diaChi = txtDiaChi.Text.Trim();
            if (Quyen.Equals("hocvien"))
            {
                sql = String.Format(@"UPDATE HocVien SET HoTen = '{1}', NgaySinh = #{2}#, GioiTinh = '{3}', DiaChi = '{4}' WHERE (MaHV = '{0}')", TenDangNhap, hoTen, ngaySinh, gioiTinh, diaChi);
            }
            else if (Quyen.Equals("giaovien"))
            {
                sql = String.Format(@"UPDATE GiaoVien SET HoTen = '{1}', NgaySinh = #{2}#, GioiTinh = '{3}', DiaChi = '{4}' WHERE (MaGV = '{0}')", TenDangNhap, hoTen, ngaySinh, gioiTinh, diaChi);
            }
            DB.ExecuteNonQuery(sql);
        }

        private void menuItemCapNhatMatKhau_Click(object sender, EventArgs e)
        {
            Auth.FormCapNhatMatKhau subform = new Auth.FormCapNhatMatKhau();
            subform.ShowDialog(this);
        }

        private void menuItemQuanLiDanhSachTaiKhoan_Click(object sender, EventArgs e)
        {
            tabControlMainMenu.SelectedTab = tabPageDSTaiKhoan;

            String sql;
            sql = "SELECT TenDangNhap, Quyen FROM NguoiDung";
            DataTable data = DB.ExecuteQuery(sql);
            dgvQuanLiDanhSachTaiKhoan.DataSource = data;
            dgvQuanLiDanhSachTaiKhoan.Columns["TenDangNhap"].Width = 200;
            dgvQuanLiDanhSachTaiKhoan.Columns["Quyen"].Width = 130;
        }

    }
}
