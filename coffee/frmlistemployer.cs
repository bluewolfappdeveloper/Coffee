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
    public partial class frmlistemployer : Form
    {
        public frmlistemployer()
        {
            InitializeComponent();
            btnshow_Click(btnshow, new EventArgs());
            rdouser.Checked = true;
        } 

        private void txtfind_TextChanged(object sender, EventArgs e)
        {
            if (txtfind.Text != string.Empty)
            {
                dgvitem.DataSource = null;
                dgvitem.Rows.Clear();
                dgvitem.Refresh();
                DataTable datatable = DataProviderDAO.Instance.ExecuteQuery("SELECT * FROM dbo.login WHERE dbo.convertstring(NAME) like N'%' + dbo.convertstring(N'" + txtfind.Text + "') + '%'");

                string status;
                for (int i = 0; i < datatable.Rows.Count; i++)
                {
                    if (datatable.Rows[i][7].ToString() == "1") status = "Admin"; else status = "User";
                    dgvitem.Rows.Add(datatable.Rows[i][0], (i + 1).ToString(), datatable.Rows[i][1], datatable.Rows[i][2], datatable.Rows[i][3], datatable.Rows[i][4].ToString().Substring(0, 10), datatable.Rows[i][5], datatable.Rows[i][6], status);
                }
            }
            else btnshow_Click(btnshow, new EventArgs());
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            dgvitem.DataSource = null;
            dgvitem.Rows.Clear();
            dgvitem.Refresh();
            DataTable datatable = DataProviderDAO.Instance.ExecuteQuery("SELECT * FROM dbo.login ORDER BY name");
            string status;
            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                if (datatable.Rows[i][7].ToString() == "1") status = "Admin"; else status = "User";
                dgvitem.Rows.Add(datatable.Rows[i][0], (i + 1).ToString(), datatable.Rows[i][1], datatable.Rows[i][2], datatable.Rows[i][3], datatable.Rows[i][4].ToString().Substring(0, 10), datatable.Rows[i][5], datatable.Rows[i][6], status);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtaddress.Text != "" && txtphone.Text != "")
            {
                int k;
                if (rdoadmin.Checked) { k=1;} else k=2;
                if (EmployeeDAO.Instance.add(txtcode.Text, txtname.Text, txtname.Text, txtphone.Text, date.Value.Date.ToString("yyyy/MM/dd"), txtaddress.Text, txtphone.Text, k.ToString()))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    btnshow_Click(btnshow, new EventArgs());
                    txtcode.Text = txtname.Text = txtaddress.Text = txtphone.Text = "";
                    rdouser.Checked = true;
                    date.Text = DateTime.Now.Date.ToShortDateString();
                    btndelete.Enabled = btnrepair.Enabled = true;
                }
                else MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Lỗi dữ liệu " + Environment.NewLine + Environment.NewLine + "Kiểm tra lại dữ liệu vừa nhập", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        
        private void dgvitem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtaddress.Text != "" && txtphone.Text != "")
            {
                int k;
                if (rdoadmin.Checked) { k = 1; } else k = 2;
                if (EmployeeDAO.Instance.delete(txtcode.Text, txtname.Text, txtname.Text, txtphone.Text, date.Value.Date.ToString("yyyy/MM/dd"), txtaddress.Text, txtphone.Text, k.ToString()))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    btnshow_Click(btnshow, new EventArgs());
                    txtcode.Text = txtname.Text = txtaddress.Text = txtphone.Text = "";
                    rdouser.Checked = true;
                    date.Text = DateTime.Now.Date.ToShortDateString();
                    btndelete.Enabled = btnrepair.Enabled = true;
                }
                else MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Lỗi dữ liệu " + Environment.NewLine + Environment.NewLine + "Kiểm tra lại dữ liệu vừa nhập", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void btnrepair_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtaddress.Text != "" && txtphone.Text != "")
            {
                int k;
                if (rdoadmin.Checked) { k = 1; } else k = 2;
                if (EmployeeDAO.Instance.repair(txtcode.Text, txtname.Text, txtname.Text, txtphone.Text, date.Value.Date.ToString("yyyy/MM/dd"), txtaddress.Text, txtphone.Text, k.ToString()))
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    btnshow_Click(btnshow, new EventArgs());
                    txtcode.Text = txtname.Text = txtaddress.Text = txtphone.Text = "";
                    rdouser.Checked = true;
                    date.Text = DateTime.Now.Date.ToShortDateString();
                    btndelete.Enabled = btnrepair.Enabled = true;
                }
                else MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Lỗi dữ liệu " + Environment.NewLine + Environment.NewLine + "Kiểm tra lại dữ liệu vừa nhập", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void frmlistemployer_Resize(object sender, EventArgs e)
        {
            panel1.Width = panel2.Width = this.Width / 2 - 20;
      
            panel2.Location = new Point(this.Width / 2 + 2, panel2.Location.Y);

            //label1.Location = new Point(this.Width / 2 - 180, label1.Location.Y);

            if (this.Width < 956) this.Width = 956;
            if (this.Height < 642) this.Height = 642;
        }

        private void frmlistemployer_ResizeEnd(object sender, EventArgs e)
        {
            if (this.Width < 958) this.Width = 958;
            if (this.Height < 610) this.Height = 610;
        }

        private void frmlistemployer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form home = new frmhome();
            home.Show();
            this.Hide();
        }

        private void dgvitem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < dgvitem.Rows.Count - 1 && row != -1)
            {
                btndelete.Enabled = btnrepair.Enabled = true;
                txtcode.Text = dgvitem.Rows[row].Cells[0].Value.ToString();
                txtname.Text = dgvitem.Rows[row].Cells[2].Value.ToString();
                date.Text = dgvitem.Rows[row].Cells[5].Value.ToString();
                txtaddress.Text = dgvitem.Rows[row].Cells[6].Value.ToString();
                txtphone.Text = dgvitem.Rows[row].Cells[7].Value.ToString();
                if (dgvitem.Rows[row].Cells[8].Value.ToString() == "Admin") rdoadmin.Checked = true; else rdouser.Checked = true ;
                
            }



            if (row == dgvitem.Rows.Count - 1)
            {
                btndelete.Enabled = btnrepair.Enabled = false;
                txtcode.Text = txtname.Text = txtaddress.Text = txtphone.Text = "";
                date.Text = DateTime.Now.Date.ToShortDateString();
                rdouser.Checked = true;
            }
        }


    }
}

    

