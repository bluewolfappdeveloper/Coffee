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
    public partial class frmcustomer : Form
    {
        public frmcustomer()
        {
            InitializeComponent();
            btnshow_Click(btnshow,new EventArgs());
        }

        private void dgvitem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             int row = e.RowIndex;
             if (row != dgvitem.Rows.Count - 1)
             {
                 btndelete.Enabled = btnrepair.Enabled = true;
                 //btnadd.Enabled = false;
                 if (row >= 0)
                 {
                     txtcode.Text = dgvitem.Rows[row].Cells[0].Value.ToString();
                     txtname.Text = dgvitem.Rows[row].Cells[2].Value.ToString();
                     txtchucvu.Text = dgvitem.Rows[row].Cells[3].Value.ToString();
                 }
             }
             if (row == dgvitem.Rows.Count - 1)
             {
                 btndelete.Enabled = btnrepair.Enabled = false;
                 //btnadd.Enabled = true;
                 txtname.Text = txtchucvu.Text = "";
             }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            dgvitem.DataSource = null;
            dgvitem.Rows.Clear();
            dgvitem.Refresh();
            DataTable datatable = DataProviderDAO.Instance.ExecuteQuery("SELECT * FROM dbo.customer ORDER BY name");

            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                dgvitem.Rows.Add(datatable.Rows[i][0], (i + 1).ToString(), datatable.Rows[i][1], datatable.Rows[i][2]);
            }
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtname.Text != string.Empty && txtchucvu.Text != string.Empty)
            {
                int table = DataProviderDAO.Instance.ExecuteNonQuery("INSERT dbo.customer( name, donvi ) VALUES  ( N'" + txtname.Text + "', N'" + txtchucvu.Text + "')");
                if (table>0) 
                {
                    //DataProviderDAO.Instance.ExecuteQuery("INSERT dbo.kiemtra(ten, soluong, tong) VALUES( N'" + txtname.Text + "',0,0)");
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    btnshow_Click(btnshow, new EventArgs());
                    txtcode.Text = txtname.Text = null;
                }
                else MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Lỗi dữ liệu " + Environment.NewLine + Environment.NewLine + "Kiểm tra lại dữ liệu vừa nhập", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtname.Text != string.Empty && txtchucvu.Text != string.Empty)
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa khách hàng này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    int table = DataProviderDAO.Instance.ExecuteNonQuery("DELETE dbo.customer WHERE id = '" + txtcode.Text + "'");

                    if (table > 0)
                    {
                        //DataProviderDAO.Instance.ExecuteQuery("INSERT dbo.kiemtra(ten, soluong, tong) VALUES( N'" + txtname.Text + "',0,0)");
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        btnshow_Click(btnshow, new EventArgs());
                        txtcode.Text = txtname.Text = null;
                    }
                    else MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Lỗi dữ liệu " + Environment.NewLine + Environment.NewLine + "Kiểm tra lại dữ liệu vừa nhập", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void btnrepair_Click(object sender, EventArgs e)
        {
            if (txtname.Text != string.Empty && txtchucvu.Text != string.Empty)
            {
                int table = DataProviderDAO.Instance.ExecuteNonQuery("UPDATE dbo.customer SET name = N'"+txtname.Text+"', donvi = N'"+txtchucvu.Text+"' WHERE id="+txtcode.Text);
                if (table > 0)
                {
                    //DataProviderDAO.Instance.ExecuteQuery("INSERT dbo.kiemtra(ten, soluong, tong) VALUES( N'" + txtname.Text + "',0,0)");
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    btnshow_Click(btnshow, new EventArgs());
                    txtcode.Text = txtname.Text = null;
                }
                else MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Lỗi dữ liệu " + Environment.NewLine + Environment.NewLine + "Kiểm tra lại dữ liệu vừa nhập", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

        }

        private void frmcustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();

        }

        private void frmcustomer_SizeChanged(object sender, EventArgs e)
        {
            if (this.Width < 651) this.Width = 651;
            if (this.Height < 450) this.Height = 450;
        }
    }
}
