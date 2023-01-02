using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDaoTao.Auth
{
    public partial class FormDangKi : Form
    {
        public FormDangKi()
        {
            InitializeComponent();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text != txtNhapLaiMatKhau.Text)
            {
                lblError.Text = "Mật khẩu không khớp";
                lblError.Visible = true;

                return;
            }

            try
            {
                String sql = String.Format(@"INSERT INTO NguoiDung(TenDangNhap, MatKhau, Quyen) VALUES ('{0}','{1}','{2}')", txtTenNguoiDung.Text.Trim(), txtMatKhau.Text.Trim(), "hocvien");
                DB.ExecuteNonQuery(sql);
                sql = String.Format(@"INSERT INTO HocVien(MaHV, HoTen, NgaySinh, GioiTinh, DiaChi) VALUES ('{0}','{1}',#1/1/1990#,'','')", txtTenNguoiDung.Text.Trim(), txtTenNguoiDung.Text.Trim());
                DB.ExecuteNonQuery(sql);

                this.Hide();
                MessageBox.Show("Đăng kí thành công! Chào mừng, " + txtTenNguoiDung.Text + "!");
                this.Owner.Activate();
                this.Close();
            }
            catch (Exception ex)
            {
                lblError.Text = "Tài khoản đã tồn tại";
                lblError.Visible = true;
            }
        }
    }
}
