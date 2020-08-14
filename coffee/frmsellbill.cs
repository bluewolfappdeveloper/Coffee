using coffee.DAO;
using coffee.Report;
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
    public partial class frmsellbill : Form
    {
        public frmsellbill()
        {
            InitializeComponent();
            cbname.Items.Clear();
            label1.Text = frmbill.khachhang;
            txtsukien.Text = frmbill.sukien;
            chkthanhtoan.Checked = false;

            DateTime ngay = Convert.ToDateTime(frmbill.day + ' ' + frmbill.tg);

            date.Value = ngay;

            btnshow_Click(btnshow,new EventArgs());
            txtprice.Text = txtsum.Text = "0";
            DataTable drink = DataProviderDAO.Instance.ExecuteQuery("select * from drink order by name");
            for (int i = 0; i < drink.Rows.Count; i++) cbname.Items.Add(drink.Rows[i][1]);
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            dgvitem.DataSource = null;
            dgvitem.Rows.Clear();
            dgvitem.Refresh();
            DataTable datatable = DataProviderDAO.Instance.ExecuteQuery("SELECT id,namedrink,price,quantify,total FROM dbo.bill where idtable = " + frmbill.bill);

            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                dgvitem.Rows.Add((i + 1).ToString(), datatable.Rows[i][0], datatable.Rows[i][1], datatable.Rows[i][2], datatable.Rows[i][3], datatable.Rows[i][4]);
            }

            object sum = DataProviderDAO.Instance.ExecuteScalar("SELECT SUM(total) FROM dbo.bill where idtable = " + frmbill.bill);
            if (sum == null) sum2.Text = "0"; else sum2.Text = stringformat(sum.ToString(), 1);
        }

        private string stringformat(string a, int d)
        {
            string k = "0";
            if (a != "")
            {
                if (d == 1)
                {
                    if (a.Length > 1) k = string.Format("{0:0,0}", Convert.ToDouble(a));
                    else k = string.Format("{0:0}", Convert.ToDouble(a));
                }
                else k = string.Format("{0:0}", Convert.ToDouble(a));
            }

            return k;
        }



        private void nudcount_ValueChanged(object sender, EventArgs e)
        {
            long a;
            txtprice.Text = stringformat(txtprice.Text, 2);
            if (Int64.TryParse(txtprice.Text, out a)) txtsum.Text = stringformat((a * nudcount.Value).ToString(), 1);
            txtprice.Text = stringformat(txtprice.Text, 1);
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            };

            if (e.KeyChar == 13)
            {
                long a;
                txtprice.Text = stringformat(txtprice.Text, 2);
                if (Int64.TryParse(txtprice.Text, out a)) txtsum.Text = stringformat((a * nudcount.Value).ToString(), 1);
                txtprice.Text = stringformat(txtprice.Text, 1);
                txtprice.SelectionLength = 0;
                txtprice.SelectionStart = txtprice.Text.Length;
            }


        }

        private void txtprice_Leave(object sender, EventArgs e)
        {
            long a;
            if (txtprice.SelectedText == "")
            {
                txtprice.Text = stringformat(txtprice.Text, 2);
                if (Int64.TryParse(txtprice.Text, out a)) txtsum.Text = stringformat((a * nudcount.Value).ToString(), 1);
                txtprice.Text = stringformat(txtprice.Text, 1);
                txtprice.SelectionLength = 0;
                txtprice.SelectionStart = txtprice.Text.Length;

            }


        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (cbname.Text != "" && txtprice.Text != "" && txtsum.Text != "")
            {
                string k = stringformat(txtprice.Text, 2);
                string h = stringformat(txtsum.Text, 3);
                if (SellBillDAO.Instance.add(txtSTT.Text, cbname.Text, frmbill.bill, Int64.Parse(k), Int64.Parse(nudcount.Value.ToString()), Int64.Parse(h)))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    cbname.Text = "";
                    txtprice.Text = "0";
                    txtsum.Text = "0";
                    nudcount.Value = 1;

                    btnshow_Click(btnshow, new EventArgs());
                }
                else MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Lỗi dữ liệu " + Environment.NewLine + Environment.NewLine + "Kiểm tra lại dữ liệu vừa nhập", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void dgvitem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < dgvitem.Rows.Count - 1 && row != -1)
            {
                btndelete.Enabled = btnrepair.Enabled = true;
                txtSTT.Text = dgvitem.Rows[row].Cells[1].Value.ToString();
                cbname.Text = dgvitem.Rows[row].Cells[2].Value.ToString();
                txtprice.Text = dgvitem.Rows[row].Cells[3].Value.ToString();
                nudcount.Value = Int64.Parse(dgvitem.Rows[row].Cells[4].Value.ToString());
                txtsum.Text = dgvitem.Rows[row].Cells[5].Value.ToString();
                txtprice.Text = stringformat(txtprice.Text, 1);
                txtsum.Text = stringformat(txtsum.Text, 1);
            }



            if (row == dgvitem.Rows.Count - 1)
            {
                btndelete.Enabled = btnrepair.Enabled = false;
                txtSTT.Text = cbname.Text = "";
                txtsum.Text = txtprice.Text = "0";
                nudcount.Value = 1;
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (cbname.Text != "" && txtprice.Text != "" && txtsum.Text != "")
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa mặt hàng này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    string k = stringformat(txtprice.Text, 2);
                    string h = stringformat(txtsum.Text, 3);
                    if (SellBillDAO.Instance.delete(txtSTT.Text, cbname.Text, frmbill.bill, Int64.Parse(h), Int64.Parse(nudcount.Value.ToString()), Int64.Parse(k)))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        cbname.Text = "";
                        txtprice.Text = "0";
                        txtsum.Text = "0";
                        nudcount.Value = 1;
                        btnshow_Click(btnshow, new EventArgs());
                    }
                    else MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Lỗi dữ liệu " + Environment.NewLine + Environment.NewLine + "Kiểm tra lại dữ liệu vừa nhập", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void btnrepair_Click(object sender, EventArgs e)
        {
            string k = stringformat(txtprice.Text, 2);
            string h = stringformat(txtsum.Text, 3);
            if (cbname.Text != "" && txtprice.Text != "" && txtsum.Text != "")
            {
                if (SellBillDAO.Instance.repair(txtSTT.Text, cbname.Text, frmbill.bill, Int64.Parse(k), Int64.Parse(nudcount.Value.ToString()), Int64.Parse(h)))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    cbname.Text = "";
                    txtprice.Text = "0";
                    txtsum.Text = "0";
                    nudcount.Value = 1;
                    btnshow_Click(btnshow, new EventArgs());
                }
                else MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Lỗi dữ liệu " + Environment.NewLine + Environment.NewLine + "Kiểm tra lại dữ liệu vừa nhập", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void btnloc_Click(object sender, EventArgs e)
        {
            DataProviderDAO.Instance.ExecuteQuery("EXEC dbo.USP_ResetBill");
            btnshow_Click(btnshow, new EventArgs());
        }


        private void btnprint_Click(object sender, EventArgs e)
        {
            frmbill.frm = "2";
            Form frmtakebill = new frmtakebill();
            frmtakebill.Show();
            this.Hide();

        }


        private void frmsell_FormClosed(object sender, FormClosedEventArgs e)
        {
            object tong = DataProviderDAO.Instance.ExecuteScalar("SELECT SUM(total) FROM bill WHERE idtable = " + frmbill.bill);
            DataProviderDAO.Instance.ExecuteQuery("UPDATE dbo.bill_info SET tongtien = " + tong + " WHERE id= " + frmbill.bill);

            btnloc_Click(btnloc, new EventArgs());

            this.Hide();
            Form bill = new frmbill();
            bill.Show();

        }



        private void frmsell_SizeChanged(object sender, EventArgs e)
        {
            panel1.Width = panel3.Width = this.Width / 2 - 10;
            panel2.Width = panel4.Width = this.Width / 2 - 30;
            panel2.Location = new Point(this.Width / 2 + 3, panel2.Location.Y);
            panel4.Location = new Point(this.Width / 2 + 3, panel4.Location.Y);
            label6.Location = new Point(this.Width / 2 - 90, label6.Location.Y);
            
        }



        private void txtsukien_TextChanged(object sender, EventArgs e)
        {
            frmbill.sukien = txtsukien.Text;
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            frmbill.tg = date.Value.ToShortTimeString();
            frmbill.day = date.Value.ToShortDateString();
        }

        private void cbname_SelectedIndexChanged(object sender, EventArgs e)
        {
            long a;
            if (cbname.Text != "")
            {
                nudcount.Value = 1;
                DataTable drink = DataProviderDAO.Instance.ExecuteQuery("select * from drink where name = N'" + cbname.Text + "'");
                txtprice.Text = drink.Rows[0][2].ToString();
                txtprice.Text = stringformat(txtprice.Text, 2);
                if (Int64.TryParse(txtprice.Text, out a))
                {
                    txtsum.Text = (a * nudcount.Value).ToString();
                    txtprice.Text = stringformat(txtprice.Text, 1);
                    if (txtsum.Text != "") txtsum.Text = stringformat(txtsum.Text, 1);
                    txtprice.Text = stringformat(txtprice.Text, 1);
                }
            }
            else MessageBox.Show("Lỗi dữ liệu " + Environment.NewLine + Environment.NewLine + "Kiểm tra lại dữ liệu vừa nhập", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void frmsellbill_ResizeEnd(object sender, EventArgs e)
        {
            if (this.Width < 956) this.Width = 956;
            if (this.Height < 642) this.Height = 642;
        }


    }
}
