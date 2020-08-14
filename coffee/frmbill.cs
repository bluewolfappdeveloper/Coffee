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
    public partial class frmbill : Form
    {
        public frmbill()
        {
            InitializeComponent();
            btnreload1_Click(btnreload1, new EventArgs());
            btnreload2_Click(btnreload2, new EventArgs());
        }

        public static string bill, day, khach, sukien, tg,khachhang,frm;
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private void btnshow_Click(object sender, EventArgs e)
        {
            dgvbill.DataSource = null;
            dgvbill.Rows.Clear();
            dgvbill.Refresh();
            DataTable datatable = DataProviderDAO.Instance.ExecuteQuery("SELECT tenkhach,SUM(tongtien),COUNT(*),typekhach FROM dbo.bill_info WHERE STATUS = 0 GROUP BY tenkhach,typekhach,status");
            string name = "";
            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                name = "";
                if (IsNumber(datatable.Rows[i][0].ToString()) == true)
                {
                    Object obj = DataProviderDAO.Instance.ExecuteScalar("SELECT name FROM dbo.customer WHERE id =" + datatable.Rows[i][0].ToString());
                    name = obj.ToString();
                }
                else name = datatable.Rows[i][1].ToString();

                dgvbill.Rows.Add((i + 1).ToString(),name, datatable.Rows[i][1], datatable.Rows[i][2], datatable.Rows[i][3]);
            }
        }
        int rowbill;
        private void dgvbill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowbill = e.RowIndex;
            btnreload2_Click(btnreload2, new EventArgs());
        }

        private void btnreload1_Click(object sender, EventArgs e)
        {
            dgvbill.DataSource = null;
            dgvbill.Rows.Clear();
            dgvbill.Refresh();
            DataTable datatable = DataProviderDAO.Instance.ExecuteQuery("SELECT tenkhach,SUM(tongtien),COUNT(*),typekhach FROM dbo.bill_info WHERE STATUS = 0 GROUP BY tenkhach,typekhach,status");
            string name = "";
            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                name = "";
                if (IsNumber(datatable.Rows[i][0].ToString()) == true)
                {
                    Object obj = DataProviderDAO.Instance.ExecuteScalar("SELECT name FROM dbo.customer WHERE id =" + datatable.Rows[i][0].ToString());
                    name = obj.ToString();
                }
                else name = datatable.Rows[i][1].ToString();

                dgvbill.Rows.Add((i + 1).ToString(), name, datatable.Rows[i][1], datatable.Rows[i][2], datatable.Rows[i][3]);
            }
        }

        private void btnreload2_Click(object sender, EventArgs e)
        {
            if (rowbill >= 0 && dgvbill.RowCount > 0)
            {
                string name;
                if (dgvbill.Rows[rowbill].Cells[4].Value.ToString() == "0") name = dgvbill.Rows[rowbill].Cells[1].Value.ToString();
                else
                {
                    Object obj = DataProviderDAO.Instance.ExecuteScalar("SELECT id FROM dbo.customer WHERE name =N'" + dgvbill.Rows[rowbill].Cells[1].Value.ToString() + "'");
                    name = obj.ToString();
                }
                DataTable datatable = DataProviderDAO.Instance.ExecuteQuery("SELECT id,ngaymua,giomua,sukien,tongtien FROM dbo.bill_info WHERE tenkhach =N'" + name + "' and status = 0 ");
                dgvbillinfo.DataSource = null;
                dgvbillinfo.Rows.Clear();
                dgvbillinfo.Refresh();
                for (int i = 0; i < datatable.Rows.Count; i++)
                {
                    dgvbillinfo.Rows.Add(datatable.Rows[i][0], (i + 1).ToString(), datatable.Rows[i][1].ToString().Substring(0, 10), datatable.Rows[i][2], datatable.Rows[i][3], datatable.Rows[i][4]);
                }

            }
            else btnreload1_Click(btnreload1, new EventArgs());
        }

        private void txtfind_TextChanged(object sender, EventArgs e)
        {
            btnfind1_Click(btnfind1, new EventArgs());
        }

        private void btnfind1_Click(object sender, EventArgs e)
        {
            if (txtfind.Text != string.Empty)
            {
                dgvbill.DataSource = null;
                dgvbill.Rows.Clear();
                dgvbill.Refresh();
                DataTable datatable = DataProviderDAO.Instance.ExecuteQuery("SELECT b.tenkhach,SUM(tongtien),COUNT(*),typekhach FROM dbo.bill_info AS b,dbo.customer AS c WHERE (b.STATUS = 0 AND dbo.convertstring(b.tenkhach) like N'%'+dbo.convertstring(N'" + txtfind.Text + "')+'%' ) or (dbo.convertstring(c.name) like N'%'+dbo.convertstring(N'" + txtfind.Text + "')+'%'  AND CAST(c.id AS NVARCHAR)= b.tenkhach AND b.status =0 ) GROUP BY tenkhach,typekhach,status");

                string name = "";
                for (int i = 0; i < datatable.Rows.Count; i++)
                {
                    name = "";
                    if (IsNumber(datatable.Rows[i][0].ToString()) == true)
                    {
                        Object obj = DataProviderDAO.Instance.ExecuteScalar("SELECT name FROM dbo.customer WHERE id =" + datatable.Rows[i][0].ToString());
                        name = obj.ToString();
                    }
                    else name = datatable.Rows[i][1].ToString();

                    dgvbill.Rows.Add((i + 1).ToString(), name, datatable.Rows[i][1], datatable.Rows[i][2], datatable.Rows[i][3]); 
                }
            }
            else btnshow_Click(btnshow, new EventArgs());
        }

        private void btnfind2_Click(object sender, EventArgs e)
        {
            if (rowbill >= 0 && dgvbill.RowCount > 0)
            {
                string name;
                if (dgvbill.Rows[rowbill].Cells[4].Value.ToString() == "0") name = dgvbill.Rows[rowbill].Cells[1].Value.ToString();
                else
                {
                    Object obj = DataProviderDAO.Instance.ExecuteScalar("SELECT id FROM dbo.customer WHERE name =N'" + dgvbill.Rows[rowbill].Cells[1].Value.ToString() + "'");
                    name = obj.ToString();
                }
                DataTable datatable = DataProviderDAO.Instance.ExecuteQuery("SELECT id,ngaymua,giomua,sukien,tongtien FROM dbo.bill_info WHERE tenkhach =N'" + name + "' and status = 0 AND ngaymua <= '" + dateTimePicker1.Value.Date.ToString("yyyy/MM/dd") + "'");
                dgvbillinfo.DataSource = null;
                dgvbillinfo.Rows.Clear();
                dgvbillinfo.Refresh();
                for (int i = 0; i < datatable.Rows.Count; i++)
                {
                    dgvbillinfo.Rows.Add(datatable.Rows[i][0], (i + 1).ToString(), datatable.Rows[i][1].ToString().Substring(0, 10), datatable.Rows[i][2], datatable.Rows[i][3], datatable.Rows[i][3]);
                }

            }
        }

        private void dgvinfobill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rows = e.RowIndex;
            if (rows>= 0 && dgvbillinfo.RowCount > 0 && dgvbill.RowCount>0)
            {
                //string name;
                idbill.Text = dgvbillinfo.Rows[rows].Cells[0].Value.ToString();
                day = dgvbillinfo.Rows[rows].Cells[2].Value.ToString();
                khachhang = dgvbill.Rows[rowbill].Cells[1].Value.ToString();
                if (dgvbill.Rows[rowbill].Cells[1].Value.ToString() == "0") khach = dgvbill.Rows[rowbill].Cells[1].Value.ToString();
                else
                {
                    Object obj = DataProviderDAO.Instance.ExecuteScalar("SELECT id FROM dbo.customer WHERE name =N'" + dgvbill.Rows[rowbill].Cells[1].Value.ToString() + "'");
                    khach = obj.ToString();
                }
                if (dgvbillinfo.Rows[rows].Cells[4].Value == null) sukien = null;
                else sukien = dgvbillinfo.Rows[rows].Cells[4].Value.ToString();
                tg = dgvbillinfo.Rows[rows].Cells[3].Value.ToString();
                bill = idbill.Text;
                btnthanhtoan.Enabled = true;
                btnupdate.Enabled = true;
                buttonX1.Enabled = true;
            }else
            {
                dgvbillinfo.DataSource = null;
                dgvbillinfo.Rows.Clear();
                dgvbillinfo.Refresh();
                btnthanhtoan.Enabled = false;
                btnupdate.Enabled = false;
                buttonX1.Enabled = false;
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frm = "1";
            Form frmtakebill = new frmtakebill();
            frmtakebill.Show();
            this.Hide();
        }

        private void frmbill_Load(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Form sellbill = new frmsellbill();
            sellbill.Show();
            this.Hide();
        }

        private void frmbill_SizeChanged(object sender, EventArgs e)
        {
            panel2.Width = this.Width / 2 - 25;
            panel4.Width = this.Width / 2 - 25;

            
        }

        private void frmbill_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form home = new frmhome();
            home.Show();
            this.Hide();
        }

        private void frmbill_ResizeEnd(object sender, EventArgs e)
        {
            if (this.Width < 924) this.Width = 924;
            if (this.Height < 503) this.Height = 503;
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn cập nhật hóa đơn thành 'ĐÃ THANH TOÁN' ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {

                DataProviderDAO.Instance.ExecuteQuery("UPDATE dbo.bill_info SET status = 1 WHERE id = " + frmbill.bill);
                btnreload1_Click(btnreload1, new EventArgs());
                btnreload2_Click(btnreload2, new EventArgs());
                MessageBox.Show("CẬP NHẬT THÀNH CÔNG", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
