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
    public partial class frmitem : Form
    {
        public frmitem()
        {
            InitializeComponent();
            btnshow_Click(btnshow, new EventArgs());
            btndelete.Enabled = btnrepair.Enabled = false;
        }

        private void frmitem_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtname.Text != string.Empty && numupdown1.Value.ToString() != string.Empty)
            {
                if (ItemDAO.Instance.add(txtcode.Text, txtname.Text, int.Parse(numupdown1.Value.ToString())))
                {
                    //DataProviderDAO.Instance.ExecuteQuery("INSERT dbo.kiemtra(ten, soluong, tong) VALUES( N'" + txtname.Text + "',0,0)");
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    btnshow_Click(btnshow, new EventArgs());
                    txtcode.Text = txtname.Text = null;
                    numupdown1.Value = 0;
                    label3.Text = (dgvitem.Rows.Count - 1).ToString();
                    
                }
                else MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Lỗi dữ liệu " + Environment.NewLine + Environment.NewLine + "Kiểm tra lại dữ liệu vừa nhập", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        
        private void btnshow_Click(object sender, EventArgs e)
        {
            dgvitem.DataSource = null;
            dgvitem.Rows.Clear();
            dgvitem.Refresh();
            DataTable datatable = DataProviderDAO.Instance.ExecuteQuery("SELECT * FROM dbo.drink ORDER BY name");

            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                dgvitem.Rows.Add( datatable.Rows[i][0],(i + 1).ToString(), datatable.Rows[i][1], datatable.Rows[i][2] );
            }
            label3.Text = (dgvitem.Rows.Count - 1).ToString();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            if (txtcode.Text != string.Empty && txtname.Text != string.Empty && numupdown1.Value.ToString() != string.Empty )
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa mặt hàng này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    if (ItemDAO.Instance.delete(txtcode.Text, txtname.Text, Int64.Parse(numupdown1.Value.ToString())))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        btnshow_Click(btnshow, new EventArgs());
                        txtcode.Text = txtname.Text = null;
                        numupdown1.Value =  0;
                        label3.Text = (dgvitem.Rows.Count-1).ToString();
                    }
                    else MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Lỗi dữ liệu " + Environment.NewLine  + "Kiểm tra lại dữ liệu vừa nhập", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void dgvitem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row != dgvitem.Rows.Count-1)
            {
                btndelete.Enabled = btnrepair.Enabled = true;
                //btnadd.Enabled = false;
                if (row >= 0)
                {
                    txtcode.Text  = dgvitem.Rows[row].Cells[0].Value.ToString();
                    txtname.Text  = dgvitem.Rows[row].Cells[2].Value.ToString();
                    numupdown1.Value = Int64.Parse(dgvitem.Rows[row].Cells[3].Value.ToString());
                }

            }

            if (row == dgvitem.Rows.Count-1)
            {
                btndelete.Enabled = btnrepair.Enabled = false;
                //btnadd.Enabled = true;
                txtcode.Text = txtname.Text = null;
                numupdown1.Value  = 0;
            }
        }

        private void btnrepair_Click(object sender, EventArgs e)
        {
            if (txtcode.Text != string.Empty && txtname.Text != string.Empty && numupdown1.Value.ToString() != string.Empty)
            {
                if (ItemDAO.Instance.repair(txtcode.Text, txtname.Text, int.Parse(numupdown1.Value.ToString())))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    btnshow_Click(btnshow, new EventArgs());
                    txtcode.Text = txtname.Text = null;
                    numupdown1.Value  = 0;
                    label3.Text = (dgvitem.Rows.Count - 1).ToString();
                }
                else MessageBox.Show("Cật nhật thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Lỗi dữ liệu " + Environment.NewLine + Environment.NewLine + "Kiểm tra lại dữ liệu vừa nhập", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        

        private void txtfind_TextChanged(object sender, EventArgs e)
        {
            if (txtfind.Text != string.Empty)
            {
                dgvitem.DataSource = null;
                dgvitem.Rows.Clear();
                dgvitem.Refresh();
                DataTable datatable = DataProviderDAO.Instance.ExecuteQuery("SELECT * FROM Drink WHERE dbo.convertstring(NAME) like N'%' + dbo.convertstring(N'" + txtfind.Text + "') + '%'");

                for (int i = 0; i < datatable.Rows.Count; i++)
                {
                    dgvitem.Rows.Add(datatable.Rows[i][0], (i + 1).ToString(), datatable.Rows[i][1], datatable.Rows[i][2]);
                }
                label3.Text = (dgvitem.Rows.Count - 1).ToString();
            }
            else btnshow_Click(btnshow, new EventArgs());
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
          
            

           
            
        }

        private void frmitem_ResizeEnd(object sender, EventArgs e)
        {
            if (this.Width < 925) this.Width = 925;
            if (this.Height < 604) this.Height = 604;
        }

        private void frmitem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form home = new frmhome();
            home.Show();
            this.Hide();
        }

        private void label3_Resize(object sender, EventArgs e)
        {

        }

        private void frmitem_SizeChanged(object sender, EventArgs e)
        {
            dgvitem.Width = panel3.Width = panel5.Width = this.Width / 2 - 15;
            label3.Location = new Point(label2.Location.X + label2.Width, label2.Location.Y);
            panel5.Location = new Point(panel3.Location.X, flowLayoutPanel1.Location.Y);
            // panel3.Width = this.Width / 2-30;
            //// panel3.Location = new Point(this.panel2.Width + 20, panel3.Location.Y);
            flowLayoutPanel1.Location = new Point(this.dgvitem.Location.X + (dgvitem.Width / 2) / 2 - 10, flowLayoutPanel1.Location.Y);
            if (flowLayoutPanel1.Width + flowLayoutPanel1.Location.X > dgvitem.Width) flowLayoutPanel1.Location = new Point(dgvitem.Location.X, flowLayoutPanel1.Location.Y);
            // panel5.Location = new Point(panel3.Location.X,flowLayoutPanel1.Location.Y);
            // //label2.Location = new Point(panel3.Location.X, panel3.Location.Y);
            // label3.Location = new Point(label2.Location.X + label2.Width, label2.Location.Y );
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
                    numupdown1.Value = Int64.Parse(dgvitem.Rows[row].Cells[3].Value.ToString());
                }

            }

            if (row == dgvitem.Rows.Count - 1)
            {
                btndelete.Enabled = btnrepair.Enabled = false;
                //btnadd.Enabled = true;
                txtcode.Text = txtname.Text = null;
                numupdown1.Value = 0;
            }
        }
    }
}
