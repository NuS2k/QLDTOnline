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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String sql = String.Format(@"SELECT * FROM NguoiDung WHERE (TenDangNhap = '{0}') AND (MatKhau = '{1}')", txtTenNguoiDung.Text.Trim(), txtMatKhau.Text.Trim());
            DataTable data = DB.ExecuteQuery(sql);

            if (data.Rows.Count > 0)
            {
                (this.Owner as GiaoDienChinh).TenDangNhap = data.Rows[0]["TenDangNhap"].ToString();
                (this.Owner as GiaoDienChinh).Quyen = data.Rows[0]["Quyen"].ToString();

                this.Close();
            }
            else
            {
                label1.Visible = true;
            }
        }
    }
}
