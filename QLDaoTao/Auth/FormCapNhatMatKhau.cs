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
    public partial class FormCapNhatMatKhau : Form
    {
        public FormCapNhatMatKhau()
        {
            InitializeComponent();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text != txtNhapLaiMatKhauMoi.Text)
            {
                lblError.Text = "Mật khẩu mới không khớp";
                lblError.Visible = true;

                return;
            }

            String username = (this.Owner as GiaoDienChinh).TenDangNhap;
            if (username == null || username.Equals("")) 
            {
                lblError.Text = "Lỗi! Bạn chưa đăng nhập!";
                lblError.Visible = true;

                return;
            }

            String sql = String.Format(@"SELECT * FROM NguoiDung WHERE (TenDangNhap = '{0}')", username);
            DataTable authUser = DB.ExecuteQuery(sql);
            if (authUser.Rows.Count <= 0)
            {
                lblError.Text = "Lỗi! Tài khoản không tồn tại!";
                lblError.Visible = true;

                return;
            }

            String password = authUser.Rows[0]["MatKhau"].ToString();
            if (!password.Equals(txtMatKhauCu.Text.Trim()))
            {
                lblError.Text = "Mật khẩu cũ chưa đúng";
                lblError.Visible = true;

                return;
            }

            try
            {
                sql = String.Format(@"UPDATE NguoiDung SET MatKhau = '{1}' WHERE (TenDangNhap = '{0}')", username, txtMatKhauMoi.Text.Trim());
                DB.ExecuteNonQuery(sql);

                this.Hide();
                MessageBox.Show("Cập nhật mật khẩu thành công!");
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
