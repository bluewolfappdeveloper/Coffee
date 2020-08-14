using coffee.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace coffee
{
    public partial class frmlogin : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public static string name,user,status;
        public frmlogin()
        {
            InitializeComponent();
        }



        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtpass.Text != null || txtuser.Text != null)
            {
                DataTable login = DataProviderDAO.Instance.ExecuteQuery("EXEC dbo.USP_Login @username = N'" + txtuser.Text + "' , @password = N'" + txtpass.Text + "'");
                if (login.Rows.Count > 0)
                {
                    name = login.Rows[0][0].ToString();
                    status = login.Rows[0][1].ToString();
                    user = txtuser.Text;
                    this.Hide();
                    Form home = new frmhome();
                    home.Show();
                    txtpass.Text = null;
                    txtuser = null;
                }
                else
                {
                    MessageBox.Show("VUI LÒNG KIỂM TRA TÀI KHOẢN & MẬT KHẨU", "ĐĂNG NHẬP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpass.Text = null;
                }

            }
            else MessageBox.Show("VUI LÒNG KIỂM TRA TÀI KHOẢN & MẬT KHẨU", "ĐĂNG NHẬP", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void chkshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshowpass.Checked) txtpass.PasswordChar = char.Parse("\0"); else txtpass.PasswordChar = char.Parse("*");
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

    }
}
