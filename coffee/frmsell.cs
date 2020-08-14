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
    public partial class frmsell : Form
    {
        public frmsell()
        {
            InitializeComponent();
            cbname.Items.Clear();
            cbkhachhang.Items.Clear();
            txtprice.Text = txtsum.Text = "0";
            DataTable drink = DataProviderDAO.Instance.ExecuteQuery("select * from drink order by name");
            for (int i = 0; i < drink.Rows.Count; i++) cbname.Items.Add(drink.Rows[i][1]);
            DataTable khach = DataProviderDAO.Instance.ExecuteQuery("SELECT id,name FROM customer order by name");
            for (int i = 0; i < khach.Rows.Count; i++) cbkhachhang.Items.Add(khach.Rows[i][1]);
            for (int i = 0; i < khach.Rows.Count; i++) cbidkhach.Items.Add(khach.Rows[i][0]);
            DataProviderDAO.Instance.ExecuteQuery("Delete from tablebill");
            DataProviderDAO.Instance.ExecuteQuery("DBCC CHECKIDENT (tablebill,RESEED,0)");
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            dgvitem.DataSource = null;
            dgvitem.Rows.Clear();
            dgvitem.Refresh();
            DataTable datatable = DataProviderDAO.Instance.ExecuteQuery("SELECT * FROM dbo.tablebill");

            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                dgvitem.Rows.Add((i + 1).ToString(), datatable.Rows[i][0], datatable.Rows[i][1], datatable.Rows[i][2], datatable.Rows[i][3], datatable.Rows[i][4]);
            }
           
            object sum = DataProviderDAO.Instance.ExecuteScalar("SELECT SUM(dbo.tablebill.total) FROM dbo.tablebill");
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

        private void cbname_SelectedIndexChanged(object sender, EventArgs e)
        {
            long a;
            string k = btnreset.Tag.ToString();
            if (k== "0")
            {
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
            
        }


        private void nudcount_ValueChanged(object sender, EventArgs e)
        {
            long a;
            txtprice.Text = stringformat(txtprice.Text,2);
            if (Int64.TryParse(txtprice.Text, out a))txtsum.Text = stringformat((a * nudcount.Value).ToString(), 1);
            txtprice.Text = stringformat(txtprice.Text, 1); 
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            };

            if(e.KeyChar==13)
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
                string h = stringformat(txtsum.Text,3);
                if (SellDAO.Instance.add(txtSTT.Text, cbname.Text, Int64.Parse(k), Int64.Parse(nudcount.Value.ToString()), Int64.Parse(h)))
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
            if (row < dgvitem.Rows.Count-1 && row != -1)
            {
                    btndelete.Enabled = btnrepair.Enabled = true;
                    txtSTT.Text = dgvitem.Rows[row].Cells[1].Value.ToString();
                    cbname.Text = dgvitem.Rows[row].Cells[2].Value.ToString();
                    txtprice.Text = dgvitem.Rows[row].Cells[3].Value.ToString();
                    nudcount.Value = Int64.Parse(dgvitem.Rows[row].Cells[4].Value.ToString());
                    txtsum.Text = dgvitem.Rows[row].Cells[5].Value.ToString();
                    txtprice.Text = stringformat(txtprice.Text,1);
                    txtsum.Text = stringformat(txtsum.Text,1);
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
                    if (SellDAO.Instance.delete(txtSTT.Text, cbname.Text, Int64.Parse(h), Int64.Parse(nudcount.Value.ToString()), Int64.Parse(k)))
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
                if (SellDAO.Instance.repair(txtSTT.Text, cbname.Text, Int64.Parse(k), Int64.Parse(nudcount.Value.ToString()), Int64.Parse(h)))
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
            DataTable tabledrink = DataProviderDAO.Instance.ExecuteQuery("SELECT dbo.tablebill.namedrink,dbo.tablebill.price, SUM(quantify), SUM(dbo.tablebill.total)  FROM dbo.tablebill GROUP BY dbo.tablebill.namedrink, price ORDER BY namedrink");
            DataProviderDAO.Instance.ExecuteQuery("Delete from tablebill");
            DataProviderDAO.Instance.ExecuteQuery("DBCC CHECKIDENT (tablebill, RESEED, 0)");

            for (int i = 0; i < tabledrink.Rows.Count; i++)
            {
                SellDAO.Instance.add((i + 1).ToString(), tabledrink.Rows[i][0].ToString(), Int64.Parse(tabledrink.Rows[i][1].ToString()), Int64.Parse(tabledrink.Rows[i][2].ToString()), Int64.Parse(tabledrink.Rows[i][3].ToString()));
            }
            btnshow_Click(btnshow, new EventArgs());                             
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void save()
        {
           
            string khach,status;
            if (cbkhachhang.Text == "") khach = "Unknown";
            else khach = cbkhachhang.Text;

            int k;
            if (chkthanhtoan.Checked == true) k = 1; else k = 0;
            if (k == 1) status = "Đủ";
            else status = "Thiếu";
            string h = string.Format(
             "Bạn có thật sự muốn lưu hóa đơn  \n Tên Khách: {0} \n Ngày mua: {1} \n Giờ mua: {2} \n Sự Kiện: {3} \n Tổng tiền: {4} \n Trạng thái: {5}", khach, date.Value.Date.ToShortDateString(), date.Value.ToShortTimeString(), txtsukien.Text, sum2.Text, status);
            if (dgvitem.RowCount > 0)
            {
                if (MessageBox.Show(h, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
                {
                    btnloc_Click(btnloc, new EventArgs());
                    if (cbkhachhang.Text == "")
                    {
                        DataProviderDAO.Instance.ExecuteQuery("INSERT dbo.bill_info(tenkhach,ngaymua,giomua,sukien,tongtien,status,typekhach) VALUES  ( N'UnKnown' , '" + date.Value.Date.ToString("yyyy/MM/dd") + "', '" + date.Value.ToShortTimeString() + "' , N'" + txtsukien.Text + "' , '" + Int64.Parse(stringformat(sum2.Text, 2)) + "' , " + k.ToString() + ",0)")
                            ;
                    }
                    else
                        if (cbidkhach.Text != "-1")
                          DataProviderDAO.Instance.ExecuteQuery("INSERT dbo.bill_info(tenkhach,ngaymua,giomua,sukien,tongtien,status,typekhach) VALUES  ( N'" + cbidkhach.Text + "' , '" + date.Value.Date.ToString("yyyy/MM/dd") + "', '" + date.Value.ToShortTimeString() + "' , N'" + txtsukien.Text + "' , '" + Int64.Parse(stringformat(sum2.Text, 2)) + "' , " + k.ToString() + ",1)");
                        else
                            DataProviderDAO.Instance.ExecuteQuery("INSERT dbo.bill_info(tenkhach,ngaymua,giomua,sukien,tongtien,status,typekhach) VALUES  ( N'" + cbkhachhang.Text + "' , '" + date.Value.Date.ToString("yyyy/MM/dd") + "', '" + date.Value.ToShortTimeString() + "' , N'" + txtsukien.Text + "' , '" + Int64.Parse(stringformat(sum2.Text, 2)) + "' , " + k.ToString() + ",0)");
                    
                    object id = DataProviderDAO.Instance.ExecuteScalar("SELECT MAX(id) FROM dbo.bill_info ");
                    for (int i = 0; i < dgvitem.Rows.Count - 1; i++)
                    {
                        //MessageBox.Show("INSERT dbo.bill(idbill,namedrink ,price ,quantify ,total) VALUES (" + id.ToString() + ",N'" + dgvitem.Rows[i].Cells[2].Value.ToString() + "'," + dgvitem.Rows[i].Cells[3].Value.ToString() + "," + dgvitem.Rows[i].Cells[4].Value.ToString() + " , " + dgvitem.Rows[i].Cells[5].Value.ToString() + ")");
                        DataProviderDAO.Instance.ExecuteQuery("INSERT dbo.bill(idtable,namedrink ,price ,quantify ,total) VALUES (" + id.ToString() + ",N'" + dgvitem.Rows[i].Cells[2].Value.ToString() + "'," + dgvitem.Rows[i].Cells[3].Value.ToString() + "," + dgvitem.Rows[i].Cells[4].Value.ToString() + " , " + dgvitem.Rows[i].Cells[5].Value.ToString() + ")");
                    }
                    btnsave.Enabled = false;
                }

            }
            
        }

        public static string day, time, sukien, ten;    

        private void btnprint_Click(object sender, EventArgs e)
        {
            day = String.Format("{0:d/M/yyyy}", date.Value.Date.ToShortDateString());
            time = date.Value.ToShortTimeString();
            sukien = txtsukien.Text;
            ten = cbkhachhang.Text;
            Form bill = new frmbillsell();
            bill.ShowDialog();
            
        }


        private void frmsell_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form home = new frmhome();
            home.Show();

        }


        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn tạo một hóa đơn mới", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            LoadForm();
        }

        private void LoadForm()
        {
            btnreset.Tag = 1;
            cbkhachhang.Text = cbname.Text = txtsukien.Text = null;
            date.ResetText();
            txtprice.Text = txtsum.Text = sum2.Text = "0";
            DataProviderDAO.Instance.ExecuteQuery("Delete from tablebill");
            DataProviderDAO.Instance.ExecuteQuery("DBCC CHECKIDENT (tablebill,RESEED,0)");
            btnshow_Click(btnshow, new EventArgs());
            btnadd.Enabled = btndelete.Enabled = btnrepair.Enabled = btnshow.Enabled = btnprint.Enabled = btnsave.Enabled = true;
            btnreset.Tag = 0;
        }

        private void frmsell_SizeChanged(object sender, EventArgs e)
        {
            panel1.Width = panel3.Width = this.Width / 2 - 10;
            panel2.Width = panel4.Width = this.Width / 2 - 30;
            panel2.Location = new Point(this.Width / 2 + 3,panel2.Location.Y);
            panel4.Location = new Point(this.Width / 2 + 3, panel4.Location.Y);
            //label6.Location = new Point(this.Width / 2 -90, label6.Location.Y);
            label6.Location = new Point(this.Width / 2 - 90, label6.Location.Y);

        }

        private void cbkhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i=-1;
            if (cbkhachhang.SelectedIndex.ToString() == i.ToString())
            {
                cbidkhach.Text = (i).ToString(); 
            }
            else cbidkhach.SelectedIndex = cbkhachhang.SelectedIndex;
        }


        private void cbkhachhang_TextChanged(object sender, EventArgs e)
        {
            cbidkhach.Text = cbkhachhang.SelectedIndex.ToString();
        }

        private void frmsell_ResizeEnd(object sender, EventArgs e)
        {
            if (this.Width < 956) this.Width = 956;
            if (this.Height < 642) this.Height = 642;
        }

        private void label6_Resize(object sender, EventArgs e)
        {

        }
    }
}
