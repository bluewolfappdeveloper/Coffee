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
    public partial class frminformation : Form
    {
        string pass;
        public frminformation()
        {
            InitializeComponent();
            DataTable data = DataProviderDAO.Instance.ExecuteQuery("select id,name,username,password from login where username = '" + frmlogin.user + "'");
            txtmanv.Text = data.Rows[0][0].ToString();
            txtname.Text = data.Rows[0][1].ToString();
            txtuser.Text = data.Rows[0][2].ToString();
            //txtpass.Text = data.Rows[0][3].ToString();
            pass = data.Rows[0][3].ToString();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string displayName = txtname.Text;
            string password = txtpass.Text;
            string newpass = txtNewPass.Text;
            string reenterPass = txtReEnterPass.Text;
            string userName = txtuser.Text;

            

            if (txtpass.Text != pass || txtpass.Text == "" || txtReEnterPass.Text == "" || txtNewPass.Text == "")
            {
                if (txtpass.Text == pass && txtReEnterPass.Text == "" && txtNewPass.Text == "")
                {
                    DataTable data = DataProviderDAO.Instance.ExecuteQuery("UPDATE dbo.login SET name = '" + txtname.Text + "', username= '" + txtuser.Text + "' , password = '" + txtpass.Text + "' where id = " + txtmanv.Text);
                    if (data.Rows.Count == 0)
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        txtpass.Text = "";
                    }
                    else MessageBox.Show("Vui lòng điền đúng mật khấu", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                MessageBox.Show("Vui lòng nhập lại mật khẩu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
                if (!newpass.Equals(reenterPass) || newpass == "")
                {
                    MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    Int64 table = (Int64)DataProviderDAO.Instance.ExecuteNonQuery("UPDATE dbo.login SET name = '"+displayName+"',username='"+userName+"', password='"+newpass+"' WHERE id="+txtmanv.Text);
                    if (table > 0)
                    {
                        frmlogin.user = txtuser.Text;
                        pass = txtNewPass.Text;
                        txtpass.Text = txtNewPass.Text = txtReEnterPass.Text = "";                
                        //txtpass.Text = password;
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Vui lòng điền đúng mật khấu","Thông Báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void chkshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshowpass.Checked) txtpass.PasswordChar = char.Parse("\0"); else txtpass.PasswordChar = char.Parse("*");
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) txtNewPass.PasswordChar = char.Parse("\0"); else txtNewPass.PasswordChar = char.Parse("*");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) txtReEnterPass.PasswordChar = char.Parse("\0"); else txtReEnterPass.PasswordChar = char.Parse("*");
        }

        private void frminformation_SizeChanged(object sender, EventArgs e)
        {
            if (this.Width < 643) this.Width = 643;
            if (this.Height < 456) this.Height = 456;
        }

        private void frminformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
